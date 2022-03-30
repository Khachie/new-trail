using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int sum = SayHi(4, 6);
             Console.WriteLine("the sum is " + sum);
             int name;
             int x = 5;
             string username = "khachi";
             bool statement = true;
             bool outcome;
             bool outcome2;
             outcome = int.TryParse(x.ToString(), out name);
             outcome2 = int.TryParse(username, out name);
             Console.WriteLine(outcome);
             Console.WriteLine(outcome2);

             string outcome3;
             outcome3 = verify(username, out statement); 
             Console.WriteLine(outcome3); */

            /* int[] p = { 8, 9, 10 };
             int[] numbers = p;
             Console.WriteLine(numbers);
             numbers[1] = 50;
             int value = numbers[0];
             Console.WriteLine(numbers.Length);
             Console.WriteLine(value);

             int[] num = new int[] {2,8,9,10};
             num[0] = 9;
             num[1] = 10;
             num[2] = 20;
             Console.WriteLine(num);

             string[] names = new string[] { "ouma", "mimia" };
             Array.Sort(names);
             Console.WriteLine(names);
             Console.WriteLine(names.Length);  */

            /* int value = 3;
             while (value > 0)
             {
                 value -= 2;
                 Console.WriteLine(value);
             }
             int number = 5;
             do
             {
                 Console.WriteLine("hello");
             }
             while (number == 5); */
            string[] names = new string[] { "khachi", "mimi", "ouma" };

            for (int i = 2; i < 5; i--)
            {
                Console.WriteLine( i + names[i]);   
            }
            

        }

        static int SayHi(int x = 5, int y = 7)
        {
            Console.WriteLine("hellom user" + x + y);
            int sum = x + y;
            return sum;

        }

        static string verify(string ouma, out bool mathebula)
        {
            Console.WriteLine("myn name is " + ouma);
            mathebula = false;
            return ouma;

        }

       
    }
}
