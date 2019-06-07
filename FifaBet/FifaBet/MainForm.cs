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
using System.IO;


namespace FifaBet
{
    public partial class MainForm : Form
    {
        public List<fifateam> teams;

        public fifateam hometeam;
        public fifateam awayteam;
        

        public int balance = 50; // Saldo 
        public int creditsBet; // credits gebet

        string nameTeamOne;// naam van eerste team home game.
        string nameTeamTwo;// naam van tweede team away game.

        string fifaJson; // roep de api aan


        
        public MainForm()
        {
            InitializeComponent();
            UpdateBalanceLabel(); //update de label.
            API(); // update de api

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //deze laat je naam zien op je gok applicatie
            gokkerCreateForm newProfiel = new gokkerCreateForm();

            newProfiel.ShowDialog();

            nameLabel.Text = newProfiel.naam;

            if (nameLabel.Text == "")
            {
                this.Close();
            }


        }

        public void API()
        {
            System.Net.WebClient downloader = new System.Net.WebClient();

            try
            {
                // api link

                fifaJson = downloader.DownloadString("http://localhost/Proj_fifa/PHP/PHP/api.php/?key=hardcodedkey1234");

                teams = JsonConvert.DeserializeObject<List<fifateam>>(fifaJson);
                // zet de team in een comebox met buhulp van een list

                foreach (fifateam team in teams)
                {
                    comboBoxGames.Items.Add(team);
                }
            }
            catch (System.Net.WebException)
            {
                // als de api link niet werkt krijg je deze melding

                MessageBox.Show("er is iets misgegaan");
            }
        }

        public void UpdateBalanceLabel()
        {
            balanceLabel.Text = String.Format("${0}", this.balance); //Update de label.

            Debug.WriteLine(String.Format("${0}", this.balance)); // check of de code werkt in de debug!
        }

        private void nameLabel_DoubleClick(object sender, EventArgs e)
        {
            //Deze code actieveert de cheatcode!
            if (balance == 0)
            {
                cheatCodeForm cheatcode = new cheatCodeForm();

                if (cheatcode.ShowDialog() == DialogResult.OK) //Als de cheatcode goed is voer die deze code uit
                {
                    balance = cheatcode.balance;
                }

                UpdateBalanceLabel();
            }
            else
            {
                MessageBox.Show("Je hebt nog genoeg geld!"); //als je geld heb krijg je deze bericht
            }
        }

        private void buttonBet_Click(object sender, EventArgs e)
        {
            //hier plaats hij deze bet.
            placeBet();

        }

        private void placeBet()
        {
            getAmountBetCredits();

            if (creditsBet == 0)
            {
                MessageBox.Show("Zet altublieft een hoger aantal credits in");
            }

            // ^
            // |
            //Get the amount of credits on your account
            //Get the amount of credits you want to bet
            //checkCreditBetAmount(creditsBet, balance);

            else
            {
                if (!enoughCredits())
                {
                    if (balance == 1)
                    {
                        MessageBox.Show("Je hebt maar " + balance + " Credit, dus niet genoeg om een weddeschap aan te gaan");
                    }

                    else if (balance == 0)
                    {
                        MessageBox.Show("Je hebt geen Credits dus niet genoeg om een weddeschap aan te gaan");
                    }

                    else
                    {
                        MessageBox.Show("Je hebt maar " + balance + " Credits, dus niet genoeg om een weddeschap aan te gaan");
                    }
                    /// ^                    /// |
                    ///Check if the credits you want to bet are more than the amount you have
                    ///yes: Error message || no: place bet
                    ///
                }
                else
                {
                    if (radioButtonWinnerTeamOne.Checked && radioButtonWinnerTeamTwo.Checked)
                    {
                        MessageBox.Show("");
                    }
                    
                    /// ^^
                    /// ||
                    ///Check if what team team 1 and 2 are
                    ///Check what team is selected to win
                    else
                    {
                        int pointsTeamOne = (int)numericUpDownHomeTeam.Value;
                        int pointsTeamtwo = (int)numericUpDownAwayTeam.Value;
                        buttonPayOut.Enabled = true;
                        /// ^^
                        /// ||
                        ///Check how much points team 1 gets
                        ///Check how much points team 2 gets
                        ///
                        ///vraag of het goed is
                        /// ||
                        DialogResult dialogResult = MessageBox.Show("Weet je het zeker", "Zeker?", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            if (radioButtonWinnerTeamOne.Checked)
                            {
                                MessageBox.Show("U heeft " + creditsBet + " Credits op " + nameTeamOne + " ingezet");
                                buttonPayOut.Enabled = true;
                                //Inzet = hometeam.homescore;
                            }

                            else if (radioButtonWinnerTeamTwo.Checked)
                            {
                                MessageBox.Show("U heeft " + creditsBet + " Credits op " + nameTeamTwo + " ingezet");
                                buttonPayOut.Enabled = true;
                                //Inzet = awayteam.awayscore;
                            }

                            balance -= creditsBet;

                            UpdateBalanceLabel();

                        }
                     
                    }
                }
            }
        }

        private bool enoughCredits()
        {
            //kijk of je genoeg credit heb
            if (creditsBet > balance)
            {
                return false;
            }
            else { return true; }
        }

        private void checkCreditBetAmount(int creditsBet, int balance)
        {
            // kijk of je genoeg belanse heb
            if (creditsBet > balance)
            {
                MessageBox.Show("Je hebt maar " + balance + " Credits, dus niet genoeg");
            }
        }

        private void getAmountBetCredits()
        {
            // haal de hoeveelheid op die de speler heeft ingezet
            creditsBet = (int)numericUpDownBet.Value;
        }

        private void checkScores()
        {
            //kijk wat de speler heeft ingevuld in de scorebord.
            int teamOnePoints = (int)numericUpDownHomeTeam.Value;
            int teamTwoPoints = (int)numericUpDownAwayTeam.Value;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // Hier maak je een save text bestand aan.
            save saveObject = new save();

            saveObject.Balance = balance.ToString();
            saveObject.Name = nameLabel.Text;
            saveObject.hometeam = radioButtonWinnerTeamOne.ToString();
            saveObject.awayteam = radioButtonWinnerTeamTwo.ToString();
            saveObject.bets = creditsBet.ToString();

            string json = JsonConvert.SerializeObject(saveObject);

            File.WriteAllText(@"..\json.txt", json);
        }

        private void comboBoxGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            //het splitten van de teams waardoor de text van de teams op de radiobuttons komt
            string splitBy = ",";
            string[] splitted = comboBoxGames.Text.Split(splitBy[0]);

            nameTeamOne = splitted[0].Trim();
            nameTeamTwo = splitted[1].Trim();

            updateTeamLabels();
        }

        private void updateTeamLabels()
        {
            //update de radiobuttons met de team namen
            radioButtonWinnerTeamOne.Text = nameTeamOne;
            radioButtonWinnerTeamTwo.Text = nameTeamTwo;

            labelTeamOne.Text = nameTeamOne;
            labelTeamTwo.Text = nameTeamTwo;
        }

        private void buttonPayOut_Click(object sender, EventArgs e)
        {
            payOut();

            choseTeamGroupBox.Enabled = true;
            radioButtonWinnerTeamOne.Checked = false;
            radioButtonWinnerTeamTwo.Checked = false;

            groupBoxRightScore.Enabled = true;
            numericUpDownHomeTeam.Value = 0;
            numericUpDownAwayTeam.Value = 0;
        }

        public void payOut()
        {
            foreach (fifateam team in teams)
            {
                string winningTeam = "";
                bool teamA = nameTeamOne == team.home;
                bool teamB = nameTeamTwo == team.away;


                if (team.awayscore > team.homescore)
                {
                    winningTeam = team.away;
                }
                else if (team.awayscore < team.homescore)
                {
                    winningTeam = team.home;
                }
                if ((teamA && teamB))
                {
                    if (winningTeam == nameTeamOne)
                    {
                        MessageBox.Show(winningTeam + " heeft gewonnen");

                        if (team.awayscore == numericUpDownAwayTeam.Value && team.homescore == numericUpDownHomeTeam.Value)
                        {
                            creditsBet *= 3;
                            balance += creditsBet;
                            UpdateBalanceLabel();
                            buttonPayOut.Enabled = false;
                            return;
                        }
                        else if (radioButtonWinnerTeamOne.Checked)
                        {
                            creditsBet *= 2;
                            balance += creditsBet;
                            UpdateBalanceLabel();
                            buttonPayOut.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Je hebt verloren!");
                        }

                    }
               
                    else if (winningTeam == nameTeamTwo)
                    {
                        MessageBox.Show(winningTeam + " heeft gewonnen");

                        if (team.awayscore == numericUpDownAwayTeam.Value && team.homescore == numericUpDownHomeTeam.Value)
                        {
                            creditsBet *= 3;
                            balance += creditsBet;
                            UpdateBalanceLabel();
                            buttonPayOut.Enabled = false;
                            return;
                        }
                        else if (radioButtonWinnerTeamTwo.Checked)
                        {
                            creditsBet *= 2;
                            balance += creditsBet;
                            UpdateBalanceLabel();
                            buttonPayOut.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Je hebt verloren!");
                        }
                    }


                    else if (team.awayscore != numericUpDownAwayTeam.Value && team.homescore != numericUpDownHomeTeam.Value)
                    {
                        MessageBox.Show("Je hebt niet de juiste score ingevuld");
                        return;
                    }
                    return;
                }
            }
        }

        private void groupBoxRightScore_Enter(object sender, EventArgs e)
        {
            if (radioButtonWinnerTeamOne.Checked || radioButtonWinnerTeamTwo.Checked)
            {
                groupBoxRightScore.Enabled = false;
                return;
            }
        }

        private void choseTeamGroupBox_Enter(object sender, EventArgs e)
        {
            if (numericUpDownHomeTeam.Value > 1 || numericUpDownAwayTeam.Value > 1)
            {
                choseTeamGroupBox.Enabled = false;
                return;
            }
        }

        private void checkBoxWinnerTeamTwo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonWinnerTeamOne.Checked)
            {
                radioButtonWinnerTeamOne.Checked = false;
            }
        }

        private void checkBoxWinnerTeamOne_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonWinnerTeamTwo.Checked)
            {
                radioButtonWinnerTeamTwo.Checked = false;
            }

        }
    }
}
    