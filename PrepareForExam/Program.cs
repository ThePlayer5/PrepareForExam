using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepareForExam
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            //Console.WriteLine("Enter 2 numbers: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //if (num1 > num2)
            //    Console.WriteLine($"Bigger is {num1}");
            //else if (num1 < num2)
            //    Console.WriteLine($"Bigger is {num2}");
            //else Console.WriteLine("Equls");

            // Task 2
            //Console.WriteLine("Enter number: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //if (num % 2 == 0)
            //    Console.WriteLine("Chetnoe");
            //else Console.WriteLine("Ne chetnoe");

            // Task 3
            //Console.WriteLine("Enter 2 numbers: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter operation: ");
            //char operation = Convert.ToChar(Console.ReadLine());
            //if (operation == '+')
            //    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            //else if (operation == '-')
            //    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            //else if (operation == '*')
            //    Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            //else if (operation == '/')
            //    Console.WriteLine($"{num1} / {num2} = {num1 / num2}");

            // Task 4
            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        Console.WriteLine();
            //        Console.Write($"{i} * {j} = {i*j}");
            //    }
            //    Console.WriteLine();
            //}

            // Task 5
            //Console.WriteLine("Enter number: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int answer = 1;
            //for (int i = num; i >= 1; i--)
            //{
            //    answer *= i;
            //}
            //Console.WriteLine(answer);

            // Task 6
            //Console.WriteLine("Enter number: ");
            //int N = Convert.ToInt32(Console.ReadLine());
            //int fobonachchi = 0;
            //int[] mass = new int[N];
            //mass[0] = 1;
            //mass[1] = 1;
            //for(int i = 2; i < N; i++)
            //{
            //    mass[i] = mass[i - 2] + mass[i - 1];
            //}
            //foreach (int i in mass)
            //{
            //    Console.Write(i + " ");
            //}

            // Task 7
            //Console.WriteLine("Enter number: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int c = 0;
            //int k = num;
            //int result = 0;
            //while (k != 0)
            //{
            //    c = k % 10;
            //    result = result + c;
            //    k /= 10;
            //}
            //Console.WriteLine(result);

            // Task 8
            Console.WriteLine("Enter string: ");
            string str = Console.ReadLine(); // aboba
            string str2 = str;
            string str3 = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                if (i == str.Length - i - 1)
                {

                }
            }
        }
    }
}
