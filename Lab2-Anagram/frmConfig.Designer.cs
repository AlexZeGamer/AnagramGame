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
            grpTheme = new GroupBox();
            chbCustomComplementaryColor = new CheckBox();
            lblTxtComplementaryColor = new Label();
            lblTxtBackgroundColor = new Label();
            btnColorComplementary = new Button();
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
            numNbMaxTries.Name = "numNbMaxTries";
            numNbMaxTries.Size = new Size(133, 23);
            numNbMaxTries.TabIndex = 0;
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
            tabSettingsAppearance.Controls.Add(grpTheme);
            tabSettingsAppearance.Location = new Point(4, 24);
            tabSettingsAppearance.Name = "tabSettingsAppearance";
            tabSettingsAppearance.Padding = new Padding(3);
            tabSettingsAppearance.Size = new Size(397, 321);
            tabSettingsAppearance.TabIndex = 1;
            tabSettingsAppearance.Text = "Appearance";
            tabSettingsAppearance.UseVisualStyleBackColor = true;
            tabSettingsAppearance.Paint += tabSettingsAppearance_Paint;
            // 
            // grpTheme
            // 
            grpTheme.Controls.Add(chbCustomComplementaryColor);
            grpTheme.Controls.Add(lblTxtComplementaryColor);
            grpTheme.Controls.Add(lblTxtBackgroundColor);
            grpTheme.Controls.Add(btnColorComplementary);
            grpTheme.Controls.Add(btnColorBG);
            grpTheme.Location = new Point(6, 6);
            grpTheme.Name = "grpTheme";
            grpTheme.Size = new Size(385, 92);
            grpTheme.TabIndex = 0;
            grpTheme.TabStop = false;
            grpTheme.Text = "Theme";
            // 
            // chbCustomComplementaryColor
            // 
            chbCustomComplementaryColor.AutoSize = true;
            chbCustomComplementaryColor.Location = new Point(311, 54);
            chbCustomComplementaryColor.Name = "chbCustomComplementaryColor";
            chbCustomComplementaryColor.Size = new Size(68, 19);
            chbCustomComplementaryColor.TabIndex = 4;
            chbCustomComplementaryColor.Text = "Custom";
            chbCustomComplementaryColor.UseVisualStyleBackColor = true;
            // 
            // lblTxtComplementaryColor
            // 
            lblTxtComplementaryColor.AutoSize = true;
            lblTxtComplementaryColor.Location = new Point(43, 55);
            lblTxtComplementaryColor.Name = "lblTxtComplementaryColor";
            lblTxtComplementaryColor.Size = new Size(123, 15);
            lblTxtComplementaryColor.TabIndex = 3;
            lblTxtComplementaryColor.Text = "Complementary color";
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
            // btnColorComplementary
            // 
            btnColorComplementary.BackColor = Color.Black;
            btnColorComplementary.Enabled = false;
            btnColorComplementary.Location = new Point(6, 51);
            btnColorComplementary.Name = "btnColorComplementary";
            btnColorComplementary.Size = new Size(31, 23);
            btnColorComplementary.TabIndex = 1;
            btnColorComplementary.UseVisualStyleBackColor = false;
            btnColorComplementary.Click += btnColorComplementary_Click;
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
            FormClosed += frmConfig_FormClosed;
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
        private Button btnColorComplementary;
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
        private Label lblTxtComplementaryColor;
        private Label lblTxtBackgroundColor;
        private CheckBox chbCustomComplementaryColor;
    }
}