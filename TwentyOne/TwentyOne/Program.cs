using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    { 
        static void Main(string[] args)
        {
            ////Polymorphism
            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string>() { "Jesse", "Bill", "Bob" };
            //game.ListPlayers();

            //Console.ReadLine();

            ////Overloading operators
            //Game game = new TwentyOneGame();
            //game.Players = new List<Player>();
            //Player player = new Player();
            //player.Name = "Jesse";
            //game = game + player;
            //game = game - player;

            ////Structs
            //Card card1 = new Card();
            //Card card2 = card1;
            //card1.Face = Face.Eight;
            //card2.Face = Face.King;

            //Console.WriteLine(card1.Face);

            Deck deck = new Deck();

            ////Lambdas
            //int count = deck.Cards.Count(x => x.Face == Face.Ace);

            //List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();

            List<int> numberList = new List<int>() { 1, 2, 3, 535, 342, 23 };

            int sum = numberList.Where(x => x > 20).Sum();

             Console.WriteLine(sum);
                        


            //deck.Shuffle(3);

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }
    }
}
