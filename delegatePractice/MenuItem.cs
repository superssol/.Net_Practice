using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace delegatePractice
{
    class MenuItem
    {
        public delegate void MenuKeyPressedDelegate(object sender, MenuArgs menuArgs);
        public string MenuChar { get; set; }
        public string MenuTitle { get; set; }
        public MenuKeyPressedDelegate KeyPressedDelegate { get; set; } //func(sender, menuArgs)

        public MenuItem(string menu_char, string menu_title, MenuKeyPressedDelegate del)
        {
            MenuChar = menu_char;
            MenuTitle = menu_title;
            KeyPressedDelegate = del;
        }

        public MenuItem() : this(null, null, null)
        {

        }
    }
}
