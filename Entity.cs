using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HelloWorld
{
    class Entity
    {
        private string _name;
        private int _health;
        protected int _gold;
        protected int _damage;


        public Entity()
        {
            _name = "???";
            _health = 100;
            _damage = 10;
        }

        public Entity(string nameVal, int healthVal,int damageVal, int gold)
        {
            _name = nameVal;
            _health = healthVal;
            _damage = damageVal;
            _gold = gold;
        }

        public virtual void Attack(Entity enemy)
        {
            enemy.TakeDamage(_damage);
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
            writer.WriteLine(_name);
            writer.WriteLine(_health);
            writer.WriteLine(_damage);
            writer.WriteLine(_gold);
        }

        public virtual bool load(StreamReader reader)
        {
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
            return true;
        }
    }
}
