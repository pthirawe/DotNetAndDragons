using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAndDragons.Items
{
    public class HealthPotion : IItem
    {
        public string Name { get; set; } = "Health Potion";

        public string Description { get; set; } = "A small vial of red liquid. Restores 5 HP.";

        public string Use()
        {
            return "heal 10";
        }
    }
}
