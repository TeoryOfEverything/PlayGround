using PlayGround.Lesson3;

Practice practice = new Practice();



Console.WriteLine("1 - прямая, 2 - обратная");
int choice = int.Parse(Console.ReadLine());

Console.Write("Введите символ: ");
char symbol = Console.ReadKey().KeyChar;
Console.WriteLine();

Console.Write("Введите размер: ");
int size = int.Parse(Console.ReadLine());
Console.WriteLine();

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        if (choice == 1) 
        {
            if (i == j)
                Console.Write(symbol);
            else
                Console.Write(" ");
        }
        else if (choice == 2) 
        {
            if (i + j == size - 1)
                Console.Write(symbol);
            else
                Console.Write(" ");
        }
    }
    Console.WriteLine(); 
}

//practice.Task07();