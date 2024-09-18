using System;

namespace ShippingQuoteApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Greet the user.
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Step 2: Prompt the user to enter the weight of the package.
            Console.Write("Please enter the package weight (in lbs): ");
            float weight = float.Parse(Console.ReadLine());

            // Step 3: Check if the weight is greater than 50 lbs.
            if (weight > 50)
            {
                // If weight exceeds 50 lbs, display error message and exit.
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // End the program here.
            }

            // Step 4: Prompt the user for package dimensions (width, height, length).
            Console.Write("Please enter the package width (in inches): ");
            float width = float.Parse(Console.ReadLine());

            Console.Write("Please enter the package height (in inches): ");
            float height = float.Parse(Console.ReadLine());

            Console.Write("Please enter the package length (in inches): ");
            float length = float.Parse(Console.ReadLine());

            // Step 5: Check if the sum of dimensions exceeds 50 inches.
            if (width + height + length > 50)
            {
                // If dimensions are too large, display error message and exit.
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // End the program here.
            }

            // Step 6: Calculate the shipping quote.
            // Multiply the three dimensions (width, height, length).
            float volume = width * height * length;

            // Multiply the volume by the weight and divide by 100 to get the shipping quote.
            float quote = (volume * weight) / 100;

            // Step 7: Display the calculated quote as a dollar amount.
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");

            // Step 8: Thank the user.
            Console.WriteLine("Thank you!");
        }
    }
}
