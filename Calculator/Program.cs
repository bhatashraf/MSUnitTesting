using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Program
    {
        static void  Main(string[] args)
        {
            //if(IsPositive(Int32.Parse(args[0])))
            //{
            //    return 0;
            //}
            //else
            //{
            //    return 1;
            //}
            int num1 = 20;
            int num2 = 4;
            int result = 0;
            result = Divide(num1,num2);
            Console.WriteLine("Division of " + num1 + " and " + num2 + " = " + result);
            Console.ReadLine();
        }
        public static int Divide(int temp1, int temp2)
        {
            
            if(IsPositive(temp1)&&IsPositive(temp2))
            {
                return temp1 / temp2;
            }
            else
            {
                throw new ArgumentException("only +ve no.s allowed..");
            }
        }
        public static bool IsPositive(int num)
        {
            return num > 0;
        }

      
    }
}
