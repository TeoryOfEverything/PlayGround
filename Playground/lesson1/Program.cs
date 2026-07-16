


Console.WriteLine("Введите год рождения: ");
int yearBirth = Convert.ToInt32(Console.ReadLine());

int presentYear = DateTime.Now.Year; // int presentYear = 2026
int age = presentYear - yearBirth;

if (yearBirth <= 1990 || yearBirth >= presentYear)
{
    Console.WriteLine("ругаемся");
}
else
{
    Console.Write("Вам " + age + " лет");
}

Console.ReadKey();