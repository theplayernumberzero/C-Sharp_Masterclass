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

//Strings are collection of characters(char)
char charExample = 'a';

//Check if all characters are digit in a string
Console.WriteLine("Enter a number a number for check all chars are digit: ");
var userInput4 = Console.ReadLine();

bool isParsableToInt = userInput4.All(char.IsDigit);    //All() method checks if all characters are digit

//The array is most basic collection type in C#, storing multiple elements of the same type
//Arrays are fixed size. Size cant be change

//for integer array default value is 0
int[] numbers = new int[10];    //new keyword create instance from Array class

var firstElement = numbers[0];
var lastElement = numbers[numbers.Length - 1];    //Length is a property of array

var firstElement2 = numbers[^1];    //^1 is the last element of array (sondan birinci)

int[] numbers2 = new int[3] { 1, 2, 3 };    //Array initialization
var numbers3 = new [] { 1, 2, 3 };    //Array initialization (needs to be same type)

//Disadvantage of array is fixed size. It means we cant add or remove element from array

//Two dimensional array
int[,] array2 = new int[2, 3];    //2 rows and 3 columns

array2[0, 0] = 1;
array2[0, 1] = 2;       // 1 2 3
array2[0, 2] = 3;       // 4 5 6
array2[1, 0] = 4;
array2[1, 1] = 5;
array2[1, 2] = 6;

var array3 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };

var height = array3.GetLength(0);    //GetLength method returns the size of the specified dimension
var width = array3.GetLength(1);
Console.WriteLine("Height is: " + height);
Console.WriteLine("Width is: " + width);

for(int i = 0; i < height; i++)
{
    for (int j = 0; j < width; j++)
    {
        Console.Write(array3[i, j] + " ");
    }
    Console.WriteLine();
}

//For each loops
var words = new string[] {"hello", "welcome", "good bye" };

foreach (string word in words)
{
    Console.WriteLine(word);
}

//List
//Size of a list can be change

List<int> listNumbers = new List<int>();    //<> are generic type
Console.WriteLine("Count of listNumbers elemnts is: " + listNumbers.Count); //listNumbers.Count is the number of elements in the list

listNumbers.Add(5); //Add() method adds element to the end of the list

var listWords = new List<string> {"one", "two", "three" }; //List initialization

listWords.Remove("three");    //Remove() method removes the first occurence of the specified value

listWords.RemoveAt(0);    //RemoveAt() method removes the element at the specified index

var moreWords = new List<string> { "four", "five" };

listWords.AddRange(moreWords);    //AddRange() method adds the elements of the specified collection to the end of the list
listWords.AddRange(new string[] { "six", "seven" }); //AddRange() method can also be used with array

Console.WriteLine("Index of element 'six' is: " + listWords.IndexOf("six"));    //IndexOf() method returns the index of the first occurence of the specified value. If element is not in the list, it returns -1

Console.WriteLine("Is collection contains 'one': " + listWords.Contains("one"));    //Contains() method returns true if the specified value is in the list
listWords.Clear();    //Clear() method removes all elements from the list   

foreach (string word in listWords)
{
    Console.WriteLine(word);
}

for (int i = 0; i < listNumbers.Count; i++)
{
    Console.WriteLine(listWords[i]);
}

int nonPositiveCount;   //It will be assigned in the function with "out" keyword
List<int> GetOnlyPositiveNumbers(int[] numbers, out int countOfPositiveNumber)
{
    countOfPositiveNumber = 0;
    List<int> positiveNumbers = new List<int>();
    foreach (int number in numbers)
    {
        if (number > 0)
        {
            positiveNumbers.Add(number);
        }
        else
        {
            countOfPositiveNumber++;
        }
    }
    return positiveNumbers;
}

var onlyPositiveNumbers = GetOnlyPositiveNumbers(new int[] { -5, 10, -3, 20, 0 }, out nonPositiveCount);
foreach (int number5 in onlyPositiveNumbers)
{
    Console.WriteLine(number5);
}

//"out" keyword: It is used to pass arguments to a method by reference, not by value
//out keyword is used when you want a method to return more than one value (bypass the limitation)
//out keyword is used when you want to return a value from a method without using a return statement

//tryParse() method is used to convert string to int without throwing exception
Console.WriteLine("Enter a number: ");
var userInput6 = Console.ReadLine();

bool isParsingSuccess = int.TryParse(userInput6, out int number6);    //TryParse() method returns true if the conversion is successful, otherwise false. If userinput6 is false, number6 will be 0 by default.

if (isParsingSuccess)
{
    Console.WriteLine("Number is: " + number6);
}
else
{
    Console.WriteLine("Please enter a valid number");
}

//En sona işlemleri bitirip uygulamayı kapatmak için ReadKey koyuyorum
Console.WriteLine("Press any key to exit...");
Console.ReadKey();