using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GameObjects;
using Games;

namespace GUI {
    public partial class Blackjack_Form : Form {

        public Blackjack_Form() {
            InitializeComponent();

            
            //set the numeric up down minimum
            numericUpDown1.Minimum = 10;
            //set the numeric up down maximum
            numericUpDown1.Maximum = 100;

            SetButtonEnable(btnHitPlayerHand2, false);
            SetButtonEnable(btnStandPlayerHand2, false);
            SetButtonEnable(btnDoublePlayerHand2, false);

            SetButtonEnable(btnHitPlayerHand1, false);
            SetButtonEnable(btnDoublePlayerHand1, false);
            SetButtonEnable(btnStandPlayerHand1, false);
            SetButtonEnable(btnSurrenderPlayerHand1, false);
            SetButtonEnable(btnSplitPlayerHand1, false);

            lblInstructions.Text = "Press DEAL to start.";

            Blackjack.Reset();


        }

        /// <summary>
        /// Display the hand in the gui form
        /// </summary>
        /// <param name="hand"></param>
        /// <param name="panel"></param>
        /// <param name="showAllCards"></param>
        private void DisplayHand(Hand hand, TableLayoutPanel panel, bool showAllCards = true) {
            panel.Controls.Clear();
            panel.ColumnStyles.Clear();
            panel.ColumnCount = hand.Count;
            for (int i = 0; i < hand.Count; i++) {
                panel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                PictureBox picCard = new PictureBox();
                picCard.SizeMode = PictureBoxSizeMode.AutoSize;
                if ((!showAllCards && i == 0) || showAllCards) {
                    picCard.Image = Images.GetCardImage(hand.GetCard(i));
                } else {
                    picCard.Image = Images.GetBackOfCardImage();
                }
                panel.Controls.Add(picCard, i, 0);
            }
        }

        /// <summary>
        /// deal button event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeal_Click(object sender, EventArgs e) {

            // clear the player 2 table
            if (Blackjack.PlayerHands.Count == 2) {
                tblPlayerHand2.Controls.Clear();
                lblPlayerInfo2.Text = "Info";
            }

            Blackjack.NewRound(Convert.ToInt32(numericUpDown1.Value));

            DisplayHand(Blackjack.PlayerHands[0], tblPlayerHand1, true);
            
            DisplayHand(Blackjack.DealerHand, tblDealerHand, false);

            picDeck.Image = Images.GetBackOfCardImage();

            // change the player funds Label
            lblMoney.Text = Blackjack.PlayerFunds.ToString();

            SetButtonEnable(btnDeal, false);

            lblInstructions.Text = "Player Turn";

            lblDealerInfo.Text = "Info";

            lblInstructions2.Text = "";

            // set the numeric up down to disable and change the color
            numericUpDown1.Enabled = false;
            numericUpDown1.BackColor = Color.Cornsilk;

            UpdateGUI();
            

        }

        /// <summary>
        /// Hand 1 Hit Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHitPlayerHand1_Click(object sender, EventArgs e) {

            Blackjack.Hit(0);

            UpdateGUI();
            CanDealerPlay();
        }
        /// <summary>
        /// Hand 1 Double Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDoublePlayerHand1_Click(object sender, EventArgs e) {
            
            Blackjack.Double(0);

            UpdateGUI();
            CanDealerPlay();
        }
        /// <summary>
        /// Hand 1 Stand Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStandPlayerHand1_Click(object sender, EventArgs e) {
           
            Blackjack.Stand(0);

            UpdateGUI();
            CanDealerPlay();
        }
        /// <summary>
        /// Hand 1 Surrender Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSurrenderPlayerHand1_Click(object sender, EventArgs e) {
            
            Blackjack.Surrender();

            UpdateGUI();
            CanDealerPlay();


        }
        /// <summary>
        /// Hand 1 Split Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSplitPlayerHand1_Click(object sender, EventArgs e) {

            SetButtonEnable(btnSplitPlayerHand1, false);
            Blackjack.Split();

            UpdateGUI();
        }
        /// <summary>
        /// Hand 2 Hit Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHitPlayerHand2_Click(object sender, EventArgs e) {
            
            Blackjack.Hit(1);

            
            UpdateGUI();
            CanDealerPlay();
        }
        /// <summary>
        /// Hand 2 Double Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDoublePlayerHand2_Click(object sender, EventArgs e) {
            
            Blackjack.Double(1);

            UpdateGUI();
            CanDealerPlay();
        }
        /// <summary>
        /// Hand 2 Stand Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStandPlayerHand2_Click(object sender, EventArgs e) {
            
            Blackjack.Stand(1);
            

            UpdateGUI();
            CanDealerPlay();
        }
        /// <summary>
        /// Reset button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e) {
            Blackjack.Reset();

            lblMoney.Text = String.Format("{0:C}", Blackjack.PlayerFunds);

            // Player 2 Button Disable
            SetButtonEnable(btnHitPlayerHand2, false);
            SetButtonEnable(btnStandPlayerHand2, false);
            SetButtonEnable(btnDoublePlayerHand2, false);

            // Player 1 Button Disable
            SetButtonEnable(btnHitPlayerHand1, false);
            SetButtonEnable(btnDoublePlayerHand1, false);
            SetButtonEnable(btnStandPlayerHand1, false);
            SetButtonEnable(btnSurrenderPlayerHand1, false);
            SetButtonEnable(btnSplitPlayerHand1, false);

            // set the deal button  to enable
            SetButtonEnable(btnDeal, true);

            // set the numeric up down to enable and change the color
            numericUpDown1.Enabled = true;
            numericUpDown1.BackColor = Color.Yellow;

            // Clear everything
            tblDealerHand.Controls.Clear();
            tblPlayerHand1.Controls.Clear();
            tblPlayerHand2.Controls.Clear();

            lblPlayerInfo1.Text = "Info";
            lblPlayerInfo2.Text = "Info";
            lblDealerInfo.Text = "Info";

            lblInstructions.Text = "Press DEAL to start.";
            lblInstructions2.Text = "";
        }

        /// <summary>
        /// Set button enable
        /// </summary>
        /// <param name="button"></param>
        /// <param name="enabled"></param>
        public void SetButtonEnable(Button button, bool enabled = true) {
            button.Enabled = enabled;
            if (enabled) {
                button.BackColor = Color.Yellow;
                button.ForeColor = Color.Black;
            } else {
                button.BackColor = Color.Cornsilk;
                button.ForeColor = Color.Gray;
            }
        }
        /// <summary>
        /// Update the GUI
        /// </summary>
        /// <param name="dealerShow"></param>
        public void UpdateGUI() {

            // update the player Fund
            lblMoney.Text = String.Format("{0:C}", Blackjack.PlayerFunds);

            // -- Player Hand 1
            // update the Card -- Show the Card in the Table 
            DisplayHand(Blackjack.PlayerHands[0], tblPlayerHand1, true);

            // Update the Player Info
            lblPlayerInfo1.Text = String.Format("Bet: {0:C}   Score: {1}",
               Blackjack.PlayerHands[0].Bet, Blackjack.PlayerHands[0].Score);


            // Player 1 Update the Button 
            SetButtonEnable(btnHitPlayerHand1, Blackjack.CanHit(0));
            SetButtonEnable(btnDoublePlayerHand1, Blackjack.CanDouble(0));
            SetButtonEnable(btnStandPlayerHand1, Blackjack.CanStand(0));
            SetButtonEnable(btnSurrenderPlayerHand1, Blackjack.CanSurrender());
            SetButtonEnable(btnSplitPlayerHand1, Blackjack.CanSplit());

            // -- Player hand 2
            if (Blackjack.PlayerHands.Count == 2) {
                // update the Card -- Show the Card in the Table 
                DisplayHand(Blackjack.PlayerHands[1], tblPlayerHand2, true);

                // update the player Info
                lblPlayerInfo2.Text = String.Format("Bet: {0:C}   Score: {1}",
                Blackjack.PlayerHands[1].Bet, Blackjack.PlayerHands[1].Score);

                // update the button
                SetButtonEnable(btnDoublePlayerHand2, Blackjack.CanDouble(1));
                SetButtonEnable(btnHitPlayerHand2, Blackjack.CanHit(1));
                SetButtonEnable(btnStandPlayerHand2, Blackjack.CanStand(1));
                
            }

            // deal button update to Enable 
            SetButtonEnable(btnDeal, !Blackjack.CanPlayerPlay());
            
        }
        /// <summary>
        /// Check if Dealer Turn
        /// </summary>
        public void CanDealerPlay() {

            int fund = Blackjack.PlayerFunds;

            List<Blackjack.Result> results = new List<Blackjack.Result>();

            if (!Blackjack.CanPlayerPlay()) {
                
                results = Blackjack.DealerPlay();
                
                // -- Dealer hand Update
                DisplayHand(Blackjack.DealerHand, tblDealerHand, true);

                lblDealerInfo.Text = String.Format("Score: {0}",
                    Blackjack.DealerHand.Score);


                //player 1 -- Result
                lblPlayerInfo1.Text = String.Format("Bet: {0:C}   Score: {1} ({2})",
                Blackjack.PlayerHands[0].Bet, Blackjack.PlayerHands[0].Score, results[0]);

                // Player 2 -- Result
                if (Blackjack.PlayerHands.Count == 2) {
                    lblPlayerInfo2.Text = String.Format("Bet: {0:C}   Score: {1} ({2})",
               Blackjack.PlayerHands[1].Bet, Blackjack.PlayerHands[1].Score, results[1]);
                }


                // show player gain or loss
                lblInstructions.Text = String.Format("Gain: {0:C}", Blackjack.PlayerFunds - fund);

                // Deal button to enable
                SetButtonEnable(btnDeal, true);

                //numeric up down to enable and change the color
                numericUpDown1.Enabled = true;
                numericUpDown1.BackColor = Color.Yellow;

                // display the instruction for the second play
                lblInstructions2.Text = "Press DEAL to start a new round...";
            }

            

        }


       
    }
}
