using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace delegatePractice
{
    class MenuItem
    {
        //public delegate void MenuKeyPressedDelegate(object sender, EventArgs menuArgs);
        public event EventHandler MenuKeyPressEventHandler;
        public string MenuChar { get; set; }
        public string MenuTitle { get; set; }
        //public MenuKeyPressedDelegate KeyPressedDelegate { get; set; } //func(sender, menuArgs)

        public MenuItem(string menu_char, string menu_title)
        {
            MenuChar = menu_char;
            MenuTitle = menu_title;
            //KeyPressedDelegate = del;
        }

        public MenuItem() : this(null, null)
        {

        }

        public void CallEvent(object sender, string args)
        {
            if(MenuKeyPressEventHandler != null)
            {
                MenuKeyPressEventHandler(sender, new MenuKeyPressArgs(args));
            }
        }
    }
}
