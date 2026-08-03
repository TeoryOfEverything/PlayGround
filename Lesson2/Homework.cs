namespace PlayGround.Lesson2;

public class Homework
    {
        public static void RandomChislo()
        {
            bool igratSnova = true;

            while (igratSnova) 
            {
                Console.Clear(); 
                Console.WriteLine("  ИГРА УГАДАЙ ЧИСЛО  ");
                Console.WriteLine();

                int maxPopitok = 0;
                bool pravilniyVibor = false;

                while (pravilniyVibor == false)
                {
                    Console.WriteLine("Выбери сложность:");
                    Console.WriteLine("1 - Легкий (10 попыток)");
                    Console.WriteLine("2 - Средний (5 попыток)");
                    Console.WriteLine("3 - Сложный (3 попытки)");
                    Console.WriteLine();
                    Console.Write("Введи номер: ");

                    string vibor = Console.ReadLine();

                    if (vibor == "1")
                    {
                        maxPopitok = 10;
                        Console.WriteLine();
                        Console.WriteLine("Ты выбрал легкий уровень!");
                        Console.WriteLine("У тебя 10 попыток, число уже загадано!");
                        pravilniyVibor = true;
                    }
                    else if (vibor == "2")
                    {
                        maxPopitok = 5;
                        Console.WriteLine();
                        Console.WriteLine("Ты выбрал средний уровень!");
                        Console.WriteLine("У тебя 5 попыток, число уже загадано!");
                        pravilniyVibor = true;
                    }
                    else if (vibor == "3")
                    {
                        maxPopitok = 3;
                        Console.WriteLine();
                        Console.WriteLine("Ты выбрал сложный уровень!");
                        Console.WriteLine("У тебя 3 попытки, число уже загадано!");
                        pravilniyVibor = true;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("ОШИБКА! Нужно ввести 1, 2 или 3! Попробуй еще раз");
                        Console.WriteLine();
                    }
                }

                Random rnd = new Random();
                int chislo = rnd.Next(1, 101);

                int popitka;
                int ispolzovano = 0;
                bool ugadal = false;

                while (ispolzovano < maxPopitok)
                {
                    Console.Write("Введи число: ");

                    bool etoChislo = int.TryParse(Console.ReadLine(), out popitka);

                    if (etoChislo == false)
                    {
                        Console.WriteLine("ОШИБКА! Нужно ввести ЧИСЛО от 1 до 100!");
                        Console.WriteLine("Попробуй еще раз");
                        Console.WriteLine();
                        continue;
                    }

                    if (popitka < 1 || popitka > 100)
                    {
                        Console.WriteLine("ОШИБКА! Число должно быть от 1 до 100!");
                        Console.WriteLine("Попробуй еще раз");
                        Console.WriteLine();
                        continue;
                    }

                    ispolzovano++;

                    int ostalos = maxPopitok - ispolzovano;

                    if (popitka > chislo)
                    {
                        Console.WriteLine("Меньше");
                        Console.WriteLine("Осталось попыток: " + ostalos);
                    }
                    else if (popitka < chislo)
                    {
                        Console.WriteLine("Больше");
                        Console.WriteLine("Осталось попыток: " + ostalos);
                    }
                    else if (popitka == chislo)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Поздравляю, вы угадали!");
                        Console.WriteLine("Ты угадал за " + ispolzovano + " попыток!");
                        ugadal = true;
                        break;
                    }

                    Console.WriteLine();
                }

                if (ugadal == false)
                {
                    Console.WriteLine();
                    Console.WriteLine("К сожалению, ты не угадал!");
                    Console.WriteLine("Загаданное число было: " + chislo);
                }

                Console.WriteLine();
                Console.Write("Хочешь сыграть еще раз? (y/n): ");
                string otvet = Console.ReadLine();

                if (otvet == "y" || otvet == "Y")
                {
                    igratSnova = true; 
                }
                else if (otvet == "n" || otvet == "N")
                {
                    igratSnova = false; 
                    Console.WriteLine();
                    Console.WriteLine("Спасибо за игру! До встречи!");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Спасибо за игру! До встречи!");
                    igratSnova = false;
                }

                Console.WriteLine();
                Console.WriteLine("Нажми любую клавишу...");
                Console.ReadKey();
            }
        }
}