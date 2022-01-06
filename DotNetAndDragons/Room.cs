using DotNetAndDragons.Characters;
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
        public List<IItem> Items { get; }
        public List<IEquipment> Equipment { get; }
        public Monster Enemy { get; set; }

        public Room(string onEntry, /*List<Room> exits,*/ List<IItem> items, List <IEquipment> equipment, Monster monster)
        {
            OnEntry = onEntry;
            //ConnectedRooms = exits;
            Items = items;
            Equipment = equipment;
            Enemy = monster;
        }

        public void RemoveMonster(Monster monster)
        {
            if(Enemy == monster)
            {
                Enemy = null;
            }
        }

        public IItem TakeItem(string command)
        {
            int index = 0;
            IItem toPickup = null;
            foreach(IItem item in Items)
            {
                if(command.Contains(item.Name.ToLower()))
                {
                    toPickup = item;
                    Items.RemoveAt(index);
                    break;
                }
                index++;
            }
            return toPickup; 
        }
    }
}
