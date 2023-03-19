using System.Configuration;

namespace Lab2_Anagram {
    public partial class frmMainWindow : Form {
        // Variables
        string word = "";
        int gameNumber = 0;
        int nbTriesRemaining;

        public frmMainWindow()
        {
            InitializeComponent();
        }

        private int randint(int min, int max)
        {
            Random rand = new Random();
            int x = min;
            int y = max;
            int randInt = rand.Next(x, y);
            return randInt;
        }

        String jumble(String word)
        {
            string shuffledWord;

            do {
                shuffledWord = "";

                for (int i = 0; i < word.Length; i++)
                {
                    char letter = word[i];
                    int pos = randint(0, shuffledWord.Length);
                    shuffledWord = shuffledWord.Insert(pos, letter.ToString());
                }
            } while (shuffledWord == word);

            return shuffledWord;
        }

        private void frmMainWindow_Load(object sender, EventArgs e)
        {
            initialisation();
        }

        public void initialisation()
        {
            // Load the config
            Program.loadConfig();

            // Hide the arrows of the numeric up/down field (number of tries)
            numNbrGuesses.Controls[0].Visible = false;

            // Increase the game number
            gameNumber++;

            // get a random word (between minWordLength and maxWordLength)
            do {
                int pos = randint(0, Program.words.Length);
                word = Program.words[pos];
            } while (word.Length < Program.minWordLength || word.Length > Program.maxWordLength);

            // Jumble the word and display it
            String jumbledWord = jumble(word);
            lblWord.Text = jumbledWord.ToUpper();

            // Set the remaining number of tries
            nbTriesRemaining = Program.MAX_NB_TRIES;
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
                cbxLanguage.Items.Add(languages[i]);
            }

            // default language selected : en
            cbxLanguage.SelectedIndex = 0;
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

        private void comboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            e.DrawBackground();

            string language = cbxLanguage.Items[e.Index].ToString() ?? "en";
            string imagePath = $"./files/flags/{language}.png";

            using (Image image = Image.FromFile(imagePath))
            {
                float imageRatio = (float)image.Width / (float)image.Height;
                e.Graphics.DrawImage(image, e.Bounds.Left, e.Bounds.Top, e.Bounds.Height * imageRatio, e.Bounds.Height);
            }

            e.DrawFocusRectangle();
        }

        private void logGame(bool win = false)
        {
            // Format : "Game 1 - STRING - Won - 3 tries"
            String result = win ? "Won" : "Lost";
            String log = $"Game {gameNumber} - {word.ToUpper()} - {result} - {Program.MAX_NB_TRIES - nbTriesRemaining} tries";

            // Add the log to the list
            lstGameHistory.Items.Add(log);

            // Scroll down to the bottom of the list
            lstGameHistory.TopIndex = lstGameHistory.Items.Count - 1;
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

            // Close without triggering frmMainWindow_FormClosing
            else { this.Dispose(); }
        }

        private void tbxGuess_TextChanged(object sender, EventArgs e)
        {
            tbxGuess.CharacterCasing = CharacterCasing.Upper;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            String guessedWord = tbxGuess.Text;

            // If the text box is empty, do nothing
            if (guessedWord.Trim() == "")
            {
                MessageBox.Show("Please enter a word.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // If the word was already guessed, do nothing
            if (lstPreviousGuesses.Items.Contains(guessedWord))
            {
                MessageBox.Show("You already guessed this word.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // If the word is not the same length as the word to guess, do nothing
            if (guessedWord.Length != word.Length)
            {
                MessageBox.Show("The word must be the same length as the word to guess.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the guess contains all the letters shuffled the same amount of times
            for (int i = 0; i < word.Length; i++)
            {
                char letter = word[i];
                int nbLetterInWord = word.Count(x => x.ToString().ToUpper() == letter.ToString().ToUpper());
                int nbLetterInGuess = guessedWord.Count(x => x.ToString().ToUpper() == letter.ToString().ToUpper());

                if (nbLetterInWord != nbLetterInGuess)
                {
                    MessageBox.Show("The word must contain every letters of the word to guess in the same amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Increase the number of tries
            nbTriesRemaining--;
            numNbrGuesses.Value = nbTriesRemaining;

            // Get the word and save it in the history
            lstPreviousGuesses.Items.Add(guessedWord);

            // Scroll down to the bottom of the list
            lstPreviousGuesses.TopIndex = lstPreviousGuesses.Items.Count - 1;

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

        private void lnkHowToPlay_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            String title = "How to play";
            String message = "The goal of the game is to guess the word that was jumbled." + Environment.NewLine
                + "You can enter your guess in the text box and press the \"Test\" button to validate it." + Environment.NewLine
                + "You have " + Program.MAX_NB_TRIES + " tries to guess the word." + Environment.NewLine
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

        private void lstGameHistory_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) { return; }

            // Create a new ContextMenuStrip control
            ContextMenuStrip cms = new ContextMenuStrip();

            int index = this.lstGameHistory.IndexFromPoint(e.Location);
            if (index == ListBox.NoMatches) { return; }
            else { lstGameHistory.SetSelected(index, true); }

            string? text = lstGameHistory.Items[index].ToString();

            // Add the Copy option (copies the selected text inside the richtextbox)
            ToolStripMenuItem tsmiCopy = new ToolStripMenuItem("Copy");
            tsmiCopy.Click += (sender, e) => Clipboard.SetText(text); ;
            cms.Items.Add(tsmiCopy);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            // open the frmConfig window
            frmConfig frmConfig = new frmConfig(this);
            frmConfig.ShowDialog();
        }
    }
}