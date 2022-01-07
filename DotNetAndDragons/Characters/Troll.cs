using DotNetAndDragons.Equipment;
using DotNetAndDragons.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAndDragons.Characters
{
    public class Troll : Monster
    {
        public override string Name { get; } = "Troll";
        public override int Health { get; set; } = 50;
        public override List<IItem> Inventory { get; } = new List<IItem>() { };
        public override List<IEquipment> Equipment { get; } = new List<IEquipment>();
        public override int BaseAttack { get; } = 15;

        public override int Attack()
        {
            return BaseAttack;
        }

        public override void Heal(int healing)
        {
            Health += healing;
        }

        public override void TakeDamage(int damage)
        {
            Health -= damage;
        }
    }
}
