

public class GuessingGame
{
    private readonly Dice _dice;
    private const int _maxTries = 3;

    public GuessingGame(Dice dice)
    {
        _dice = dice;
    }

    public GameResult Play()
    {
        var diceRollResult = _dice.Roll();
        Console.WriteLine($"Dice rolled. Guess the number. You have {_maxTries} tries..");

        var triesLeft = _maxTries;
        while(triesLeft > 0)
        {
            var guessNumber = ConsoleReader.ReadInteger("Enter a number: ");
            if (guessNumber == diceRollResult)
            {
                Console.WriteLine("Congratulations! You guessed the number!");
                return GameResult.Victory;
            }
            Console.WriteLine("Wrong number :(");
            triesLeft--;
        }
        return GameResult.Loss;
    }

    public static void PrintResult(GameResult gameResult)
    {
        string message = gameResult == GameResult.Victory ? "You won!" : "You lost!";
    }
}

public enum GameResult
{
    Victory,
    Loss
}