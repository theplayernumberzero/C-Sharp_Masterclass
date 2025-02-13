var todos = new List<string>();

Console.WriteLine("Hello");

bool shallExit = false;

while (!shallExit)
{
    Console.WriteLine();
    Console.WriteLine("What dou you want to do?:");
    Console.WriteLine("[S]ee all TODOs");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");

    var userChoice = Console.ReadLine();
    switch (userChoice)
    {
        case "s":
        case "S":
            SeeAllTodos();
            break;
        case "a":
        case "A":
            AddTodo();
            break;
        case "r":
        case "R":
            RemoveTodo();
            break;
        case "e":
        case "E":
            Console.WriteLine("Exit");
            shallExit = true;
            break;
        default:
            Console.WriteLine("Invalid option");
            break;
    }
}

void RemoveTodo()
{
    if(todos.Count == 0)
    {
        Console.WriteLine("There are no TODOs to remove");
        return;
    }
    bool isIndexValid = false;
    while (!isIndexValid)
    {
        Console.WriteLine();
        Console.WriteLine("Select the index of TODO you want to remove:");
        SeeAllTodos();
        Console.WriteLine();
        var userInput = Console.ReadLine();
        if (userInput == "")
        {
            Console.WriteLine("Selected index can not be empty");
            continue;   // skip the rest of the code and start the loop again
        }
        if (int.TryParse(userInput, out int index) && index >= 1 && index <= todos.Count)
        {
            var indexOfTodo = index - 1;
            var todoToBeRemoved = todos[indexOfTodo];
            todos.RemoveAt(indexOfTodo);
            isIndexValid = true;
            Console.WriteLine("TODO removed: " + todoToBeRemoved);
        }
        else
        {
            Console.WriteLine("Invalid index");
        }
    }
    
}

void SeeAllTodos()
{
    if (todos.Count == 0)
    {
        Console.WriteLine("There are no TODOs");
        return;
    }
    else
    {
        for (int i = 0; i < todos.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {todos[i]}");
        }
    }
}

void AddTodo()
{
    bool isDescriptionValid = false;

    while (!isDescriptionValid)
    {
        Console.WriteLine("Enter the TODO description:");
        var description = Console.ReadLine();

        if (description == "")
        {
            Console.WriteLine("The description cant be empty");
            return;
        }
        else if (todos.Contains(description))
        {
            Console.WriteLine("The description already exists");
            return;
        }
        else
        {
            todos.Add(description);
            isDescriptionValid = true;
        }
    }
    
}