using Newtonsoft.Json;
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
    public partial class GokkersSelect : Form
    {
        public GokkersSelect()
        {
            InitializeComponent();
        }

        private void GokkersSelect_Load(object sender, EventArgs e)
        {
            List<string> hi = new List<string>();
            string[] hih = new string[2];
            hih[0] = "si";
            hih[1] = "no";


        }

        private void GokkersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
