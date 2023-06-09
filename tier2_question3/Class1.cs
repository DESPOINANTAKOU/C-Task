using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Task.tier2_question3
{
    public class Class1
    {
        static void Main(string[] args)
        {

            //creation of a random number's List 
            List<int> numbers = new List<int> { 2, 3, -9, 10, 15, -7, 6, 0 };

            //initialization of sum which adds the numbers that are divided by 3 and also turned into their absolute value through Math.Abs()
            int sum = 0;

            foreach (int num in numbers)
            {
                if (num % 3 == 0)
                {
                    sum += Math.Abs(num);
                }
            }

            Console.WriteLine("Sum of absolute values divisible by 3: " + sum);
        }
    }
}
