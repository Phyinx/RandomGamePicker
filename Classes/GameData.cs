using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RandomGamePicker.Interfaces;

namespace RandomGamePicker.Classes
{
    public class GameData
    {
        static private string[] GameList;
        private string Path = "./Games.csv";

        public GameData(IFileAccess File)
        {
            GameList = File.ReadCsv(Path);
        }

        public string[] GetGameList()
        {
            return GameList;
        }
    }
}
