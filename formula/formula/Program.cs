using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("На сколько процентов первое число больше второго\n---------------------------------------------");
            Console.WriteLine("Введите первое число");
           double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double num2 = Convert.ToDouble(Console.ReadLine());

             Console.WriteLine("на " + Math.Round((num1/num2*100-100),1) + "%% ");

           // double result = (num1 / num2 * 100 - 100);
           // Console.WriteLine(Math.Round(result,1));


            Console.ReadLine();


        }
    }
}
