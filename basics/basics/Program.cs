// See //In C# when variable type declared, its cant change. Only value can be change
//String need to be declared with double quote (")
string userInput = "A";
Console.WriteLine(userInput);

userInput = "ABC";
Console.WriteLine(userInput);

//We can first declare variable and then initilazie it
//And you can print variable only after you initialize it
int number;
number = 58;

//You can declare and initialize more than one variable in single line
string myName, surname;
double a = 10, b = 20;

Console.WriteLine("Number a: " + a + " ,Number b: " + b);
Console.WriteLine("Addition: " + (a + b));
Console.WriteLine("Substriction: " + (a - b));
Console.WriteLine("Multiplicaiton: " + (a * b));
Console.WriteLine("Divison: " + (a / b));
//CTRL + R R => rename variable

//Implicity typed variables (var). Also cant change type after initiliaze
//Also you need to initiliaze immediatley after declaring
var impVariable = 10;
//impVariable = "ABC"   ERROR

//Boolean type
bool isTrue = true;
var isFalse = false;

Console.WriteLine("Enter a name: ");
userInput = Console.ReadLine();
var isUserInputABC = userInput == "ABC";
var isUserInputNotABC = userInput != "ABC";
var isUserInputNotABC2 = !(userInput == "ABC");

//Short-circuiting: If first condition is false, it will not check second condition
var isSmallerThan10 = 5 < 10 && 5 < 20; //dont look for second condition

//If-else and length of string
if (userInput.Length < 10)
{
    Console.WriteLine("User input character number is smaller than 10");
}
else if (userInput.Length == 10)
{
    Console.WriteLine("User input character number is equal to 10");
}
else
{
    Console.WriteLine("User input character number is greater than 10");
}

//Functions
//Arguments are passed by value to the function parameters
void addTwoNumbers(int a, int b)
{
    Console.WriteLine("Addition: " + (a + b));
}

int addTwoNumbersAndReturn(int a, int b)
{
    return a + b;
}
//Methods can be used before or after they are defined
addTwoNumbers(5, 10);
int result = addTwoNumbersAndReturn(5, 10);
Console.WriteLine("5 + 10 = " + result);

//Convert string to int
Console.WriteLine("Enter a number: ");
string userInput2 = Console.ReadLine();
int number2 = int.Parse(userInput2);    //Converting string to int
Console.WriteLine(number2);

//Exceptions are C# way of representing runtime errors.
//Example of it exceptions are thrown when you try to convert a string that is not a number

//Solution is simply a collection of projects

//String interpolation
Console.WriteLine($"User input is: {userInput} and number is: {number2}");

//Switch case
Console.WriteLine("Enter a number between 1-7: ");
string userInput3 = Console.ReadLine();
int number3 = int.Parse(userInput3);

//Fall -through is not allowed in C# switch-case
//But if you write nothing in case, it will fall through to next case
switch (number3)
{
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
        Console.WriteLine("Hafta içi");
        break;
    case 6:
    case 7:
        Console.WriteLine("Hafta sonu");
        break;
    default:
        Console.WriteLine("Hatalı giriş");
        break;
}


//En sona işlemleri bitirip uygulamayı kapatmak için ReadKey koyuyorum
Console.WriteLine("Press any key to exit...");
Console.ReadKey();