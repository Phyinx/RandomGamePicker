using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RandomGamePicker.Classes;

namespace RandomGamePickerTests
{
    [TestClass]
    public class RandomGamePickerTests
    {
        [TestMethod]
        public void When_the_program_starts_the_number_of_available_games_will_be_printed()
        {
            TestDataAccess TestData = new TestDataAccess();
            GameData StoredMockData = new GameData(TestData);

            OutputToTestDataStorage LogOutput = new OutputToTestDataStorage();
            Menu Menu = new Menu(LogOutput);
        }
    }
}