using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORGrocery
{
    public interface IItemHandler
    {
        IItemHandler Next { get; set; }

        void Handle(string items);
    }
}
