using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RandomGamePicker.Classes;

namespace RandomGamePickerTests
{
    [TestClass]
    public class RandomGamePickerTests
    {
        TestDataAccess TestData;
        GameData StoredMockData;
        OutputToTestDataStorage LogOutput;
        Menu Menu;

        [TestInitialize]
        public void TestInitalise()
        {
            TestData = new TestDataAccess();
            StoredMockData = new GameData(TestData);

            LogOutput = new OutputToTestDataStorage();
            Menu = new Menu(LogOutput);
        }

        [TestMethod]
        public void When_the_program_starts_the_number_of_available_games_will_be_printed()
        {

        }
    }
}