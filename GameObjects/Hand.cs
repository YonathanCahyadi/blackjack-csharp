using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameObjects {

    /// <summary>
    /// Hand
    /// </summary>
    public class Hand : IEnumerable {

        // Field
        private List<Card> _hand;

        //properties
        public int Count {
            get {
                return _hand.Count;
            }
        }

        // Method

        /// <summary>
        /// Construct a new empty hand
        /// </summary>
        public Hand() {
            _hand = new List<Card>();
        }

        /// <summary>
        /// Construct a new Hand containing the given list of Cards
        /// </summary>
        /// <param name="listOfCard"> A list of Card</param>
        public Hand(List<Card> listOfCard) {

            _hand = new List<Card>();

            foreach (Card cards in listOfCard) {
                _hand.Add(cards);
            }

        }

        /// <summary>
        /// Return Card at the given position
        /// </summary>
        /// <param name="index">position</param>
        /// <returns>Card at that position</returns>
        public Card GetCard(int index) {
            return _hand[index];

        }

        /// <summary>
        /// Add the given Card to the Hand
        /// </summary>
        /// <param name="card">The Card</param>
        public void AddCard(Card card) {
            _hand.Add(card);

        }

        /// <summary>
        /// Check card in the Hand
        /// </summary>
        /// <param name="card">The Card</param>
        /// <returns>Return True if the given card is in the Hand</returns>
        public bool ContainsCard(Card card) {
            return _hand.Contains(card);
        }

        /// <summary>
        /// Remove card from the Hand
        /// </summary>
        /// <param name="card">The card</param>
        /// <returns>Return True if the card successfully removed</returns>
        public bool RemoveCard(Card card) {
            return _hand.Remove(card);
        }

        /// <summary>
        /// Remove Card at a given index
        /// </summary>
        /// <param name="index">index</param>
        /// <returns>Return True if sucessful</returns>
        public bool RemoveCardAt(int index) {

            try {
                _hand.RemoveAt(index);
            } catch (ArgumentOutOfRangeException) {
                return false;
            }

            return true;
        }

        /// <summary>
        ///  Sort the Hand first by Suit, and then by FaceValue
        /// </summary>
        public void SortHand() {
            _hand.Sort();
        }

        /// <summary>
        /// Gets an enumerator over the Hand
        /// </summary>
        /// <returns>An Enumerator over the Hand</returns>
        public IEnumerator GetEnumerator() {
            return _hand.GetEnumerator();
        }
    }
}
