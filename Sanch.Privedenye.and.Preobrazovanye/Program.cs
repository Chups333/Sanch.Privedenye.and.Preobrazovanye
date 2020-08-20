using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanch.Privedenye.and.Preobrazovanye
{
    class Program
    {
        static void Main(string[] args)
        {
            string UserName; // Два слова в одном с большой буквы Верхняя верблюжья нотация PascalCase
            string lowerCamelCase; // нижняя верб нотация 
            string snake_case; // змеиная нотация
            string FAT_SNAKE_CASE; // толстая нотация змеиная 
            // string kebab-case; //  шашлычная нотация
            string sHungarianCase; // венгерская нотация
                                   // int X; -так не надо


            // string s = "1";
            //  int i = s; // ошибка
            // int j = 5;
            // double d = j; // ошибки нет 
            // int k = d // ошибка есть

            //неявное приведение
            // byte b = 42; // от 0 до 255
            // int i = b; // от - 2 миллиарда до 2 милиардом

            // явное приведение
            //int i = 5;
            // int j = 2047; // 255 по кругу
            //int j = 2048;// 0 по кругу
            // byte b = (byte)i; // ошибки нет
            // byte bb = j;//  ошибка
            // byte bb = (byte)j;//  ошибка


            //явное преобразование
            // 1 способ
            //string s = "2048";
            //int jojo = int(s); // ошибка
            //int ii = Convert.ToInt32(s);// преобразование 1

            //2  способ 
            //int ii = int.Parse("42");// преобразование 2

            //неявное преобразование
            //int i = 1;
            //string s = "str " + i;
            //string s = "str " + i.ToString(); - явное

            // bool b = true;
            // string s = b.ToString();// работает

            //string s = "true";
           // bool b = Convert.ToBoolean(s); // работает

            if ( int.TryParse("123", out int result)){
                Console.WriteLine(result);
                Console.ReadKey(); // если сможет перевести в инт строку то выдаст консоль
            }

            //Console.WriteLine(b);
            //Console.ReadKey();
        }
    }
}
