using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star_Building_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the number of rows for the star pattern: ");
                int rows = int.Parse(Console.ReadLine());

                if (rows <= 0)
                {
                    throw new ArgumentException("Number of rows must be a positive integer.");
                    
                }

                StarPrinter starPrinter = new StarPrinter(rows);
                starPrinter.PrintStars();
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter a valid integer.");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            Console.ReadLine();
        }
    }
}
