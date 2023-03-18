namespace Lab2_Anagram
{
    partial class frmMainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainWindow));
            lblTxtWordToGuess = new Label();
            lblWord = new Label();
            grpGuess = new GroupBox();
            btnTest = new Button();
            tbxGuess = new TextBox();
            grpTries = new GroupBox();
            lstPreviousGuesses = new ListBox();
            lblTxtPreviousGuesses = new Label();
            numNbrGuesses = new NumericUpDown();
            lblTxtNumberOfRemainingGuesses = new Label();
            grpGameHistory = new GroupBox();
            lstGameHistory = new ListBox();
            btnNewGame = new Button();
            btnExit = new Button();
            lnkHowToPlay = new LinkLabel();
            cbxLanguage = new ComboBox();
            lnkAbout = new LinkLabel();
            grpGuess.SuspendLayout();
            grpTries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numNbrGuesses).BeginInit();
            grpGameHistory.SuspendLayout();
            SuspendLayout();
            // 
            // lblTxtWordToGuess
            // 
            lblTxtWordToGuess.AutoSize = true;
            lblTxtWordToGuess.Location = new Point(12, 9);
            lblTxtWordToGuess.Name = "lblTxtWordToGuess";
            lblTxtWordToGuess.Size = new Size(86, 15);
            lblTxtWordToGuess.TabIndex = 0;
            lblTxtWordToGuess.Text = "Word to guess:";
            // 
            // lblWord
            // 
            lblWord.AutoSize = true;
            lblWord.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            lblWord.Location = new Point(12, 24);
            lblWord.Name = "lblWord";
            lblWord.Size = new Size(176, 46);
            lblWord.TabIndex = 1;
            lblWord.Text = "Loading...";
            // 
            // grpGuess
            // 
            grpGuess.Controls.Add(btnTest);
            grpGuess.Controls.Add(tbxGuess);
            grpGuess.Location = new Point(12, 73);
            grpGuess.Name = "grpGuess";
            grpGuess.Size = new Size(303, 66);
            grpGuess.TabIndex = 2;
            grpGuess.TabStop = false;
            grpGuess.Text = "Guess";
            // 
            // btnTest
            // 
            btnTest.Location = new Point(213, 22);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(84, 23);
            btnTest.TabIndex = 1;
            btnTest.Text = "Test";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += btnTest_Click;
            // 
            // tbxGuess
            // 
            tbxGuess.Location = new Point(6, 22);
            tbxGuess.Name = "tbxGuess";
            tbxGuess.Size = new Size(201, 23);
            tbxGuess.TabIndex = 0;
            tbxGuess.TextChanged += tbxGuess_TextChanged;
            tbxGuess.KeyDown += tbxGuess_KeyDown;
            // 
            // grpTries
            // 
            grpTries.Controls.Add(lstPreviousGuesses);
            grpTries.Controls.Add(lblTxtPreviousGuesses);
            grpTries.Controls.Add(numNbrGuesses);
            grpTries.Controls.Add(lblTxtNumberOfRemainingGuesses);
            grpTries.Location = new Point(12, 145);
            grpTries.Name = "grpTries";
            grpTries.Size = new Size(303, 232);
            grpTries.TabIndex = 3;
            grpTries.TabStop = false;
            grpTries.Text = "Tries";
            // 
            // lstPreviousGuesses
            // 
            lstPreviousGuesses.FormattingEnabled = true;
            lstPreviousGuesses.ItemHeight = 15;
            lstPreviousGuesses.Location = new Point(6, 64);
            lstPreviousGuesses.Name = "lstPreviousGuesses";
            lstPreviousGuesses.Size = new Size(291, 154);
            lstPreviousGuesses.TabIndex = 4;
            lstPreviousGuesses.TabStop = false;
            // 
            // lblTxtPreviousGuesses
            // 
            lblTxtPreviousGuesses.AutoSize = true;
            lblTxtPreviousGuesses.Location = new Point(6, 46);
            lblTxtPreviousGuesses.Name = "lblTxtPreviousGuesses";
            lblTxtPreviousGuesses.Size = new Size(99, 15);
            lblTxtPreviousGuesses.TabIndex = 2;
            lblTxtPreviousGuesses.Text = "Previous guesses:";
            // 
            // numNbrGuesses
            // 
            numNbrGuesses.Enabled = false;
            numNbrGuesses.ImeMode = ImeMode.NoControl;
            numNbrGuesses.Location = new Point(184, 17);
            numNbrGuesses.Name = "numNbrGuesses";
            numNbrGuesses.Size = new Size(113, 23);
            numNbrGuesses.TabIndex = 3;
            numNbrGuesses.TabStop = false;
            // 
            // lblTxtNumberOfRemainingGuesses
            // 
            lblTxtNumberOfRemainingGuesses.AutoSize = true;
            lblTxtNumberOfRemainingGuesses.Location = new Point(6, 19);
            lblTxtNumberOfRemainingGuesses.Name = "lblTxtNumberOfRemainingGuesses";
            lblTxtNumberOfRemainingGuesses.Size = new Size(172, 15);
            lblTxtNumberOfRemainingGuesses.TabIndex = 0;
            lblTxtNumberOfRemainingGuesses.Text = "Number of remaining guesses: ";
            // 
            // grpGameHistory
            // 
            grpGameHistory.Controls.Add(lstGameHistory);
            grpGameHistory.Location = new Point(321, 73);
            grpGameHistory.Name = "grpGameHistory";
            grpGameHistory.Size = new Size(261, 268);
            grpGameHistory.TabIndex = 4;
            grpGameHistory.TabStop = false;
            grpGameHistory.Text = "Game history";
            // 
            // lstGameHistory
            // 
            lstGameHistory.FormattingEnabled = true;
            lstGameHistory.ItemHeight = 15;
            lstGameHistory.Location = new Point(6, 22);
            lstGameHistory.Name = "lstGameHistory";
            lstGameHistory.Size = new Size(249, 229);
            lstGameHistory.TabIndex = 5;
            lstGameHistory.TabStop = false;
            lstGameHistory.MouseDown += lstGameHistory_MouseDown;
            // 
            // btnNewGame
            // 
            btnNewGame.Location = new Point(327, 347);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(153, 30);
            btnNewGame.TabIndex = 6;
            btnNewGame.Text = "New Game";
            btnNewGame.UseVisualStyleBackColor = true;
            btnNewGame.Click += btnNewGame_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(486, 347);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(90, 30);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lnkHowToPlay
            // 
            lnkHowToPlay.AutoSize = true;
            lnkHowToPlay.Location = new Point(404, 12);
            lnkHowToPlay.Name = "lnkHowToPlay";
            lnkHowToPlay.Size = new Size(76, 15);
            lnkHowToPlay.TabIndex = 8;
            lnkHowToPlay.TabStop = true;
            lnkHowToPlay.Text = "How to play?";
            lnkHowToPlay.TextAlign = ContentAlignment.TopRight;
            lnkHowToPlay.LinkClicked += lnkHowToPlay_LinkClicked;
            // 
            // cbxLanguage
            // 
            cbxLanguage.DrawMode = DrawMode.OwnerDrawFixed;
            cbxLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxLanguage.Enabled = false;
            cbxLanguage.FormattingEnabled = true;
            cbxLanguage.Location = new Point(532, 12);
            cbxLanguage.Name = "cbxLanguage";
            cbxLanguage.Size = new Size(50, 24);
            cbxLanguage.TabIndex = 10;
            cbxLanguage.TabStop = false;
            cbxLanguage.DrawItem += comboBox_DrawItem;
            // 
            // lnkAbout
            // 
            lnkAbout.AutoSize = true;
            lnkAbout.Location = new Point(486, 12);
            lnkAbout.Name = "lnkAbout";
            lnkAbout.Size = new Size(40, 15);
            lnkAbout.TabIndex = 9;
            lnkAbout.TabStop = true;
            lnkAbout.Text = "About";
            lnkAbout.TextAlign = ContentAlignment.TopRight;
            lnkAbout.LinkClicked += lnkAbout_LinkClicked;
            // 
            // frmMainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 389);
            Controls.Add(lnkAbout);
            Controls.Add(cbxLanguage);
            Controls.Add(lnkHowToPlay);
            Controls.Add(btnExit);
            Controls.Add(btnNewGame);
            Controls.Add(grpGameHistory);
            Controls.Add(grpTries);
            Controls.Add(grpGuess);
            Controls.Add(lblWord);
            Controls.Add(lblTxtWordToGuess);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMainWindow";
            Text = "Anagram Game";
            FormClosing += frmMainWindow_FormClosing;
            Load += frmMainWindow_Load;
            grpGuess.ResumeLayout(false);
            grpGuess.PerformLayout();
            grpTries.ResumeLayout(false);
            grpTries.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numNbrGuesses).EndInit();
            grpGameHistory.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTxtWordToGuess;
        private Label lblWord;
        private GroupBox grpGuess;
        private Button btnTest;
        private TextBox tbxGuess;
        private GroupBox grpTries;
        private ListBox lstPreviousGuesses;
        private Label lblTxtPreviousGuesses;
        private NumericUpDown numNbrGuesses;
        private Label lblTxtNumberOfRemainingGuesses;
        private GroupBox grpGameHistory;
        private ListBox lstGameHistory;
        private Button btnNewGame;
        private Button btnExit;
        private LinkLabel lnkHowToPlay;
        private ComboBox cbxLanguage;
        private LinkLabel lnkAbout;
    }
}