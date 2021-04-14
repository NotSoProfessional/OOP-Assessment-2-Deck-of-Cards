using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assessment_2
{
    class Card
    {
        // Fields
        private string _suit;
        private dynamic _value;

        // Properties
        public string Suit
        {
            get { return _suit; }
            private set { _suit = value; }
        }

        public dynamic Value
        { 
            get { return _value; }
            private set
            {
                // Set the cards value and replaces the value with its representing name.
                _value = value;

                switch (value)
                {
                    case 13:
                        _value = "King";
                        break;

                    case 12:
                        _value = "Queen";
                        break;

                    case 11:
                        _value = "Jack";
                        break;

                    case 1:
                        _value = "Ace";
                        break;
                }
            }
        }


        public Card(string suit, int value)
        {
            // Set the cards suit and value
            Suit = suit;
            Value = value;
        }
    }
}
