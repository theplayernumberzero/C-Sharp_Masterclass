public class Dice
{
    private readonly Random _random;
    private const int _sides = 6;

    public Dice(Random random)
    {
        _random = random;
    }

    public int Roll()
    {
        return _random.Next(1, _sides + 1);
    }

    public void Describe() => Console.WriteLine($"This is a dice with {_sides} side");
}