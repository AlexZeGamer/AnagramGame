namespace Lab2_Anagram
{
    partial class frmConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfig));
            grpWordList = new GroupBox();
            btnImportWordList = new Button();
            cbxWordList = new ComboBox();
            tabSettings = new TabControl();
            tabSettingsGameplay = new TabPage();
            grpChecks = new GroupBox();
            chbCheckWordCorrect = new CheckBox();
            grpNbTries = new GroupBox();
            numNbMaxTries = new NumericUpDown();
            grpRandomWord = new GroupBox();
            lblTxtDifficultyPreset = new Label();
            cbxDifficultyPreset = new ComboBox();
            lblMaxLength = new Label();
            lblMinLength = new Label();
            lblMaxLengthValue = new Label();
            lblMinLengthValue = new Label();
            tbrMaxLength = new TrackBar();
            tbrMinLength = new TrackBar();
            lblTxtMaxLength = new Label();
            lblTxtMinLength = new Label();
            tabSettingsAppearance = new TabPage();
            grpDisplayLanguage = new GroupBox();
            cbxLanguage = new ComboBox();
            grpTheme = new GroupBox();
            btnDarkTheme = new Button();
            chbCustomSecondaryBGColor = new CheckBox();
            lblTxtSecondaryBGColor = new Label();
            btnColorBGSecondary = new Button();
            btnDefaultColor = new Button();
            chbCustomFGColor = new CheckBox();
            lblTxtFGColor = new Label();
            lblTxtBackgroundColor = new Label();
            btnColorFG = new Button();
            btnColorBG = new Button();
            ofdWordList = new OpenFileDialog();
            grpWordList.SuspendLayout();
            tabSettings.SuspendLayout();
            tabSettingsGameplay.SuspendLayout();
            grpChecks.SuspendLayout();
            grpNbTries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numNbMaxTries).BeginInit();
            grpRandomWord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbrMaxLength).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbrMinLength).BeginInit();
            tabSettingsAppearance.SuspendLayout();
            grpDisplayLanguage.SuspendLayout();
            grpTheme.SuspendLayout();
            SuspendLayout();
            // 
            // grpWordList
            // 
            grpWordList.Controls.Add(btnImportWordList);
            grpWordList.Controls.Add(cbxWordList);
            grpWordList.Location = new Point(6, 6);
            grpWordList.Name = "grpWordList";
            grpWordList.Size = new Size(385, 54);
            grpWordList.TabIndex = 0;
            grpWordList.TabStop = false;
            grpWordList.Text = "Word list";
            // 
            // btnImportWordList
            // 
            btnImportWordList.Location = new Point(284, 22);
            btnImportWordList.Name = "btnImportWordList";
            btnImportWordList.Size = new Size(95, 23);
            btnImportWordList.TabIndex = 1;
            btnImportWordList.Text = "Import";
            btnImportWordList.UseVisualStyleBackColor = true;
            btnImportWordList.Click += btnImportWordList_Click;
            // 
            // cbxWordList
            // 
            cbxWordList.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxWordList.FormattingEnabled = true;
            cbxWordList.Location = new Point(6, 22);
            cbxWordList.Name = "cbxWordList";
            cbxWordList.Size = new Size(272, 23);
            cbxWordList.TabIndex = 0;
            cbxWordList.SelectedIndexChanged += cbxWordList_SelectedIndexChanged;
            // 
            // tabSettings
            // 
            tabSettings.Controls.Add(tabSettingsGameplay);
            tabSettings.Controls.Add(tabSettingsAppearance);
            tabSettings.Location = new Point(12, 12);
            tabSettings.Name = "tabSettings";
            tabSettings.SelectedIndex = 0;
            tabSettings.Size = new Size(405, 349);
            tabSettings.TabIndex = 1;
            // 
            // tabSettingsGameplay
            // 
            tabSettingsGameplay.BackColor = Color.Transparent;
            tabSettingsGameplay.Controls.Add(grpChecks);
            tabSettingsGameplay.Controls.Add(grpNbTries);
            tabSettingsGameplay.Controls.Add(grpRandomWord);
            tabSettingsGameplay.Controls.Add(grpWordList);
            tabSettingsGameplay.Location = new Point(4, 24);
            tabSettingsGameplay.Name = "tabSettingsGameplay";
            tabSettingsGameplay.Padding = new Padding(3);
            tabSettingsGameplay.Size = new Size(397, 321);
            tabSettingsGameplay.TabIndex = 0;
            tabSettingsGameplay.Text = "Gameplay";
            // 
            // grpChecks
            // 
            grpChecks.Controls.Add(chbCheckWordCorrect);
            grpChecks.Location = new Point(157, 244);
            grpChecks.Name = "grpChecks";
            grpChecks.Size = new Size(234, 68);
            grpChecks.TabIndex = 3;
            grpChecks.TabStop = false;
            grpChecks.Text = "Checks";
            // 
            // chbCheckWordCorrect
            // 
            chbCheckWordCorrect.AutoSize = true;
            chbCheckWordCorrect.Location = new Point(8, 22);
            chbCheckWordCorrect.MaximumSize = new Size(220, 100);
            chbCheckWordCorrect.MinimumSize = new Size(0, 40);
            chbCheckWordCorrect.Name = "chbCheckWordCorrect";
            chbCheckWordCorrect.Size = new Size(220, 40);
            chbCheckWordCorrect.TabIndex = 0;
            chbCheckWordCorrect.Text = "Check if the guessed word is an anagram before sending";
            chbCheckWordCorrect.UseVisualStyleBackColor = true;
            chbCheckWordCorrect.CheckedChanged += chbCheckWordCorrect_CheckedChanged;
            // 
            // grpNbTries
            // 
            grpNbTries.Controls.Add(numNbMaxTries);
            grpNbTries.Location = new Point(6, 244);
            grpNbTries.Name = "grpNbTries";
            grpNbTries.Size = new Size(145, 68);
            grpNbTries.TabIndex = 2;
            grpNbTries.TabStop = false;
            grpNbTries.Text = "Number of tries";
            // 
            // numNbMaxTries
            // 
            numNbMaxTries.Location = new Point(6, 28);
            numNbMaxTries.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numNbMaxTries.Name = "numNbMaxTries";
            numNbMaxTries.Size = new Size(133, 23);
            numNbMaxTries.TabIndex = 0;
            numNbMaxTries.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numNbMaxTries.ValueChanged += numNbMaxTries_ValueChanged;
            // 
            // grpRandomWord
            // 
            grpRandomWord.Controls.Add(lblTxtDifficultyPreset);
            grpRandomWord.Controls.Add(cbxDifficultyPreset);
            grpRandomWord.Controls.Add(lblMaxLength);
            grpRandomWord.Controls.Add(lblMinLength);
            grpRandomWord.Controls.Add(lblMaxLengthValue);
            grpRandomWord.Controls.Add(lblMinLengthValue);
            grpRandomWord.Controls.Add(tbrMaxLength);
            grpRandomWord.Controls.Add(tbrMinLength);
            grpRandomWord.Controls.Add(lblTxtMaxLength);
            grpRandomWord.Controls.Add(lblTxtMinLength);
            grpRandomWord.Location = new Point(6, 66);
            grpRandomWord.Name = "grpRandomWord";
            grpRandomWord.Size = new Size(385, 172);
            grpRandomWord.TabIndex = 1;
            grpRandomWord.TabStop = false;
            grpRandomWord.Text = "Random Word";
            // 
            // lblTxtDifficultyPreset
            // 
            lblTxtDifficultyPreset.AutoSize = true;
            lblTxtDifficultyPreset.Location = new Point(6, 142);
            lblTxtDifficultyPreset.Name = "lblTxtDifficultyPreset";
            lblTxtDifficultyPreset.Size = new Size(90, 15);
            lblTxtDifficultyPreset.TabIndex = 8;
            lblTxtDifficultyPreset.Text = "Difficulty preset";
            // 
            // cbxDifficultyPreset
            // 
            cbxDifficultyPreset.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxDifficultyPreset.Enabled = false;
            cbxDifficultyPreset.FormattingEnabled = true;
            cbxDifficultyPreset.Location = new Point(121, 139);
            cbxDifficultyPreset.Name = "cbxDifficultyPreset";
            cbxDifficultyPreset.Size = new Size(248, 23);
            cbxDifficultyPreset.TabIndex = 8;
            // 
            // lblMaxLength
            // 
            lblMaxLength.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblMaxLength.AutoSize = true;
            lblMaxLength.Location = new Point(357, 19);
            lblMaxLength.Name = "lblMaxLength";
            lblMaxLength.Size = new Size(12, 15);
            lblMaxLength.TabIndex = 7;
            lblMaxLength.Text = "-";
            // 
            // lblMinLength
            // 
            lblMinLength.AutoSize = true;
            lblMinLength.Location = new Point(121, 19);
            lblMinLength.Name = "lblMinLength";
            lblMinLength.Size = new Size(12, 15);
            lblMinLength.TabIndex = 6;
            lblMinLength.Text = "-";
            // 
            // lblMaxLengthValue
            // 
            lblMaxLengthValue.AutoSize = true;
            lblMaxLengthValue.Location = new Point(6, 103);
            lblMaxLengthValue.Name = "lblMaxLengthValue";
            lblMaxLengthValue.Size = new Size(15, 15);
            lblMaxLengthValue.TabIndex = 5;
            lblMaxLengthValue.Text = "()";
            // 
            // lblMinLengthValue
            // 
            lblMinLengthValue.AutoSize = true;
            lblMinLengthValue.Location = new Point(6, 52);
            lblMinLengthValue.Name = "lblMinLengthValue";
            lblMinLengthValue.Size = new Size(15, 15);
            lblMinLengthValue.TabIndex = 4;
            lblMinLengthValue.Text = "()";
            // 
            // tbrMaxLength
            // 
            tbrMaxLength.BackColor = SystemColors.Control;
            tbrMaxLength.Location = new Point(111, 88);
            tbrMaxLength.Name = "tbrMaxLength";
            tbrMaxLength.Size = new Size(268, 45);
            tbrMaxLength.TabIndex = 3;
            tbrMaxLength.Scroll += tbrMaxLength_Scroll;
            // 
            // tbrMinLength
            // 
            tbrMinLength.BackColor = SystemColors.Control;
            tbrMinLength.Location = new Point(111, 37);
            tbrMinLength.Name = "tbrMinLength";
            tbrMinLength.Size = new Size(268, 45);
            tbrMinLength.TabIndex = 2;
            tbrMinLength.Scroll += tbrMinLength_Scroll;
            // 
            // lblTxtMaxLength
            // 
            lblTxtMaxLength.AutoSize = true;
            lblTxtMaxLength.Location = new Point(6, 88);
            lblTxtMaxLength.Name = "lblTxtMaxLength";
            lblTxtMaxLength.Size = new Size(99, 15);
            lblTxtMaxLength.TabIndex = 1;
            lblTxtMaxLength.Text = "Maximum length";
            // 
            // lblTxtMinLength
            // 
            lblTxtMinLength.AutoSize = true;
            lblTxtMinLength.Location = new Point(6, 37);
            lblTxtMinLength.Name = "lblTxtMinLength";
            lblTxtMinLength.Size = new Size(97, 15);
            lblTxtMinLength.TabIndex = 0;
            lblTxtMinLength.Text = "Minimum length";
            // 
            // tabSettingsAppearance
            // 
            tabSettingsAppearance.Controls.Add(grpDisplayLanguage);
            tabSettingsAppearance.Controls.Add(grpTheme);
            tabSettingsAppearance.Location = new Point(4, 24);
            tabSettingsAppearance.Name = "tabSettingsAppearance";
            tabSettingsAppearance.Padding = new Padding(3);
            tabSettingsAppearance.Size = new Size(397, 321);
            tabSettingsAppearance.TabIndex = 1;
            tabSettingsAppearance.Text = "Appearance";
            tabSettingsAppearance.UseVisualStyleBackColor = true;
            // 
            // grpDisplayLanguage
            // 
            grpDisplayLanguage.Controls.Add(cbxLanguage);
            grpDisplayLanguage.Location = new Point(6, 159);
            grpDisplayLanguage.Name = "grpDisplayLanguage";
            grpDisplayLanguage.Size = new Size(385, 57);
            grpDisplayLanguage.TabIndex = 12;
            grpDisplayLanguage.TabStop = false;
            grpDisplayLanguage.Text = "Display language";
            // 
            // cbxLanguage
            // 
            cbxLanguage.DrawMode = DrawMode.OwnerDrawFixed;
            cbxLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxLanguage.Enabled = false;
            cbxLanguage.FormattingEnabled = true;
            cbxLanguage.Location = new Point(6, 22);
            cbxLanguage.Name = "cbxLanguage";
            cbxLanguage.Size = new Size(138, 24);
            cbxLanguage.TabIndex = 11;
            cbxLanguage.TabStop = false;
            cbxLanguage.DrawItem += comboBox_DrawItem;
            // 
            // grpTheme
            // 
            grpTheme.Controls.Add(btnDarkTheme);
            grpTheme.Controls.Add(chbCustomSecondaryBGColor);
            grpTheme.Controls.Add(lblTxtSecondaryBGColor);
            grpTheme.Controls.Add(btnColorBGSecondary);
            grpTheme.Controls.Add(btnDefaultColor);
            grpTheme.Controls.Add(chbCustomFGColor);
            grpTheme.Controls.Add(lblTxtFGColor);
            grpTheme.Controls.Add(lblTxtBackgroundColor);
            grpTheme.Controls.Add(btnColorFG);
            grpTheme.Controls.Add(btnColorBG);
            grpTheme.Location = new Point(6, 6);
            grpTheme.Name = "grpTheme";
            grpTheme.Size = new Size(385, 147);
            grpTheme.TabIndex = 0;
            grpTheme.TabStop = false;
            grpTheme.Text = "Theme";
            // 
            // btnDarkTheme
            // 
            btnDarkTheme.Location = new Point(179, 111);
            btnDarkTheme.Name = "btnDarkTheme";
            btnDarkTheme.Size = new Size(123, 23);
            btnDarkTheme.TabIndex = 9;
            btnDarkTheme.Text = "Dark theme";
            btnDarkTheme.UseVisualStyleBackColor = true;
            btnDarkTheme.Click += btnDarkTheme_Click;
            // 
            // chbCustomSecondaryBGColor
            // 
            chbCustomSecondaryBGColor.AutoSize = true;
            chbCustomSecondaryBGColor.Location = new Point(311, 54);
            chbCustomSecondaryBGColor.Name = "chbCustomSecondaryBGColor";
            chbCustomSecondaryBGColor.Size = new Size(68, 19);
            chbCustomSecondaryBGColor.TabIndex = 8;
            chbCustomSecondaryBGColor.Text = "Custom";
            chbCustomSecondaryBGColor.UseVisualStyleBackColor = true;
            chbCustomSecondaryBGColor.CheckedChanged += chbCustomSecondaryBGColor_CheckedChanged;
            // 
            // lblTxtSecondaryBGColor
            // 
            lblTxtSecondaryBGColor.AutoSize = true;
            lblTxtSecondaryBGColor.Location = new Point(43, 55);
            lblTxtSecondaryBGColor.Name = "lblTxtSecondaryBGColor";
            lblTxtSecondaryBGColor.Size = new Size(159, 15);
            lblTxtSecondaryBGColor.TabIndex = 7;
            lblTxtSecondaryBGColor.Text = "Secondary background color";
            // 
            // btnColorBGSecondary
            // 
            btnColorBGSecondary.BackColor = Color.Black;
            btnColorBGSecondary.Enabled = false;
            btnColorBGSecondary.Location = new Point(6, 51);
            btnColorBGSecondary.Name = "btnColorBGSecondary";
            btnColorBGSecondary.Size = new Size(31, 23);
            btnColorBGSecondary.TabIndex = 6;
            btnColorBGSecondary.UseVisualStyleBackColor = false;
            btnColorBGSecondary.Click += btnColorBGSecondary_Click;
            // 
            // btnDefaultColor
            // 
            btnDefaultColor.Location = new Point(6, 111);
            btnDefaultColor.Name = "btnDefaultColor";
            btnDefaultColor.Size = new Size(167, 23);
            btnDefaultColor.TabIndex = 5;
            btnDefaultColor.Text = "Default (light theme)";
            btnDefaultColor.UseVisualStyleBackColor = true;
            btnDefaultColor.Click += btnDefaultColor_Click;
            // 
            // chbCustomFGColor
            // 
            chbCustomFGColor.AutoSize = true;
            chbCustomFGColor.Location = new Point(311, 83);
            chbCustomFGColor.Name = "chbCustomFGColor";
            chbCustomFGColor.Size = new Size(68, 19);
            chbCustomFGColor.TabIndex = 4;
            chbCustomFGColor.Text = "Custom";
            chbCustomFGColor.UseVisualStyleBackColor = true;
            chbCustomFGColor.CheckedChanged += chbCustomFGColor_CheckedChanged;
            // 
            // lblTxtFGColor
            // 
            lblTxtFGColor.AutoSize = true;
            lblTxtFGColor.Location = new Point(43, 84);
            lblTxtFGColor.Name = "lblTxtFGColor";
            lblTxtFGColor.Size = new Size(58, 15);
            lblTxtFGColor.TabIndex = 3;
            lblTxtFGColor.Text = "Text color";
            // 
            // lblTxtBackgroundColor
            // 
            lblTxtBackgroundColor.AutoSize = true;
            lblTxtBackgroundColor.Location = new Point(43, 26);
            lblTxtBackgroundColor.Name = "lblTxtBackgroundColor";
            lblTxtBackgroundColor.Size = new Size(101, 15);
            lblTxtBackgroundColor.TabIndex = 2;
            lblTxtBackgroundColor.Text = "Background color";
            // 
            // btnColorFG
            // 
            btnColorFG.BackColor = Color.Black;
            btnColorFG.Enabled = false;
            btnColorFG.Location = new Point(6, 80);
            btnColorFG.Name = "btnColorFG";
            btnColorFG.Size = new Size(31, 23);
            btnColorFG.TabIndex = 1;
            btnColorFG.UseVisualStyleBackColor = false;
            btnColorFG.Click += btnColorFG_Click;
            // 
            // btnColorBG
            // 
            btnColorBG.BackColor = Color.Black;
            btnColorBG.Location = new Point(6, 22);
            btnColorBG.Name = "btnColorBG";
            btnColorBG.Size = new Size(31, 23);
            btnColorBG.TabIndex = 0;
            btnColorBG.UseVisualStyleBackColor = false;
            btnColorBG.Click += btnColorBG_Click;
            // 
            // ofdWordList
            // 
            ofdWordList.AddExtension = false;
            ofdWordList.FileName = "WordList";
            ofdWordList.Filter = "Text files|*.txt|All files|*";
            ofdWordList.Title = "Choose a word list";
            // 
            // frmConfig
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 367);
            Controls.Add(tabSettings);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmConfig";
            Text = "Settings";
            FormClosing += frmConfig_FormClosing;
            Load += frmConfig_Load;
            grpWordList.ResumeLayout(false);
            tabSettings.ResumeLayout(false);
            tabSettingsGameplay.ResumeLayout(false);
            grpChecks.ResumeLayout(false);
            grpChecks.PerformLayout();
            grpNbTries.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numNbMaxTries).EndInit();
            grpRandomWord.ResumeLayout(false);
            grpRandomWord.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbrMaxLength).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbrMinLength).EndInit();
            tabSettingsAppearance.ResumeLayout(false);
            grpDisplayLanguage.ResumeLayout(false);
            grpTheme.ResumeLayout(false);
            grpTheme.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpWordList;
        private TabControl tabSettings;
        private TabPage tabSettingsGameplay;
        private TabPage tabSettingsAppearance;
        private GroupBox grpTheme;
        private Button btnColorBG;
        private Button btnColorFG;
        private ComboBox cbxWordList;
        private Button btnImportWordList;
        private OpenFileDialog ofdWordList;
        private GroupBox grpRandomWord;
        private Label lblTxtMinLength;
        private GroupBox grpNbTries;
        private TrackBar tbrMaxLength;
        private TrackBar tbrMinLength;
        private Label lblTxtMaxLength;
        private NumericUpDown numNbMaxTries;
        private Label lblMaxLengthValue;
        private Label lblMinLengthValue;
        private Label lblMinLength;
        private Label lblMaxLength;
        private GroupBox grpChecks;
        private CheckBox chbCheckWordCorrect;
        private Label lblTxtDifficultyPreset;
        private ComboBox cbxDifficultyPreset;
        private Label lblTxtFGColor;
        private Label lblTxtBackgroundColor;
        private CheckBox chbCustomFGColor;
        private Button btnDefaultColor;
        private CheckBox chbCustomSecondaryBGColor;
        private Label lblTxtSecondaryBGColor;
        private Button btnColorBGSecondary;
        private Button btnDarkTheme;
        private ComboBox cbxLanguage;
        private GroupBox grpDisplayLanguage;
    }
}