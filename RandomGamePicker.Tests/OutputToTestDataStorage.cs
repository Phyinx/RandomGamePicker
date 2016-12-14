using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RandomGamePicker.Interfaces;

namespace RandomGamePickerTests
{
    public class OutputToTestDataStorage : IOutput
    {
        private TestDataStorage m_dataStorage;
        public OutputToTestDataStorage()
        {
            m_dataStorage = new TestDataStorage();
        }
        
        public void Print(string textToPrint)
        {
            m_dataStorage.AddToConsoleOutput(textToPrint);
        }
    }
}
