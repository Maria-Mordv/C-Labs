﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3.MenuItems
{
    public abstract class MenuItemCore
    {
        public abstract string Title { get; }

        public abstract void Execute();
    }
}
