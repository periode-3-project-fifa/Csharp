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
        int balance;

        public MainForm()
        {
            InitializeComponent();

            balance = 50; //Hoeveel geld iedereen heeft.
            UpdateBalanceLabel(); //update de label.
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            System.Net.WebClient downloader = new System.Net.WebClient();
            string fifaJson;

            try
            {
                fifaJson = downloader.DownloadString("http://localhost/Project%20fifa/PHP/PHP/api.php");
                List<fifateam> teams = JsonConvert.DeserializeObject<List<fifateam>>(fifaJson);


                foreach (fifateam team in teams)
                {
                    comboBoxGames.Items.Add(team);
                }

            }
            catch (System.Net.WebException)
            {
                MessageBox.Show("er is iets misgegaan");
            }
        }

        private void UpdateBalanceLabel()
        {
            balanceLabel.Text = balance.ToString(); //Update de label.
        }
    }
}
