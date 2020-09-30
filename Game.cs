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
        public int statBoost;
        public int cost;
        public int level;
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
        public float percentange;

        //Run the game
        public void Run()
        {
            Start();
            while(_gameOver == false)
            {
                Update();
            }
            End();
        }

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

        public void InitItems()
        {
            _empty.name = "nothing";
            _empty.type = "all";
            _empty.statBoost = 0;
            _empty.cost = 0;
            _empty.level = 0;

            _sword.name = "sword";
            _sword.type = "weapon";
            _sword.statBoost = 10;
            _sword.cost = 5;
            _sword.level = 1;

            _dagger.name = "dagger";
            _dagger.type = "weapon";
            _dagger.statBoost = 10;
            _dagger.cost = 5;
            _dagger.level = 1;

            _nuke.name = "nuke";
            _nuke.type = "weapon";
            _nuke.statBoost = 10;
            _nuke.cost = 5;
            _nuke.level = 1;

            _cherryBomb.name = "cherrybomb";
            _cherryBomb.type = "weapon";
            _cherryBomb.statBoost = 10;
            _cherryBomb.cost = 5;
            _cherryBomb.level = 1;

            _bow.name = "bow";
            _bow.type = "weapon";
            _bow.statBoost = 10;
            _bow.cost = 5;
            _bow.level = 1;

            _crossBow.name = "crossbow";
            _crossBow.type = "weapon";
            _crossBow.statBoost = 10;
            _crossBow.cost = 5;
            _crossBow.level = 1;

            _medevilShield.name = "old shield";
            _medevilShield.type = "shield";
            _medevilShield.statBoost = 10;
            _medevilShield.cost = 5;
            _medevilShield.level = 1;

            _modernShield.name = "blocker";
            _modernShield.type = "shield";
            _modernShield.statBoost = 10;
            _modernShield.cost = 5;
            _modernShield.level = 1;

            _poision.name = "poision";
            _poision.type = "potion";
            _poision.statBoost = 10;
            _poision.cost = 5;
            _poision.level = 1;

            _lightning.name = "lightning";
            _lightning.type = "potion";
            _lightning.statBoost = 10;
            _lightning.cost = 5;
            _lightning.level = 1;
        }

        public void InitShops()
        {
            _potionInv = new Item[] {_poision, _lightning};
            _potionShop = new Shop(_potionInv);

            _weaponInv = new Item[] { _sword, _dagger, _nuke, _cherryBomb, _bow , _crossBow};
            _weaponShop = new Shop(_weaponInv);

            _shieldInv = new Item[] {_medevilShield, _modernShield};
            _shieldShop = new Shop(_shieldInv);
        }

        public void PrintInventory(Item[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine("item " + (i + 1) + ": " + items[i].name);
                Console.WriteLine("cost " + (i + 1) + ": " + items[i].cost);
            }
        }

        private void OpenShopMenu(Shop shop)
        {
            Console.WriteLine("welcome to the shopping district!");
            Item[] shopInv = shop.Getinventory();
            PrintInventory(shopInv);

            char input;
            int shopIndex = 0;
            int playerIndex = 0;

            GetInput(out input, shopInv[0].name, shopInv[1].name, shopInv[2].name, shopInv[3].name, "what to buy?");
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
            }
            Console.Clear();
            
            Item[] playerInv = _player1.GetInventory();
            PrintInventory(playerInv);
            GetInput(out input, playerInv[0].name, playerInv[1].name, playerInv[2].name, playerInv[3].name, "what slot do you want your new weapon in");
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
                case '4':
                    {
                        playerIndex = 3;
                        break;
                    }
            }
            shop.Sell(_player1, shopIndex, playerIndex);
        }

        public Entity GenEnemy(int num,Item item)
        {
            switch (num)
            {
                case 1:
                    {
                        return _enemy = new Entity("krita", 100, 10, 0, item);
                    }
                case 2:
                    {
                        return _enemy = new Entity("shima", 100, 10, 0, item);
                    }
                case 3:
                    {
                        return _enemy = new Entity("kirigami", 100, 10, 0, item);
                    }
                case 4:
                    {
                        return _enemy = new Entity("sankai", 100, 10, 0, item);
                    }
                case 5:
                    {
                        return _enemy = new Entity("Kamaitachi", 100, 30, 0, item);
                    }
                default:
                    {
                        return _enemy = new Entity();
                    }
            }
            
        }

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
            
            while(input != '1')
            {
                name = Console.ReadLine();
                GetInput(out input, "yes", "change it", "do you want to keep this name");
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
                            continue;
                        }
                }
            }
            Console.WriteLine("thank you for coming " + name );
            Console.WriteLine("now lets get to it!");
            Console.WriteLine("whole objective survive if you die gameover");
            GetInput(out input, "tutorial", "new game","continue", "what to do?");
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
                    Console.WriteLine("load failed \n starting new game");
                    _player1 = new Player(name, 100, 10, 10, 3);
                    SelectLoadout(_player1);
                }
            }

        }
        //tell  you how to play the game
        public void Tutorial()
        {
            Console.WriteLine("you enter a room bright with an enemy on the other side");
            Console.WriteLine("you get to select a loadout that has three classes of items");
            Console.WriteLine("potion/weapon/shield");
            Console.WriteLine("potions breaks shields");
            Console.WriteLine("shields stops weapons");
            Console.WriteLine("starting with basic stats boost per item");
            Console.WriteLine("and weapons are stronger than potions");
            Console.WriteLine();
            Battle(GenEnemy(RandomNumber(1,5), GenItem(RandomNumber(1, 10))));
        }

        public void Battle(Entity enemy)
        {
            Console.WriteLine("you spot an enemy!");
            if (enemy.GetWeapon().type == "potion")
            {
                Console.WriteLine("the " + enemy.GetName() + " is holding a bottle of " + enemy.GetWeapon().name);
            }
            else
            {
                Console.WriteLine("the " + enemy.GetName() + " is holding a " + enemy.GetWeapon().name);
            }
            
            while(_player1.IsAlive() && enemy.IsAlive())
            {
                _player1.PrintStats();
                enemy.PrintStats();
                char input;
                GetInput(out input, "fight","change weapon","save","what do you do?");
                if(input == '1')
                {
                    if (_player1.GetWeapon().type == "weapon" && enemy.GetWeapon().type == "potion")
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
                    save();
                }

           
                Console.Clear();
            }
            if (_player1.IsAlive() == false)
            {
                _gameOver = true;
            }
            _level += percentange;
        }

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

        public void save()
        {
            StreamWriter writer = new StreamWriter("SaveData.txt");
            writer.WriteLine(_level);
            _player1.Save(writer);
            _enemy.Save(writer);
            writer.Close();
        }

        public bool Load()
        {
            float level = 0;
            StreamReader reader = new StreamReader("SaveData.txt");
            if (float.TryParse(reader.ReadLine(), out level) == false)
            {
                return false;
            }
            _level = level;
            _player1.load(reader);
            _enemy.load(reader);
            reader.Close();
            return true;
        }

        public void Explore()
        {
            char input;
            int num = RandomNumber(1,10);
            Console.WriteLine("you are found in the forest nothing around you");
            GetInput(out input,"north","east","south","west", "which way to go?");
            if(input == '1')
            {
                if (num > 9)
                {
                    OpenShopMenu(_potionShop);
                }
                else if (num > 4)
                {
                    Battle(GenEnemy(RandomNumber(1, 5), GenItem(RandomNumber(1, 10))));
                }
                else
                {
                    Console.WriteLine("you end up finding nothing");
                }
            }
            else if(input == '2')
            {
                if (num > 8)
                {
                    OpenShopMenu(_shieldShop);
                }
                else if (num > 6)
                {
                    Battle(GenEnemy(RandomNumber(1, 5), GenItem(RandomNumber(1, 10))));
                }
                else
                {
                    Console.WriteLine("you end up finding nothing");
                }
            }
            else if(input == '3')
            {
                if(num > 7)
                {
                    OpenShopMenu(_weaponShop);
                }
                else if (num > 3)
                {
                    Battle(GenEnemy(RandomNumber(1, 5), GenItem(RandomNumber(1, 10))));
                }
                else
                {
                    Console.WriteLine("you end up finding nothing");
                }
            }
            else
            {   
                if (num > 5)
                {
                    Battle(GenEnemy(RandomNumber(1, 5), GenItem(RandomNumber(1, 10))));
                }
                else
                {
                    Console.WriteLine("you end up finding nothing");
                }
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
            GetInput(out input, "loadout 1", "loadout 2","loadout 3","loadout 4", "choose your weapon!");
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
            char input;
            GetInput(out input, "continue", "quit", "");
            if (input == '1')
            {
                for (int i = 0; i < 5; i++)
                {
                    Explore();
                    percentange *= 0.01f;
                }
                
            }
            else
            {
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
                Console.WriteLine("great you died you lost!");
            }
        }
    }
}
