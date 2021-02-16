using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameObjects {

    public enum Suit { Clubs, Diamonds, Hearts, Spades }
    public enum FaceValue {
        Ace = 1, Two, Three, Four, Five, Six, Seven, Eight, Nine,
        Ten, Jack, Queen, King
    }

    /// <summary>
    /// Card
    /// </summary>
    public class Card : IEquatable<Card>, IComparable<Card> {

        // Properties
        public FaceValue FaceValue { get; }
        public Suit Suit { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="suit">The Suit</param>
        /// <param name="facevalue">The Face Value</param>
        public Card(Suit suit, FaceValue facevalue) {

            FaceValue = facevalue;
            Suit = suit;
        }

        /// <summary>
        /// Compare this card to the other Card
        /// </summary>
        /// <param name="other">The other Card</param>
        /// <returns>Return below 0 if this card should be sorted before the other Card
        /// Return 0 if this card occure on the same position as the other Card
        /// Return above 1 if this card should be sorted after the other Card</returns>
        public int CompareTo(Card other) {

            // same position
            if (this.Suit == other.Suit && this.FaceValue == other.FaceValue) {
                return 0;
            }

            // Same suit but different Face Value
            if (this.Suit == other.Suit) {
                if (this.FaceValue > other.FaceValue) { // compare facevalue
                    return 1;
                } else {
                    return -1;
                }
            }

            //Different Suit compare
            if (this.Suit != other.Suit) {
                if (this.Suit > other.Suit) {
                    return 1;

                } else {
                    return -1;
                }

            }
            return 0;
        }


        /// <summary>
        /// To check if thhis card Equals to the given card
        /// </summary>
        /// <param name="otherCard">The other Card</param>
        /// <returns>Return True if this card had the same value as the other card</returns>
        public bool Equals(Card otherCard) {

            //chcek if this suit and facevalue is equal to other suit and facevalue
            if (this.Suit == otherCard.Suit &&
                this.FaceValue == otherCard.FaceValue) {
                //if both equal then will return true
                return true;
            } else {
                //otherwise false
                return false;
            }

            /*
             return this.Suit.Equals(other.Suit) && this.FaceValue.Equals(other.FaceValue); 
             */

        }

        /// <summary>
        /// Obtain the value representing the card in String format
        /// </summary>
        /// <returns>the first letter of FaceValue followed by the first leeter of the Suit</returns>
        public override string ToString() {
            //check the first letter of the facevalue
            string faceValuePart = FaceValue.ToString()[0].ToString();
            //check the first character of the suit
            char suitPart = Suit.ToString()[0];

            //if facevalue is between 2 and 10 will return the number of the facevalue
            if ((int)FaceValue >= 2 && (int)FaceValue <= 10) {
                faceValuePart = ((int)FaceValue).ToString();
            }
            //return the first letter of facevalue and first character of suit
            return string.Format("{0}{1}", faceValuePart, suitPart);
        }
    }
}





