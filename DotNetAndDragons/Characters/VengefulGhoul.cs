using DotNetAndDragons.Equipment;
using DotNetAndDragons.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAndDragons.Characters
{
    public class VengefulGhoul : Monster
    {
        public override string Name { get; } = "Vengeful Ghoul";
        public override int Health { get; set; } = 30;
        public override List<IItem> Inventory { get; } = new List<IItem>() { };
        public override List<IEquipment> Equipment { get; } = new List<IEquipment>();
        public override int BaseAttack { get; } = 10;

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
