using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAndDragons.Equipment
{
    public class Helm : IEquipment
    {
        public string Name { get; set; } = "Helm";
        public int AttackBonus { get; set; } = 0;
        public int ArmorBonus { get; set; } = 2;
    }
}
