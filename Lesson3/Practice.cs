namespace PlayGround.Lesson3;

internal class Practice
    {
        //
        public void Main()
        {
            for (int i = 10; i < 100; i++)
            {
                if (i % 5 == 0)
                {
                    Console.Write($"{i} ");
                }
            }
        }
        
        //
        public void Task05()
        {
            int i = 0;
            do 
            {
                i -= 20;
                Console.Write($" {i} ");
            } 
            
            while (i > -1000);
            
        }
        //
        public void Task04()
        {
            Console.WriteLine("");
            ConsoleKey key = Console.ReadKey().Key;

            switch (key)
            {
                case ConsoleKey.W:
                    Console.WriteLine(" Движение вверх (W)");
                    break;
                case ConsoleKey.S:
                    Console.WriteLine(" Движение вниз (S)");
                    break;
                case ConsoleKey.A:
                    Console.WriteLine(" Движение влево (A)");
                    break;
                case ConsoleKey.D:
                    Console.WriteLine(" Движение вправо (D)");
                    break;
            }
        }
        //
        public void Task06()
        {

            int Myage = 26;
            int number = 100;
            while (number <= 800)
            {
                if (number % Myage == 0)
                    Console.Write(number + " ");

                number++;
            }

        }
        //
        public void Task07()
        {
            int[] numbers = { 5, 10, 15, 20, 25 };

            for (int i = 0; i < numbers.Length; i++)
            {
                string indent = new string(' ', i);

                Console.WriteLine(indent + numbers[i]);
            }
        }
        //
        public void Task08()
        {
            string[] likes = {
                "Alex",
                "Bart",
                "Max",
                "Alice",
                "Mark"
            };

            switch (likes.Length)
            {
                case 0:
                    Console.WriteLine("no one likes this");
                    break;
                case 1:
                    Console.WriteLine($"{likes[0]} likes this");
                    break;
                case 2:
                    Console.WriteLine($"{likes[0]} and {likes[1]} like this");
                    break;
                case 3:
                    Console.WriteLine($"{likes[0]}, {likes[1]} and {likes[2]} like this");
                    break;
                default:
                    Console.WriteLine($"{likes[0]}, {likes[1]} and {likes.Length - 2} others like this");
                    break;
            }
        }
}
