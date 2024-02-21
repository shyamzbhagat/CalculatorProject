static int AddNumbers(int num1, int num2)
{
    return num1 + num2;
}

static int SubtractNumbers(int num1, int num2)
{
    return num1 - num2;
}

static int MultiplyNumbers(int num1, int num2)
{
    return num1 * num2;
}

static double DivideNumbers(int num1, int num2)
{
    return (double)num1 / num2;
}

// Greet the user
Console.Write("Please enter your name: ");
string userName = Console.ReadLine();
Console.WriteLine($"Hello, {userName}!");

// Ask for numbers
Console.Write("Enter the first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

// Update the user prompt and switch statement to include multiplication
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
        int sum = AddNumbers(number1, number2);
        Console.WriteLine($"The sum of {number1} and {number2} is {sum}.");
        break;
    case 2:
        int difference = SubtractNumbers(number1, number2);
        Console.WriteLine($"The difference of {number1} and {number2} is {difference}.");
        break;
    case 3:
        int product = MultiplyNumbers(number1, number2);
        Console.WriteLine($"The product of {number1} and {number2} is {product}.");
        break;
    case 4:
        if (number2 != 0) {
            double quotient = DivideNumbers(number1, number2);
            Console.WriteLine($"The quotient of {number1} divided by {number2} is {quotient}.");
        } else {
            Console.WriteLine("Cannot divide by zero.");
        }
        break;
    default:
        Console.WriteLine("Invalid choice.");
        break;
}
