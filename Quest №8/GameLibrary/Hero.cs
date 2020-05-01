using GameLibrary.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class Hero : Character
    {
        /// <summary>
        /// Конструктор наследуемого класса
        /// </summary>
        /// <param name="name">Имя героя</param>
        public Hero(string name) : base(name)
        {

        }
        /// <summary>
        /// Конструктор наследуемого класса
        /// </summary>
        /// <param name="healthPoints">Очки здоровья героя</param>
        public Hero( int healthPoints) : base(healthPoints)
        {

        }
        /// <summary>
        /// Конструктор наследуемого класса
        /// </summary>
        /// <param name="damagePerSecond">Количество урона в секунду</param>
        public Hero(double damagePerSecond) : base(damagePerSecond)
        {

        }

        /// <summary>
        /// Конструктор наследумого класса
        /// </summary>
        /// <param name="name">Имя героя</param>
        /// <param name="healthPoints">Очки здоровья героя</param>
        /// <param name="damagePerSecond">Уроно, который может нанести герой за секунду</param>
        /// <param name="characterType">Виды героев</param>
        public Hero(string name, int healthPoints, double damagePerSecond, CharacterType characterType) 
            : base(name, healthPoints, damagePerSecond, characterType)
        {
        }
        /// <summary>
        /// Очки здоровья Героя 
        /// </summary>
        public override int HealthPoints
        {
            get
            {
                return base.HealthPoints;
            }
            set
            {
                if (value > 5000) 
                    throw new GameException("Incorrect HP");
                base.HealthPoints = value;
            }
        }
        /// <summary>
        /// Список видов героев
        /// </summary>
        public override List<CharacterType> AccessTypes
        {
            get
            {
                return new List<CharacterType>()
                {
                     CharacterType.DamageDealer, CharacterType.Hiller, CharacterType.Tank
                };
            }
        }
    }
}
