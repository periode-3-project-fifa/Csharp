using System;
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
    public partial class gokkerCreateForm : Form
    {
        public string naam;

        public gokkerCreateForm()
        {
            InitializeComponent();
        }

        private void createNewUser_Click(object sender, EventArgs e)
        {
            naam = nameTextBox.Text;

            MessageBox.Show("Welkom" + " " + naam);

            this.Close();
        }


        private void nameTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                createNewUser.PerformClick();
            }
        }
    }
}
