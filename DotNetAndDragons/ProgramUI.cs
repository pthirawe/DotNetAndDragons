﻿using DotNetAndDragons.Equipment;
using DotNetAndDragons.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAndDragons
{
    public class ProgramUI
    {     
        //Create rooms
        //1
        public static Room EntryHall = new Room("You step into the dank entry. The bright light of the outside world doesn't seem to penetrate as far as it should. The only way forward appears to be NORTH",
            new List<IItems> { },
            new List<IEquipment> { });
            //2
        public static Room FirstFork = new Room("The outside light fades rapidly as you continue your trek deeper into the lair.  You see there is a way WEST and a path to the EAST.",
                new List<IItems> { },
                new List<IEquipment> { });
            //3
        public static Room GuardRoom = new Room("In the dim light from your lantern you see rusted weapons and armor adorning the walls.  Perhaps you might find something useful, but otherwise it looks like the only way out is EAST the way you came.",
                new List<IItems> { },
                new List<IEquipment> { });
            //4
        public static Room HallBend = new Room("The path turns sharply NORTH and the natural cave walls being giving way to rough hewn, but clearly artifical stonework.  The surfaces are cracked and worn.",
                new List<IItems> { },
                new List<IEquipment> { });    
            //5
        public static Room FirstT = new Room("The path splits.  To the NORTH, you hear faint low rumbling.  To the EAST, a faint metallic smell.",
                new List<IItems> { },
                new List<IEquipment> { });    
            //6
        public static Room BloodyHall = new Room("The metallic stench grows stronger and parts of the floor appears to have red streaks.",
                new List<IItems> { },
                new List<IEquipment> { });  
            //7
        public static Room TortureRoom = new Room("In the dim light from your lantern you see rusted weapons and armor adorning the walls.",
                new List<IItems> { },
                new List<IEquipment> { });
            //8
        public static Room SecondT = new Room("In the dim light from your lantern you see rusted weapons and armor adorning the walls.",
                new List<IItems> { },
                new List<IEquipment> { });    
            //9
        public static Room DankHall = new Room("In the dim light from your lantern you see rusted weapons and armor adorning the walls.",
                new List<IItems> { },
                new List<IEquipment> { });   
            //10
        public static Room DungeonRoom = new Room("In the dim light from your lantern you see rusted weapons and armor adorning the walls.",
                new List<IItems> { },
                new List<IEquipment> { });        
            //11
        public static Room CrumblingHall = new Room("In the dim light from your lantern you see rusted weapons and armor adorning the walls.",
                new List<IItems> { },
                new List<IEquipment> { });    
            //12
        public static Room Antechamber = new Room("In the dim light from your lantern you see rusted weapons and armor adorning the walls.",
                new List<IItems> { },
                new List<IEquipment> { });   
            //13
        public static Room TheHorde = new Room("In the dim light from your lantern you see rusted weapons and armor adorning the walls.",
                new List<IItems> { },
                new List<IEquipment> { });

        public void Run()
        {
            ConnectRooms();

            Console.Clear();
            Console.WriteLine("You stand before the gaping maw of a long dead monstrosity " +
                "that once guarded the entrance to this den of evil.\n" +
                "You must venture inside and slay the ancient evil that threatens all that you know.\n" +
                "You set forth into the depths holding only a dim lantern and a quarterstaff.");
            Console.ReadKey();
            bool alive = true;
            Room currentRoom = EntryHall;

            while (alive)
            {
                Console.Clear();
                Console.WriteLine(currentRoom.OnEntry);
                bool foundExit = false;

                string command = Console.ReadLine().ToLower();
                if (command.StartsWith("go "))
                {
                    foreach(string exit in currentRoom.Exits.Keys)
                    {
                        if(command.Contains(exit))
                        {
                            currentRoom = currentRoom.Exits[exit];
                            foundExit = true;
                            break;
                        }
                    }
                    if(!foundExit)
                    {
                        Console.WriteLine("Where to?");
                    }
                }
                else if (command.StartsWith("look "))
                {
                    Console.WriteLine("Look at what?");
                }
                else if (command.StartsWith("get ") || command.StartsWith("grab ") || command.StartsWith("take "))
                {
                    Console.WriteLine("Get what?");
                }
                else if (command.StartsWith("use "))
                {
                    Console.WriteLine("Use What?");
                }
                else
                {
                    Console.WriteLine("I don't understand.");
                }
            }
        }
        public void ConnectRooms()
        {
            EntryHall.Exits = new Dictionary<string, Room>
            {
                {"north", FirstFork }
            };
            FirstFork.Exits = new Dictionary<string, Room>
            {
                { "west", GuardRoom },
                { "east", HallBend },
                { "south", EntryHall }
            };
            GuardRoom.Exits = new Dictionary<string, Room>
            {
                { "east", FirstFork }
            };
            HallBend.Exits = new Dictionary<string, Room>
            {
                { "north", FirstT },
                { "west", FirstFork }
            };
        }
    }
}
