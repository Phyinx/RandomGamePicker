using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RandomGamePicker.Classes;
using RandomGamePicker.Classes.Interface_Classes;
using RandomGamePicker.Interfaces;

namespace RandomGamePicker
{
    class Program
    {
        static void Main(string[] args)
        {
            CSVAccess FileAccessor = new CSVAccess();
            GameData Games = new GameData(FileAccessor);

            OutputToConsole ConsoleOutput = new OutputToConsole();
            Menu MenuSystem = new Menu(ConsoleOutput, Games);

            MenuSystem.Run();

            Console.ReadLine();
        }
    }
}
