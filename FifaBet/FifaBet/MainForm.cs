using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace FifaBet
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void comboBoxGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch
            {
                MessageBox.Show("Er is iets misgegaan");
            }
        }
    }
}
