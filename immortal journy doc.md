| Lucas Alan Campbell|
|:----               |
|s208055|
|Proggramming Class 2022|
|12/05/2020|

# I. Requirements
1. Description of problem 
   1. name of game: immortal Journy
   2. problem statement: clear requirements on Assessment
   3. preoblem specs: must be either a shop, text adventure, or pvp game
2. Input Info
   1. player will be selceting from a list of choices max choices can be up to six.
   2. name is create by the player at the very begining and that would be it.
3. Output Info
   1. when a choice is made a result will happen base on the choice and continue the game.
   2. when name is inputed you can change it if you made a mistake.
# functions

## File Game.cs

### RandomNumber(int min, int max)
+ return type: int
+ visability: public
  + gives random number using Random in the system functions.

### GetInput()
+ return type: void
+ visability: public
  + GetInput(out char input, string option1, string option2,string query)
  + GetInput(out char input, string option1, string option2, string option3, string query)
  + GetInput(out char input, string option1, string option2, string option3, string query, bool messUp)
  + GetInput(out char input, string option1, string option2, string option3, string option4, string query)
  + GetInput(out char input, string option1, string option2, string option3, string option4, string query, bool messUp)
  + GetInput(out char input, string option1, string option2, string option3, string option4, string option5, string query)
  + GetInput(out char input, string option1, string option2, string option3, string option4, string option5, string option6, string query)
     1. input - returns the users input.
     2. options 1-6 - the option you give to the user.
     3. query - question you ask the user.
     4. messup - when true GetInput wont give you invaled input; so if the player failed there is a concenquence..

### InitItems()
+ return type: void
+ visability: public
  + sets the name, type, statBoost, cost, and level of each item made.

### InitShop()
+ return type: void
+ visability: public
  + sets the inventory of each individual shop from items made.

### PrintInventory(Item[] items)
+ return type: void
+ visability: public
  + takes what ever inventory suplied and writes each items name, statBoost, and cost.

### OpenShopMenu(Shop shop,int shopInstance)
+ return type: void
+ visability: private
  + shop - take a shops inventory prints them out for player.
  + shopInstance - changes the GetInput to acommidate for out of bounds errors.

### UpgradeWeapons(float level)
+ return type: void
+ visability: public
  + used to change the rates at which each weapon damage value increase based on level of the game.

### GenEnemy(int num, Item item)
+ return type: Entity
+ visability: public
  + num intilize which enemy get chosen for battle.
  + item set the enemies weapon.

### GenItem(int num)
+ return type: Item
+ visability: public
  + num intilize which item get chosen for enemy.

### Intro()
+ return type: void
+ visability: public
  + introduces the player to the game and gives options to learn how the game works.
  + gives the player option to create a new game or continue with an old game.

### Tutorial()
+ return type: void
+ visability: public
  + helps player learn the concept of the game.

### Battle(Entity enemy)
+ return type: void
+ visability: public
  + Enemy get chosen for battle against the player.
  + get the input from player to make an action.
    + *can be better balanced.* 

### ChangeWeapons(Player player)
+ return type: void
+ visability: public
  + player - grabs there inventory to show the user and lets them select from one of the items in their inventory.

### Save()
+ return type: void
+ visability: public
  + save player and enemy stats and loadouts into a text file.

### Load()
+ return type: bool
+ visability: public
  + load player and enemy stats and loadouts from a text file.

### Explore()
+ return type: void
+ visability: public
  + makes the player choose which direction to walk in a never ending forest.

### SelectLoadout(Player player)
+ return type: void
+ visability: public
  + lets the player to select from the premade weapon loadouts to have something so they dont die for not having anything.

## File shop.cs
+ shop sells one item it's inventory in exchange for gold.

### constructors
+ visability: public
+ shop()
  + set gold the shop has and inventory space
+ Shop(Item[] items)
  + sets gold the shop has and 

### GetInventory()
+ return type: Item[]
+ visability: public
  + returns items in the shops inventory

### AddItemToShop(Item item, int index)
+ return type: void
+ visability: public
  + put item at shops inventory index
  + used to change shopsinventory mid game

### sell(Player player,int shopIndex,int playerIndex)
+ return type: bool
+ visability: public
  + sees if the player can buy an item in shops inventory if so exchanges it for gold

### GetGold()
+ return type: int
+ visability: public
  + makes gold readable anywhere

## File Entity.cs
+ used to identify stats for players and enemies.

### constructors
+ visability: public
+ Entity()
  + sets name, health, and damage for a basic entity
+ Entity(string nameVal, int HealthVal, int damageVal, int gold)
  + set name, health , damage, and gold for more advance entity
+ Entity(string nameVal, int HealthVal, int damageVal, int gold, Item item)
  + set name, health , damage, gold, and weapon for more advance entity with weapon choice

### virtual attack(Entity enemy)
+ return type: void
+ visability: public
    + attacks opossing enemy.

### virtual TakeDamage(float damageVal)
+ return type: void
+ visability: public
  + changes the health of the entity based on damage.

### PrintStats()
+ return type: void
+ visability: public
  + write the stats of the instance of that entity

### IsAlive()
+ return type: bool
+ visability: public
    + checks to see if player is alive

### GetName()
+ return type: string
+ visability: public
  + returns entity name

### GetHealth()
+ return type: float
+ visability: public
  + returns health

### virtual save()
+ return type: void
+ visability: public
  + save information on the entity during gameplay

### virtual load()
+ return type: bool
+ visability: public
  + loads entities information from a text file

### GetWeapon()
+ return type: item
+ visability: public
  + return entities current weapon

### GetGold()
+ return type: int
+ visability: public
  + tells you how much gold the player will recive

## File Player.cs
 
inherited from entity
### constructors
+ Player()
+ visability: public 
  + initilizes a player object with entity stats but with a inventory
+ Player(string nameVal, int healthVal,int damageVal,int gold,int inventorySize) : base(nameVal,healthVal,damageVal,gold)
  + sets player stats to a base value and add an inventory size

### overide Attack(Entity enemy)
+ return type: void
+ visability: public
  + changes the way a player attack compared to a plain entity attack

### AddGold(int gold)
+ return type: void
+ visability: public
  + increases players gold base on what entity they killed

### GetInventory()
+ return type: Item[]
+ visability: public
  + returns players inventory

### contains(int index)
+ return type: bool
+ visability: private
  + sees if the item can be put in the inventories slot

### EquipItem(int itemIndex)
+ return type: void
+ visability: public
  + allows the player to change weapons midfight

### AddItemToInv(Item item, int index)
+ return type: void
+ visability: public
  + takes an item from either a shop or a premade loadout and add it to player inventory

### UnEquipItem()
+ return type: void
+ visability: public
  + when ever player messup on a change weapon they throw away their weapon

### override Save(streamWriter writer)
+ return type: void
+ visability: public
  + save base stats and all item in players inventory

### override Load(StreamReader reader)
+ return type: void
+ visability: public
  + load player stats and inventory from last save

### Buy(Item item,int index)
+ return type: void
+ visability: public
  + check to see if you can buy the item selected in the shop when it does adds the item to your inventory