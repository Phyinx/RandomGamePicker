using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RandomGamePicker.Classes;

namespace RandomGamePickerTests
{
    [TestClass]
    public class RandomGamePickerTests
    {
        TestDataStorage TestData;
        TestDataAccess DataAccess;
        GameData StoredMockCSV;
        OutputToTestDataStorage LogOutput;
        Menu Menu;
        public void Setup(string[] mock_data, int[] commands)
        {
            TestData = new TestDataStorage(mock_data, commands, 200); //Store mock CSV into storage class

            DataAccess = new TestDataAccess(); //Create a mock file reader that conforms to IFileAccess interface

            StoredMockCSV = new GameData(DataAccess); //Create GameData class (holds game data to avoid repeated reads of CSV)...
                                                     //and give it something that conforms to IFileAccess, in this case the...
                                                     //mock file reader, which reads the mock csv data in TestDataStorage

            LogOutput = new OutputToTestDataStorage(); //Create an output class that conforms to IOutput interface
                                                       //This will allow for menu output to be logged...
                                                       //without the need for two separate menu classes

            Menu = new Menu(LogOutput, StoredMockCSV); //Create the menu with something that conforms to IOutput
                                                       //Also give it a GameData so the menu has access to the game list
        }

        [TestMethod]
        public void When_the_program_starts_the_number_of_available_games_will_be_printed()
        {
            string[] mock_data = {"Game 1", "Game 2", "Game 3", "Game 4", "Game 5" };
            int[] commands = {};

            Setup(mock_data, commands);
            Menu.Run();

            string[] console_output = TestData.GetConsoleOutput();
            string[] expected_output = { "Available games: 5" };
            Assert.AreEqual(expected_output[0], console_output[0]);
        }

        [TestMethod]
        public void When_the_program_starts_print_a_menu()
        {
            string[] mock_data = { "Game 1", "Game 2", "Game 3", "Game 4", "Game 5" };
            int[] commands = { };

            Setup(mock_data, commands);
            Menu.Run();

            string[] console_output = TestData.GetConsoleOutput();
            string[] expected_output = { "1: Pick game",
                                         "2: Show list of games",
                                         "3: Add game",
                                         "4: Remove game" };

            for (int i = 0; i < expected_output.Length; i++)
            {
                Assert.AreEqual(expected_output[i], console_output[ (i + 1) ]); //+1 is to skip "Available Games" printing
            }
        }

        [TestMethod]
        public void A_game_is_randomly_picked_from_the_list()
        {
            string[] mock_data = { "Game 1", "Game 2", "Game 3", "Game 4", "Game 5" };
            int[] commands = { };

            Setup(mock_data, commands);
            Menu.Run();

            string[] console_output = TestData.GetConsoleOutput();
        }
    }
}