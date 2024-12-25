using System.Collections.Generic;
using System.Linq;
namespace laba6
{
    class Program
    {
        static void Main()
        {
            var barsik = new Cat("Барсик");
            Console.WriteLine("Барсик мяукнет 1 раз и 3 раза:");
            barsik.Meow();
            barsik.Meow(3);
            Console.WriteLine("Введите количество мяуканий Барсика(введите 0, если хотите прекратить):");
            int choice = Check();
            while (choice != 0)
            {
                barsik.Meow(choice);
                Console.WriteLine("Введите количество мяуканий Барсика(введите 0, если хотите прекратить):");
                choice = Check();
            }
            Console.WriteLine("Введите имя собаки:");
            string name = Console.ReadLine();
            var dog = new Dogs(name);
            var trackeddog = new MeowTrack(dog);
            Console.WriteLine($"Введите количество гавканий {name}а:");
            trackeddog.Meow(Check());
            Console.WriteLine($"Количество гавканий {name}а: {trackeddog.Count}.");
            Console.WriteLine("Введите числитель и знаменатель первой дроби:");
            var fraction1 = new Fraction(Check1(), Check());
            Console.WriteLine("Введите числитель и знаменатель второй дроби:");
            var fraction2 = new Fraction(Check1(), Check());
            Console.WriteLine("Введите числитель и знаменатель третьей дроби:");
            var fraction3 = new Fraction(Check1(), Check());
            Console.WriteLine($"Дробь1 = {fraction1}\nДробь2 = {fraction2}\nДробь3 = {fraction3}");
            var result = fraction1 + fraction2;
            var result1 = (fraction1 + fraction2) / fraction3 - 5;
            Console.WriteLine($"{fraction1} + {fraction2} = {result}");
            Console.WriteLine($"({fraction1} + {fraction2}) / {fraction3} - 5 = {result1}");
            var cachedFraction = new DoubleFraction(fraction1);
            Console.WriteLine($"Значение дроби {fraction1}: {cachedFraction.Value()}");
        }
        public static int Check()
        {
            int a;
            if (int.TryParse(Console.ReadLine(), out a) && a >= 0)
            {
                return a;
            }
            Console.WriteLine("Вы ввели некорректное значение, введите значение вновь: ");
            return Check();
        }
        public static int Check1()
        {
            int a;
            if (int.TryParse(Console.ReadLine(), out a))
            {
                return a;
            }
            Console.WriteLine("Вы ввели некорректное значение, введите значение вновь: ");
            return Check();
        }
    }
}