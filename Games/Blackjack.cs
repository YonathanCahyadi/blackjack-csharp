using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GameObjects;

namespace Games {
    public static class Blackjack {
        public enum Result { Push, Won, Lost, Bust, Surrendered }
        const int INITIAL_VALUE = 1000;

        //fields
        private static CardPile _deck;

        //properties
        public static BlackjackHand DealerHand { get; private set; }

        public static List<BlackjackHand> PlayerHands { get; private set; }

        public static int PlayerFunds { get; private set; }

        //methods

        /// <summary>
        /// Reset Everything
        /// </summary>
        public static void Reset() {
            DealerHand = new BlackjackHand();
            PlayerHands = new List<BlackjackHand>();

            PlayerFunds = INITIAL_VALUE;
        }

        /// <summary>
        /// make a new round 
        /// </summary>
        /// <param name="initialBet"> The bet </param>
        public static void NewRound(int initialBet) {

            // make a full deck and shuffle it
            _deck = new CardPile(true);
            _deck.ShufflePile();

            // reduce the player fund
            PlayerFunds -= initialBet;


            DealerHand = new BlackjackHand();

            // make a new player hand
            PlayerHands = new List<BlackjackHand>();
            PlayerHands.Add(new BlackjackHand(initialBet));


            // deals  2 card to the player and the dealer
            for (int i = 0; i < 2; i++) {
                PlayerHands[0].AddCard(_deck.DealOneCard());
                DealerHand.AddCard(_deck.DealOneCard());

            }


        }

        /// <summary>
        /// Hit
        /// </summary>
        /// <param name="HandNum">Player Hand num</param>
        public static void Hit(int HandNum) {

            BlackjackHand playerHandNum = PlayerHands[HandNum];

            /*
            // if the score is atlest 21 
            if (playerHandNum.Score > 21 || playerHandNum.Score == 21) {
                // Is standing automaticaly True
                playerHandNum.IsStanding = true;
            } else {
                playerHandNum.IsStanding = false;
            }
            */

            // draw one Card
            playerHandNum.AddCard(_deck.DealOneCard());


            if (playerHandNum.Score > 21 || playerHandNum.Score == 21) {
                // Is standing automaticaly True
                playerHandNum.IsStanding = true;
            } else {
                playerHandNum.IsStanding = false;
            }

        }
        /// <summary>
        /// Double
        /// </summary>
        /// <param name="HandNum">Player Hand num</param>
        public static void Double(int HandNum) {
            BlackjackHand playerHandNum = PlayerHands[HandNum];

            //automatic standing
            playerHandNum.IsStanding = true;

            // add one card to hand
            playerHandNum.AddCard(_deck.DealOneCard());

            // substract fund
            PlayerFunds -= playerHandNum.Bet;

            // double the bet
            playerHandNum.Bet += playerHandNum.Bet;

        }
        /// <summary>
        /// Stand
        /// </summary>
        /// <param name="HandNum">Player Hand num</param>
        public static void Stand(int HandNum) {

            BlackjackHand playerHandNum = PlayerHands[HandNum];

            playerHandNum.IsStanding = true;


        }
        /// <summary>
        /// Surrender
        /// </summary>
        public static void Surrender() {

            PlayerHands[0].HasSurrendered = true;
            PlayerHands[0].IsStanding = true;

        }
        /// <summary>
        /// Split
        /// </summary>
        public static void Split() {
            PlayerHands.Add(new BlackjackHand(PlayerHands[0].Bet));

            PlayerFunds -= PlayerHands[0].Bet;

            PlayerHands[1].AddCard(PlayerHands[0].GetCard(0));
            PlayerHands[0].RemoveCardAt(0);

            PlayerHands[0].AddCard(_deck.DealOneCard());
            PlayerHands[1].AddCard(_deck.DealOneCard());


        }
        /// <summary>
        /// Check if Can Hit
        /// </summary>
        /// <param name="HandNum">Player Hand num</param>
        /// <returns>Return True if Can Hit</returns>
        public static bool CanHit(int HandNum) {

            //BlackjackHand playerZero = PlayerHands[0];
            //BlackjackHand playerOne = PlayerHands[1];
            //BlackjackHand playerTwo = PlayerHands[2];

            BlackjackHand playerHandNum = PlayerHands[HandNum];

            if (playerHandNum.Score <= 20 && playerHandNum.IsStanding == false) {
                return true;
            } else {
                return false;
            }
        }
        /// <summary>
        /// Check if Can Double
        /// </summary>
        /// <param name="HandNum">Player Hand num</param>
        /// <returns>Return True if Can Double</returns>
        public static bool CanDouble(int HandNum) {

            BlackjackHand playerHandNum = PlayerHands[HandNum];


            if (playerHandNum.Score <= 20 && playerHandNum.IsStanding == false &&
                playerHandNum.HasSurrendered == false && PlayerFunds >= playerHandNum.Bet) {

                return true;

            } else {
                return false;
            }

        }
        /// <summary>
        /// Check if Can Stand
        /// </summary>
        /// <param name="HandNum">PLayer Hand num</param>
        /// <returns>Return True if player Can Stand</returns>
        public static bool CanStand(int HandNum) {

            BlackjackHand playerHandNum = PlayerHands[HandNum];

            if (playerHandNum.Score <= 20 && playerHandNum.IsStanding == false) {
                return true;
            } else {
                return false;
            }
        }
        /// <summary>
        /// Check if Can Surrender
        /// </summary>
        /// <returns>Return true if player can Surrender</returns>
        public static bool CanSurrender() {

            if (PlayerHands.Count == 1) {

                BlackjackHand playerHandNum = PlayerHands[0];

                if (playerHandNum.Score <= 20 && playerHandNum.IsStanding == false) {
                    return true;
                } else {
                    return false;
                }
            } else {
                return false;
            }
        }
        /// <summary>
        /// Check if Can Split
        /// </summary>
        /// <returns>Return True if player Can split</returns>
        public static bool CanSplit() {


            BlackjackHand playerHandNum = PlayerHands[0];

            if (PlayerHands[0].Count <= 2 && !playerHandNum.IsStanding) {
                if ((playerHandNum.GetCard(0).FaceValue == playerHandNum.GetCard(1).FaceValue) ||
                    ((int)playerHandNum.GetCard(0).FaceValue >= 10 && (int)playerHandNum.GetCard(1).FaceValue >= 10)
                    && playerHandNum.IsStanding == false) {
                    return true;
                } else {
                    return false;
                }
            } else {
                return false;
            }
        }
        /// <summary>
        /// Check if player can play
        /// </summary>
        /// <returns>Return true if player can play</returns>
        public static bool CanPlayerPlay() {
            if (PlayerHands.Count == 2) {
                return CanHit(0) || CanHit(1) || CanDouble(0) || CanDouble(1) || CanStand(0) || CanStand(1)
                    || CanSurrender() || CanSplit();
            }
            return CanHit(0) || CanDouble(0) || CanStand(0) || CanSurrender() || CanSplit();
        }
        /// <summary>
        /// Dealer Play
        /// </summary>
        /// <returns>The result </returns>
        public static List<Result> DealerPlay() {

            List<Result> result = new List<Result>();

            bool drawCard = true;
            // Check if player gone Bust or not
            if (PlayerHands[0].Score > 21) {
                drawCard = false;
            }

            if (PlayerHands[0].HasSurrendered) { // player surrender
                result.Add(Result.Surrendered);
                // player get half the bet
                PlayerFunds += PlayerHands[0].Bet / 2;

            }

            // Draw Card for Dealer
            if (!PlayerHands[0].HasSurrendered && drawCard) {
                while (DealerHand.Score < 17) {
                    DealerHand.AddCard(_deck.DealOneCard());
                }
            }

            // Check Player Result
            for (int x = 0; x < PlayerHands.Count && !PlayerHands[0].HasSurrendered; x++) {
                if (DealerHand.Score > 21 || (PlayerHands[x].Score > DealerHand.Score
                    && PlayerHands[x].Score <= 21)) {// player win

                    result.Add(Result.Won);
                    // player gain twice their bet
                    PlayerFunds += PlayerHands[x].Bet * 2;

                } else if (PlayerHands[x].Score > 21) {// player bust
                    result.Add(Result.Bust);

                } else if (PlayerHands[x].Score == DealerHand.Score) {// player Push

                    result.Add(Result.Push);
                    // player get their bet back 
                    PlayerFunds += PlayerHands[x].Bet;

                } else if (PlayerHands[x].Score < DealerHand.Score) { // player lost
                    result.Add(Result.Lost);

                } 

            }

            return result;
        }
    }
}




