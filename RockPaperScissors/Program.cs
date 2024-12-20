using System;

class Program
{
	// Method to get the user's choice, validates the input
	static string GetUserChoice(string userInput)
	{
		userInput = userInput.ToLower();
		if (userInput == "rock" || userInput == "paper" || userInput == "scissors" || userInput == "bomb")
		{
			return userInput;
		}
		else
		{
			Console.WriteLine("Error! Please enter a valid choice.");
			return null; // Indicates invalid input
		}
	}

	// Method to randomly generate the computer's choice
	static string GetComputerChoice()
	{
		Random random = new Random();
		int randomNumber = random.Next(0, 3); // Generate a number between 0 and 2

		return randomNumber switch
		{
			0 => "rock",
			1 => "paper",
			2 => "scissors",
			_ => "rock" // Default case, though not required
		};
	}

	// Method to determine the winner based on user and computer choices
	static string DetermineWinner(string userChoice, string computerChoice)
	{
		if (userChoice == computerChoice)
		{
			return "This game is a tie!";
		}

		if (userChoice == "rock")
		{
			return (computerChoice == "paper") ? "The computer won!" : "The user won!";
		}

		if (userChoice == "paper")
		{
			return (computerChoice == "scissors") ? "The computer won!" : "The user won!";
		}

		if (userChoice == "scissors")
		{
			return (computerChoice == "rock") ? "The computer won!" : "The user won!";
		}

		if (userChoice == "bomb") // Special cheat code
		{
			return "The user won!";
		}

		return "Error in determining winner."; // Fallback case
	}

	// Main game logic
	static void PlayGame()
	{
		// Simulating user input; this can be replaced with real input from Console.ReadLine
		string userChoice = GetUserChoice("bomb");
		if (userChoice == null) return; // Exit if the user input is invalid

		string computerChoice = GetComputerChoice();

		Console.WriteLine($"You threw {userChoice}.");
		Console.WriteLine($"The computer threw {computerChoice}.");
		Console.WriteLine(DetermineWinner(userChoice, computerChoice));
	}

	static void Main()
	{
		PlayGame();
	}
}