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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            comboBoxGames_SelectedIndexChanged(null, null);
        }

        private void comboBoxGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Net.WebClient downloader = new System.Net.WebClient();
            string fifaJson;
            
            try
            {
                fifaJson = downloader.DownloadString("http://localhost/Project%20fifa/PHP/PHP/api.php");
                List<fifateam> teams = JsonConvert.DeserializeObject<List<fifateam>>(fifaJson);

                foreach(fifateam team in teams)
                {
                    comboBoxGames.Items.Add(team.name);
                }
                
            }
            catch (System.Net.WebException)
            {
                MessageBox.Show("er is iets misgegaan");
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
