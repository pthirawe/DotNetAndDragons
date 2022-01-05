using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAndDragons
{
    public class ProgramUI
    {
        public void Run()
        {
            Console.Clear();
            Console.WriteLine("You stand before the gaping maw of a long dead monstrosity " +
                "that once guarded the entrance to this den of evil.\n" +
                "You must venture inside and slay the ancient evil that threatens all that you know.\n" +
                "You set forth into the depths holding only a dim lantern and a quarterstaff.");
            bool alive = true;

            while (alive)
            {
                string command = Console.ReadLine().ToLower();
                if (command.StartsWith("go "))
                {
                    Console.WriteLine("Where to?");
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
    }
}
