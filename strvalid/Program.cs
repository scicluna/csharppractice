using System.Buffers;

Console.WriteLine("Enter your role name (Administrator, Manager, or User.)");
string? input;

while (true)
{
    input = Console.ReadLine();
    if (input != "Administrator" && input != "Manager" && input != "User")
    {
        Console.WriteLine($"{input} is not valid. Enter your role name (Administrator, Manager, or User.)");
    }
    else
    {
        break;
    }
}
Console.WriteLine($"Your input value {input} has been accepted");