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
using System.Net;

namespace FifaBet
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            comboBoxGames_SelectedIndexChanged(null, null);
        }

        private void comboBoxGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string json = client.DownloadString("http://localhost/Project%20fifa/PHP/PHP/api.php");
            fifabet teams = JsonConvert.DeserializeObject<fifabet>(json);
 
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
