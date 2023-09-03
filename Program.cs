// See https://aka.ms/new-console-template for more information

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(@"Which calculation do you want to
1. Validate the number is between 0 and 10
2. Find the maximum integer between two numbers
3. Calculate if dimensions make a portrait or landscape ratio
4. Determine if the speed is legal
5. Calculate how many numbers are divisible by 3 between 1 and 100
6. Calculate the sum of input numbers
7. Calculate the factorial of a number
8. Number guessing game
9. Find the maximum of a series of numbers
");
        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine();
        if (choice == "1")
        {
            Console.WriteLine("You chose 1");
            Console.Write("Enter a number between 0 and 10: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number >= 1 && number <= 10)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");
        }
        else if (choice == "2")
        {
            Console.WriteLine("You chose 2");
            Console.Write("Enter the first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            if (firstNumber > secondNumber)
                Console.WriteLine(firstNumber);
            else
                Console.WriteLine(secondNumber);
        }
        else if (choice == "3")
        {
            Console.WriteLine("You chose 3");
            Console.Write("Enter the width: ");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the height: ");
            int height = Convert.ToInt32(Console.ReadLine());
            if (width > height)
                Console.WriteLine("Landscape");
            else
                Console.WriteLine("Portrait");
        }
        else if (choice == "4")
        {
            Console.WriteLine("You chose 4");
            Console.Write("Enter the speed limit: ");
            int speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the speed of the car: ");
            int carSpeed = Convert.ToInt32(Console.ReadLine());
            if (carSpeed <= speedLimit)
                Console.WriteLine("OK");
            else
            {
                int demeritPoints = (carSpeed - speedLimit) / 5;
                if (demeritPoints > 12)
                    Console.WriteLine("License Suspended");
                else
                    Console.WriteLine("Demerit Points: " + demeritPoints);
            }
        }
        else if (choice == "5")
        {
            Console.WriteLine("You chose 5");
            int count = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                    count++;
            }
            Console.WriteLine("There are " + count + " numbers divisible by 3 between 1 and 100");
        }
        else if (choice == "6")
        {
            Console.WriteLine("You chose 6");
            int sum = 0;
            while (true)
            {
                Console.Write("Enter a number or OK to exit: ");
                string input = Console.ReadLine();
                if (input == "OK")
                    break;
                sum += Convert.ToInt32(input);
            }
            Console.WriteLine("The sum is " + sum);
        }
        else if (choice == "7")
        {
            Console.WriteLine("You chose 7");
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            Console.WriteLine("The factorial of " + number + " is " + factorial);
        }
        else if (choice == "8")
        {
            Console.WriteLine("You chose 8");
            Random random = new Random();
            int number = random.Next(1, 10);
            int guessCount = 0;
            while (true)
            {
                Console.Write("Guess the number: ");
                int guess = Convert.ToInt32(Console.ReadLine());
                guessCount++;
                if (guess == number)
                {
                    Console.WriteLine("You won!");
                    break;
                }
                else if (guessCount == 4)
                {
                    Console.WriteLine("You lost!");
                    break;
                }
            }
        }
        else if (choice == "9")
        {
            Console.WriteLine("You chose 9");
            Console.Write("Enter a series of numbers separated by commas: ");
            string input = Console.ReadLine();
            string[] numbers = input.Split(',');
            int max = Convert.ToInt32(numbers[0]);
            foreach (string number in numbers)
            {
                if (Convert.ToInt32(number) > max)
                    max = Convert.ToInt32(number);
            }
            Console.WriteLine("The maximum number is " + max);
        }
    }
}
