using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RandomGamePicker.Interfaces;

namespace RandomGamePicker.Classes
{
    public class Menu
    {
        public enum Accepted_Commands
        {
            pick_game = '1',
            list_games = '2',
            add_game = '3',
            remove_game = '4'
        }

        public Menu(IOutput Output)
        {

        }

        public void Run()
        {

        }
    }
}
