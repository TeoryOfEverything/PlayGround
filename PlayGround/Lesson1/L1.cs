using System;
using System.Collections.Generic;
using System.Text;

namespace PlayGround.Lesson1
{
    internal class L1
    {
        public void GetGreetings()
        {
            string originalName = "влад";

            Console.WriteLine("Введите Ваше имя: ");
            string? name = Console.ReadLine();

            if (name?.ToLower() == originalName)
            {
                Console.WriteLine($"Добро пожаловать, {name}!");
            }
            else
            {
                Console.WriteLine($"Привет, {name}");
            }
        }

        public void FindHeaviestWeight()
        {
            int maxWeight = int.MinValue;
            int index = -1;

            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Введите вес гири {i}: ");
                int weight = int.Parse(Console.ReadLine());

                if (weight > maxWeight)
                {
                    maxWeight = weight;
                    index = i;
                }
            }

            Console.WriteLine($"Самая тяжелая гиря: {maxWeight}, номер: {index}");
        }

        public void CalculateAge()
        {
            Console.Write("Введите ваш год рождения: ");
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int result))
            {
                int currentYear = DateTime.Now.Year;

                if (result > 1900 && result <= currentYear)
                {
                    int ageNow = currentYear - result;

                    Console.WriteLine($"Ваш возраст на {currentYear} год: {ageNow}");
                }
            }
            else
            {
                Console.WriteLine("Ругаемся!");
            }

        }
    }
}

