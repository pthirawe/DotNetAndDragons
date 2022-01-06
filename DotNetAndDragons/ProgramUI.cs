using DotNetAndDragons.Characters;
using DotNetAndDragons.Equipment;
using DotNetAndDragons.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DotNetAndDragons
{
    public class ProgramUI
    {     
        //Create rooms
        //1
        public static Room EntryHall = new Room("You step into the dank entry. The bright light of the outside world doesn't seem to penetrate as far as it should. The only way forward appears to be NORTH",
            new List<IItem> { new HealthPotion() },
            new List<IEquipment> { },
            null);
            //2
        public static Room FirstFork = new Room("The outside light fades rapidly as you continue your trek deeper into the lair.  You see there is a way WEST and a path to the EAST.",
                new List<IItem> { },
                new List<IEquipment> { },
                new GiantRat());
            //3
        public static Room GuardRoom = new Room("In the dim light from your lantern you see rusted weapons and armor adorning the walls.  Perhaps you might find something useful, but otherwise it looks like the only way out is EAST the way you came.",
                new List<IItem> { },
                new List<IEquipment> { },
                null);
            //4
        public static Room HallBend = new Room("The path turns sharply NORTH and the natural cave walls being giving way to rough hewn, but clearly artifical stonework.  The surfaces are cracked and worn.",
                new List<IItem> { },
                new List<IEquipment> { },
                null);    
            //5
        public static Room FirstT = new Room("The path splits.  To the NORTH, you hear faint low rumbling.  To the EAST, a faint metallic smell.",
                new List<IItem> { },
                new List<IEquipment> { },
                null);    
            //6
        public static Room BloodyHall = new Room("The metallic stench grows stronger and parts of the floor appears to have red streaks.  To the WEST, lies the intersection.  To the EAST, the stench seems to grow stronger.",
                new List<IItem> { },
                new List<IEquipment> { },
                null);  
            //7
        public static Room TortureRoom = new Room("As you approach the chamber the stench becomes overpowering.  The source is apparent.  Pools of blood, rotting corpses, decaying body parts.  There doesn't appear to be any way forward through here. You must turn back WEST.",
                new List<IItem> { },
                new List<IEquipment> { },
                null);
            //8
        public static Room SecondT = new Room("Yet another intersection.  The low rumbling seems to be coming from the EAST.  The WEST seems dead silent. SOUTH takes you back towards the entrance.",
                new List<IItem> { },
                new List<IEquipment> { },
                null);    
            //9
        public static Room DankHall = new Room("As you pass, you feel the air grow colder and hear a faint dripping noise further down to the SOUTH. EAST leads back to the intersection.",
                new List<IItem> { },
                new List<IEquipment> { },
                null);   
            //10
        public static Room DungeonRoom = new Room("Chains hanging from the wall restraining emaciated corpses make the purpose of this room clear. The only way out is NORTH the way you came.",
                new List<IItem> { },
                new List<IEquipment> { },
                null);        
            //11
        public static Room CrumblingHall = new Room("Parts of the stonework here has crumbled, others bulged out as though something too large has pushed it's way through.  The destruction seems to lead to the EAST.  To the WEST lies the last intersection.",
                new List<IItem> { },
                new List<IEquipment> { },
                null);    
            //12
        public static Room Antechamber = new Room("The destruction continues here with crushed furniture and the doorways reduced to rubble.  The low rumble now sounds like the snoring of an incredibly immense creature and is coming from a small gap in the NORTH.  The way back lies to the WEST.",
                new List<IItem> { },
                new List<IEquipment> { },
                null);   
            //13
        public static Room TheHorde = new Room("Through the gap the chamber opens into a cavernous space the top of which is lost in darkness.  A soft glitter emanates from mountains of gold, silver, and gems of all kinds.  Anything of value for miles around seems to have been gathered here.  The only way out seems to be to the SOUTH.",
                new List<IItem> { },
                new List<IEquipment> { },
                null);
        // Create a static player
        public static Player player = new Player();

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
            int combatResult;
            Room currentRoom = EntryHall;
            Room previousRoom = null;
            bool foundItem = false;

            while (alive)
            {
                Console.Clear();
                Console.WriteLine(currentRoom.OnEntry);
                bool foundExit = false;
                if (currentRoom.Enemy != null)
                {
                    combatResult = CombatEncounter(player, currentRoom);
                    if(player.Health==0)
                    {
                        alive = false;
                        continue;
                    }
                    else if(combatResult == 0)
                    {
                        Console.WriteLine("You manage to escape the way you came.");
                        currentRoom = previousRoom;
                        previousRoom = null;
                    }
                }

                Console.WriteLine($"\nPlayer:");
                Console.WriteLine($"Name: {player.Name}");
                Console.WriteLine($"Health: {player.Health}");
                Console.WriteLine("");

                string command = Console.ReadLine().ToLower();
                if (command.StartsWith("go "))
                {
                    foreach (string exit in currentRoom.Exits.Keys)
                    {
                        if (command.Contains(exit))
                        {
                            previousRoom = currentRoom;
                            currentRoom = currentRoom.Exits[exit];
                            foundExit = true;
                            foundItem = false;
                            break;
                        }
                    }
                    if (!foundExit)
                    {
                        Console.WriteLine("Where to?");
                    }
                }
                else if (command.StartsWith("look ") || command.StartsWith("search "))
                {
                    if(command.Contains("around") || command.Contains("room"))
                    {
                        Console.WriteLine("You search the room and find...");
                        if(currentRoom.Items.Count==0 && currentRoom.Equipment.Count==0)
                        {
                            Console.WriteLine("nothing...");
                            Console.ReadKey();
                        }
                        else
                        {                            
                            foreach(IItem item in currentRoom.Items)
                            {
                                Console.WriteLine($"A {item.Name}");
                            }
                            foreach(IEquipment equipment in currentRoom.Equipment)
                            {
                                Console.WriteLine($"A {equipment.Name}");
                            }
                            foundItem = true;
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Look at what?");
                        Console.ReadKey();
                    }
                }
                else if (command.StartsWith("get ") || command.StartsWith("grab ") || command.StartsWith("take "))
                {
                    if(!foundItem)
                    {
                        Console.WriteLine("Get what?");
                        Console.ReadKey();
                    }
                    else
                    {
                        IItem newItem = currentRoom.TakeItem(command);
                        if(newItem == null)
                        {
                            Console.WriteLine("Can't find that item.");
                            Console.ReadKey();
                        }
                        else
                        {
                            player.Inventory.Add(newItem);
                            Console.WriteLine($"Added {newItem.Name} to inventory.");
                            Console.ReadKey(); 
                        }
                    }
                }
                else if (command.StartsWith("use "))
                {
                    if(command.Contains("item"))
                    {
                        ItemMenu();
                    }
                    else
                    {
                        Console.WriteLine("Use What?");
                        Console.ReadKey();
                    }

                }
                else
                {
                    Console.WriteLine("I don't understand.");
                }
            }
        }
        public int CombatEncounter(Player player, Room currentRoom)
        {
            bool inCombat = true;
            string action;
            Console.WriteLine("");
            Console.WriteLine($"Monsters! You must defend yourself from the {currentRoom.Enemy.Name}.");

            while(inCombat)
            {
                Console.WriteLine($"Player:".PadRight(30)+$"Enemy:");
                Console.WriteLine($"Name: {player.Name}".PadRight(30)+$"Name: {currentRoom.Enemy.Name}");
                Console.WriteLine($"Health: {player.Health}".PadRight(30)+$"Health: {currentRoom.Enemy.Health}");
                Console.WriteLine("");
                Console.WriteLine("What do you do?\n" +
                    "Attack\n" +
                    "Use Item\n" +
                    "Run");
                action = Console.ReadLine().ToLower();
                Console.WriteLine("");
                switch (action)
                {
                    case "attack"://For now, attacks all monsters
                        Console.WriteLine($"You attack dealing {player.Attack()} damage.");
                        currentRoom.Enemy.TakeDamage(player.Attack());
                        if(currentRoom.Enemy.Health<=0)
                        {
                            Console.WriteLine($"{currentRoom.Enemy.Name} was vanquished!");
                            currentRoom.RemoveMonster(currentRoom.Enemy);
                            return 1;
                        }
                        break;
                    case "use item":
                        ItemMenu();
                        break;
                    case "run": //Not sure how to determine if player ran
                        return 0;
                    default:
                        Console.WriteLine("I don't know what you mean.");
                        break;
                }

                Console.WriteLine($"{currentRoom.Enemy.Name} attacks!  It deals {currentRoom.Enemy.Attack()} damage.");
                player.TakeDamage(currentRoom.Enemy.Attack());
                if(player.Health<=0)
                {
                    return -1;
                }
                Console.ReadKey();
                Console.Clear();
            }
            return -99;
        }

        public void ItemMenu()
        {
            bool valid = true;
            if(player.Inventory.Count<=0)
            {
                Console.WriteLine("You have no items.");
                return;
            }
            do
            {
                Console.WriteLine($"Which item would you like to use?");
                int index = 1;
                int selection;
                foreach(IItem item in player.Inventory)
                {
                    Console.WriteLine($"{index}. {item.Name}: {item.Description}");
                }
                Console.WriteLine("0. Cancel");
                string input = Console.ReadLine();
                valid = Int32.TryParse(input, out selection);
                if(!valid)
                {
                    Console.WriteLine("Invalid selection.  Please enter a number.");
                    Console.ReadKey();
                }
                if(selection == 0)
                {
                    return;
                }
                else
                {
                    UseItem(player.Inventory[selection - 1]);
                }

            }while(!valid);
        }

        public void UseItem(IItem item)
        {
            string effect = item.Use();
            int effectSize = Int32.Parse(Regex.Match(effect, @"\d+").Value);
            if(effect.Contains("heal"))
            {
                Console.WriteLine($"You healed {effectSize} HP.");
                player.Heal(effectSize);
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
            FirstT.Exits = new Dictionary<string, Room>
            {
                { "north", SecondT },
                { "east", BloodyHall },
                { "south", HallBend  }
            };
            BloodyHall.Exits = new Dictionary<string, Room>
            {
                { "west", FirstT },
                { "east", TortureRoom }
            };
            SecondT.Exits = new Dictionary<string, Room>
            {
                { "west", DankHall },
                { "east", CrumblingHall },
                { "south", FirstT }
            };
            DankHall.Exits = new Dictionary<string, Room>
            {
                { "south", DungeonRoom },
                { "east", SecondT }
            };
            DungeonRoom.Exits = new Dictionary<string, Room>
            {
                { "north", DankHall }
            };
            CrumblingHall.Exits = new Dictionary<string, Room>
            {
                { "west", SecondT },
                { "east", Antechamber }
            };
            Antechamber.Exits = new Dictionary<string, Room>
            {
                { "north", TheHorde },
                { "west", CrumblingHall }
            };
            TheHorde.Exits = new Dictionary<string, Room>
            {
                { "south", Antechamber }
            };
        }
    }
}
