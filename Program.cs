// See https://aka.ms/new-console-template for more information

WorkWithStrings();
WorkWithIntegers();
OrderPrecedence();
PrecisionAndLimits();

void WorkWithStrings()
{
  Console.WriteLine("\n=== Strings ===");
  Console.WriteLine("Hello, World!");

  string aFriend = "Frank";
  Console.WriteLine($"Hello {aFriend}");

  aFriend = "Jessica";
  Console.WriteLine($"Hello {aFriend}");

  aFriend = "Francis";
  string bFriend = "Marlene";
  Console.WriteLine($"My friends are {aFriend} and {bFriend}.");
  Console.WriteLine($"The name {aFriend} has {aFriend.Length} letters.");
  Console.WriteLine($"The name {bFriend} has {bFriend.Length} letters.");

  string greeting = "          Hello World!          ";
  Console.WriteLine($"[{greeting}]");

  string trimmedGreeting = greeting.TrimStart();
  Console.WriteLine($"[{trimmedGreeting}]");

  trimmedGreeting = greeting.TrimEnd();
  Console.WriteLine($"[{trimmedGreeting}]");

  trimmedGreeting = greeting.Trim();
  Console.WriteLine($"[{trimmedGreeting}]");

  string sayHello = "Hello World!";
  Console.WriteLine(sayHello);

  sayHello = sayHello.Replace("Hello", "Greetings");
  Console.WriteLine(sayHello);

  Console.WriteLine(sayHello.ToUpper());
  Console.WriteLine(sayHello.ToLower());

  string songLyrics = "You say goodbye, and I say hello";
  Console.WriteLine(songLyrics);
  Console.WriteLine($"'goodbye': {songLyrics.Contains("goodbye")}");
  Console.WriteLine($"'greetings': {songLyrics.Contains("greetings")}");

  Console.WriteLine($"StartsWith 'You': {songLyrics.StartsWith("You")}");
  Console.WriteLine($"StartsWith 'goodbye': {songLyrics.StartsWith("goodbye")}");

  Console.WriteLine($"EndsWith 'hello': {songLyrics.EndsWith("hello")}");
  Console.WriteLine($"EndsWith 'goodbye': {songLyrics.EndsWith("goodbye")}");
}

void WorkWithIntegers()
{
  Console.WriteLine("\n=== Numbers ===");

  int a = 18;
  int b = 6;
  int c = a + b;
  // addition
  Console.WriteLine($"{a} + {b} = {c}");

  // subtraction
  c = a - b;
  Console.WriteLine($"{a} - {b} = {c}");

  // multiplication
  c = a * b;
  Console.WriteLine($"{a} * {b} = {c}");

  // division
  c = a / b;
  Console.WriteLine($"{a} / {b} = {c}");
}

void OrderPrecedence()
{
  Console.WriteLine("\n=== Order Precedence ===");
  // precedence
  int a = 5;
  int b = 4;
  int c = 2;
  int d = a + b * c;
  Console.WriteLine($"{a} + {b} * {c} = {d}");

  d = (a + b) * c;
  Console.WriteLine($"({a} + {b}) * {c} = {d}");

  d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
  Console.WriteLine($"({a} + {b}) - 6 * {c} + (12 * 4) / 3 + 12 = {d}");

  // integer division
  int e = 7;
  int f = 4;
  int g = 3;
  int h = (e + f) / g;
  Console.WriteLine($"({e} + {f}) / {g} = {h}");
}

void PrecisionAndLimits()
{
  Console.WriteLine("\n=== Precision and Limits ===");
  int a = 7;
  int b = 4;
  int c = 3;
  int d = (a + b) / c;
  int e = (a + b) % c;
  Console.WriteLine($"quotient: ({a} + {b}) / {c} = {d}");
  Console.WriteLine($"remainder: ({a} + {b}) % {c} = {e}");

  int max = int.MaxValue;
  int min = int.MinValue;
  Console.WriteLine($"The range of integers is {min} to {max}");

  int what = max + 3;
  Console.WriteLine($"An example of overflow: {max} + 3 = {what}");
}
