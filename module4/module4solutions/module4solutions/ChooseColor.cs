using System;
namespace modue4solutions;

public class ChooseColor
{
	 public static void Colory()
	{
		for (int i = 1; i < 5; i++)
		{
			Console.WriteLine("Iteration {0}", i);
			switch (Console.ReadLine())
			{
				case "red":
					Console.BackgroundColor = ConsoleColor.Red;
					Console.ForegroundColor = ConsoleColor.Black;

					Console.WriteLine("Your color is red!");
					break;

				case "green":
					Console.BackgroundColor = ConsoleColor.Green;
					Console.ForegroundColor = ConsoleColor.Black;

					Console.WriteLine("Your color is red!");
					Console.ForegroundColor = ConsoleColor.Black;
					break;
				

            }
		}
	}
}
