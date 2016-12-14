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
        private string Path = "/m_Games.csv";

        public GameData(IFileAccess File)
        {
            if (System.IO.File.Exists(Path))
            {
                GameList = File.ReadCsv(Path);
            }
            else
            {
                //Throw an exception here if the path is invalid
                //ADD A TEST FOR THIS
                //throw new System.ArgumentException("Path invalid");
            }
        }

        public string[] GetGameList()
        {
            return GameList;
        }
    }
}
