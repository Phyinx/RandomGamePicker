using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomGamePickerTests
{
    class TestDataStorage
    {
        private string[] Data; //Holds the mockCSV data for the file accessor to pull.
        private int[] Commands; //Remember to convert these to strings before giving them to Menu
        private string[] Console_Output;
        public TestDataStorage(string[] mock_data, int[] commands)
        {

        }

        public string[] GetConsoleOutput()
        {
            return Console_Output;
        }
    }
}
