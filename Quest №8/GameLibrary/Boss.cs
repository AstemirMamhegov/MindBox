using GameLibrary.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class Boss : Character
    {
        /// <summary>
        /// Конструктор наследуемого класса
        /// </summary>
        /// <param name="name">Имя босса</param>
        public Boss(string name) : base(name)
        {
        }
        /// <summary>
        /// Конструктор наследуемого класса
        /// </summary>
        /// <param name="healthPoints">Очки здоровья босса</param>
        public Boss(int healthPoints) : base(healthPoints)
        {
        }
        /// <summary>
        /// Конструктор наследуемого класса
        /// </summary>
        /// <param name="damagePerSecond">Количество урона в секунду</param>
        public Boss(double damagePerSecond) : base(damagePerSecond)
        {
        }
        /// <summary>
        /// Конструктор наследуемого класса
        /// </summary>
        /// <param name="name">Имя босса</param>
        /// <param name="healthPoints">Очки здоровья босса</param>
        /// <param name="damagePerSecond">Урон который может нанести босс за секунду</param>
        /// <param name="characterType">Виды боссов</param>
        public Boss(string name, int healthPoints, double damagePerSecond, CharacterType characterType)
            : base(name, healthPoints, damagePerSecond, characterType)
        {
        }


        /// <summary>
        /// Очки здоровья босса
        /// </summary>
        public override int HealthPoints
        {
            get
            {
                return base.HealthPoints;
            }
            set
            {
                if (value > 10000) 
                    throw new GameException("Incorrect HP");
                base.HealthPoints = value;
            }
        }
       /// <summary>
       /// Типы боссов
       /// </summary>
        public override List<CharacterType> AccessTypes => new List<CharacterType>() { CharacterType.Boss };
    }
}
