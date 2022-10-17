using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace delegatePractice
{
    class delegateRun
    {
        ConsoleMenu Menu;
        public delegateRun()
        {
            Menu = new ConsoleMenu(); 
        }
        public void Run()
        {
            CreateMenu();
            while(true)
            {
                Menu.show();
                Menu.read();
            }

        }

        private void CreateMenu()
        {
            MenuItem item = new MenuItem("1", "Menu_Title_1");
            item.MenuKeyPressEventHandler += Menu1_callback;
            Menu.MenuList.Add(item);

            item = new MenuItem("2", "Menu_Title_2");
            item.MenuKeyPressEventHandler += Menu2_callback;
            Menu.MenuList.Add(item);

            item = new MenuItem("q", "프로그램 종료");
            item.MenuKeyPressEventHandler += Quit_callback;
            Menu.MenuList.Add(item);

        }

        private void Quit_callback(object sender, EventArgs menuArgs)
        {
            Console.WriteLine($"Quit_callback 호출됨 sender = {sender.ToString()}, args = {((MenuKeyPressArgs)menuArgs).MenuChar}");
            Console.WriteLine("bye...");
            Environment.Exit(0);
        }

        private void Menu1_callback(object sender, EventArgs menuArgs)
        {
            Console.WriteLine($"Menu1_callback 호출됨 sender = {sender.ToString()}, args = {((MenuKeyPressArgs)menuArgs).MenuChar}");
        }
        private void Menu2_callback(object sender, EventArgs menuArgs)
        {
            Console.WriteLine($"Menu2_callback 호출됨 sender = {sender.ToString()}, args = {((MenuKeyPressArgs)menuArgs).MenuChar}");
        }
       
    }
}
