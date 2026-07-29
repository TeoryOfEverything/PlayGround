namespace PlayGround.Lesson5;

public class Homework
    {
        public static void ProveritParol()
        {
            Console.Write("Введите пароль: ");
            string parol = Console.ReadLine();

            if (parol.Length < 8 || parol.Length > 20)
            {
                Console.WriteLine("Ошибка! Длина пароля должна быть от 8 до 20 символов!");
                return;
            }

            if (parol.Contains(' '))
            {
                Console.WriteLine("Ошибка! Пароль не должен содержать пробелы!");
                return;
            }

            bool estZaglavnaya = false;
            bool estStrochnaya = false;
            bool estCifra = false;
            bool estSpecial = false;

            for (int i = 0; i < parol.Length; i++)
            {
                char simvol = parol[i];

                if (char.IsUpper(simvol))
                    estZaglavnaya = true;

                if (char.IsLower(simvol))
                    estStrochnaya = true;

                if (char.IsDigit(simvol))
                    estCifra = true;

                if (char.IsPunctuation(simvol) || char.IsSymbol(simvol))
                    estSpecial = true;
            }

            if (estZaglavnaya == false)
            {
                Console.WriteLine("Ошибка! Пароль должен содержать хотя бы одну заглавную букву!");
                return;
            }

            if (estStrochnaya == false)
            {
                Console.WriteLine("Ошибка! Пароль должен содержать хотя бы одну строчную букву!");
                return;
            }

            if (estCifra == false)
            {
                Console.WriteLine("Ошибка! Пароль должен содержать хотя бы одну цифру!");
                return;
            }

            if (estSpecial == false)
            {
                Console.WriteLine("Ошибка! Пароль должен содержать хотя бы один специальный символ!");
                return;
            }

            Console.WriteLine("Пароль успешно прошел проверку!");
        }


        public static void ProverkaParola()
        {
            Console.Write("Введите пароль: ");
            string parol = Console.ReadLine();

            bool isValid = parol.Length is >= 8 and <= 20 &&
                           !parol.Contains(' ') &&
                           parol.Any(char.IsUpper) &&
                           parol.Any(char.IsLower) &&
                           parol.Any(char.IsDigit) &&
                           parol.Any(c => char.IsPunctuation(c) || char.IsSymbol(c));

            string message = isValid
                ? "Пароль успешно прошел проверку!"
                : "Ошибка! Пароль не соответствует требованиям!";

            Console.WriteLine(message);
        }
}
