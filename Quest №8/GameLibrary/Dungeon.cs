using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class Dungeon
    {
        public delegate void DungeonChangeHandler(Character character);
        public event DungeonChangeHandler NewCharacter;
        public event DungeonChangeHandler DeleteCharacter;
        private int countHero, countBoss;
        private List<Character> characters = new List<Character>();

        public int CountHero => countHero;
        public int CountBoss => countBoss;

        public IEnumerable<Character> Characters => characters;

        public void OnNewCharacter(Character character)
        {
            if (NewCharacter != null) NewCharacter(character);
        }

        public void OnDeleteCharacter(Character character)
        {
            if (DeleteCharacter != null) DeleteCharacter(character);
        }

        /// <summary>
        /// Функция добавления персонажа в подземелье
        /// </summary>
        /// <param name="character">Персонаж</param>
        public void AddCharacter(Character character)
        {
            if (character is Hero) 
                countHero++;
            else if (character is Boss) 
                countBoss++;

            characters.Add(character);
            OnNewCharacter(character);
        }
        /// <summary>
        /// Функция удаления персонажа в подземелье
        /// </summary>
        /// <param name="character">Персонаж</param>
        public void RemoveCharacter(Character character)
        {
            if (character is Hero)
                countHero--;
            else if (character is Boss)
                countBoss--;

            characters.Remove(character);
            OnDeleteCharacter(character);
        }
        /// <summary>
        /// Функция определения сложности подземелья в зависимости от количество в ней героев и боссов.
        /// </summary>
        public double Difficulty
        {
            get
            {
                if (countBoss == 0)
                    return 0;
                return (double)countHero / countBoss;
            }
        }
    }
}
