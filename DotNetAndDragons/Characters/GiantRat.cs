using DotNetAndDragons.Equipment;
using DotNetAndDragons.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAndDragons.Characters
{
    public class GiantRat : Monster
    {
        public override int Health { get; set; } = 2;

        public override List<IItem> Inventory { get; } = new List<IItem>() { };

        public override string Name { get; } = "Giant Rat";

        public override List<IEquipment> Equipment { get; } = new List<IEquipment>();

        public override int BaseAttack { get; } = 1;

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
