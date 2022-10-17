using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace delegatePractice
{
    class ConsoleMenu
    {
        public List<MenuItem> MenuList { get; set; }
        public ConsoleMenu()
        {
            MenuList = new List<MenuItem>();
        }
        public void show()
        {
            foreach(MenuItem item in MenuList)
                Console.WriteLine($"{item.MenuChar} {item.MenuTitle}");
            Console.WriteLine();

        }
        public void read()
        {
            Console.Write("메뉴를 선택하시오:");
            string retVal = Console.ReadLine();
            foreach(MenuItem item in MenuList)
            {
                //if (item.MenuChar == retVal && item.KeyPressedDelegate != null)
                if (item.MenuChar == retVal)
                {
                    //delegate 호출
                    item.CallEvent(this, retVal); 
                }
            }
        }
    }
}
