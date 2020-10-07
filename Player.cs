using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HelloWorld
{
    class Player : Entity
    {
        private Item[] _inventory;
        private Item _empty;

        //base player constructor
        public Player() : base()
        {
            _inventory = new Item[3];
            _empty.name = "empty";
            _empty.type = "none";
            _empty.statBoost = 0;
        }

        //more customized player constructor
        public Player(string nameVal,int healthVal,int damageVal,int gold,int inventorySize) : base(nameVal,healthVal,damageVal,gold)
        {
            _inventory = new Item[inventorySize];
        }

        //player attacks
        public override void Attack(Entity enemy)
        {
            if (_currentWeapon.name != "empty")//when player holds nothing it hits enemy with nothing or bare fist
            {
                float totalDamage = _damage + _currentWeapon.statBoost;
                enemy.TakeDamage(totalDamage);
                
            }
            else
            {
                base.Attack(enemy);
            }
        }

        //when player defeats an enemy adds gold to player inventory
        public void AddGold(int gold)
        {
            _gold += gold;
        }

        //returns inventory
        public Item[] GetInventory()
        {
            return _inventory;
        }

        //to check if players input is viable
        private bool Contains(int index)
        {
            if (index >= 0 && index < _inventory.Length)
            {
                return true;
            }
            return false;
        }

        //equips an item from player inventory to there hand
        public void EquipItem(int itemIndex)
        {
            if (Contains(itemIndex))
            {
                _currentWeapon = _inventory[itemIndex];
            }
            else
            {
                Console.WriteLine("invalid");
            }

        }

        //adds loadouts to player inventory
        public void AddItemToInv(Item item, int index)
        {
            _inventory[index] = item;
        }

        //if player messup on selecting a weapon replaces that weapon with nothing
        public void UnEquipItem()
        {
            _currentWeapon = _empty;
        }

        //saves player info and stats
        public override void Save(StreamWriter writer)
        {
            writer.WriteLine();
            writer.WriteLine(GetName());
            writer.WriteLine(GetHealth());
            writer.WriteLine(_damage);
            writer.WriteLine(_gold);
            for (int i = 0; i < _inventory.Length; i++)// saves all the items in player inventory
            {
                writer.WriteLine(_inventory[i].name);
                writer.WriteLine(_inventory[i].type);
                writer.WriteLine(_inventory[i].statBoost);
                writer.WriteLine(_inventory[i].cost);
                writer.WriteLine(_inventory[i].level);
            }
        }

        // loads players info and stats
        public override bool Load(StreamReader reader)
        {
            loader = 1;
            if (base.Load(reader))// base loader for health gold and damage and name
            {
                for (int i = 0; i < _inventory.Length; i++) // unique load for player for all items saved
                {
                    string weaponName = reader.ReadLine();
                    string weaponType = reader.ReadLine();
                    int weaponBoost = 0;
                    int weaponCost = 0;
                    int weaponLevel = 0;
                    if (int.TryParse(reader.ReadLine(), out weaponBoost) == false)
                    {
                        return false;
                    }
                    if (int.TryParse(reader.ReadLine(), out weaponCost) == false)
                    {
                        return false;
                    }
                    if (int.TryParse(reader.ReadLine(), out weaponLevel) == false)
                    {
                        return false;
                    }
                    _inventory[i].name = weaponName;
                    _inventory[i].type = weaponType;
                    _inventory[i].statBoost = weaponBoost;
                    _inventory[i].cost = weaponCost;
                    _inventory[i].level = weaponLevel;
                }
            }

            return true;
        }

        //buys an item from store 
        public bool Buy(Item item, int index)
        {
            if (_gold >= item.cost)// actually buys if you have enough gold
            {
                _gold -= item.cost;
                _inventory[index] = item;
                return true;
            }
            else
            {
                Console.WriteLine("not enough gold");
                return false;
            }
        }
        
    }
}
