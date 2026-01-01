string aFriend = "Bill";
Console.WriteLine(aFriend);
aFriend = "Maira";
//Console.WriteLine(aFriend);
Console.WriteLine("Hello " + aFriend);
Console.WriteLine($"Hello {aFriend}"); //string interpolation


string firstFriend = "Maria";
string secondFriend = "Sage";
Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

// Trim()

string ff = "    Nayeem";
string sf = "Noman      ";
Console.WriteLine($"My friends are {ff} and {sf}.");
Console.WriteLine($"My friends are {ff.Trim()} and {sf.Trim()}.");

// Search and Replace

string sayHello = "Hello World!";
Console.WriteLine(sayHello);
sayHello = sayHello.Replace("Hello", "Greetings");
Console.WriteLine(sayHello);

Console.WriteLine(sayHello.ToUpper());
Console.WriteLine(sayHello.ToLower());

string songLyrics = "You say goodbye, and I say hello";
Console.WriteLine(songLyrics.Contains("goodbye"));
Console.WriteLine(songLyrics.Contains("greetings"));
