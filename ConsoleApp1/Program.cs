using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    class Program
    {

        static void Main(string[] args)
        {
            Int32 a = 0;
            Int32 b = 0;
            Int32 oper = 0;
            Int32 res = 0;

            Console.Write("Введите целое число: X= ");
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Ошибка! Не верный формат");
            }
            Console.Write("Введите целое число: Y= ");
            try
            {
                b = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Ошибка! Не верный формат");
            }          

            Console.WriteLine("Введите код операции:");
            Console.WriteLine("1 - сложение:");
            Console.WriteLine("2 - вычитание:");
            Console.WriteLine("3 - произведение:");
            Console.WriteLine("4 - частное:");
            try
            {
                oper = Convert.ToChar(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Ошибка! Нет операции с указанным номером");
            }

            if (oper == '1')
            {
                res = a + b;
            }

            else if (oper == '2')
            {
                res = a - b;
            }

            else if (oper == '3')
            {
                res = a * b;
            }

            else if (oper == '4')
            {
                try
                {
                    res = a / b;
                }
                catch(DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }            
            Console.WriteLine("Результат: {0}", res);
            Console.ReadLine();
        }
    }
}
