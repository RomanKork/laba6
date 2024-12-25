using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba6
{
    // Класс для подсчета количества издаваемых звуков
    public class MeowTrack : IMeow
    {
        private readonly IMeow _meowable;
        private int _meowCount;
        public int Count => _meowCount;

        public MeowTrack(IMeow meowable)
        {
            _meowable = meowable ?? throw new ArgumentNullException(nameof(meowable));
        }

        public void Meow(int amount = 1)
        {
            if (amount < 1)
                throw new ArgumentException("Количество издаваемых звуков должно быть положительным");

            _meowCount += amount;
            _meowable.Meow(amount);
        }
    }

}
