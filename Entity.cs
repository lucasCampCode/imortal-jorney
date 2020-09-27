using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Entity
    {
        private string _name;
        private int _health;
        private int _damage;

        public Entity()
        {
            _name = "???";
            _health = 100;
            _damage = 10;
        }
        public Entity(string nameVal, int healthVal,int damageVal)
        {
            _name = nameVal;
            _health = healthVal;
            _damage = damageVal;
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
    }
}
