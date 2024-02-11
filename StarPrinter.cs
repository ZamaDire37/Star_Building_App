using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star_Building_App
{
    internal class StarPrinter
    {
        private int numRows;

        public StarPrinter(int numRows)
        {
            this.numRows = numRows;
        }

        public void PrintStars()
        {
            for (int i = 1; i <= numRows; i++)
            {
                string spaces = new string(' ', numRows - i);
                string stars = new string('*', 2 * i - 1);
                Console.WriteLine(spaces + stars);
            }
        }
    }
}