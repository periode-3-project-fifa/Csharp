namespace FifaBet
{
    partial class MainForm
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
            this.labelCredits = new System.Windows.Forms.Label();
            this.comboBoxGames = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownBet = new System.Windows.Forms.NumericUpDown();
            this.labelBetCredits = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.labelTeamOne = new System.Windows.Forms.Label();
            this.labelTeamTwo = new System.Windows.Forms.Label();
            this.groupBoxRightScore = new System.Windows.Forms.GroupBox();
            this.buttonBet = new System.Windows.Forms.Button();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.choseTeamGroupBox = new System.Windows.Forms.GroupBox();
            this.radioButtonWinnerTeamTwo = new System.Windows.Forms.RadioButton();
            this.radioButtonWinnerTeamOne = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.groupBoxRightScore.SuspendLayout();
            this.choseTeamGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCredits
            // 
            this.labelCredits.AutoSize = true;
            this.labelCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCredits.Location = new System.Drawing.Point(313, 9);
            this.labelCredits.Name = "labelCredits";
            this.labelCredits.Size = new System.Drawing.Size(63, 20);
            this.labelCredits.TabIndex = 0;
            this.labelCredits.Text = "Credits:";
            // 
            // comboBoxGames
            // 
            this.comboBoxGames.FormattingEnabled = true;
            this.comboBoxGames.Location = new System.Drawing.Point(108, 76);
            this.comboBoxGames.Name = "comboBoxGames";
            this.comboBoxGames.Size = new System.Drawing.Size(191, 21);
            this.comboBoxGames.TabIndex = 1;
            this.comboBoxGames.Text = "Choose a match";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inzet:";
            // 
            // numericUpDownBet
            // 
            this.numericUpDownBet.Location = new System.Drawing.Point(126, 171);
            this.numericUpDownBet.Name = "numericUpDownBet";
            this.numericUpDownBet.Size = new System.Drawing.Size(54, 20);
            this.numericUpDownBet.TabIndex = 3;
            // 
            // labelBetCredits
            // 
            this.labelBetCredits.AutoSize = true;
            this.labelBetCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBetCredits.Location = new System.Drawing.Point(200, 171);
            this.labelBetCredits.Name = "labelBetCredits";
            this.labelBetCredits.Size = new System.Drawing.Size(59, 20);
            this.labelBetCredits.TabIndex = 4;
            this.labelBetCredits.Text = "Credits";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(6, 58);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(72, 20);
            this.numericUpDown1.TabIndex = 8;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(123, 58);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(72, 20);
            this.numericUpDown2.TabIndex = 9;
            // 
            // labelTeamOne
            // 
            this.labelTeamOne.AutoSize = true;
            this.labelTeamOne.Location = new System.Drawing.Point(6, 30);
            this.labelTeamOne.Name = "labelTeamOne";
            this.labelTeamOne.Size = new System.Drawing.Size(43, 13);
            this.labelTeamOne.TabIndex = 10;
            this.labelTeamOne.Text = "Team 1";
            // 
            // labelTeamTwo
            // 
            this.labelTeamTwo.AutoSize = true;
            this.labelTeamTwo.Location = new System.Drawing.Point(120, 30);
            this.labelTeamTwo.Name = "labelTeamTwo";
            this.labelTeamTwo.Size = new System.Drawing.Size(43, 13);
            this.labelTeamTwo.TabIndex = 11;
            this.labelTeamTwo.Text = "Team 2";
            // 
            // groupBoxRightScore
            // 
            this.groupBoxRightScore.Controls.Add(this.numericUpDown1);
            this.groupBoxRightScore.Controls.Add(this.labelTeamTwo);
            this.groupBoxRightScore.Controls.Add(this.numericUpDown2);
            this.groupBoxRightScore.Controls.Add(this.labelTeamOne);
            this.groupBoxRightScore.Location = new System.Drawing.Point(108, 316);
            this.groupBoxRightScore.Name = "groupBoxRightScore";
            this.groupBoxRightScore.Size = new System.Drawing.Size(200, 100);
            this.groupBoxRightScore.TabIndex = 12;
            this.groupBoxRightScore.TabStop = false;
            this.groupBoxRightScore.Text = "Juiste uitslag";
            // 
            // buttonBet
            // 
            this.buttonBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBet.Location = new System.Drawing.Point(108, 459);
            this.buttonBet.Name = "buttonBet";
            this.buttonBet.Size = new System.Drawing.Size(200, 42);
            this.buttonBet.TabIndex = 13;
            this.buttonBet.Text = "Inzetten";
            this.buttonBet.UseVisualStyleBackColor = true;
            this.buttonBet.Click += new System.EventHandler(this.buttonBet_Click);
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceLabel.Location = new System.Drawing.Point(371, 12);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(49, 16);
            this.balanceLabel.TabIndex = 14;
            this.balanceLabel.Text = "Saldo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Welkom:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(78, 14);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(47, 15);
            this.nameLabel.TabIndex = 16;
            this.nameLabel.Text = "label3";
            this.nameLabel.DoubleClick += new System.EventHandler(this.nameLabel_DoubleClick);
            // 
            // choseTeamGroupBox
            // 
            this.choseTeamGroupBox.Controls.Add(this.radioButtonWinnerTeamTwo);
            this.choseTeamGroupBox.Controls.Add(this.radioButtonWinnerTeamOne);
            this.choseTeamGroupBox.Location = new System.Drawing.Point(108, 210);
            this.choseTeamGroupBox.Name = "choseTeamGroupBox";
            this.choseTeamGroupBox.Size = new System.Drawing.Size(200, 100);
            this.choseTeamGroupBox.TabIndex = 17;
            this.choseTeamGroupBox.TabStop = false;
            this.choseTeamGroupBox.Text = "Kies Team";
            // 
            // radioButtonWinnerTeamTwo
            // 
            this.radioButtonWinnerTeamTwo.AutoSize = true;
            this.radioButtonWinnerTeamTwo.Location = new System.Drawing.Point(109, 40);
            this.radioButtonWinnerTeamTwo.Name = "radioButtonWinnerTeamTwo";
            this.radioButtonWinnerTeamTwo.Size = new System.Drawing.Size(61, 17);
            this.radioButtonWinnerTeamTwo.TabIndex = 1;
            this.radioButtonWinnerTeamTwo.TabStop = true;
            this.radioButtonWinnerTeamTwo.Text = "Team 2";
            this.radioButtonWinnerTeamTwo.UseVisualStyleBackColor = true;
            // 
            // radioButtonWinnerTeamOne
            // 
            this.radioButtonWinnerTeamOne.AutoSize = true;
            this.radioButtonWinnerTeamOne.Location = new System.Drawing.Point(7, 40);
            this.radioButtonWinnerTeamOne.Name = "radioButtonWinnerTeamOne";
            this.radioButtonWinnerTeamOne.Size = new System.Drawing.Size(61, 17);
            this.radioButtonWinnerTeamOne.TabIndex = 0;
            this.radioButtonWinnerTeamOne.TabStop = true;
            this.radioButtonWinnerTeamOne.Text = "Team 1";
            this.radioButtonWinnerTeamOne.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 550);
            this.Controls.Add(this.choseTeamGroupBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.buttonBet);
            this.Controls.Add(this.groupBoxRightScore);
            this.Controls.Add(this.labelBetCredits);
            this.Controls.Add(this.numericUpDownBet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxGames);
            this.Controls.Add(this.labelCredits);
            this.Name = "MainForm";
            this.Text = "FIFA Bidden";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.groupBoxRightScore.ResumeLayout(false);
            this.groupBoxRightScore.PerformLayout();
            this.choseTeamGroupBox.ResumeLayout(false);
            this.choseTeamGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCredits;
        private System.Windows.Forms.ComboBox comboBoxGames;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownBet;
        private System.Windows.Forms.Label labelBetCredits;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label labelTeamOne;
        private System.Windows.Forms.Label labelTeamTwo;
        private System.Windows.Forms.GroupBox groupBoxRightScore;
        private System.Windows.Forms.Button buttonBet;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.GroupBox choseTeamGroupBox;
        private System.Windows.Forms.RadioButton radioButtonWinnerTeamTwo;
        private System.Windows.Forms.RadioButton radioButtonWinnerTeamOne;
    }
}

