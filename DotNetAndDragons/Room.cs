using DotNetAndDragons.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAndDragons
{
    public class Room
    {
        public string OnEntry { get; }
        public List<string> Exits { get; }
        public List<IItems> Items { get; }
    }
}
