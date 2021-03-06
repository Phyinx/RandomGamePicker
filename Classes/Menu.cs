﻿using System;
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

        private IOutput m_Output;
        private GameData m_Games;

        public Menu(IOutput Output, GameData GameData)
        {
            m_Output = Output;
            m_Games = GameData;
        }

        public void Run()
        {
            string textToPrint = "Available games: ";
            textToPrint += CountGames().ToString();
            m_Output.Print(textToPrint);

            PrintMenu();
        }

        private void PrintMenu()
        {
            string[] menuDisplay = { "1: Pick game", "2: Show list of games", "3: Add game","4: Remove game" };
            for (int i = 0; i < menuDisplay.Length; i++)
            {
                m_Output.Print(menuDisplay[i]);
            }
        }

        //Private functions
        private int CountGames()
        {
            string[] games = m_Games.GetGameList();
            return games.Count();
        }
    }
}
