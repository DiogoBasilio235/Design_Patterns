﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class RightCommand : ICommand
    {
        public void Invoke()
        {
            Console.Write("Right ");
            Program.x++;
        }
        public void Undo()
        {
            Console.Write("Left ");
            Program.x--;
        }
    }
}
