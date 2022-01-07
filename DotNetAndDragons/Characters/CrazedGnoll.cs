using DotNetAndDragons.Equipment;
using DotNetAndDragons.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAndDragons.Characters
{
    public class CrazedGnoll : Monster
    {
        public override string Name { get; } = "Crazed Gnoll";
        public override int Health { get; set; } = 20;
        public override List<IItem> Inventory { get; } = new List<IItem>() { };
        public override List<IEquipment> Equipment { get; } = new List<IEquipment>();
        public override int BaseAttack { get; } = 5;

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
