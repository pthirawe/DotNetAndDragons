using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAndDragons.Equipment
{
    public class Shield : IEquipment
    {
        public string Name { get; set; } = "Shield";
        public int AttackBonus { get; set; } = 0;
        public int ArmorBonus { get; set; } = 5;
    }
}
