Console.Write("Choose a operation (addition, subtraction, multiplication, division): ");
String input = Console.ReadLine();

Console.Write("Enter the first number: ");
String num1String = Console.ReadLine();

Console.Write("Enter the second number: ");
String num2String = Console.ReadLine();

int num1, num2;
int.TryParse(num1String, out num1);
int.TryParse(num2String, out num2);

switch (input)
{
    case "addition":
        Console.WriteLine("The sum of the numbers you entered: " + (num1 + num2));
        break;

    case "subtraction":
        Console.WriteLine("The difference between the numbers you entered: " + (num1 - num2));
        break;

    case "multiplication":
        Console.WriteLine("The product of the two numbers you entered: " + (num1 * num2));
        break;

    case "division":
        Console.WriteLine("The quotient of the two numbers you entered: " + (num1 / num2));
        break;

    default:
        Console.WriteLine("You entered a incorrect value!");
        break;
}