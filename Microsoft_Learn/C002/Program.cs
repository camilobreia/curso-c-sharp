// => Searching Strings:

string songLyrics = "You say goodbye, and I say hello";

Console.WriteLine(songLyrics.Contains("goodbye"));

Console.WriteLine(songLyrics.Contains("greetings"));

Console.WriteLine("-----------------------------------");

// => to know if the string starts or ends with word:

Console.WriteLine(songLyrics.StartsWith("You"));
Console.WriteLine(songLyrics.EndsWith("hello"));
Console.WriteLine(songLyrics.StartsWith("say"));
Console.WriteLine(songLyrics.EndsWith("I"));