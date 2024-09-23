namespace Variable
{
    internal class Declaring_Variable
    {
        static void Main(string[] args)
        {
            // Loop variable
            bool continueLoop = true;

            // Start the loop
            while (continueLoop)
            {
                // Add color to the text
                Console.ForegroundColor = ConsoleColor.Green;

                // Declare variables to hold user input
                string fn, mn, ln, age, add, status, zodiac;

                // Prompt the user to enter their first name
                Console.Write("Enter Your First Name: ");
                fn = Console.ReadLine(); // Read and store the first name

                // Clear the console for better look
                Console.Clear();

                // Prompt the user to enter their middle name
                Console.Write("Enter Your Middle Name: ");
                mn = Console.ReadLine(); // Read and store the middle name

                // Clear the console for better look
                Console.Clear();

                // Prompt the user to enter their last name
                Console.Write("Enter Your Last Name: ");
                ln = Console.ReadLine(); // Read and store the last name

                // Clear the console for better look
                Console.Clear();

                // Prompt the user to enter their age
                Console.WriteLine("Enter Your Age: ");
                age = Console.ReadLine(); // Read and store the age

                // Clear the console for better look
                Console.Clear();

                // Prompt the user to enter their address
                Console.Write("Enter Your Address: ");
                add = Console.ReadLine(); // Read and store the address

                // Clear the console for better look
                Console.Clear();

                // Prompt the user to enter their status
                Console.Write("Enter Your Status: ");
                status = Console.ReadLine(); // Read and store the status

                // Clear the console for better look
                Console.Clear();

                // Prompt the user to enter their zodiac sign
                Console.Write("Enter Your Zodiac Sign: ");
                zodiac = Console.ReadLine(); // Read and store the zodiac sign

                // Clear the console for better look
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Red;

                // Output the collected information using string interpolation
                Console.WriteLine($"I am {fn} {mn} {ln}. I am {age} years old, I live in {add}. My status is {status} and my zodiac sign is {zodiac}.");

                // Ask if the user wants to repeat
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nDo you want to enter information again? (y/n): ");
                string response = Console.ReadLine();

                // If the user enters anything other than 'y', break the loop
                if (response.ToLower() != "y")
                {
                    continueLoop = false;
                }

                // Clear the console for the next iteration
                Console.Clear();
            }

            // End message
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Goodbye!");
            Console.ReadLine(); // Wait for the user to press Enter before closing the program
        }
    }
}
