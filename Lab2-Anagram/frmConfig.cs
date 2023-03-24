using System.Configuration;
using System.Drawing;

namespace Lab2_Anagram
{
    public partial class frmConfig : Form
    {
        private frmMainWindow mainForm;

        public frmConfig(frmMainWindow callingForm)
        {
            mainForm = callingForm as frmMainWindow;
            InitializeComponent();
        }

        private void cbxWordList_Load()
        {
            cbxWordList.Items.Clear();

            // Add every files in ./files/word_lists/ to cbxWordList
            string[] files = Directory.GetFiles("./files/word_lists/");
            foreach (string file in files)
            {
                cbxWordList.Items.Add(file);
            }

            // Add the value of the config file to cbxWordList if it's not already in it
            string? configPath = Program.GetSetting("wordListPath");
            if (!cbxWordList.Items.Contains(configPath) && configPath is not null)
            {
                cbxWordList.Items.Add(Program.GetSetting("wordListPath"));
            }

            // Set the value of the cbxWordList from the config file
            cbxWordList.SelectedIndex = cbxWordList.Items.IndexOf(Program.GetSetting("wordListPath") ?? "./files/word_lists/wordsEN.txt");
        }

        private void trackbars_Load()
        {
            Program.loadConfig(); // update word list

            // Find the shortest and longest word in the word list
            string shortestWord = "";
            string longestWord = "";
            foreach (string word in Program.words)
            {
                if (word.Length < shortestWord.Length || shortestWord == "") { shortestWord = word; }
                if (word.Length > longestWord.Length || longestWord == "") { longestWord = word; }
            }
            // We make sure that the min and max word length are between the shortest and longest word length
            Program.minWordLength = Math.Min(Math.Max(Program.minWordLength, shortestWord.Length), longestWord.Length);
            Program.maxWordLength = Math.Max(Math.Min(Program.maxWordLength, longestWord.Length), shortestWord.Length);
            Program.UpdateSetting("minWordLength", Program.minWordLength.ToString());
            Program.UpdateSetting("maxWordLength", Program.maxWordLength.ToString());

            // Set the min and max value of the trackbars
            tbrMinLength.Minimum = shortestWord.Length;
            tbrMinLength.Maximum = longestWord.Length;
            tbrMaxLength.Minimum = shortestWord.Length;
            tbrMaxLength.Maximum = longestWord.Length;

            // Set the value of the trackbars from the config file
            tbrMinLength.Value = Program.minWordLength;
            tbrMaxLength.Value = Program.maxWordLength;

            // Set the text of the labels to the value of the trackbars
            lblMinLengthValue.Text = "(" + Program.minWordLength.ToString() + ")";
            lblMaxLengthValue.Text = "(" + Program.maxWordLength.ToString() + ")";

            // Set the text of the labels to the min/max possible value
            lblMinLength.Text = shortestWord.Length.ToString();
            lblMaxLength.Text = longestWord.Length.ToString();
        }

        private void tabSettingsAppearance_Load()
        {
            // Check if the text color and/or secondary background color are custom from the config file
            bool isFGCustom = bool.Parse(Program.GetSetting("customFGColor") ?? "false");
            bool isSecondaryBGCustom = bool.Parse(Program.GetSetting("customSecondaryBGColor") ?? "false");

            // Set the value of the checkboxes
            chbCustomFGColor.Checked = isFGCustom;
            chbCustomSecondaryBGColor.Checked = isSecondaryBGCustom;

            // Enable or disable the color picker for the foreground color depending on the checkbox
            btnColorFG.Enabled = isFGCustom;
            lblTxtFGColor.Enabled = isFGCustom;
            lblTxtFGColor.Text = isFGCustom ? "Text color" : "Text color (auto)";

            // Enable or disable the color picker for the secondary background color depending on the checkbox
            btnColorBGSecondary.Enabled = isSecondaryBGCustom;
            lblTxtSecondaryBGColor.Enabled = isSecondaryBGCustom;
            lblTxtSecondaryBGColor.Text = isSecondaryBGCustom ? "Secondary background color" : "Secondary background color (auto)";

            // find a color automatically for the text and secondary background color
            if (!isFGCustom) { Program.autoFGColor(mainForm); }
            if (!isSecondaryBGCustom) { Program.autoSecondaryBGColor(mainForm); }

            // Set the value of the color theme from the current theme
            btnColorBG.BackColor = Program.colorBackground;
            btnColorBGSecondary.BackColor = Program.colorSecondaryBackground;
            btnColorFG.BackColor = Program.colorForeground;

            // Add the languages
            string[] languages = { "en", "fr" };
            for (int i = 0; i < languages.Length; i++)
            {
                cbxLanguage.Items.Add(languages[i]);
            }

            // default language selected : en
            cbxLanguage.SelectedIndex = 0;

            this.Refresh();
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

        private void frmConfig_Load(object sender, EventArgs e)
        {
            cbxWordList_Load();
            trackbars_Load();
            tabSettingsAppearance_Load();

            // Set the value of the numericUpDown from the config file
            numNbMaxTries.Value = int.Parse(Program.GetSetting("maxTries") ?? "5");

            // set the difficulty presets
            cbxDifficultyPreset.Items.Clear();
            cbxDifficultyPreset.Items.Add("Noob");
            cbxDifficultyPreset.Items.Add("Easy");
            cbxDifficultyPreset.Items.Add("Medium");
            cbxDifficultyPreset.Items.Add("Hard");
            cbxDifficultyPreset.Items.Add("Hardcore");
            cbxDifficultyPreset.Items.Add("Custom");

            // Set the value of the difficulty preset from the config file
            cbxDifficultyPreset.SelectedIndex = int.Parse(Program.GetSetting("difficultyPreset") ?? "5");
        }

        private void frmConfig_FormClosing(object sender, FormClosingEventArgs e)
        {
            string title = "So you want to start a new game?";
            string message = "Do you want save the settings and start a new game? Press \"Cancel\" to revert the settings and continue the current game.";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Display the popup
            result = MessageBox.Show(message, title, buttons);

            if (result == DialogResult.Yes)
            {
                mainForm.initialisation();
            }
        }

        private void cbxWordList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.UpdateSetting("wordListPath", cbxWordList.SelectedItem.ToString() ?? "./files/word_lists/wordsEN.txt");
            Program.wordListPath = cbxWordList.SelectedItem.ToString();
            trackbars_Load(); // reload the trackbars to update the min/max values
        }

        private void btnImportWordList_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please select a file that contains a list of words, one word per line.", "Import word list", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (ofdWordList.ShowDialog() == DialogResult.OK)
            {
                cbxWordList.Items.Add(ofdWordList.FileName);
                cbxWordList.SelectedIndex = cbxWordList.Items.IndexOf(ofdWordList.FileName);
            }
        }

        private void tbrMinLength_Scroll(object sender, EventArgs e)
        {
            Program.UpdateSetting("minWordLength", tbrMinLength.Value.ToString());
            lblMinLengthValue.Text = "(" + tbrMinLength.Value.ToString() + ")";
            if (tbrMinLength.Value > tbrMaxLength.Value)
            {
                tbrMaxLength.Value = tbrMinLength.Value;
                Program.UpdateSetting("maxWordLength", tbrMaxLength.Value.ToString());
                lblMaxLengthValue.Text = "(" + tbrMaxLength.Value.ToString() + ")";
            }
        }

        private void tbrMaxLength_Scroll(object sender, EventArgs e)
        {
            Program.UpdateSetting("maxWordLength", tbrMaxLength.Value.ToString());
            lblMaxLengthValue.Text = "(" + tbrMaxLength.Value.ToString() + ")";
            if (tbrMinLength.Value > tbrMaxLength.Value)
            {
                tbrMinLength.Value = tbrMaxLength.Value;
                Program.UpdateSetting("minWordLength", tbrMinLength.Value.ToString());
                lblMinLengthValue.Text = "(" + tbrMinLength.Value.ToString() + ")";
            }
        }

        private void numNbMaxTries_ValueChanged(object sender, EventArgs e)
        {
            Program.UpdateSetting("maxTries", numNbMaxTries.Value.ToString());
        }


        private void btnColorBG_Click(object sender, EventArgs e)
        {
            ColorDialog cdColor = new ColorDialog();
            if (cdColor.ShowDialog() == DialogResult.OK)
            {
                Color color = cdColor.Color;
                Program.SetBackColor(mainForm, color);
                btnColorBG.BackColor = color;
            }

            tabSettingsAppearance_Load();
        }

        private void btnColorBGSecondary_Click(object sender, EventArgs e)
        {
            if (!chbCustomSecondaryBGColor.Checked) { return; }

            ColorDialog cdColor = new ColorDialog();
            if (cdColor.ShowDialog() == DialogResult.OK)
            {
                Color color = cdColor.Color;
                Program.SetSecondaryBackColor(mainForm, color);
                btnColorBGSecondary.BackColor = color;
            }
        }

        private void btnColorFG_Click(object sender, EventArgs e)
        {
            if (!chbCustomFGColor.Checked) { return; }

            ColorDialog cdColor = new ColorDialog();
            if (cdColor.ShowDialog() == DialogResult.OK)
            {
                Color color = cdColor.Color;
                Program.SetForeColor(mainForm, color);
                btnColorFG.BackColor = color;
            }
        }

        private void chbCustomSecondaryBGColor_CheckedChanged(object sender, EventArgs e)
        {
            Program.UpdateSetting("customSecondaryBGColor", chbCustomSecondaryBGColor.Checked.ToString());
            tabSettingsAppearance_Load();
        }

        private void chbCustomFGColor_CheckedChanged(object sender, EventArgs e)
        {
            Program.UpdateSetting("customFGColor", chbCustomFGColor.Checked.ToString());
            tabSettingsAppearance_Load();
        }

        private void btnDefaultColor_Click(object sender, EventArgs e)
        {
            Program.light_mode(mainForm);
            tabSettingsAppearance_Load();
        }

        private void btnDarkTheme_Click(object sender, EventArgs e)
        {
            Program.dark_mode(mainForm);
            tabSettingsAppearance_Load();
        }

        private void chbCheckWordCorrect_CheckedChanged(object sender, EventArgs e)
        {
            Program.UpdateSetting("checkAnagram", chbCheckWordCorrect.Checked.ToString());
        }
    }
}
