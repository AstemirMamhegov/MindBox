using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Exceptions
{
    public class IncorrectNameException : GameException
    {
        public IncorrectNameException() : this("Неверное имя персонажа")
        {
        }

        public IncorrectNameException(string message) : base(message)
        {
        }
    }
}
