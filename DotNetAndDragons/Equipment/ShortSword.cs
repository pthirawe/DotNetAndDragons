using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAndDragons.Equipment
{
    public class ShortSword : IEquipment
    {
        public string Name { get; set; } = "Short Sword";
        public int AttackBonus { get; set; } = 5;
        public int ArmorBonus { get; set; } = 0;
    }
}
