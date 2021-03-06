﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HelloWorld
{
    struct Item
    {
        public string name;
        public string type;
        public float statBoost;
        public int cost;
        public float level;
    }
    class Game
    {
        private readonly Random rand = new Random();

        private bool _gameOver = false;
        private Player _player1;
        private Entity _enemy;
        private Shop _potionShop;
        private Shop _weaponShop;
        private Shop _shieldShop;
        private Item[] _potionInv;
        private Item[] _weaponInv;
        private Item[] _shieldInv;
        private Item _empty;
        private Item _sword;
        private Item _dagger;
        private Item _nuke;
        private Item _cherryBomb;
        private Item _bow;
        private Item _crossBow;
        private Item _medevilShield;
        private Item _modernShield;
        private Item _poision;
        private Item _lightning;
        private float _level;
        public float percentange = 0.25f;

        //Run the game
        public void Run()
        {
            Start();
            while(_gameOver == false)//repeats until game is over
            {
                Update();
            }
            End();
        }
        //give a random numeber between the min and max numbers
        public int RandomNumber(int min, int max)
        {
            return rand.Next(min, max);
        }
        //possible ways to take ask a question for the user and return input
        public void GetInput(out char input, string option1, string option2, string query)
        {
            Console.WriteLine(query);
            Console.WriteLine("1." + option1);
            Console.WriteLine("2." + option2);
            Console.Write("> ");

            input = ' ';
            while (input != '1' && input != '2')
            {
                input = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (input != '1' && input != '2')
                {
                    Console.WriteLine("invalid input!");
                }
            }
        }
        public void GetInput(out char input, string option1, string option2, string option3, string query)
        {
            Console.WriteLine(query);
            Console.WriteLine("1." + option1);
            Console.WriteLine("2." + option2);
            Console.WriteLine("3." + option3);
            Console.Write("> ");

            input = ' ';
            while (input != '1' && input != '2' && input != '3')
            {
                input = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (input != '1' && input != '2' && input != '3')
                {
                    Console.WriteLine("invalid input!");
                }
            }
        }
        public void GetInput(out char input, string option1, string option2, string option3, string query, bool messUp)
        {
            Console.WriteLine(query);
            Console.WriteLine("1." + option1);
            Console.WriteLine("2." + option2);
            Console.WriteLine("3." + option3);
            Console.Write("> ");

            input = ' ';
            if (messUp == false)
            {
                while (input != '1' && input != '2' && input != '3')
                {
                    input = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                    if (input != '1' && input != '2' && input != '3')
                    {
                        Console.WriteLine("invalid input!");
                    }
                }
            }
            else
            {
                input = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }
        }
        public void GetInput(out char input, string option1, string option2, string option3, string option4, string query)
        {
            Console.WriteLine(query);
            Console.WriteLine("1." + option1);
            Console.WriteLine("2." + option2);
            Console.WriteLine("3." + option3);
            Console.WriteLine("4." + option4);
            Console.Write("> ");

            input = ' ';
            while (input != '1' && input != '2' && input != '3' && input != '4')
            {
                input = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (input != '1' && input != '2' && input != '3' && input != '4')
                {
                    Console.WriteLine("invalid input!");
                }
            }
        }
        public void GetInput(out char input, string option1, string option2, string option3, string option4, string query, bool messUp)
        {
            Console.WriteLine(query);
            Console.WriteLine("1." + option1);
            Console.WriteLine("2." + option2);
            Console.WriteLine("3." + option3);
            Console.WriteLine("4." + option4);
            Console.Write("> ");

            input = ' ';
            if (messUp == false)
            {
                while (input != '1' && input != '2' && input != '3' && input != '4')
                {
                    input = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                    if (input != '1' && input != '2' && input != '3' && input != '4')
                    {
                        Console.WriteLine("invalid input!");
                    }
                }
            }
            else
            {
                input = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }
        }
        public void GetInput(out char input, string option1, string option2, string option3, string option4, string option5, string query)
        {
            Console.WriteLine(query);
            Console.WriteLine("1." + option1);
            Console.WriteLine("2." + option2);
            Console.WriteLine("3." + option3);
            Console.WriteLine("4." + option4);
            Console.WriteLine("5." + option5);
            Console.Write("> ");

            input = ' ';
            while (input != '1' && input != '2' && input != '3' && input != '4' && input != '5')
            {
                input = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (input != '1' && input != '2' && input != '3' && input != '4' && input != '5')
                {
                    Console.WriteLine("invalid input!");
                }
            }
        }
        public void GetInput(out char input, string option1, string option2, string option3, string option4, string option5,string option6, string query)
        {
            Console.WriteLine(query);
            Console.WriteLine("1." + option1);
            Console.WriteLine("2." + option2);
            Console.WriteLine("3." + option3);
            Console.WriteLine("4." + option4);
            Console.WriteLine("5." + option5);
            Console.WriteLine("6." + option6);
            Console.Write("> ");

            input = ' ';
            while (input != '1' && input != '2' && input != '3' && input != '4' && input != '5' && input != '6')
            {
                input = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (input != '1' && input != '2' && input != '3' && input != '4' && input != '5' && input != '6')
                {
                    Console.WriteLine("invalid input!");
                }
            }
        }
        //initializes weapons
        public void InitItems()
        {
            _empty.name = "nothing";//unequiped item
            _empty.type = "weapon";
            _empty.statBoost = 0;
            _empty.cost = 0;
            _empty.level = 0;
            //sword
            _sword.name = "sword";
            _sword.type = "weapon";
            _sword.statBoost = 10;
            _sword.cost = 5;
            _sword.level = 1;
            //dagger
            _dagger.name = "dagger";
            _dagger.type = "weapon";
            _dagger.statBoost = 10;
            _dagger.cost = 5;
            _dagger.level = 1;
            //nuke "duke nukem"
            _nuke.name = "nuke";
            _nuke.type = "weapon";
            _nuke.statBoost = 10;
            _nuke.cost = 5;
            _nuke.level = 1;
            //cherryBomb
            _cherryBomb.name = "cherrybomb";
            _cherryBomb.type = "weapon";
            _cherryBomb.statBoost = 10;
            _cherryBomb.cost = 5;
            _cherryBomb.level = 1;
            //bow
            _bow.name = "bow";
            _bow.type = "weapon";
            _bow.statBoost = 10;
            _bow.cost = 5;
            _bow.level = 1;
            //crossBow
            _crossBow.name = "crossbow";
            _crossBow.type = "weapon";
            _crossBow.statBoost = 10;
            _crossBow.cost = 5;
            _crossBow.level = 1;
            //magical shield
            _medevilShield.name = "old shield";
            _medevilShield.type = "shield";
            _medevilShield.statBoost = 10;
            _medevilShield.cost = 5;
            _medevilShield.level = 1;
            //tech shield
            _modernShield.name = "blocker";
            _modernShield.type = "shield";
            _modernShield.statBoost = 10;
            _modernShield.cost = 5;
            _modernShield.level = 1;
            //poision potion
            _poision.name = "poision";
            _poision.type = "potion";
            _poision.statBoost = 10;
            _poision.cost = 5;
            _poision.level = 1;
            //lightning potion
            _lightning.name = "lightning";
            _lightning.type = "potion";
            _lightning.statBoost = 10;
            _lightning.cost = 5;
            _lightning.level = 1;
        }
        //initializes shops
        public void InitShops()
        {
            //potion shop with inventory
            _potionInv = new Item[] {_poision, _lightning};
            _potionShop = new Shop(_potionInv);

            _weaponInv = new Item[] { _sword, _dagger, _nuke, _cherryBomb, _bow , _crossBow};
            _weaponShop = new Shop(_weaponInv);

            _shieldInv = new Item[] {_medevilShield, _modernShield};
            _shieldShop = new Shop(_shieldInv);
        }
        //prints inventory for all the shops and player
        public void PrintInventory(Item[] items)
        {
            for (int i = 0; i < items.Length; i++)//repeats this loop till reaches the end of the inventory
            {
                Console.WriteLine("item " + (i + 1) + ": " + items[i].name);//prints the name of the item
                Console.WriteLine("damage boost: " + items[i].statBoost);//prints the damage boost fo the item
                Console.WriteLine("cost: " + items[i].cost);//prints the cost of the item
            }
        }
        //opens shop thatwas identified
        private void OpenShopMenu(Shop shop, int shopInstance)
        {
            Console.WriteLine("welcome to the shopping district!");
            Item[] shopInv = shop.Getinventory();
            PrintInventory(shopInv);

            char input;
            GetInput(out input, "buy", "skip", "do you want to buy something?");//ask if the want to buy anything
            if (input == '1')
            {
                int shopIndex = 0;
                int playerIndex = 0;
                if (shopInstance == 1)
                {
                    GetInput(out input, shopInv[0].name, shopInv[1].name, "what to buy?");//asks for want potion/ shields to buy
                    switch (input)
                    {
                        case '1':
                            {
                                shopIndex = 0;
                                break;
                            }
                        case '2':
                            {
                                shopIndex = 1;
                                break;
                            }
                    }
                }
                else if (shopInstance == 2)
                {
                    GetInput(out input, shopInv[0].name, shopInv[1].name, shopInv[2].name, shopInv[3].name, shopInv[4].name, shopInv[5].name, "what to buy?");//asks for what weapons to buy
                    switch (input)
                    {
                        case '1':
                            {
                                shopIndex = 0;
                                break;
                            }
                        case '2':
                            {
                                shopIndex = 1;
                                break;
                            }
                        case '3':
                            {
                                shopIndex = 2;
                                break;
                            }
                        case '4':
                            {
                                shopIndex = 3;
                                break;
                            }
                        case '5':
                            {
                                shopIndex = 4;
                                break;
                            }
                        case '6':
                            {
                                shopIndex = 5;
                                break;
                            }
                    }
                }
                Console.Clear();

                Item[] playerInv = _player1.GetInventory();
                PrintInventory(playerInv);
                GetInput(out input, playerInv[0].name, playerInv[1].name, playerInv[2].name, "what slot do you want your new weapon in");//ask for the inventory slot of the player to put the new weapon in
                switch (input)
                {
                    case '1':
                        {
                            playerIndex = 0;
                            break;
                        }
                    case '2':
                        {
                            playerIndex = 1;
                            break;
                        }
                    case '3':
                        {
                            playerIndex = 2;
                            break;
                        }
                }
                shop.Sell(_player1, shopIndex, playerIndex);//this is what actually buys the item from the shop and throws it into your inventory
            }
            else
            {
                Console.WriteLine("you pass up the shopping district");//pass by if player doesnt want to buy
            }
            Console.ReadKey();
            Console.Clear();
        }

        //updates weapons to make them stronger everyround the player battles
        public void UpgradeWeapons(float level)
        {
            float upgradeShortRange = level * 5;
            _sword.statBoost = upgradeShortRange;
            _sword.cost += 1;
            _sword.level = level;

            _dagger.statBoost = upgradeShortRange;
            _dagger.cost += 1;
            _dagger.level = level;

            float upgradeMediumRange = level * 7.5f;
            _nuke.statBoost = upgradeMediumRange;
            _nuke.cost += 3;
            _nuke.level = level;

            _cherryBomb.statBoost = upgradeMediumRange;
            _cherryBomb.cost += 3;
            _cherryBomb.level = level;

            float upgradeLongRange = level * 2.5f;
            _bow.statBoost = upgradeLongRange;
            _bow.cost += 2;
            _bow.level = level;

            _crossBow.statBoost = upgradeLongRange;
            _crossBow.cost += 2;
            _crossBow.level = level;

            float upgradeShield = level * 1.5f;
            _medevilShield.statBoost = upgradeShield;
            _medevilShield.cost += 4;
            _medevilShield.level = level;

            _modernShield.statBoost = upgradeShield;
            _modernShield.cost += 4;
            _modernShield.level = level;

            float upgradePotion = level * 10;
            _poision.statBoost = upgradePotion;
            _poision.cost += 5;
            _poision.level = level;

            _lightning.statBoost = upgradePotion;
            _lightning.cost += 5;
            _lightning.level = level;
        }

        //generates an enemy for the player to battle against
        public Entity GenEnemy(int num,Item item)
        {
            switch (num)
            {
                case 1:
                    {
                        return _enemy = new Entity("krita", 100, 10, 10, item);
                    }
                case 2:
                    {
                        return _enemy = new Entity("shima", 100, 10, 10, item);
                    }
                case 3:
                    {
                        return _enemy = new Entity("kirigami", 100, 10, 10, item);
                    }
                case 4:
                    {
                        return _enemy = new Entity("sankai", 100, 10, 10, item);
                    }
                case 5:
                    {
                        return _enemy = new Entity("Kamaitachi", 100, 30, 10, item);
                    }
                default:
                    {
                        return _enemy = new Entity();
                    }
            }
            
        }

        //generates items for each enemy for random possibilities
        public Item GenItem(int num)
        {
            switch (num)
            {
                case 1:
                    {
                        return _sword;
                    }
                case 2:
                    {
                        return _dagger;
                    }
                case 3:
                    {
                        return _nuke;
                    }
                case 4:
                    {
                        return _cherryBomb;
                    }
                case 5:
                    {
                        return _bow;
                    }
                case 6:
                    {
                        return _crossBow;
                    }
                case 7:
                    {
                        return _medevilShield;
                    }
                case 8:
                    {
                        return _modernShield;
                    }
                case 9:
                    {
                        return _poision;
                    }
                case 10:
                    {
                        return _lightning;
                    }
                default:
                    {
                        return _empty;
                    }
            }
        }

        //give user instructions 
        public void Intro()
        {
            string name = " ";
            char input = ' ';
            Console.WriteLine("Good morning and welcome");
            Console.WriteLine("let's start with introductions!");
            Console.WriteLine("What's your name traveler?");
            Console.Write("> ");
            
            while(input != '1')
            {
                name = Console.ReadLine();
                Console.WriteLine();
                GetInput(out input, "yes", "change it", "do you want to keep this name");//ask if the player want to keep their name
                switch (input)
                {
                    case '1':
                        {
                            Console.WriteLine("your forever name will be " + name + "!");
                            break;
                        }
                    case '2':
                        {
                            Console.WriteLine("Alright lets change that name of yours");
                            Console.Write("> ");
                            continue;
                        }
                }
            }
            Console.WriteLine("thank you for coming " + name );
            Console.WriteLine("now lets get to it!");
            Console.WriteLine("whole objective survive if you die gameover");
            Console.WriteLine();
            GetInput(out input, "tutorial", "new game","continue", "what to do?");//ask if the player wants to learn/create a new game/or start from an old game
            if(input == '1')
            {
                _player1 = new Player(name, 100, 10, 10, 3);
                SelectLoadout(_player1);
                Tutorial();
            }
            else if(input == '2')
            {
                _player1 = new Player(name, 100, 10, 10, 3);
                SelectLoadout(_player1);
            }
            else
            {
                _enemy = new Entity();
                _player1 = new Player();
                if (Load())
                {
                    Console.WriteLine("load Successful");
                }
                else
                {
                    Console.WriteLine("load failed \nstarting new game");
                    _player1 = new Player(name, 100, 10, 10, 3);
                    SelectLoadout(_player1);
                }
            }
            Console.ReadKey();
            Console.Clear();

        }

        //tell  you how to play the game
        public void Tutorial()
        {
            Console.WriteLine("you enter a room bright with an enemy on the other side");
            Console.WriteLine("you get to select a loadout that has three classes of items");
            Console.WriteLine("potion/weapon/shield");
            Console.WriteLine();
            Console.WriteLine("potions breaks shields");
            Console.WriteLine("shields stops weapons");
            Console.WriteLine("and weapons are stronger than potions");
            Console.WriteLine();
            Console.WriteLine("starting with basic stats boost per item");
            Console.WriteLine("all items will increase in damage as you play");
            Console.WriteLine();
            Battle(GenEnemy(RandomNumber(1,5), GenItem(RandomNumber(1, 10))));//pre game learning to help them get their bearings
            Console.WriteLine("when a battle is over you will gain gold to spend at a shop to upgrade your own items");
        }

        //initates a battle scene where player battles a random enemy
        public void Battle(Entity enemy)
        {
            Console.WriteLine("you spot an enemy!");
            if (enemy.GetWeapon().type == "potion")//changes the prompt based on what the enemy is holding
            {
                Console.WriteLine("the " + enemy.GetName() + " is holding a bottle of " + enemy.GetWeapon().name);
            }
            else
            {
                Console.WriteLine("the " + enemy.GetName() + " is holding a " + enemy.GetWeapon().name);
            }
            
            while(_player1.IsAlive() && enemy.IsAlive())//checks to see if both player and enemy is alive
            {
                _player1.PrintStats();//print player stats
                enemy.PrintStats();//prints enemy stats
                char input;
                GetInput(out input, "fight","change weapon","save","what do you do?");//ask the player to fight 
                if(input == '1')
                {
                    if (_player1.GetWeapon().type == "weapon" && enemy.GetWeapon().type == "potion")//checks to see 
                    {
                        _player1.Attack(enemy);
                    }
                    else if (_player1.GetWeapon().type == "shield" && enemy.GetWeapon().type == "weapon")
                    {
                        _player1.Attack(enemy);
                    }
                    else if (_player1.GetWeapon().type == "potion" && enemy.GetWeapon().type == "shield")
                    {
                        _player1.Attack(enemy);
                    }
                    else
                    {
                        enemy.Attack(_player1);
                    }
                }
                else if(input == '2')
                {
                    ChangeWeapons(_player1);
                }
                else
                {
                    Save();
                }

           
                Console.Clear();
            }

            if (_player1.IsAlive() == false)
            {
                _gameOver = true;
            }
            else
            {
                _player1.AddGold(enemy.GetGold());
            }
            
            _level += percentange;
        }

        //when called asks player what weapon he/she wants to grab
        public void ChangeWeapons(Player player)
        {
            char input;
            Item[] inventory = player.GetInventory();
            GetInput(out input, inventory[0].name, inventory[1].name, inventory[2].name, "chose your weapon", true);
            switch (input)
            {
                case '1':
                    {
                        player.EquipItem(0);
                        Console.WriteLine("you equiped " + inventory[0].name);
                        break;
                    }
                case '2':
                    {
                        player.EquipItem(1);
                        Console.WriteLine("you equiped " + inventory[1].name);
                        break;
                    }
                case '3':
                    {
                        player.EquipItem(2);
                        Console.WriteLine("you equiped " + inventory[2].name);
                        break;
                    }
                default:
                    {
                        player.UnEquipItem();
                        Console.WriteLine("you disarmed yourself");
                        break;
                    }
            }

        }

        //save progress of game
        public void Save()
        {
            StreamWriter writer = new StreamWriter("SaveData.txt");
            writer.WriteLine(_level);
            _player1.Save(writer);
            writer.Close();
        }

        //loads stats and level for the player
        public bool Load()
        {
            if (File.Exists("SaveData.txt") == false)
            {
                return false;
            }
            float level = 0;
            StreamReader reader = new StreamReader("SaveData.txt");
            if (float.TryParse(reader.ReadLine(), out level) == false)
            {
                return false;
            }
            _level = level;
            _player1.Load(reader);
            reader.Close();
            return true;
        }

        //scene where player wonders a never ending forest to find battle or a shop to upgrade weapons
        public void Explore()
        {
            char input;
            int num = RandomNumber(0,10);
            Console.WriteLine("you are found in the forest nothing around you");
            GetInput(out input,"north","east","south","west","save", "which way to go?");//player decides which way to go
            Console.Clear();
            if(input == '1')
            {
                if (num >= 9)// 2/10 chance to get a shop 
                {
                    OpenShopMenu(_potionShop,1);
                }
                else if (num >= 4)//4/10 chance to run into an enemy
                {
                    Battle(GenEnemy(RandomNumber(1, 5), GenItem(RandomNumber(1, 10))));
                }
                else//4/10 chance to find nothing
                {
                    Console.WriteLine("you end up finding nothing");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            else if(input == '2')
            {
                if (num >= 8) // 3/10 chance to run into a shop
                {
                    OpenShopMenu(_shieldShop,1);
                }
                else if (num >= 4) // 3/10 chance to run into an enemy
                {
                    Battle(GenEnemy(RandomNumber(1, 5), GenItem(RandomNumber(1, 10))));
                }
                else // 4/10 chance to get nothing
                {
                    Console.WriteLine("you end up finding nothing");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            else if(input == '3')
            {
                if(num >= 8) // 3/10 chance to run into a shop
                {
                    OpenShopMenu(_weaponShop,2);
                }
                else if (num >= 4) // 3/10 chance to run into an enemy
                {
                    Battle(GenEnemy(RandomNumber(1, 5), GenItem(RandomNumber(1, 10))));
                }
                else // 4/10 chance to get nothing
                {
                    Console.WriteLine("you end up finding nothing");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            else if(input == '4')
            {   
                if (num > 5) // 5/10 chance to run into enemy
                {
                    Battle(GenEnemy(RandomNumber(1, 5), GenItem(RandomNumber(1, 10))));
                }
                else // 5/10 chance to find nothing
                {
                    Console.WriteLine("you end up finding nothing");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            else
            {
                Save();
            }
            
        }

        //gives the player the option to select a basic loadout
        public void SelectLoadout(Player player)
        {
            Console.Clear();
            Console.WriteLine("Loadout 1: ");
            Console.WriteLine(_crossBow.name);
            Console.WriteLine(_medevilShield.name);
            Console.WriteLine(_poision.name);
            Console.WriteLine();
            Console.WriteLine("Loadout 2: ");
            Console.WriteLine(_bow.name);
            Console.WriteLine(_modernShield.name);
            Console.WriteLine(_lightning.name);
            Console.WriteLine();
            Console.WriteLine("Loadout 3: ");
            Console.WriteLine(_sword.name);
            Console.WriteLine(_medevilShield.name);
            Console.WriteLine(_cherryBomb.name);
            Console.WriteLine();
            Console.WriteLine("Loadout 4:");
            Console.WriteLine(_dagger.name);
            Console.WriteLine(_modernShield.name);
            Console.WriteLine(_nuke.name);
            char input;
            GetInput(out input, "loadout 1", "loadout 2","loadout 3","loadout 4", "choose your Loadout!"); //ask the player for a loadout
            if (input == '1')
            {
                player.AddItemToInv(_crossBow, 0);
                player.AddItemToInv(_medevilShield, 1);
                player.AddItemToInv(_poision, 2);
            }
            else if (input == '2')
            {
                player.AddItemToInv(_bow, 0);
                player.AddItemToInv(_modernShield, 1);
                player.AddItemToInv(_lightning, 2);
            }
            else if (input == '3')
            {
                player.AddItemToInv(_sword, 0);
                player.AddItemToInv(_medevilShield, 1);
                player.AddItemToInv(_cherryBomb, 2);
            }
            else if (input == '4')
            {
                player.AddItemToInv(_dagger, 0);
                player.AddItemToInv(_modernShield, 1);
                player.AddItemToInv(_nuke, 2);
            }
            Console.WriteLine("player " + player.GetName());
            player.PrintStats();
            Console.ReadKey();
            Console.Clear();
        }

        //Performed once when the game begins
        public void Start()
        {
            InitItems();
            Intro();
            Console.WriteLine("so you know the basics lets throw you in");
        }

        //Repeated until the game ends
        public void Update()
        {
            InitShops();
            char input;
            GetInput(out input, "continue", "save & quit", " ");
            if (input == '1')
            {
                UpgradeWeapons(_level);
                for (int i = 0; i < 5; i++)
                {
                    Explore();
                    if (_player1.IsAlive()== false)
                    {
                        break;
                    }
                    percentange = 0.5f;
                }
                
            }
            else
            {
                Save();
                _gameOver = true;
            }
            
            
        }

        //Performed once when the game ends
        public void End()
        {
            if (_player1.IsAlive())
            {
                Console.WriteLine("see you agian soon");
            }
            else
            {
                Console.WriteLine("great you died!");
            }
        }
    }
}
