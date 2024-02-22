using CalculatorApp;

Console.Write("Please enter your name: ");
string userName = Console.ReadLine();
Console.WriteLine($"Hello, {userName}!");

Console.Write("Enter the first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Choose an operation:");
Console.WriteLine("1. Add");
Console.WriteLine("2. Subtract");
Console.WriteLine("3. Multiply");
Console.WriteLine("4. Divide"); 
Console.Write("Enter your choice (1, 2, 3, or 4): ");
int operation = Convert.ToInt32(Console.ReadLine());

switch (operation)
{
    case 1:
        int sum = MathUtilities.AddNumbers(number1, number2);
        Console.WriteLine($"The sum of {number1} and {number2} is {sum}.");
        break;
    case 2:
        int difference = MathUtilities.SubtractNumbers(number1, number2);
        Console.WriteLine($"The difference of {number1} and {number2} is {difference}.");
        break;
    case 3:
        int product = MathUtilities.MultiplyNumbers(number1, number2);
        Console.WriteLine($"The product of {number1} and {number2} is {product}.");
        break;
    case 4:
        if (number2 != 0) {
            double quotient = MathUtilities.DivideNumbers(number1, number2);
            Console.WriteLine($"The quotient of {number1} divided by {number2} is {quotient}.");
        } else {
            Console.WriteLine("Cannot divide by zero.");
        }
        break;
    default:
        Console.WriteLine("Invalid choice.");
        break;
}
