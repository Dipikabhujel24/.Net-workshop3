using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class ExceptionHandling
    {
         public void ShowExceptions()
        {
            // Try-Catch-Finally
            try
            {
                Console.Write("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("You entered: " + num);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number format.");
            }
            finally
            {
                Console.WriteLine("Program Executed.");
            }

            // Throw example
            Console.Write("\nEnter a password: ");
            string password = Console.ReadLine();

            try
            {
                if (password.Length < 6)
                {
                    throw new Exception("Password must be at least 6 characters.");
                }
                Console.WriteLine("Password accepted.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
