var importantDay = new DateTime(2025, 2, 14);
Console.WriteLine("Year is: " + importantDay.Year);
Console.WriteLine("Month is: " + importantDay.Month);
Console.WriteLine("Day is: " + importantDay.Day);
Console.WriteLine("Day of the week: " + importantDay.DayOfWeek);

var importantDay2 = importantDay.AddYears(1);

Console.WriteLine();
Console.WriteLine("Year is: " + importantDay2.Year);
Console.WriteLine("Month is: " + importantDay2.Month);
Console.WriteLine("Day is: " + importantDay2.Day);
Console.WriteLine("Day of the week: " + importantDay2.DayOfWeek);

var myRectangle = new Rectangle(10, 20);
Console.WriteLine("Width is: " + myRectangle.Width);
Console.WriteLine("Height is: " + myRectangle.Height);

Console.WriteLine("Area is: " + myRectangle.CalculateCircumfence());

Console.WriteLine();
var myExample = new ProportiesExample();
Console.WriteLine("My Example: " + myExample.Age);  //Property is used like a field. And it is get method that is called
myExample.Age = 10;     //Property is used like a field. And it is set method that is called

Console.WriteLine(myExample.Description);  //This is a read-only property

//Object initializer
var myRectangle2 = new Rectangle(10, 20)    //value will be 30 and 40. Because first constructor is called and then object initializer is called
{
    Width = 30,
    Height = 40
};

Console.ReadKey();

public class Rectangle
{
    //public fields needs to start with a capital letter
    //By default, fields are private
    //If it is private, it should start with an underscore
    //Private fields means that they can only be accessed within the class
    public int Width;
    public int Height;

    //Constructor name should be the same as the class name
    //Constructor is a method that is called when an object is created
    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public int CalculateCircumfence()
    {
        return 2* (Width + Height);
    }

    //Expression-bodied method
    int CalculateArea() => Width * Height;
}

class ProportiesExample
{
    //If i use a property with set, dont forget to make the field private also
    private int _age;
    public int Age
    {
        get
        {
            return _age;
        }
        set
        {
            if (value > 0)
            {
                _age = value;
            }
            
        }
    }

    public string Description => "This is a read-only property";
}
class MedicalAppointment
{
    private string _patientName;
    private DateTime _date;

    public MedicalAppointment(string patientName,DateTime date)
    {
        _patientName = patientName;
        _date = date;
    }

    public MedicalAppointment(string patientName) : this(patientName, 7)
    {
        
    }

    public MedicalAppointment(string patientName, int daysFromNow)
    {
        _patientName = patientName;
        _date = DateTime.Now.AddDays(daysFromNow);
    }

    public void Reschedule(DateTime newDate)
    {
        _date = newDate;
    }

    //Method overloading: having multiple methods with the same name but different parameters
    public void Reschedule(int month, int day)
    {
        _date = new DateTime(_date.Year, month, day);
    }

    //It is error because the method parameters are the same as the previous one
    //public void Reschedule(int monthsToAdd, int daysToAdd)
    //{
    //    _date = new DateTime(_date.Year, _date.Month + monthsToAdd, _date.Day + daysToAdd);
    //}
}