using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction
{
    class Program
    {

        static void Main(string[] args)
        {
            int day = 234, ten = 10, one = 1,meter=100,week=7,thousand=1000,hundred=100,ThreeNumber=465;
            double pi = 3.14;
            Console.WriteLine("Введите x");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(7 * x * x - 3 * x + 4);

            Console.WriteLine("Введите радиус");
            int radius = int.Parse(Console.ReadLine());
            Console.WriteLine(pi * radius * radius);

            Console.WriteLine("Введите расстрояние в сантиметрах");
            int cm = int.Parse(Console.ReadLine());
            Console.WriteLine(cm / meter);

            Console.WriteLine("Всего недель: "+day / week);

            Console.WriteLine("Введите число двузначное");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Десятков: " + number / ten);
            Console.WriteLine("Единиц: " + number / one);
            Console.WriteLine("сумма : " + (number / ten + number % ten));
            Console.WriteLine("произведение : " + ((number / ten) * (number % ten)));

            Console.WriteLine("Введите число четырехзначное");
            int bignumber = int.Parse(Console.ReadLine());


            Console.WriteLine("сумма : " + ((bignumber / thousand) + ((bignumber % thousand)/hundred) + (((bignumber % thousand) % hundred) / ten)+ (((bignumber % thousand) % hundred) % ten)));
            Console.WriteLine("произведение : " + ((bignumber / thousand) * ((bignumber % thousand) / hundred) * (((bignumber % thousand) % hundred) / ten) * (((bignumber % thousand) % hundred) % ten)));


            Console.WriteLine("x равен: " + ((ThreeNumber % hundred) / ten));


















            Console.ReadLine();

        }
    }
}
