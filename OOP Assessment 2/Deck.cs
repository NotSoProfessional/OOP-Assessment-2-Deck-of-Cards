using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Assessment_2
{
    class Deck
    {
        // Fields
        private Stack<Card> _deckStack = new Stack<Card>();
        private List<Card> _cards = new List<Card>();

        // Properties
        private Stack<Card> DeckStack
        {
            get { return _deckStack; }
            set { _deckStack = value; }
        }

        private List<Card> Cards
        {
            get { return _cards; }
            set { _cards = value; }
        }


        public Deck()
        {
            // Create and add all 52 cards to deck
            String[] suits = new String[] { 
                "Hearts",
                "Clubs",
                "Diamonds",
                "Spades"
            };

            foreach (string suit in suits)
            {
                for (int i = 1; i < 14; i++)
                {
                    _deckStack.Push(new Card(suit, i));
                }
            }
        }

        public bool isEmpty()
        {
            // Check if the deck has no cards and return appropriate bool
            if (DeckStack.Count < 1)
            {
                return true;
            } 
            else
            {
                return false;
            }
        }

        public void Shuffle()
        {   
            // Convert the deck stack object to a list so that any cards within the deck can be removed
            List<Card> convertedDeck = DeckStack.ToList<Card>();

            Stack<Card> shuffledDeck = new Stack<Card>();

            // Randomise the order of the cards that are currently in the deck
            // Works by picking a random card from the current deck and appends it onto a new list for every card in the deck
            foreach (Card card in DeckStack)
            {
                int randomIndex = new Random().Next(0, convertedDeck.Count);
                
                shuffledDeck.Push(convertedDeck[randomIndex]);
                convertedDeck.RemoveAt(randomIndex);
            }

            // Replace the deck stack with the new shuffled one
            DeckStack.Clear();
            DeckStack = shuffledDeck;
        }

        public Card Deal()
        {
            // If the deck is not empty then return the card that is on top of the stack
            if (this.isEmpty())
            {
                return null;
            }
            else
            {
                return DeckStack.Pop();
            }
        }
    }
}
