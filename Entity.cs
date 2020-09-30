using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HelloWorld
{
    class Entity
    {
        public int loader;

        private string _name;
        private int _health;
        protected int _gold;
        protected int _damage;
        protected Item _currentWeapon;


        public Entity()
        {
            _name = "???";
            _health = 100;
            _damage = 10;
            loader = 0;
        }

        public Entity(string nameVal, int healthVal,int damageVal, int gold)
        {
            _name = nameVal;
            _health = healthVal;
            _damage = damageVal;
            _gold = gold;
            loader = 0;
            
        }

        public Entity(string nameVal, int healthVal, int damageVal, int gold, Item item)
        {
            _name = nameVal;
            _health = healthVal;
            _damage = damageVal;
            _gold = gold;
            _currentWeapon = item;
            loader = 0;
        }

        public virtual void Attack(Entity enemy)
        {
            enemy.TakeDamage(_damage + _currentWeapon.statBoost);
        }

        public virtual void TakeDamage(int damageVal)
        {
            _health -= damageVal;
            if (IsAlive() == false)
            {
                _health = 0;
            }
        }

        public virtual void PrintStats()
        {
            Console.WriteLine("Name: " + _name);
            Console.WriteLine("health: " + _health);
            Console.WriteLine("Damage: " + (_damage + _currentWeapon.statBoost));
            Console.WriteLine();
        }

        public bool IsAlive()
        {
            return _health > 0;
        }

        public string GetName()
        {
            return _name;
        }

        public float GetHealth()
        {
            return _health;
        }

        public void Heal(int healthRestored)
        {
            _health += healthRestored;
        }

        public virtual void Save(StreamWriter writer)
        {
            writer.WriteLine();
            writer.WriteLine(_name);
            writer.WriteLine(_health);
            writer.WriteLine(_damage);
            writer.WriteLine(_gold);
            writer.WriteLine(_currentWeapon.name);
            writer.WriteLine(_currentWeapon.type);
            writer.WriteLine(_currentWeapon.cost);
            writer.WriteLine(_currentWeapon.level);
            
            
        }

        public virtual bool load(StreamReader reader)
        {

            reader.ReadLine();
            string name = reader.ReadLine();
            int damage = 0;
            int health = 0;
            int gold = 0;
            
            if (int.TryParse(reader.ReadLine(), out health) == false)
            {
                return false;
            }
            if (int.TryParse(reader.ReadLine(), out damage) == false)
            {
                return false;
            }
            if (int.TryParse(reader.ReadLine(), out gold) == false)
            {
                return false;
            }
            _name = name;
            _damage = damage;
            _health = health;
            _gold = gold;
            if (loader == 0)
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
                _currentWeapon.name = weaponName;
                _currentWeapon.type = weaponType;
                _currentWeapon.cost = weaponCost;
                _currentWeapon.level = weaponLevel;
            }
            loader = 0;
            return true;
        }

        public Item GetWeapon()
        {
            return _currentWeapon;
        }

        public int GetGold()
        {
            return _gold;
        }
    }
}
