﻿string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
string[] myLikes = myStrings[0].Split(".");

foreach (var like in myLikes)
{
    Console.WriteLine(like.TrimStart());
}
Console.WriteLine(myStrings[1]);