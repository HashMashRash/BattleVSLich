using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTestHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Добрый день! Как Вас зовут?  ");
            string name = Console.ReadLine();
            Console.Write("Введите, пожалуйста Ваш возраст (полных лет): ");
            string age = Console.ReadLine();
            Console.Write("Кто Вы по знаку зодиака?  ");
            string zodiac = Console.ReadLine();
            Console.Write("Какова Ваша профессия?  ");
            string profession = Console.ReadLine();
            Console.WriteLine($"Вот, что мы знаем о Вас {name}. Возраст: {age}, знак зодиака {zodiac}, Ваша профессия {profession} ");
            Console.ReadKey();
        }
    }
}
