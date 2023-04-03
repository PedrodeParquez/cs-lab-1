using System;
using System.IO;
using System.Net.Http.Headers;

namespace FirstLab
{
    class Program1 
    {
        static void Task1()  //Первая программа
        {
            int NumberA, Degree = 0, ResultNumber = 0;

            Console.Write("Введите число для возведения в степень: ");
            NumberA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите значение степени: ");
            Degree = Convert.ToInt32(Console.ReadLine());

            ResultNumber = NumberA;

            for (int DegreeIndex = 0; DegreeIndex < Degree - 1; ++DegreeIndex)
            {
                ResultNumber = ResultNumber * NumberA;
            }

            Console.WriteLine("Число в указанной степени: " + ResultNumber);
            Console.ReadKey();
        } 

        static void Task2() //Вторая программа
        {
            string Number = "", NewNumber = "";

            Console.Write("Введите число: ");
            Number = Console.ReadLine();

            if (Number.Length <= 2)
            {
                Console.WriteLine("Данное число не подходит! Повторите попытку.");
                Task2();
            }

            for (int NumberIndex = 0; NumberIndex < Number.Length; NumberIndex++)
            {
                if (NumberIndex != 1)
                {
                    NewNumber += Number[NumberIndex];
                }
            }

            NewNumber += Number[1];

            Console.WriteLine(NewNumber);
            Console.ReadKey();
        }

        static void Main()
        {
            Console.Write("Введите номер задачи: ");
            int UserChoice = Convert.ToInt32(Console.ReadLine());

            if (UserChoice == 1)
            {
                Task1();
            }
            else if (UserChoice == 2)
            {
                Task2();
            }
            else if ((UserChoice != 1) || (UserChoice != 2))
            {
                Console.WriteLine("Введён неверный аргумент! Повторите попытку.");
                Main();
                Console.ReadKey();
            }
        }
    }
}    
