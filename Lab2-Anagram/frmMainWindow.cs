using System.DirectoryServices;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

// TODO:
// - Display an error if the word list is not found (with instructions to put it back)
// - Put an icon on the form (that will show up in the taskbar)
// - Check the functional and operational tables
// - Make the "How to play" popup
// - Make the "About" popup
// - Enhance keyboard navigation
//   - Choose appropriate default item on YesNo text boxes
//   - Make it so the default keyboard selected item is the guess text box
// - Make it so we can give up and show the word (when pressing "New game" ?)
// - Make sure a word is shuffled (the shuffled word is not the same as the original word), else shuffle it again
// - Check if the guess is the good length, and contains all the letters shuffled
// - Make a configuration popup where we can:
//   - change the language of the word list
//   - select a custom word list
//   - change the number of tries
//   - change the language of the UI
//   - define the min and max size of words (with a cursor)
//   - When saving configuration, ask if we want to save and restart a game or cancel the changes
//     (with a message to indicate that the games log will not be erased)
// - Make a win animation ? (like in Solitaire)
// - Dark mode ?

// Done:
// - Known bug : if you win/lose and hit "no" then "no" you have to restart a game and it will be logged twice
// - Make it so we can validate the word by pressing the "Enter" key


namespace Lab2_Anagram
{
    public partial class frmMainWindow : Form
    {
        // Constants
        const int MAX_NB_TRIES = 5;

        // Variables
        String word;
        int gameNumber = 0;
        int nbTriesRemaining = 5;
        string[] words = System.IO.File.ReadAllLines("./files/words.txt");

        public frmMainWindow()
        {
            InitializeComponent();
        }

        private int randint(int min, int max)
        {
            Random rand = new Random();
            int x = min;
            int y = max;
            int randInt = rand.Next(x, y + 1);
            return randInt;
        }

        String jumble(String word)
        {
            string shuffledWord = "";

            for (int i = 0; i < word.Length; i++)
            {
                char letter = word[i];
                int pos = randint(0, shuffledWord.Length);
                shuffledWord = shuffledWord.Insert(pos, letter.ToString());
            }

            return shuffledWord;
        }

        private void comboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            e.DrawBackground();

            string language = comboBox1.Items[e.Index].ToString() ?? "en";
            string imagePath = $"./files/flags/{language}.png";

            using (Image image = Image.FromFile(imagePath))
            {
                float imageRatio = (float)image.Width / (float)image.Height;
                e.Graphics.DrawImage(image, e.Bounds.Left, e.Bounds.Top, e.Bounds.Height * imageRatio, e.Bounds.Height);
            }

            e.DrawFocusRectangle();
        }

        private void frmMainWindow_Load(object sender, EventArgs e)
        {
            initialisation();
        }

        private void initialisation()
        {
            // Hide the arrows of the numeric up/down field (number of tries)
            numNbrGuesses.Controls[0].Visible = false;

            // Increase the game number
            gameNumber++;

            // get a random word
            int randInt = randint(0, words.Length);
            word = words[randInt];

            // Jumble the word and display it
            String jumbledWord = jumble(word);
            lblWord.Text = jumbledWord.ToUpper();

            // Set the remaining number of tries
            nbTriesRemaining = MAX_NB_TRIES;
            numNbrGuesses.Value = nbTriesRemaining;

            // Enable the "Test" button and the text box and clear the text box
            btnTest.Enabled = true;
            tbxGuess.Enabled = true;
            tbxGuess.Clear();

            // Clear the list of previous guesses
            lstPreviousGuesses.Items.Clear();

            // Make the text box maximum Length equal to the length of the word
            tbxGuess.MaxLength = word.Length;

            // Add the languages
            string[] languages = { "en", "fr" };
            for (int i = 0; i < languages.Length; i++)
            {
                comboBox1.Items.Add(languages[i]);
            }

            // default language selected : en
            comboBox1.SelectedIndex = 0;
        }

        private void logGame(bool win = false)
        {
            // Format : "Game 1 - STRING - Won - 3 tries"
            String result = win ? "Won" : "Lost";
            String log = $"Game {gameNumber} - {word.ToUpper()} - {result} - {MAX_NB_TRIES - nbTriesRemaining} tries";

            // Add the log to the list
            lstGameHistory.Items.Add(log);
        }

        private void endOfTheGame(bool win = false)
        {
            // Disable the "Test" button and the text box
            btnTest.Enabled = false;
            tbxGuess.Enabled = false;

            // Register the result in the history
            // Format : "Game 1 - STRING - Won - 3 tries"
            logGame(win);

            // Show the popup
            String title = (win) ? "Won!" : "Lost!";
            String message = (win) ? "Congratulations, you won!" : "You lost, too bad. The word was " + word.ToUpper() + ".";
            message += Environment.NewLine + "Do you want to play again?";

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Display the popup
            result = MessageBox.Show(message, title, buttons);

            // If the user wants to play again, start a new game
            if (result == DialogResult.Yes) { initialisation(); }

            // close without triggering frmMainWindow_FormClosing
            else { this.Dispose(); }
        }

        private void tbxGuess_TextChanged(object sender, EventArgs e)
        {
            tbxGuess.CharacterCasing = CharacterCasing.Upper;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            // If the text box is empty, do nothing
            if (tbxGuess.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a word.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // If the word was already guessed, do nothing
            if (lstPreviousGuesses.Items.Contains(tbxGuess.Text))
            {
                MessageBox.Show("You already guessed this word.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // If the word is not the same length as the word to guess, do nothing
            if (tbxGuess.Text.Length != word.Length)
            {
                MessageBox.Show("The word must be the same length as the word to guess.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Increase the number of tries
            nbTriesRemaining--;
            numNbrGuesses.Value = nbTriesRemaining;

            // Get the word and save it in the history
            String guessedWord = tbxGuess.Text;
            lstPreviousGuesses.Items.Add(guessedWord);

            // Empty the text box
            tbxGuess.Clear();

            // Win
            if (guessedWord == word.ToUpper())
            {
                endOfTheGame(true);
            }

            // Lose (if the number of tries is equal to the maximum number of tries)
            else if (nbTriesRemaining <= 0)
            {
                endOfTheGame(false);
            }
        }

        private void tbxGuess_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTest.PerformClick();
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            String title = "Start a new game";
            String message = "This will cancel the current game and it will be lost. Are you sure?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Display the popup
            result = MessageBox.Show(message, title, buttons);

            if (result == DialogResult.Yes)
            {
                logGame(false);
                initialisation();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            string title = "Exit";
            string message = "Do you really want to exit?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Display the popup
            result = MessageBox.Show(message, title, buttons);

            if (result == DialogResult.No)
            {
                // Cancel the Closing event from closing the form.
                e.Cancel = true;
            }
        }

        private void lnkHowToPlay_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            String title = "How to play";
            String message = "The goal of the game is to guess the word that was jumbled." + Environment.NewLine
                + "You can enter your guess in the text box and press the \"Test\" button to validate it." + Environment.NewLine
                + "You have " + MAX_NB_TRIES + " tries to guess the word." + Environment.NewLine
                + "You can also press the \"Enter\" key to validate your guess." + Environment.NewLine
                + "If you want to start a new game, press the \"New game\" button." + Environment.NewLine
                + "If you want to exit the game, press the \"Exit\" button.";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
        }

        private void lnkAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            String title = "About";
            String message = "This game was made by Alexandre MALFREYT." + Environment.NewLine
                + "It was made for the course \"Développement d'applications avec IHM\" at the IUT d'Orsay." + Environment.NewLine
                + "It is an assignment for the 2nd semester." + Environment.NewLine
                + "The source code is available on GitHub at https://github.com/AlexZeGamer/AnagramGame";

            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
        }
    }
}