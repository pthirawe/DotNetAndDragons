using DotNetAndDragons.Equipment;
using DotNetAndDragons.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAndDragons.Characters
{
    public abstract class Monster : ICharacter
    {
        public abstract int Health { get; set; }
        public abstract List<IItem> Inventory { get; }
        public abstract string Name { get; }
        public abstract List<IEquipment> Equipment { get; }
        public abstract int BaseAttack { get; }

        public abstract void Heal(int healing);
        public abstract void TakeDamage(int damage);

        public abstract int Attack();
    }
}
