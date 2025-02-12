void add(int number1, int number2)
{
    Console.WriteLine(number1 + number2);
}
void subtract(int number1, int number2)
{
    Console.WriteLine(number1 - number2);
}

void divide(int number1, int number2)
{
    Console.WriteLine(number1 / number2);
}

void multiply(int number1, int number2)
{
    Console.WriteLine(number1 * number2);
}

Console.WriteLine("Hello!");

Console.WriteLine("Input the first number:");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Input the second number:");
int number2 = int.Parse(Console.ReadLine());

Console.WriteLine("What do you want to do?");
Console.WriteLine("[A]dd numbers");
Console.WriteLine("[S]ubtract numbers");
Console.WriteLine("[D]ivide numbers");
Console.WriteLine("[M]ultiply numbers");

string operation = Console.ReadLine();

if(operation.ToUpper() == "A")
{
    add(number1, number2);
}
else if (operation.ToUpper() == "S")
{
    subtract(number1, number2);
}
else if (operation.ToUpper() == "D")
{
    divide(number1, number2);
}
else if (operation.ToUpper() == "M")
{
    multiply(number1, number2);
}
else
{
    Console.WriteLine("Invalid choice!");
}

Console.WriteLine("Press any key to close.");
Console.ReadKey();
