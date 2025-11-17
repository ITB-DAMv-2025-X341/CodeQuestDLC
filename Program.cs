using System;

namespace CodeQuestDLC
{
    public class Program
    {
        public static void Main()
        {
            //MENU MESSAGES
            const string msgMainMenu = "===== MAIN MENU - CODEQUEST =====";
            const string msgMenuPlayer = "===== Welcome, {0} the {1} with level {2} =====";
            const string msgMenuOption1 = "1. Train your wizard"; 
            const string msgMenuOption2 = "2. Increase LVL";
            const string msgMenuOption3 = "3. Loot the mine";
            const string msgMenuOption4 = "4. Show inventory";
            const string msgMenuOption5 = "5. Buy items";
            const string msgMenuOption6 = "6. Show attacks by LVL";
            const string msgMenuOption7 = "7. Decode ancient Scroll";
            const string msgMenuOption8 = "0. Exit game";
            const string msgMenuOptionBlocked = " (Blocked)";
            const string msgMenuOptionNew = " (New!)";
            const string msgMenuOptionUpdated = " (Updated!)";

            //TITTLE MESSAGES
            const string titleLevel0 = "Raoden el Elantrí";
            const string titleLevel1 = "Zyn el Buguejat";
            const string titleLevel2 = "Arka Nullpointer";
            const string titleLevel3 = "Elarion de les Brases";
            const string titleLevel4 = "ITB-Wizard el Gris";
            
            //CHAPTER 1 MESSAGES
            const string msgInitialTraining = "Started training for {0} days.";
            
            
            //Menu variables
            int menuOption;
            string menuOptionStr;

            //Random value
            var rand = new Random();
            
            //Player variables
            string name = "";
            string title = "";
            int level = 0;
            
            //Chapter 1 variables
            int exp = 0;
            const int trainingDays = 5;
            const int maxTrainingHours = 24;
            const int maxTrainingExp = 10;
            
            
            do
            {
                do
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine(msgMainMenu);
                    Console.WriteLine(name.Equals("") ? null : string.Format(msgMenuPlayer,name,title,level));
                    Console.Write(msgMenuOption1);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(msgMenuOptionNew);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write(msgMenuOption2);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(msgMenuOptionBlocked);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write(msgMenuOption3);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(msgMenuOptionBlocked);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write(msgMenuOption4);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(msgMenuOptionBlocked);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write(msgMenuOption5);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(msgMenuOptionBlocked);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write(msgMenuOption6);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(msgMenuOptionBlocked);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write(msgMenuOption7);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(msgMenuOptionBlocked);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine(msgMenuOption8);
                    menuOptionStr = Console.ReadLine();
                } while (!int.TryParse(menuOptionStr, out menuOption));

                switch (menuOption)
                {
                    case 1:
                        break;
                }
            } while (menuOption != 0);
        }
    }
}