using System;
using System.Collections.Generic;
using System.Text;

namespace PlayGround.Lesson6
{
    public class Homework
    {

        #region Простая задача
        public static void Task09()
        {
            int a = 3;
            int b = 56;

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{a} + {b} = {a + b}");
            sb.AppendLine($"{a} - {b} = {a - b}");
            sb.AppendLine($"{a} * {b} = {a * b}");

            Console.WriteLine("Первый вывод:");
            Console.WriteLine(sb.ToString());

            sb.Replace("=", "equals");

            Console.WriteLine("\nВторой вывод:");
            Console.WriteLine(sb.ToString());
        }
        #endregion

        public static void Task01()
        {
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();

            List<string> parts = new List<string>();
            string word = "";

            foreach (char c in input)
            {
                if (char.IsLetterOrDigit(c))
                    word += c;
                else
                {
                    if (word != "")
                    {
                        parts.Add(word);
                        word = "";
                    }
                    parts.Add(c.ToString());
                }
            }
            if (word != "") parts.Add(word);

            List<string> words = new List<string>();
            foreach (string part in parts)
            {
                if (char.IsLetterOrDigit(part[0]))
                    words.Add(part);
            }

            words.Reverse();

            string result = "";
            int index = 0;

            foreach (string part in parts)
            {
                if (char.IsLetterOrDigit(part[0]))
                {
                    result += words[index];
                    index++;
                }
                else
                {
                    result += part;
                }
            }

            Console.WriteLine("Результат: " + result);
        }
        // дз
    }
}
