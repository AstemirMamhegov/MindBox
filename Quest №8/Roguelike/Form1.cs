using GameLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roguelike
{
    public partial class Form1 : Form
    {
        Dungeon dungeon;

        public Form1()
        {
            InitializeComponent();

            dungeon = new Dungeon();
            dungeon.NewCharacter += Dungeon_NewCharacter;
            dungeon.DeleteCharacter += Dungeon_DeleteCharacter;
        }

        private void Dungeon_DeleteCharacter(Character character)
        {
            listBox1.Items.Remove(character);
        }

        private void Dungeon_NewCharacter(Character character)
        {
            listBox1.Items.Add(character);
        }

        /// <summary>
        /// Функция создания персонажа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            Character character = null;
            string name = txtBxName.Text;
            int hp = (int) numUpDownHP.Value;
            double dps = (double)numUpDownDPS.Value;
            CharacterType chartype = (CharacterType)comboBox2.SelectedIndex;

            try
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    character = new Hero(name, hp, dps, chartype);
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    character = new Boss(name, hp, dps, chartype);
                }
                dungeon.AddCharacter(character);
                
                txtBxDiff.Text = dungeon.Difficulty.ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                Character character = listBox1.SelectedItem as Character;
                dungeon.RemoveCharacter(character);
            }
        }
    }
}
