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
        public abstract int Health { get; }
        public abstract List<IItems> Inventory { get; }
        public abstract string Name { get; }
        public abstract List<IEquipment> Equipment { get; }
    }
}
