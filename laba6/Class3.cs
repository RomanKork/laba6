using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba6
{
    //Класс собак
    public class Dogs : IMeow
    {
        private readonly string _name;
        public string Name => _name;

        public Dogs(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Имя не может быть пустым");

            _name = name;
        }

        public void Meow(int amount = 1)
        {
            if (amount < 1)
                throw new ArgumentException("Количество гавканий должно быть положительным");

            Console.Write($"{_name}: ");
            for (int i = 0; i < amount - 1; ++i)
                Console.Write("гав-");
            Console.WriteLine("гав!");
        }
    }
}
