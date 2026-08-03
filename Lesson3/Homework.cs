namespace PlayGround.Lesson3;

internal class Homework
    {
        public static void PlayKNB()
        {
            int win1 = 0;
            int win2 = 0;
            int draws = 0;
            bool play = true;

            while (play == true)
            {
                Console.Clear();
                Console.WriteLine("СЧЕТ: Игрок1 " + win1 + " - " + win2 + " Игрок2");
                Console.WriteLine("Ничьи: " + draws);
                Console.WriteLine("");

                Console.Write("Игрок 1: ");
                string p1 = Console.ReadLine();
                p1 = p1.ToLower();

                Console.Write("Игрок 2: ");
                string p2 = Console.ReadLine();
                p2 = p2.ToLower();

                string[] names = { "камень", "ножницы", "бумага", "колодец" };
                string[] shorts = { "к", "н", "б", "д" };

                int index1 = -1;
                int index2 = -1;

                for (int i = 0; i < shorts.Length; i++)
                {
                    if (shorts[i] == p1)
                    {
                        index1 = i;
                    }
                    if (shorts[i] == p2)
                    {
                        index2 = i;
                    }
                }

                if (index1 == -1 || index2 == -1)
                {
                    Console.WriteLine("Ошибка! Нажми любую клавишу");
                    Console.ReadKey();
                    continue;
                }

                Console.WriteLine("Игрок 1: " + names[index1]);
                Console.WriteLine("Игрок 2: " + names[index2]);

                if (index1 == index2)
                {
                    Console.WriteLine("Ничья!");
                    draws = draws + 1;
                }
                else
                {
                    if (index1 == 0 && index2 == 1)
                    {
                        Console.WriteLine("Игрок 1 выиграл!");
                        win1 = win1 + 1;
                    }
                    else if (index1 == 1 && index2 == 2)
                    {
                        Console.WriteLine("Игрок 1 выиграл!");
                        win1 = win1 + 1;
                    }
                    else if (index1 == 2 && index2 == 0)
                    {
                        Console.WriteLine("Игрок 1 выиграл!");
                        win1 = win1 + 1;
                    }
                    else if (index1 == 3 && index2 == 0)
                    {
                        Console.WriteLine("Игрок 1 выиграл!");
                        win1 = win1 + 1;
                    }
                    else if (index1 == 3 && index2 == 1)
                    {
                        Console.WriteLine("Игрок 1 выиграл!");
                        win1 = win1 + 1;
                    }
                    else if (index1 == 2 && index2 == 3)
                    {
                        Console.WriteLine("Игрок 1 выиграл!");
                        win1 = win1 + 1;
                    }
                    else
                    {
                        Console.WriteLine("Игрок 2 выиграл!");
                        win2 = win2 + 1;
                    }
                }

                Console.WriteLine();
                Console.Write("Еще раунд? (д/н): ");
                string answer = Console.ReadLine();
                answer = answer.ToLower();

                if (answer != "y" && answer != "Y")
                {
                    play = false;
                }
            }

            Console.Clear();
            Console.WriteLine("Итоговый счет: Игрок1 " + win1 + " - " + win2 + " Игрок2");
            Console.WriteLine("Ничьих: " + draws);

            if (win1 > win2)
            {
                Console.WriteLine("Победил Игрок 1!");
            }
            else if (win2 > win1)
            {
                Console.WriteLine("Победил Игрок 2!");
            }
            else
            {
                Console.WriteLine("Общая ничья!");
            }

            Console.ReadKey();
        }
}
