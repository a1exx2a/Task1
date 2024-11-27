namespace Task1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Привет! Введи два числа и я выведу их сумму! Первое число: ");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Теперь введи второе число: ");
        double x2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Сумма двух чисел --> " + (x1+x2));
    }
}
