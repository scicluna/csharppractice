Console.WriteLine("Please input an integer between 5 and 10.");
bool valid = true;
var input = "";

while (valid)
{
    input = Console.ReadLine();
    if (Int32.Parse(input) < 5 || Int32.Parse(input) > 10)
    {
        Console.WriteLine("Not a valid integer. Please input an integer between 5 and 10.");
        continue;
    }
    valid = false;
}
Console.WriteLine($"Input has been accepted. You chose {input}.");