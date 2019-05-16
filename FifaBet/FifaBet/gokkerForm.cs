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
            if(string.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("voer een naam in");
            }
            else
            {
                naam = nameTextBox.Text;

                MessageBox.Show("Welkom" + " " + naam);

                this.Close();
            }
        }


        private void nameTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                createNewUser.PerformClick();
            }
        }

        private void gokkerCreateForm_Load(object sender, EventArgs e)
        {

        }

        /*private void gokkerCreateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //zorgt er voor dat je de form niet kan sluiten voordat je een naam heb ingevoerd
            if(string.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("Voer eerst een naam in om de form te sluiten.");
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }*/
    }
}
