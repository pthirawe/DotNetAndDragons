using DotNetAndDragons.Equipment;
using DotNetAndDragons.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAndDragons.Characters
{
    public interface ICharacter
    {
        string Name { get; }
        int Health { get; set; }
        int BaseAttack { get; }
        List<IItem> Inventory { get; }
        List<IEquipment> Equipment { get; }
        void TakeDamage(int damage);
        void Heal(int healing);
        int Attack();
    }
}
