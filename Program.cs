// Jeylo Tangaro Baoit 

namespace Variable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare variables to hold user input
            string fn, mn, ln, age, add, status, zodiac;

            // Prompt the user to enter their first name
            Console.WriteLine("Enter Your First Name:");
            fn = Console.ReadLine(); // Read and store the first name

            // Prompt the user to enter their middle name
            Console.WriteLine("Enter Your Middle Name:");
            mn = Console.ReadLine(); // Read and store the middle name

            // Prompt the user to enter their last name
            Console.WriteLine("Enter Your Last Name:");
            ln = Console.ReadLine(); // Read and store the last name

            // Prompt the user to enter their age
            Console.WriteLine("Enter Your Age:");
            age = Console.ReadLine(); // Read and store the age

            // Prompt the user to enter their address
            Console.WriteLine("Enter Your Address:");
            add = Console.ReadLine(); // Read and store the address

            // Prompt the user to enter their status
            Console.WriteLine("Enter Your Status:");
            status = Console.ReadLine(); // Read and store the status

            // Prompt the user to enter their zodiac sign
            Console.WriteLine("Enter Your Zodiac Sign:");
            zodiac = Console.ReadLine(); // Read and store the zodiac sign

            // Output the collected information using string interpolation
            Console.WriteLine($"I am {fn} {mn} {ln}. I am {age} years old, I live in {add}. My status is {status} and my zodiac sign is {zodiac}.");

            // Wait for the user to press Enter before closing the program
            Console.ReadLine();
        }
    }
}
