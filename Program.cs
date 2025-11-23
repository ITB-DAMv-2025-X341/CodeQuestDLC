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
            const string msgMenuPlayer = "===== Welcome, {0} the {1} with level {2} =====\n";
            const string msgMenuPlayerResources = "Bits: {0} | Inventory slots: {1}\n";
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
            const string msgCh1AskName = "Tell us your name wizard: ";
            const string msgCh1InitialTraining = "Started training for {0} days.";
            const string msgCh1DayTrained = "You trained for {0} hours and gained {1} exp.";
            const string msgCh1RankObtained = "Congratulations {0}, you reached the tittle of {1}";
            
            //CHAPTER 2 MESSAGES
            const string msgCh2EnteredFight = "You will fight a {0}!";
            const string msgCh2HealthLeft = "The {0} has {1} HP left";
            const string msgCh2PressToRoll = "Press Enter to roll the dice";
            const string msgCh2Win = "You defeated a {0}!";
            const string msgCh2MaxLevel = "You are at max level ({0})!";
            const string msgCh2NewLevel = "You leveled up! You are level {0}";
            
            //CHAPTER 3 MESSAGES
            const string msgCh3EnterMine = "You entered the mine.";
            const string msgCh3TriesLeft = "You have {0} tries left.";
            const string msgCh3FoundCoin = "You found a coin! you win {0} bits";
            const string msgCh3FoundNothing = "You mined and founded nothing.";
            const string msgCh3MapLayout = "[{0}]";
            const string msgCh3MineSelect = "Select where you want to mine: {0} [1, {1}]";
            const string msgCh3AlreadyMined = "You already mined this location. Try another one.";
            const string msgCh3MineOutOfTries = "You are out of tries! You exit the mine with now {0} bits.";
            
            //CHAPTER 4 MESSAGES
            const string msgCh4InventoryHeader = "===== INVENTORY =====";
            
            //CHAPTER 5 MESSAGES
            const string msgCh5ShopHeader = "===== WELCOME TO THE SHOP =====";
            const string msgCh5SelectItem = "Select the item number you want to buy: ";
            const string msgCh5NotEnoughBits = "You don't have enough bits to buy this item.";
            const string msgCh5ItemBought = "You bought a {0}!";
            
            //CHAPTER 6 MESSAGES
            const string msgCh6AttacksHeader = "===== ATTACKS =====";
            
            //CHAPTER 7 MESSAGES
            const string msgCh7DecodeHeader = "===== ANCIENT SCROLL =====";
            const string msgCh7Intro = "You fund a mysterious ancient scroll. You try to decode it:";
            const string msgCh7DecodeOptions = "Choose an option to decode the scroll:\n{0}\n{1}\n{2}";
            const string msgCh7DecodeOp1 = "1. Decipher spell (remove spaces)";
            const string msgCh7DecodeOp2 = "2. Count magical runes (vowels)";
            const string msgCh7DecodeOp3 = "3. Extract secret code (numbers)";
            const string msgCh7DecodeSuccess = "You have successfully decoded all parts of the scroll";
            const string msgCh7IncorrectOption = "Incorrect option selected.";
            const string msgCh7DecodedLine1 = "Deciphered Spell: {0}";
            const string msgCh7DecodedLine2 = "Number of Magical Runes: {0}";
            const string msgCh7DecodedLine3 = "Extracted Secret Code: {0}";
            const string msgCh7DecodeOp4 = "Exit decoding";
            
            
            //CHAPTER 2 CONSTANTS
            string[] monstersName = { "Wandering Skeleton 💀", "Forest Goblin 👹", "Green Slime 🟢", "Ember Wolf 🐺", "Giant Spider 🕷️", "Iron Golem 🤖", "Lost Necromancer 🧝‍", "Ancient Dragon 🐉" };
            int[] monstersHp = { 3, 5, 10, 11, 18, 15, 20, 50 };
            string[] dice = { "   ________\n  /       /|\n /_______/ |\n |       | |\n |   o   | /\n |       |/\n '-------'", "   ________\n  /       /|\n /_______/ |\n | o     | |\n |       | /\n |     o |/\n '-------'", "   ________\n  /       /|\n /_______/ |\n | o     | |\n |   o   | /\n |     o |/\n '-------'", "   ________\n  /       /|\n /_______/ |\n | o   o | |\n |       | /\n | o   o |/\n '-------'", "   ________\n  /       /|\n /_______/ |\n | o   o | |\n |   o   | /\n | o   o |/\n '-------'", "   ________\n  /       /|\n /_______/ |\n | o   o | |\n | o   o | /\n | o   o |/\n '-------'" };

            //CHAPTER 3 CONSTANTS
            const int mapWidth = 5;
            const int mapHeight = 5;
            const int startingTries = 5;
            
            //CHAPTER 5 CONSTANTS
            string[] shopItems = { "Iron Dagger 🗡️", "Healing Potion ⚗️", "Ancient Key 🗝️", "Crossbow 🏹", "Metal Shield 🛡️"};
            int[] shopItemsPrice = { 30, 10, 50, 40, 20 };
            
            //CHAPTER 6 CONSTANTS
            string[][] attacksLvl =
            {
                new string[] { "Magic Spark 💫" },
                new string[] { "Fireball 🔥", "Ice Ray 🥏", "Arcane Shield ⚕️" },
                new string[] { "Meteor ☄️", "Pure Energy Explosion 💥", "Minor Charm 🎭", "Air Strike 🍃" },
                new string[] { "Wave of Light ⚜️", "Storm of Wings 🐦" },
                new string[] { "Cataclysm 🌋", "Portal of Chaos 🌀", "Arcane Blood Pact 🩸", "Elemental Storm ⛈️" },
            };
            
            //CHAPTER 7 CONSTANTS
            string[] acientScroll = 
            {
                "The 🐲 sleeps in the mountain of fire 🔥",
                "Ancient magic flows through the crystal caves",
                "Spell: Ignis 5 🔥, Aqua 6 💧, Terra 3 🌍, Ventus 8 🌪️️"
            };
            
            //Menu variables
            int menuOption;
            string menuOptionStr;

            //Random value
            var rand = new Random();
            
            //Player variables
            string name = "";
            string title = "";
            int level = 0;
            int bits = 0;
            string[] inventory = new string[0];
            
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
            string posXStr, posYStr;
            int posXin, posYin;
            
            //Chapter 5 variables
            int shopOption;
            string shopOptionStr;
            
            //Chapter 7 variables
            bool decoded = false;
            int decodeOption;
            string decodeOptionStr;
            bool line1Decoded = false;
            bool line2Decoded = false;
            bool line3Decoded = false;
            
            do
            {
                do
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine(msgMainMenu);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(name.Equals("") ? null : string.Format(msgMenuPlayer,name,title,level));
                    Console.Write(bits == 0 ? null : string.Format(msgMenuPlayerResources,bits,inventory.Length));
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine(msgMenuOption1);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine(msgMenuOption2);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine(msgMenuOption3);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine(msgMenuOption4);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine(msgMenuOption5);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine(msgMenuOption6);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write(msgMenuOption7);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(msgMenuOptionNew);
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
                    /*
                     * CHAPTER 1 - TRAINING
                     */
                    case 1:
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write(msgCh1AskName);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        name = Console.ReadLine();
                        Console.WriteLine(msgCh1InitialTraining);
                        for (int i = 0; i < 5; i++)
                        {
                            int dayExp = rand.Next(1, maxTrainingExp+1);
                            int trainingHours = rand.Next(1, maxTrainingHours + 1);
                            Console.WriteLine(msgCh1DayTrained,trainingHours,dayExp);
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
                        Console.WriteLine(msgCh1RankObtained,name,title);
                        break;
                    /*
                     * CHAPTER 2 - LEVEL UP
                     */
                    case 2:
                        monsterIndex = rand.Next(0, monstersName.GetLength(0));
                        monster = monstersName[monsterIndex];
                        monsterHeath = monstersHp[monsterIndex];
                        Console.WriteLine(msgCh2EnteredFight,monster);
                        while (monsterHeath > 0)
                        {
                            Console.WriteLine(msgCh2HealthLeft,monster,monsterHeath);
                            Console.Write(msgCh2PressToRoll);
                            Console.ReadLine();
                            diceNumber = rand.Next(1, 7);
                            Console.WriteLine(dice[diceNumber-1]);
                            monsterHeath -= diceNumber;
                        }
                        Console.WriteLine(msgCh2Win, monster);
                        level = (level == 5) ? 5 : level + 1;
                        Console.WriteLine(level == 5 ? $"{msgCh2MaxLevel}" : $"{msgCh2NewLevel}", level);
                        break;
                    /*
                     * CHAPTER 3 - LOOT THE MINE
                     */
                    case 3:
                        //Setup map
                        for (int w = 0; w < backMap.GetLength(0); w++)
                        {
                            for (int h = 0; h < backMap.GetLength(1); h++)
                            {
                                int randValue = rand.Next(0, 5);
                                backMap[w, h] = randValue == 1 ? "1" : "0";
                            }
                        }
                        for (int w = 0; w < backMap.GetLength(0); w++)
                        {
                            for (int h = 0; h < backMap.GetLength(1); h++)
                            {
                                frontMap[w, h] = "➖";
                            }
                        }
                        
                        Console.WriteLine(msgCh3EnterMine);
                        tries = startingTries;
                        while (tries > 0)
                        {
                            tries--;
                            for (int w = 0; w < frontMap.GetLength(0); w++)
                            {
                                for (int h = 0; h < frontMap.GetLength(1); h++)
                                {
                                    Console.Write(msgCh3MapLayout, frontMap[w,h]);
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine(msgCh3TriesLeft, tries + 1);
                            do
                            {
                                Console.WriteLine(msgCh3MineSelect, "X", frontMap.GetLength(0));
                                posXStr = Console.ReadLine();
                            } while (!int.TryParse(posXStr, out posXin) || posXin < 1 || posXin > frontMap.GetLength(0));

                            do
                            {
                                Console.WriteLine(msgCh3MineSelect, "Y", frontMap.GetLength(1));
                                posYStr = Console.ReadLine();
                            } while (!int.TryParse(posYStr, out posYin) || posYin < 1 || posYin > frontMap.GetLength(1));

                            int posX = posXin - 1, posY = posYin - 1;
                            
                            if (frontMap[posX, posY] != "➖")
                            {
                                Console.WriteLine(msgCh3AlreadyMined);
                                tries++;
                            }
                            else
                            {
                                if (backMap[posX, posY] == "1")
                                {
                                    bits += rand.Next(1, 51);
                                    frontMap[posX, posY] = "🪙";
                                    Console.WriteLine(msgCh3FoundCoin, bits);
                                }
                                else
                                {
                                    frontMap[posX, posY] = "❌";
                                    Console.WriteLine(msgCh3FoundNothing);
                                }
                            }
                        }
                        
                        Console.WriteLine(msgCh3MineOutOfTries, bits);
                        break;
                    /*
                     * CHAPTER 4 - SHOW INVENTORY
                     */
                    case 4:
                        Console.WriteLine(msgCh4InventoryHeader);
                        //Cycle for slot in inventory
                        foreach (string slot in inventory)
                        {
                            //Show slot
                            Console.WriteLine(slot);
                        }
                        break;
                    
                    /*
                     * CHAPTER 5 - BUY ITEMS
                     */
                    case 5:
                        Console.WriteLine(msgCh5ShopHeader);
                        
                        //Display all items
                        for (int i = 0; i < shopItems.Length; i++)
                        {
                            string item = shopItems[i];
                            int price = shopItemsPrice[i];
                            Console.WriteLine($"{i}. {item} - {price} bits");
                        }

                        //Select item to buy
                        do
                        {
                            Console.Write(msgCh5SelectItem);
                            shopOptionStr = Console.ReadLine();
                        } while (!int.TryParse(shopOptionStr, out shopOption));

                        //Check if enough bits
                        if (bits >= shopItemsPrice[shopOption])
                        {
                            //Buy item
                            bits -= shopItemsPrice[shopOption];
                            Array.Resize(ref inventory, inventory.Length + 1);
                            inventory[inventory.Length - 1] = shopItems[shopOption];
                            Console.WriteLine(msgCh5ItemBought, shopItems[shopOption]);
                        }
                        else
                        {
                            Console.WriteLine(msgCh5NotEnoughBits);
                        }
                        break;
                    
                    /*
                     * CHAPTER 6 - SHOW ATTACKS BY LVL
                     */
                    case 6:
                       Console.WriteLine(msgCh6AttacksHeader);
                       for (int i = 1; i <= level; i++)
                       {
                           foreach (var attack in attacksLvl[i - 1])
                           {
                               Console.WriteLine($"- {attack}");
                           }
                       }
                        break;
                    
                    /*
                     * CHAPTER 7 - DECODE ANCIENT SCROLL
                     */
                    case 7:
                        //Show messages
                        Console.WriteLine(msgCh7DecodeHeader);
                        Console.WriteLine(msgCh7Intro);
                        do
                        {
                            foreach (var line in acientScroll)
                            {
                                Console.WriteLine(line);
                            }
                            Console.WriteLine(msgCh7DecodeOptions, msgCh7DecodeOp1, msgCh7DecodeOp2, msgCh7DecodeOp3, msgCh7DecodeOp4);
                            //Select decode option
                            do
                            {
                                decodeOptionStr = Console.ReadLine();
                            } while (!int.TryParse(decodeOptionStr, out decodeOption) || decodeOption < 1 || decodeOption > 3);
                            //Decode scroll
                            switch (decodeOption)
                            {
                                case 1:
                                    //Decipher spell (remove spaces)
                                    Console.WriteLine(msgCh7DecodedLine1, acientScroll[0].Replace(" ", ""));
                                    line1Decoded = true;
                                    break;
                                case 2:
                                    //Count magical runes (vowels)
                                    string lowerLine = acientScroll[1].ToLower();
                                    int vowelCount = 0;
                                    foreach (char c in lowerLine)
                                    {
                                        if ("aeiouàèéíòóú".Contains(c))
                                        {
                                            vowelCount++;
                                        }
                                    }
                                    Console.WriteLine(msgCh7DecodedLine2, vowelCount);
                                    line2Decoded = true;
                                    break;
                                case 3:
                                    //Extract secret code (numbers)
                                    string numbers = "";

                                    foreach (char c in acientScroll[2])
                                    {
                                        if (char.IsDigit(c))
                                        {
                                            numbers += c;
                                        }
                                    }
                                    Console.WriteLine(msgCh7DecodedLine3, numbers);
                                    line3Decoded = true;
                                    break;
                                default:
                                    Console.WriteLine(msgCh7IncorrectOption);
                                    break;
                            }
                            //Check if all lines decoded
                            if (line1Decoded && line2Decoded && line3Decoded)
                            {
                                Console.WriteLine(msgCh7DecodeSuccess);
                            }
                        } while (decodeOption != 4 && !(line1Decoded && line2Decoded && line3Decoded));
                        break;
                    
                    /*
                     * INCORRECT OPTION
                     */
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(msgMenuIncorrectOption);
                        break;
                }
            } while (menuOption != 0);
        }
    }
}