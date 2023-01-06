// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
void PrintMessage(string message, string s )
{
    if (message is null)
    {
        Console.WriteLine(s);
    }
    Console.WriteLine(message + "$");

}
