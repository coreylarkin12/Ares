﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capstone.Classes;

namespace Capstone
{
    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine VM = new VendingMachine();
            UserInterface UI = new UserInterface(VM);
            UI.Run();
        }
    }
}
