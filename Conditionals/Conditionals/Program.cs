// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string statement = Console.ReadLine();

switch (statement)
{
    case "hello":
    case "hi":
        Console.WriteLine("you greeted me");
        break;
    case "fku":
        Console.WriteLine("rude");
        break;
    case "":
        Console.WriteLine("nothing?");
        break;
    default: 
        Console.WriteLine("whatever");
        break; //needed also for default
}

statement = null;

switch (statement?.Trim())
{
    case string trimmedStatement when trimmedStatement.EndsWith("!") && trimmedStatement == trimmedStatement.ToUpper():
        Console.WriteLine("dont yell!");
        break;
    case string trimmedStatement when trimmedStatement == String.Empty:
        Console.WriteLine("nothing to say?");
        break;
    case string trimmedStatement when trimmedStatement != String.Empty:
        Console.WriteLine("ok we'll see");
        break;
}


