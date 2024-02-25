using System;

class Program
{
    static void Main(string[] args)
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Оберiть завдання:");
            Console.WriteLine("1. Обчислити ребро куба");
            Console.WriteLine("2. Перевiрити суму цифр двозначного числа на парнiсть");
            Console.WriteLine("3. Перевiрити точку на площинi в областi");
            Console.WriteLine("4. Знайти невiдому дату");
            Console.WriteLine("5. Пiднести цiле число у квадрат");
            Console.WriteLine("6. Обчислити вираз");
            Console.WriteLine("7. Вийти");
            Console.Write("Ваш вибiр: ");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    Console.Write("Введiть площу повної поверхнi куба: ");
                    double s = double.Parse(Console.ReadLine());
                    double edge = ObchyslytyRebroKuba(s);
                    Console.WriteLine($"Ребро куба: {edge}");
                    break;
                case 2:
                    Console.Write("Введiть двозначне число: ");
                    int number = int.Parse(Console.ReadLine());
                    bool isSumEven = PerevirytySumuTsyrDvoznachnogoChyslaNaParnist(number);
                    Console.WriteLine($"Сума цифр парна: {isSumEven}");
                    break;
                case 3:
                    task3();
                    break;
                case 4:
                    Console.Write("Введiть кiлькiсть мiсяцiв, що минули: ");
                    int months = int.Parse(Console.ReadLine());
                    DateTime unknownDate = ZnaytyNevidomuDatu(months);
                    Console.WriteLine($"Невiдома дата: {unknownDate}");
                    break;
                case 5:
                    Console.Write("Введiть цiле число: ");
                    int num = int.Parse(Console.ReadLine());
                    int squared = PidnestyTseleChysloUKvadrat(num);
                    Console.WriteLine($"Квадрат числа: {squared}");
                    break;
                case 6:
                    Console.Write("Введiть значення x: ");
                    double valX = double.Parse(Console.ReadLine());
                    Console.Write("Введiть значення y: ");
                    double valY = double.Parse(Console.ReadLine());
                    double result = ObchyslytyVyraz(valX, valY);
                    Console.WriteLine($"Результат виразу: {result}");
                    break;
                case 7:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Невiрний вибiр.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static double ObchyslytyRebroKuba(double poverkhnya)
    {
        return Math.Pow(poverkhnya, 1.0 / 3.0);
    }

    static bool PerevirytySumuTsyrDvoznachnogoChyslaNaParnist(int chyslo)
    {
        int suma = (chyslo / 10) + (chyslo % 10);
        return suma % 2 == 0;
    }

    static void task3()
    {
        Console.WriteLine("Завдання 3");
        Console.WriteLine("Введiть координати точки:");
        Console.Write("X = ");
        var x = double.Parse(Console.ReadLine());
        Console.Write("Y = ");
        var y = double.Parse(Console.ReadLine());

        if ((y < Math.Abs(x)) && (y < 12))
            Console.WriteLine("Inside");
        else if ((y == Math.Abs(x)) || (y == 12))
            Console.WriteLine("On the border");
        else
            Console.WriteLine("Outside");
    }

    static DateTime ZnaytyNevidomuDatu(int misyatsi)
    {
        return DateTime.Now.AddMonths(-misyatsi);
    }

    static int PidnestyTseleChysloUKvadrat(int chyslo)
    {
        return chyslo * chyslo;
    }

    static double ObchyslytyVyraz(double x, double y)
    {
        return Math.Pow(x - y, 2) - ((5 * x + Math.Pow(y, 2)) - (Math.Pow(y, 2) + 1));
    }
}
