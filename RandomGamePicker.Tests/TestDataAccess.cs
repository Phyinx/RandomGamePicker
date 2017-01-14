using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RandomGamePicker.Interfaces;

namespace RandomGamePickerTests
{
    class TestDataAccess : IFileAccess
    {
        public string[] ReadCsv(string pathToCsv)
        {
            TestDataStorage data = new TestDataStorage();
            return data.GetData();
        }
    }
}
