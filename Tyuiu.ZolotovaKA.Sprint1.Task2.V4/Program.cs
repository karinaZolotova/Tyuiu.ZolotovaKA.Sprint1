using Tyuiu.ZolotovaKA.Sprint1.Task2.V4.Lib;

namespace Tyuiu.ZolotovaKA.Sprint1.Task2.V4
{
    class Program 
    { 
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1| Выполнила: Золотова. К. А. | ИСПб-24-1 ";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Арифметические операторы в C#                                     *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнила: Золотова Карина Алексеевна | ИСПб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x;
            Console.WriteLine("Введите длину стороны квадрата:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Площадь квадрата " + ds.CalculateSquare(x));
            Console.ReadLine();
        }
    }
}