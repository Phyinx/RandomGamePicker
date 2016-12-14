using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomGamePickerTests
{
    class TestDataStorage
    {
        static private string[] m_Data; //Holds the mockCSV data for the file accessor to pull.
        static private string[] m_ConsoleOutput;

        static private int m_ConsoleOutputIndex = 0;
        static private int m_CommandsIndex = 0;

        static private int[] m_Commands; //Remember to convert these to strings before giving them to Menu
        

        public TestDataStorage(string[] mock_data, int[] commands, int size_of_console_output = 200)
        { //Only used in the tests, for setting up data and commands
            m_Data = mock_data;
            m_Commands = commands;
            m_ConsoleOutput = new string[size_of_console_output];
        }

        public TestDataStorage()
        { //Used when needing to access the data and adding to it, instead of overwriting or setting up

        }

        public string[] GetConsoleOutput()
        {
            return m_ConsoleOutput;
        }

        public string[] GetData()
        {
            return m_Data;
        }

        public string GetNextCommand()
        {
            return "TEMP";
        }

        public void AddToConsoleOutput(string textToAdd)
        {
            m_ConsoleOutput[m_ConsoleOutputIndex] = textToAdd;
            m_ConsoleOutputIndex++;
        }
    }
}
