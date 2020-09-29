using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HelloWorld
{
    class Player : Entity
    {
        private Item[] _inventory;
        private Item _currentWeapon;
        private Item _empty;

        public Player() : base()
        {
            _inventory = new Item[3];
            _empty.name = "empty";
            _empty.type = "none";
            _empty.statBoost = 0;
        }

        public Player(string nameVal,int healthVal,int damageVal,int inventorySize) : base(nameVal,healthVal,damageVal)
        {
            _inventory = new Item[inventorySize];
        }
        public override void Attack(Entity enemy)
        {
            if (_currentWeapon.name != "empty")
            {
                int totalDamage = _damage + _currentWeapon.statBoost;
                enemy.TakeDamage(totalDamage);
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
            if (index > 0 && index < _inventory.Length)
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

        public void UnequipItem()
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

        public override void PrintStats()
        {
            base.PrintStats();
            Console.WriteLine("Damage: " + (_damage + _currentWeapon.statBoost));
            Console.WriteLine();
        }
        public override void Save(StreamWriter writer)
        {
            base.Save(writer);
        }
        public override bool load(StreamReader reader)
        {
            return base.load(reader);
            
        }
    }
}
