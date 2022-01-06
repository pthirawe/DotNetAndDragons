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
            Health -= damage;
        }

        public int Attack()
        {
            return BaseAttack;
        }
    }
}
