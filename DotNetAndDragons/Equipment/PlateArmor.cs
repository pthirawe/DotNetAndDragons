using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAndDragons.Equipment
{
    public class PlateArmor : IEquipment
    {
        public string Name { get; set; } = "Plate Armor";
        public int AttackBonus { get; set; } = 0;
        public int ArmorBonus { get; set; } = 15;
    }
}
