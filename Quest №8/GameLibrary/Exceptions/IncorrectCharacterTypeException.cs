using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Exceptions
{
    public class IncorrectCharacterTypeException : GameException
    {
        public IncorrectCharacterTypeException() : this("Неверный тип персонажа")
        {

        }

        public IncorrectCharacterTypeException(string message) : base(message)
        {

        }
    }
}
