using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            //      Objects are the backbone of Object Oriented Programming

            Deck deck = new Deck();
            int timesShuffled = 0;
            deck = Shuffle(deck, out timesShuffled, 3);        //      A named paramter will not change function but will make code easier to read
            //deck = Shuffle(deck, 3);      //      ex. deck = Shuffle(deck: deck, times: 3);
                        
            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.WriteLine($"This deck has been shuffled {timesShuffled} times.");

            Console.ReadLine();


        }

        //          Methods aka Functions aka Routines = bits of code which do something and can be called over and over
        //          Method overloading is something C# has created that allows us to use the same Method name and create another method that is similar
        //              but it is required to be different.

        public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1)        //  By adding a =1, the (times) integer becomes an optional input for the method. If no  
        {                                                           //  number is input (times) is assumed to be 1, but will accept another number as an input.
            timesShuffled = 0;
            for (int i = 0; i < times; i++)
            {
                timesShuffled++;                                                    // The timesShuffled var is called an out. We are taking data out of the method and assigning it to another
                List<Card> TempList = new List<Card>();                             // variable. This example will allow us to verify the number of times this method runs.
                Random random = new Random();

                while (deck.Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, deck.Cards.Count);
                    TempList.Add(deck.Cards[randomIndex]);
                    deck.Cards.RemoveAt(randomIndex);
                }
                deck.Cards = TempList;
            }
            
            return deck;
        }

        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}
    }
}
