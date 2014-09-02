using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorKata
{
    public class Program
    {
        String[] elements, previousString;

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
                if (numbers[0].Equals('/') && numbers[1].Equals('/'))
                {                    
                    previousString = numbers.Split(new Char[] { '\n' });
                    elements = previousString[1].Split(new Char[] { numbers[2] });
                    
                }
                else
                {
                    elements = numbers.Split(new Char[] { ',', '\n' });                    
                }
                
                foreach(var elem in elements)
                {
                    result += int.Parse(elem);
                }
                return result;
            }
        }
    }
}
