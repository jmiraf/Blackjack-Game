using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp5
{
	class Program
	{
		static void Main(string[] args)
		{
			//File IO
			//string text = "Here is some text";
			//File.WriteAllText(@"C:\Users\jmirafue\source\repos\ConsoleApp5\log.txt", text);
			//string text = File.ReadAllText("C:\\Users\\jmirafue\\source\\repos\\ConsoleApp5\\log.txt");


			//Module 7 BlackJace game
			Console.WriteLine("Welcome to 21 game online! Who is playing today?");
			string playerName = Console.ReadLine();

			Console.WriteLine("How much money did you bring today?");
			int bank = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
			string answer = Console.ReadLine().ToLower();
			if (answer == "yes" || answer == "yup" || answer == "yeah")
			{
				Player player = new Player(playerName, bank);
				Game game = new TwentyOneGame();
				game += player;
				player.IsActivelyPlaying = true;
				while (player.IsActivelyPlaying && player.Balance > 0)
				{
					game.Play();
				}
				game -= player;
				Console.WriteLine("thank you for playing!");
			}
			Console.WriteLine("Feel free to look around the casino. Bye for now!");
			Console.ReadLine();

			//Structs
			//Card card1 = new Card();
			//Card card2 = card1;
			//card1.Face = (Face.Eight);
			//card2.Face = (Face.King);
			//Console.WriteLine(card1.Face);
			//Console.ReadLine();

			//TwentyOneGame game = new TwentyOneGame();
			//game.Players = new List<string>() { "Jace", "Magnus", "Cedric" };
			//game.ListPlayers();
			//game.Play();
			//Console.ReadLine();

			//enums lesson
			//DaysOfTheWeek day = new DaysOfTheWeek();
			//int underlyingvalue = Convert.ToInt32(DaysOfTheWeek.Tuesday);
			//Console.WriteLine(underlyingvalue);
			//Console.ReadLine();

			//TwentyOneGame game = new TwentyOneGame();
			//game.Players = new List<string>() { "Jace", "Magnus", "Cedric" };
			//game.ListPlayers();
			//Console.ReadLine();

			//Deck deck = new Deck();

			//Lambda sum function
			//List<int> numberList = new List<int>() { 1, 2, 3, 4, 5 };
			////int sum = numberList.Sum();
			//int sum = numberList.Sum(x => x * 2);
			//Console.WriteLine("15 x 2 = " + sum);

			//Lambda where function
			//List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();
			//foreach (Card card in newList)
			//	{
			//		Console.WriteLine(card.Face);
			//	}

			//Lambda simple method
			//int count1 = deck.Cards.Count(x => x.Face == Face.Ace);
			//Console.WriteLine(count1);

			//Lambda method
			//int counter = 0;
			//foreach (Card card in deck.Cards)
			//{
			//	if (card.Face == Face.Ace)
			//	{
			//		counter++;
			//	}
			//}
			//Console.WriteLine(counter);
			//Console.ReadLine();

			//deck.Shuffle(3);

			//foreach (Card card in deck.Cards)
			//{
			//	Console.WriteLine(card.Face + " of " + card.Suit);
			//}
			//Console.WriteLine(deck.Cards.Count);
			//Console.ReadLine();

			//}
			//public enum DaysOfTheWeek
			//{
			//	Monday=2, 
			//	Tuesday=3, 
			//	Wednesday=4, 
			//	Thursday=5, 
			//	Friday=6, 
			//	Saturday=7, 
			//	Sunday=8
			//}

		}
	}
}
