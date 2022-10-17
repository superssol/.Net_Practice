using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace delegatePractice
{
    //class MenuArgs
    //{
    //}

    class MenuKeyPressArgs : EventArgs
    {
        public string MenuChar { get; set; }
        public MenuKeyPressArgs(string menu_char)
        {
            MenuChar = menu_char;
        }
    }
}
