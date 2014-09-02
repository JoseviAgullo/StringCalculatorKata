using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorKata
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public int Add(string numbers)
        {
            if (numbers == "")
            {
                return 0;
            }
            else
            {
                return int.Parse(numbers);
            }
        }
    }
}
