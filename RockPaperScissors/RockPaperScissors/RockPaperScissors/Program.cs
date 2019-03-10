using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Please Choose Rock, Paper, or Scissors");
			Random cpu = new Random();
			int num = cpu.Next(1, 4);

			
			string play = Console.ReadLine();
			if (play == "Rock" && num == 1)
			{
				Console.WriteLine("You Chose Rock");
				Console.WriteLine("Tie Game!");
			}
			if (play == "Paper" && num == 2)
			{
				Console.WriteLine("You Chose Paper");
				Console.WriteLine("Tie Game!");
			}
			if (play == "Scissors" && num == 3)
			{
				Console.WriteLine("You Chose Scissors");
				Console.WriteLine("Tie Game!");
			}
			if (play == "Rock" && num == 2)
			{
				Console.WriteLine("You Chose Rock");
				Console.WriteLine("You Lose!");

			}
			if (play == "Rock" && num == 3)
			{
				Console.WriteLine("You Chose Rock");
				Console.WriteLine("You Win!");
			}
			if (play == "Paper" && num == 1)
			{
				Console.WriteLine("You Chose Paper");
				Console.WriteLine("You Win!");
			}
			if (play == "Scissors" && num == 2)
			{
				Console.WriteLine("You Chose Scissors");
				Console.WriteLine("You Win!");
			}

			switch (num)
			{
				case 1:
					Console.WriteLine("Computer Chose Rock");
					break;
				case 2:
					Console.WriteLine("Computer Chose Paper");
					break;
				case 3:
					Console.WriteLine("Computer Chose Scissors");
					break;
					//generates something for cpu to play
			}
			Console.WriteLine("Press any key to exit.");
			Console.ReadKey();

		}
	}
}
