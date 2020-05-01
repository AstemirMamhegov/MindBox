using GameLibrary.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public abstract class Character
    {
        /// <summary>
        /// Имя 
        /// </summary>
        protected string name;
        /// <summary>
        /// Очки здоровья
        /// </summary>
        protected int healthPoints;
        /// <summary>
        /// Количество урона за секунду
        /// </summary>
        protected double damagePerSecond;
        /// <summary>
        /// Типы персонажей
        /// </summary>
        protected CharacterType characterType;

        /// <summary>
        /// Конструктор базового класса
        /// </summary>
        /// <param name="name">Имя персонажа</param>
        public Character(string name)
        {
            Name = name;
        }
        /// <summary>
        /// Конструктор базового класса
        /// </summary>
        /// <param name="healthPoints">Очки здоровья персонажа</param>
        public Character(int healthPoints)
        {
            HealthPoints = healthPoints;
        }
        /// <summary>
        /// Конструктор базоового класса
        /// </summary>
        /// <param name="damagePerSecond">Количество урона в секунду</param>
        public Character(double damagePerSecond)
        {
            DamagePerSecond = damagePerSecond;
        }

        /// <summary>
        /// Конструктор базового класса
        /// </summary>
        /// <param name="name">Имя персонажа</param>
        /// <param name="healthPoints">Очки здоровья персонажа</param>
        /// <param name="damagePerSecond">Количество урона, котоорое может нанести персонаж за секунду</param>
        /// <param name="characterType">ВИды персонажей</param>
        public Character(string name, int healthPoints, double damagePerSecond, CharacterType characterType)
        {
            Name = name;
            HealthPoints = healthPoints;
            DamagePerSecond = damagePerSecond;
            CharacterType = characterType;
        }

        /// <summary>
        /// Имя персонажа
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length < 3 || value.Length > 15)
                    throw new IncorrectNameException("Неверная длина имени персонажа. Допустимый размер длины от 5 до 15");
                name = value;
            }
        }

        public abstract List<CharacterType> AccessTypes { get; }
        /// <summary>
        /// Виды персонажей
        /// </summary>
        public CharacterType CharacterType
        {
            
            get
            {
                return characterType;
            }
            set
            {
                if (!AccessTypes.Contains(value))
                    throw new IncorrectCharacterTypeException();
                characterType = value;
            }
        }
        /// <summary>
        /// Очки здоровья персонажа
        /// </summary>
        public virtual int HealthPoints
        {
            get
            {
                return healthPoints;
            }
            set
            {
                if (value < 0) 
                    throw new GameException("Incorrect HP");
                healthPoints = value;
            }
        }
        /// <summary>
        /// Количество урона, котоорое может нанести персонаж за секунду
        /// </summary>
        public double DamagePerSecond
        {
            get
            {
                return damagePerSecond;
            }
            set
            {
                if (value < 0) 
                    throw new GameException("Incorrect DPS");
                damagePerSecond = value;
            }
        }

        public override string ToString()
        {
            return $"Name: {Name}, type: {CharacterType}, HP: {HealthPoints}, DPS: {DamagePerSecond} ";
        }
    }
}
