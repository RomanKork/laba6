using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba6
{
    // Интерфейс для объектов, способных мяукать
    public interface IMeow
    {
        void Meow(int amount = 1);

        static void MeowAll(IMeow[] meowables)
        {
            foreach (var meowable in meowables)
                meowable.Meow();
        }
    }
}
