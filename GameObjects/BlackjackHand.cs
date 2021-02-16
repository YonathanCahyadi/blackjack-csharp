using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameObjects {

    public class BlackjackHand : Hand {
        const int INITIAL_SCORE = 0;

        //Properties
        public bool IsStanding { get; set; }

        public bool HasSurrendered { get; set; }

        public int Bet { get; set; }

        public int Score {
            get {

                int currentScore = INITIAL_SCORE;
                bool acePresent = false;

                // Count all the non-Ace
                for (int i = 0; i < Count; i++) {

                    // count the non-Ace Card
                    if (GetCard(i).FaceValue != FaceValue.Ace) {

                        // Make the value of Jack, Queen, King into 10
                        if (GetCard(i).FaceValue == FaceValue.Jack ||
                            GetCard(i).FaceValue == FaceValue.Queen ||
                            GetCard(i).FaceValue == FaceValue.King) {

                            currentScore += 10;
                        } else {

                            //Count all the normal Card
                            currentScore += (int)GetCard(i).FaceValue;
                        }

                    } else {
                        acePresent = true;
                    }


                }

                // determine the value of Ace
                if (acePresent) {
                    bool valid = true;

                    for (int x = 0; x < Count; x++) {
                        // Determine the value of the Ace
                        if (GetCard(x).FaceValue == FaceValue.Ace) {

                            // Value of Ace 11
                            if (valid && currentScore <= 10) {
                                currentScore += 11;
                                valid = false;

                            } else {
                                // Value of Ace 1
                                currentScore += (int)FaceValue.Ace;
                            }

                        }
                    }
                }

                return currentScore;
            }
        }

        //Methods
        public BlackjackHand(int initialBet = 0) {

            Bet += initialBet;

        }
    }
}
