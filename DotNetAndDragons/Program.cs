using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAndDragons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProgramUI ui = new ProgramUI();
            Console.SetWindowSize(101, 30);
            ui.Run();
        }
    }
}
