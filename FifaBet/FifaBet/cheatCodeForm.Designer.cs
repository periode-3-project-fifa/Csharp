namespace FifaBet
{
    partial class cheatCodeForm
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
            this.cheatCodeTextBox = new System.Windows.Forms.TextBox();
            this.cheatCodeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cheatCodeTextBox
            // 
            this.cheatCodeTextBox.Location = new System.Drawing.Point(12, 38);
            this.cheatCodeTextBox.Name = "cheatCodeTextBox";
            this.cheatCodeTextBox.Size = new System.Drawing.Size(207, 20);
            this.cheatCodeTextBox.TabIndex = 0;
            this.cheatCodeTextBox.TextChanged += new System.EventHandler(this.cheatCodeTextBox_TextChanged);
            this.cheatCodeTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cheatCodeTextBox_KeyUp);
            // 
            // cheatCodeButton
            // 
            this.cheatCodeButton.Location = new System.Drawing.Point(12, 64);
            this.cheatCodeButton.Name = "cheatCodeButton";
            this.cheatCodeButton.Size = new System.Drawing.Size(75, 23);
            this.cheatCodeButton.TabIndex = 1;
            this.cheatCodeButton.Text = "Check code";
            this.cheatCodeButton.UseVisualStyleBackColor = true;
            this.cheatCodeButton.Click += new System.EventHandler(this.cheatCodeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welkom je heb de cheat code ontdenkt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ken je de cheat code ook raden";
            // 
            // cheatCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 89);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cheatCodeButton);
            this.Controls.Add(this.cheatCodeTextBox);
            this.Name = "cheatCodeForm";
            this.Text = "cheatCodeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cheatCodeTextBox;
        private System.Windows.Forms.Button cheatCodeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}