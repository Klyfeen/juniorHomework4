using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juniorHomework4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, country, favoriteBook;
            int age, mealsPerDay;

            Console.Write("Как вас зовут: ");
            name = Console.ReadLine();
            Console.Write("Сколько вам лет: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("В какой стране вы живете: ");
            country = Console.ReadLine();
            Console.Write("Ваша любимая книга: ");
            favoriteBook = Console.ReadLine();
            Console.Write("Сколько раз в день вы кушаете: ");
            mealsPerDay = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nВас зовут {name}, вам {age} лет. Страна в которой вы живете - {country}, а любимая книга - {favoriteBook}." +
                $"\nВ день вы успеваете кушать {mealsPerDay} раз!");
        }
    }
}
