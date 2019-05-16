using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FifaBet
{
    public partial class MainForm : Form
    {
        public int balance = 0; // Saldo 

        public MainForm()
        {
            InitializeComponent();

            UpdateBalanceLabel(); //update de label.

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //deze laat je naam zien op je gok applicatie
            gokkerCreateForm newProfiel = new gokkerCreateForm();
            newProfiel.ShowDialog();
            nameLabel.Text = newProfiel.naam;

            if(nameLabel.Text == "")
            {
                this.Close();
            }

            System.Net.WebClient downloader = new System.Net.WebClient();
            string fifaJson;

            try
            {
                fifaJson = downloader.DownloadString("http://localhost:63342/Voetbal_app/PHP/PHP/api.php?_ijt=khv718r3ev809m3gld9e12ascq");
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

        public void UpdateBalanceLabel()
        {
            balanceLabel.Text = String.Format("{0}",this.balance); //Update de label.
            Debug.WriteLine(String.Format("{0}", this.balance)); // check of de code werkt in de debug!
        }

        private void nameLabel_DoubleClick(object sender, EventArgs e)
        {
            //Deze code actieveert de cheatcode!
            if( balance == 0)
            {
                cheatCodeForm cheatcode = new cheatCodeForm();
                if(cheatcode.ShowDialog() == DialogResult.OK) //Als de cheatcode goed is voer die deze code uit
                {
                    balance = cheatcode.balance;
                }
                
                UpdateBalanceLabel();
            }
            else
            {
                MessageBox.Show("Je hebt nog genoeg geld!");
            }
        }
    }
}
