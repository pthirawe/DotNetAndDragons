using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAndDragons.Equipment
{
    public interface IEquipment
    {
        string Name { get; set; }
        int AttackBonus { get; set; }
        int ArmorBonus { get; set; }
    }
}
