using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAndDragons.Items
{
    public interface IItems
    {
        string Name { get; }
        string Description { get; }
        void Use();
    }
}
