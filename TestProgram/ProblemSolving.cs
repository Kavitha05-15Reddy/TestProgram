using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram
{
    internal class ProblemSolving
    {
        //Names:
        public void Names()
        {
            string[] friends = { "Sangeetha", "Charan", "Likhi", "Teja", "Indu" };
            for (int i = 0; i < friends.Length; i++)
            {
                Console.WriteLine(friends[i]);
            }
        }
        //Square:
        public void Square()
        {
            Console.WriteLine("Enter the first number:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            double b = Convert.ToDouble(Console.ReadLine());
            double s = Math.Pow(a, 2) + Math.Pow(b, 2);
            Console.WriteLine("square of sum of two numbers: " + s);
            double d = Math.Pow(a, 2) - Math.Pow(b, 2);
            Console.WriteLine("square of difference between two numbers: " + d);
        }
        //String:
        public void String()
        {
            Console.WriteLine("Enter the name:");
            string name = Console.ReadLine();
            Console.WriteLine("uppercase: " + name.ToUpper());
            Console.WriteLine("lowercae :" + name.ToLower());
        }
        //Number:
        public void Number()
        {
            Console.WriteLine("Enter the number: ");
            string number = Console.ReadLine();
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(number);
            }
        }

        //Num:
        public void Num()
        {
            for (int i = 2000; i <= 3200; i++)
            {
                if (i % 7 == 0 && i % 5 != 0)
                {
                    Console.Write(i + ",");
                }
            }
        }
        //Factorial:
        public void Fact(int x)
        {
            int f = 1;
            int i = 1;
            while (i <= x)
            {
                f *= i;
                i++;
            }
            Console.WriteLine(f);
        }
        //Prime numbers:
        public void PrimeNumbers()
        {
            for (int i = 2; i <= 100; i++)
            {
                int c = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        c++;
                    }
                }
                if (c == 2)
                {
                    Console.Write(i + ",");
                }
            }
        }
        //Average
        public void Average()
        {
            int[] Average = { 6, 13, 24, 36, 45 };
            int c = 0;
            int sum = 0;
            foreach (int i in Average)
            {
                Console.Write(i+",");
                sum += i; 
                c += 1;
            }
            Console.WriteLine("\n"+"Average: "+sum/c);   
        }
        //Circle:
        public void Circle()
        {
            Console.WriteLine("Enter the diameter: ");
            double diameter = Convert.ToDouble(Console.ReadLine());
            double radius = diameter / 2;
            double perimeter = 2 * Math.PI * radius;
            double area = Math.PI * radius * radius;
            Console.WriteLine("Area of circle" + area);
            Console.WriteLine("Perimeter of circle" + perimeter);
        }
        //Avrage1
        public void Average1()
        {
            double[] Average = { 2.5,5.6,9.9,34.5,65.5};
            double c = 0;
            double sum = 0;
            foreach (int i in Average)
            {
                sum += i;
                c += 1;
            }
            Console.WriteLine("\n" + "Average: " + sum / c);
        }
        //Sum:
        public void Sum()
        {
            int[] Sum = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            int sum = 0;
            foreach (int i in Sum)
            {
                sum += i;
            }
            Console.WriteLine("Sum of array elements:"+sum);
        }
        //Checks:
        public void Checks()
        {
            Console.WriteLine("Enter the value: ");
            char c =Convert.ToChar(Console.ReadLine());
            if (char.IsLetter(c))
            {
                Console.WriteLine(c +" is a chraacter");
            }
            else if (char.IsDigit(c))
            {
                Console.WriteLine(c + " is a digit");
            }
            else
            {
                Console.WriteLine(c + " is a symbol");
            }
        }
        
    }
}
