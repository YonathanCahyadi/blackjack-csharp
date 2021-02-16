using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameObjects {


    /// <summary>
    /// Card Pile
    /// </summary>
    public class CardPile {
        //Fields
        private List<Card> _pile;
        private Random _numberGenerator = new Random();

        //Properties
        public int Count {
            get {
                return _pile.Count;
            }
        }
        public Card TopCard {
            get {
                return _pile[_pile.Count - 1];
            }
        }

        //Method

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="boolean">if True make a Card Pile with 52 Card</param>
        public CardPile(bool boolean = false) {

            // make an empty list of Card
            _pile = new List<Card>();

            //if its true then construct 52 cards in order of suits followed by facevalue
            if (boolean == true) {
                // do loop for every possible card and add them to _pile
                for (int i = (int)Suit.Clubs; i <= (int)Suit.Spades; i++) {
                    for (int x = (int)FaceValue.Ace; x <= (int)FaceValue.King; x++) {
                        // add the new card into the pile
                        _pile.Add(new Card((Suit)i, (FaceValue)x));

                    }
                }
            }

        }

        /// <summary>
        /// add card to the Card Pile
        /// </summary>
        /// <param name="card">The Card</param>
        public void AddCard(Card card) {
            _pile.Add(card);
        }

        /// <summary>
        /// Shuffle the Card Pile
        /// </summary>
        public void ShufflePile() {
           
            // go to every card in the Pile of Card
            for (int i = _pile.Count - 1; i >= 0; i--) {
                // generate a random index for x
                int x = _numberGenerator.Next(0, i);

                //swap the card between i and x
                Card temp = _pile[x];
                _pile[x] = _pile[i];
                _pile[i] = temp;


            }

        }

        /// <summary>
        /// Deals one Card from the Card Pile
        /// </summary>
        /// <returns>the first Card from Card Pile</returns>
        public Card DealOneCard() {
            Card temp = _pile[0];
            _pile.RemoveAt(0);

            return temp;

        }

        /// <summary>
        /// Deals as many number from the Card pile
        /// </summary>
        /// <param name="numberOfCard">number of Card</param>
        /// <returns>The Card from Card Pile</returns>
        public List<Card> DealCards(int numberOfCard) {

            //create a new list of a card
            List<Card> cards = new List<Card>(numberOfCard);

            //if the cards is smaller than the number of card then add one more cards
            for (int i = 0; i < numberOfCard; i++) {
                cards.Add(DealOneCard());
            }
            //return into the list of the cards
            return cards;
        }

    }
}
