using System;

namespace OOP_Assessment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type 'deal' to draw a card or type 'shuffle' to shuffle the deck...");

            Deck deck = new Deck();

            // Wait for user input and if valid input run the appropriate code then loop and wait for further input again
            while (true)
            {
                switch (Console.ReadLine().ToLower())
                {
                    case "shuffle":
                        deck.Shuffle();

                        Console.WriteLine("Shuffled deck!");

                        break;
                    case "deal":
                        {
                            try
                            {
                                Card card = deck.Deal();
                                Console.WriteLine($"{card.Value} of {card.Suit}");
                            }
                            catch (NullReferenceException)
                            {
                                Console.WriteLine("Deck is empty!");
                            }
                            
                        }

                        break;
                    case "exit":
                        Environment.Exit(0);
                        
                        break;
                }
            }
        }
    }
}
