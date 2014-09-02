using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorKata
{
    public class Program
    {
        String[] elements;

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
                int result = 0;
                elements = numbers.Split(new Char[] {','});
                foreach(var elem in elements)
                {
                    result += int.Parse(elem);
                }
                return result;
            }
        }
    }
}
