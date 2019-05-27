namespace FifaBet
{
    partial class GokkersSelect
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
            this.GokkersListBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GokkersListBox
            // 
            this.GokkersListBox.FormattingEnabled = true;
            this.GokkersListBox.Location = new System.Drawing.Point(12, 12);
            this.GokkersListBox.Name = "GokkersListBox";
            this.GokkersListBox.Size = new System.Drawing.Size(237, 394);
            this.GokkersListBox.TabIndex = 0;
            this.GokkersListBox.SelectedIndexChanged += new System.EventHandler(this.GokkersListBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // GokkersSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 442);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GokkersListBox);
            this.Name = "GokkersSelect";
            this.Text = "GokkersSelect";
            this.Load += new System.EventHandler(this.GokkersSelect_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox GokkersListBox;
        private System.Windows.Forms.Button button1;
    }
}