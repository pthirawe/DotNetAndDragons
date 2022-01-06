using DotNetAndDragons.Equipment;
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
        public Dictionary<string, Room> Exits { get; set; }
        //public List<Room> ConnectedRooms { get; }
        public List<IItems> Items { get; }
        public List<IEquipment> Equipment { get; }
        public Room()
        {

        }
        public Room(string onEntry, /*List<Room> exits,*/ List<IItems> items, List <IEquipment> equipment)
        {
            OnEntry = onEntry;
            //ConnectedRooms = exits;
            Items = items;
            Equipment = equipment;
        }
    }
}
