using System;
using System.Text;

namespace CodeQuestDLC
{
    public class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = new UTF8Encoding();
            
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
            const string msgMenuIncorrectOption = "Incorrect option selected\nTry again.";
            const string msgMenuExit = "Exiting...";
            
            //TITTLE MESSAGES
            const string titleLevel0 = "Raoden el Elantrí";
            const string titleLevel1 = "Zyn el Buguejat";
            const string titleLevel2 = "Arka Nullpointer";
            const string titleLevel3 = "Elarion de les Brases";
            const string titleLevel4 = "ITB-Wizard el Gris";
            
            //CHAPTER 1 MESSAGES
            const string msgAskName = "Tell us your name wizard: ";
            const string msgInitialTraining = "Started training for {0} days.";
            const string msgDayTrained = "You trained for {0} hours and gained {1} exp.";
            const string msgRankObtained = "Congratulations {0}, you reached the tittle of {1}";
            
            //CHAPTER 2 MESSAGES
            const string msgEnteredFight = "You will fight a {0}!";
            const string msgHealthLeft = "The {0} has {1} HP left";
            const string msgPressToRoll = "Press Enter to roll the dice";
            const string msgWin = "You defeated a {0}!";
            const string msgMaxLevel = "You are at max level ({0})!";
            const string msgNewLevel = "You leveled up! You are level {0}";
            
            //CHAPTER 3 MESSAGES
            const string msgEnterMine = "You entered the mine.\nYou have {0} tries to mine for gold.";
            const string msgTriesLeft = "You have {0} tries left.";
            const string msgFoundCoin = "You found a coin! you win {0} bits";
            const string msgFoundNothing = "You mined and founded nothing.";
            const string msgMapLayout = "[{0}]";
            const string msgMineSelect = "Select where you want to mine: {0} [1, {1}]";
            
            //CHAPTER 2 CONSTANTS
            string[] monstersName = { "Wandering Skeleton 💀", "Forest Goblin 👹", "Green Slime 🟢", "Ember Wolf 🐺", "Giant Spider 🕷️", "Iron Golem 🤖", "Lost Necromancer 🧝‍", "Ancient Dragon 🐉" };
            int[] monstersHp = { 3, 5, 10, 11, 18, 15, 20, 50 };
            string[] dice = { "   ________\n  /       /|\n /_______/ |\n |       | |\n |   o   | /\n |       |/\n '-------'", "   ________\n  /       /|\n /_______/ |\n | o     | |\n |       | /\n |     o |/\n '-------'", "   ________\n  /       /|\n /_______/ |\n | o     | |\n |   o   | /\n |     o |/\n '-------'", "   ________\n  /       /|\n /_______/ |\n | o   o | |\n |       | /\n | o   o |/\n '-------'", "   ________\n  /       /|\n /_______/ |\n | o   o | |\n |   o   | /\n | o   o |/\n '-------'", "   ________\n  /       /|\n /_______/ |\n | o   o | |\n | o   o | /\n | o   o |/\n '-------'" };

            //CHAPTER 3 CONSTANTS
            const int mapWidth = 5;
            const int mapHeight = 5;
            const int startingTries = 5;

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
            
            //Chapter 2 variables
            int diceNumber;
            int monsterIndex;
            string monster;
            int monsterHeath;
            
            //Chapter 3 variables
            string[,] backMap = new string[mapWidth, mapHeight];
            string[,] frontMap = new string[mapWidth, mapHeight];
            int tries;
            
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
                    Console.ForegroundColor = ConsoleColor.Gray;
                    menuOptionStr = Console.ReadLine();
                } while (!int.TryParse(menuOptionStr, out menuOption));

                switch (menuOption)
                {
                    case 0:
                        Console.WriteLine(msgMenuExit);
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write(msgAskName);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        name = Console.ReadLine();
                        Console.WriteLine(msgInitialTraining);
                        for (int i = 0; i < 5; i++)
                        {
                            int dayExp = rand.Next(1, maxTrainingExp+1);
                            int trainingHours = rand.Next(1, maxTrainingHours + 1);
                            Console.WriteLine(msgDayTrained,trainingHours,dayExp);
                            exp += dayExp;
                        }

                        switch (exp)
                        {
                            case > 40:
                                title = titleLevel4;
                                break;
                            case > 35:
                                title = titleLevel3;
                                break;
                            case > 30:
                                title = titleLevel2;
                                break;
                            case > 20:
                                title = titleLevel1;
                                break;
                            case < 20:
                                title = titleLevel0;
                                break;
                            default:
                                title = titleLevel0;
                                break;
                        }
                        Console.WriteLine(msgRankObtained,name,title);
                        break;
                    case 2:
                        monsterIndex = rand.Next(0, monstersName.GetLength(0));
                        monster = monstersName[monsterIndex];
                        monsterHeath = monstersHp[monsterIndex];
                        Console.WriteLine(msgEnteredFight,monster);
                        while (monsterHeath > 0)
                        {
                            Console.WriteLine(msgHealthLeft,monster,monsterHeath);
                            Console.Write(msgPressToRoll);
                            Console.ReadLine();
                            diceNumber = rand.Next(1, 7);
                            Console.WriteLine(dice[diceNumber-1]);
                            monsterHeath -= diceNumber;
                        }
                        Console.WriteLine(msgWin, monster);
                        level = (level == 5) ? 5 : level + 1;
                        Console.WriteLine(level == 5 ? $"{msgMaxLevel}" : $"{msgNewLevel}", level);
                        break;
                    case 3:
                        //Setup map
                        for (int w = 0; w < backMap.GetLength(0); w++)
                        {
                            for (int h = 0; h < backMap.GetLength(1); h++)
                            {
                                backMap[w, h] = rand.Next(0, 5) == 1 ? "1" : "0";
                            }
                        }
                        for (int w = 0; w < backMap.GetLength(0); w++)
                        {
                            for (int h = 0; h < backMap.GetLength(1); h++)
                            {
                                backMap[w, h] = "➖";
                            }
                        }
                        
                        Console.WriteLine(msgEnterMine);
                        tries = startingTries;
                        while (tries > 0)
                        {
                            tries--;
                            for (int w = 0; w < frontMap.GetLength(0); w++)
                            {
                                for (int h = 0; h < frontMap.GetLength(1); h++)
                                {
                                    Console.Write(msgMapLayout, frontMap[w,h]);
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine(msgTriesLeft, tries);
                            
                            //TODO: Finish chapter 3
                        }
                        
                        break;
                        
                    
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(msgMenuIncorrectOption);
                        break;
                }
            } while (menuOption != 0);
        }
    }
}