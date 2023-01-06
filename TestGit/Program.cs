// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
void PrintMessage(string message)
{
    if (message is null)
        Console.WriteLine("yourmessageisnull ");
    Console.WriteLine(message + "$");

}
