using DotNetAndDragons.Equipment;
using DotNetAndDragons.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAndDragons.Characters
{
    public class Player : ICharacter
    {
        public string Name { get; set; } = "John";

        public int Health { get; set; } = 25;

        public List<IItem> Inventory { get; set; } = new List<IItem>();

        public List<IEquipment> Equipment { get; set; } = new List<IEquipment>();

        public int BaseAttack { get; set; } = 1;


        public void Heal(int healing)
        {
            Health += healing;
        }

        public void TakeDamage(int damage)
        {
            int mitigation=0;
            foreach(IEquipment equipped in Equipment)
            {
                mitigation += equipped.ArmorBonus;
            }
            Health -= damage-mitigation;
        }

        public int Attack()
        {
            int bonus = 0;
            foreach(IEquipment equipped in Equipment)
            {
                bonus += equipped.AttackBonus;
            }
            return BaseAttack+bonus;
        }
    }
}
