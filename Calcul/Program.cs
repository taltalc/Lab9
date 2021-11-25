using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcul
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Вас приветствует калькулятор!");

            try
            {


                Console.Write("Введите целое число X= ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите целое число y= ");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите код операции:");
                Console.WriteLine("1-сложение");
                Console.WriteLine("2- вычитание");
                Console.WriteLine("3-умножение");
                Console.WriteLine("4-частное");

                Console.Write("Ваш выбор:");



                int[] arr = { 1, 2, 3, 4 };
                int a = Convert.ToInt32(Console.ReadLine());
                int result = 0;

                if (a == arr[0])
                {
                    Console.WriteLine("Результат:"+(x + y));
                }
                else if (a == arr[1])
                {
                    Console.WriteLine("Результат:" + (x - y));
                }
                else if (a == arr[2])
                {
                    Console.WriteLine("Результат:" + (x * y));
                }
                else if (a == arr[3])
                {
                    Console.WriteLine("Результат:" + (x / y));
                }
                else if (a < 1 || a > 4)
                {
                    Exception e = new Exception("Нет операции с указанным номером.");
                    throw e;
                }



            }
            catch (Exception ex)
            {
                Console.Write("Ошибка!" + ex.Message);

            }



            Console.ReadKey();

        }
    }
}
