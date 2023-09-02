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
    }
}
