﻿using System;
using System.Collections.Generic;
using System.Net;

namespace ConsoleApp5
{
	public class Player
	{
		public Player(string name, int beginningbalance)
		{
			Hand = new List<Card>();
			Balance = beginningbalance;
			Name = name;
		}
		private List<Card> _hand = new List<Card>();
		public List<Card> Hand { get { return _hand; } set { _hand = value; } }
		public int Balance { get; set; }
		public string Name { get; set; }
		public bool IsActivelyPlaying { get; set; }
		public bool Stay { get; set; }

		public bool Bet(int amount)
		{
			if (Balance - amount < 0)
			{
				Console.WriteLine("Insufficient funds");
				return false;
			}
			else
			{
				Balance -= amount;
				return true;
			}
		}
		public static Game operator +(Game game, Player player)
		{
			game.Players.Add(player);
			return game;
		}
		public static Game operator -(Game game, Player player)
		{
			game.Players.Remove(player);
			return game;
		}
	}
}
