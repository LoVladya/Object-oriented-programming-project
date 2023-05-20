using Object_oriented_programming_project.Class.GUI;
using Object_oriented_programming_project.GUI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Windows.Input;

namespace Object_oriented_programming_project
{
    internal class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Application.SetCompatibleTextRenderingDefault(false);
            //MotorConsole gameConsole = new MotorConsole();
            //gameConsole.GameProcess();

            MotorGUI gameGUI = new MotorGUI();
            Application.Run(gameGUI.mainForm);
        }
    }
}