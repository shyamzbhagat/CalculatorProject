Console.Write("Please enter your name: ");
string userName = Console.ReadLine();
Console.WriteLine($"Hello, {userName}!");

// Perform addition operation
Console.Write("Enter the first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int sum = AddNumbers(number1, number2);
Console.WriteLine($"The sum of {number1} and {number2} is {sum}.");