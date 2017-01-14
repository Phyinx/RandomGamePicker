using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using RandomGamePicker.Interfaces;

namespace RandomGamePicker.Classes.Interface_Classes
{
    public class CSVAccess : IFileAccess
    {
        /*
        Untestable using asserts
        Use Moq to ensure that it is called using normal program operation?
        See the TRG for examples
        */

        public string[] ReadCsv(string pathToCsv)
        { 
            if (File.Exists(pathToCsv))
            {
                string[] csvData = File.ReadAllLines(pathToCsv);
                return csvData;
            }
            else
            {
                string[] blank = { "", "NO_CSV" };
                return blank;
            }
        }
    }
}
