using DotNetAndDragons.Equipment;
using DotNetAndDragons.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAndDragons.Characters
{
    public class Player : ICharacter
    {
        public string Name { get; set; } = "John";

        public int Health { get; set; } = 25;

        public List<IItems> Inventory { get; set; } = new List<IItems>();

        public List<IEquipment> Equipment { get; set; } = new List<IEquipment>();
    }
}
