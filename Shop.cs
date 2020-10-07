using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HelloWorld
{
    class Shop
    {
        private int _gold;
        private Item[] _inventory;

        //base shop constructor
        public Shop()
        {
            _gold = 10;
            _inventory = new Item[4];
        }

        //coustom shop constructor overload
        public Shop(Item[] items)
        {
            _gold = 10;
            _inventory = items;
        }

        //return shops inventory
        public Item[] Getinventory()
        {
            return _inventory;
        }

        //add items to a shop in a specific spot
        public void AddItemToShop(Item item, int index)
        {
            _inventory[index] = item;
        }

        //sells the item the player want to buy 
        public bool Sell(Player player, int shopIndex, int playerIndex)
        {

            if (player.Buy(_inventory[shopIndex], playerIndex))
            {
                _gold += _inventory[shopIndex].cost;//adds gold based on the cost of the item sold
                return true;
            }
            return false;
        }

        //returns shops gold
        public int Getgold()
        {
            return _gold;
        }
    }
}
