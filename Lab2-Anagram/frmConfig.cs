using System.Configuration;

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
            // Add every files in ./files/word_lists/ to cbxWordList
            string[] files = Directory.GetFiles("./files/word_lists/");
            foreach (string file in files)
            {
                cbxWordList.Items.Add(file);
            }

            // Add the value of the config file to cbxWordList if it's not already in it
            if (!cbxWordList.Items.Contains(Program.GetSetting("wordListPath")))
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
            foreach (string word in Program.words) {
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

            MessageBox.Show($"Trackbars loaded with " + shortestWord.Length.ToString() + " and " + longestWord.Length.ToString());
        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            cbxWordList_Load();

            // Set the value of the numericUpDown from the config file
            numNbMaxTries.Value = int.Parse(Program.GetSetting("maxTries") ?? "5");

            // set the difficulty presets
            cbxDifficultyPreset.Items.Add("Noob");
            cbxDifficultyPreset.Items.Add("Easy");
            cbxDifficultyPreset.Items.Add("Medium");
            cbxDifficultyPreset.Items.Add("Hard");
            cbxDifficultyPreset.Items.Add("Hardcore");
            cbxDifficultyPreset.Items.Add("Custom");

            // Set the value of the difficulty preset from the config file
            cbxDifficultyPreset.SelectedIndex = int.Parse(Program.GetSetting("difficultyPreset") ?? "0");

            // Color theme
            chbCustomComplementaryColor.Checked = bool.Parse(Program.GetSetting("customComplementaryColor") ?? "false");
        }

        private void frmConfig_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.initialisation();
        }

        private void cbxWordList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.UpdateSetting("wordListPath", cbxWordList.SelectedItem.ToString());
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
                btnColorBG.BackColor = cdColor.Color;
                Program.UpdateSetting("colorBG", cdColor.Color.ToArgb().ToString());
            }

            // find a complementary color for the text
            if (chbCustomComplementaryColor.Checked == false)
            { autoComplementaryColor(); }
        }

        private void btnColorComplementary_Click(object sender, EventArgs e)
        {
            if (!chbCustomComplementaryColor.Checked) { return; }

            ColorDialog cdColor = new ColorDialog();
            if (cdColor.ShowDialog() == DialogResult.OK)
            {
                btnColorComplementary.BackColor = cdColor.Color;
                Program.UpdateSetting("colorText", cdColor.Color.ToArgb().ToString());
            }
        }

        private void autoComplementaryColor()
        {
            Color color = btnColorBG.BackColor;
            int r = 255 - color.R;
            int g = 255 - color.G;
            int b = 255 - color.B;
            btnColorComplementary.BackColor = Color.FromArgb(r, g, b);
            Program.UpdateSetting("colorText", btnColorComplementary.BackColor.ToArgb().ToString());
        }

        private void tabSettingsAppearance_Paint(object sender, PaintEventArgs e)
        {
            bool isCustom = chbCustomComplementaryColor.Checked;
            btnColorComplementary.Enabled = isCustom;
            lblTxtComplementaryColor.Enabled = isCustom;
            lblTxtComplementaryColor.Text = isCustom ? "Complementary color" : "Complementary color (auto)";
            if (chbCustomComplementaryColor.Checked == false)
            { autoComplementaryColor(); }
        }
    }
}
