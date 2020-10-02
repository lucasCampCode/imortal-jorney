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

        public Player() : base()
        {
            _inventory = new Item[3];
            _empty.name = "empty";
            _empty.type = "none";
            _empty.statBoost = 0;
        }

        public Player(string nameVal,int healthVal,int damageVal,int gold,int inventorySize) : base(nameVal,healthVal,damageVal,gold)
        {
            _inventory = new Item[inventorySize];
        }

        public override void Attack(Entity enemy)
        {
            if (_currentWeapon.name != "empty")
            {
                float totalDamage = _damage + _currentWeapon.statBoost;
                enemy.TakeDamage(totalDamage);
                _gold += enemy.GetGold();
            }
            else
            {
                base.Attack(enemy);
            }
        }

        public Item[] GetInventory()
        {
            return _inventory;
        }

        public bool contains(int index)
        {
            if (index >= 0 && index < _inventory.Length)
            {
                return true;
            }
            return false;
        }

        public void EquipItem(int itemIndex)
        {
            if (contains(itemIndex))
            {
                _currentWeapon = _inventory[itemIndex];
            }
            else
            {
                Console.WriteLine("invalid");
            }

        }

        public void AddItemToInv(Item item, int index)
        {
            _inventory[index] = item;
        }

        public void UnEquipItem()
        {
            _currentWeapon = _empty;
        }

        public void RemoveItem(int index)
        {
            _inventory[index] = _empty;
        }

        public void MoveItem(int from, int to)
        {
            _inventory[to] = _inventory[from];
            RemoveItem(from);
        }

        public override void Save(StreamWriter writer)
        {
            writer.WriteLine();
            writer.WriteLine(GetName());
            writer.WriteLine(GetHealth());
            writer.WriteLine(_damage);
            writer.WriteLine(_gold);
            for (int i = 0; i < _inventory.Length; i++)
            {
                writer.WriteLine(_inventory[i].name);
                writer.WriteLine(_inventory[i].type);
                writer.WriteLine(_inventory[i].cost);
                writer.WriteLine(_inventory[i].level);
            }
        }

        public override bool load(StreamReader reader)
        {
            loader = 1;
            if (base.load(reader))
            {
                for (int i = 0; i < _inventory.Length; i++)
                {
                    string weaponName = reader.ReadLine();
                    string weaponType = reader.ReadLine();
                    int weaponCost = 0;
                    int weaponLevel = 0;
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
                    _inventory[i].cost = weaponCost;
                    _inventory[i].level = weaponLevel;
                }
            }

            return true;
        }

        public bool Buy(Item item, int index)
        {
            if (_gold > item.cost)
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
