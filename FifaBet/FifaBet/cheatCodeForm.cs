﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FifaBet
{
    public partial class cheatCodeForm : Form
    {
        string cheatcodes; //roep de textbox aan
        public int balance = 0; // je saldo

        MainForm moneyForm = new MainForm();

        public cheatCodeForm()
        {
            InitializeComponent();
        }

        private void cheatCodeButton_Click(object sender, EventArgs e)
        {
            if(cheatCodeTextBox.Text == "fifacheatcode")
            {
                balance = 50;

                this.DialogResult = DialogResult.OK;
                
            }
            else
            {
                MessageBox.Show("Je heb de code verkeerd probeer het nog is!");
                this.DialogResult = DialogResult.No;
            }
        }

        private void cheatCodeTextBox_TextChanged(object sender, EventArgs e)
        {
            cheatcodes = cheatCodeTextBox.Text;
        }
    }
}