using Tyuiu.ZolotovaKA.Sprint1.Task3.V3.Lib;
//Написать программу, которая запрашивает у пользователя исходные данные, выполняет указанные расчёты и печатает результат на экране.

//Расчеты:

//Написать программу вычисления объема параллелепипеда. Ответ округлите до 3 знаков после запятой.

//Длина (см) -> 9

//Ширина (см) -> 7.5

//Высота (см) -> 5

//Объем: 337,5 см.куб.
namespace Tyuiu.ZolotovaKA.Sprint1.Task3.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1| Выполнила: Золотова. К. А. | ИСПб-24-1 ";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнила: Золотова Карина Алексеевна | ИСПб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, которая суммирует значение двух    *");
            Console.WriteLine("* одинаковых массивов по длинне.                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double length = 9;
            double width = 7.5;
            double height = 5;
            Console.WriteLine("Длина = " + length);
             Console.WriteLine("Ширина = " + width);
            Console.WriteLine("Высота = " + height);
           
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            
            Console.WriteLine("Объем прямоугольника = " + ds.ParallelepipedVolume(length, width, height));
           
            Console.ReadKey();
        }
    }
}
 