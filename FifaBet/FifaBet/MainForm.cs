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
                fifaJson = downloader.DownloadString("http://localhost:63342/Voetbal_app/PHP/PHP/api.php?_ijt=m5p02i0r5dtujn4enamsq60tk4");
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

        private void buttonBet_Click(object sender, EventArgs e)
        {
            placeBet();
        }

        private void placeBet()
        {
            ///TODO:
            getAmountBetCredits();
            getCredits();
            /// ^
            /// |
            ///Get the amount of credits on your account
            ///Get the amount of credits you want to bet
            checkCreditBetAmount();
            /// ^
            /// |
            ///Check if the credits you want to bet are more than the amount you have
            ///yes: Error message || no: place bet
            ///
            checkSelectedTeam();
            /// ^
            /// |
            ///Check if what team team 1 and 2 are
            ///Check what team is selected to win
            checkScores();
            /// ^
            /// |
            ///Check how much points team 1 gets
            ///Check how much points team 2 gets
        }

        private void checkCreditBetAmount()
        {
            /// check if you have enough balance
            if(creditsBet > balance)
            {
                MessageBox.Show("Je hebt maar " + balance + " Credits, dus niet genoeg");
            }
        }

        private void checkSelectedTeam()
        {
            /// check which team is selected to be a winner
            throw new NotImplementedException();
        }

        private int getCredits()
        {
            /// get the balance
            return balance;
        }

        private int getAmountBetCredits()
        {
            /// get the amount of credits the player bets
            int creditsBet = (int)numericUpDownBet.Value;
            return creditsBet;
        }

        private void checkScores()
        {
            ///check what the player filled in as scores
            throw new NotImplementedException();
        }
    }
}
