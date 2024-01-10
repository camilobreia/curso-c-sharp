// => to know the number of string letters

/* string firstFriend = "Scott";
string secondFriend = "Kendra";

Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters");
Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters"); */

// => strings with spaces

/* string greeting = "        Hello World!        ";
Console.WriteLine($"[{greeting}]");

string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]"); */

// => to replace strings / upper and lower case

string sayHello = "Hello World!";
Console.WriteLine(sayHello);
sayHello = sayHello.Replace("Hello", "Greetings");
Console.WriteLine(sayHello);

Console.WriteLine(sayHello.ToUpper());
Console.WriteLine(sayHello.ToLower());