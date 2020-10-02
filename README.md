# Immortal Journy
## How To Play 
you explore the never ending forest to either find enemies or a shop to upgrade your weapons and get stronger.

to defeat enemies you will play like rock/paper/siccors but instead weapons shields and potions.

## controls
input 1-6 using the number keys depending on what question being asked to procced with task.

## Shop
 these are places found in the forest randomly when exploring and is where you can upgrade your weaponry.

## weapons 
 each weapon has a type in which the player will use to figure which one to beat their opponnet with.

##  battle
 where player and a random entity will be called to face in a one on one fight.

## Winning 
 the game doesn't have a win sequence due to mainly making the game a surviveablility test.


## functions

### game

#### RandomNumber(int min, int max)
gives random number using Random in the system functions.

#### GetInput(out char input, string option1, string option2,string query)
+ GetInput(out char input, string option1, string option2, string option3, string query)
+ GetInput(out char input, string option1, string option2, string option3, string query, bool messUp)
+ GetInput(out char input, string option1, string option2, string option3, string option4, string query)
+ GetInput(out char input, string option1, string option2, string option3, string option4, string query, bool messUp)
+ GetInput(out char input, string option1, string option2, string option3, string option4, string option5, string query)
+ GetInput(out char input, string option1, string option2, string option3, string option4, string option5, string option6, string query)
  + returns input for curtian task that would be asked.
  + if needed the messup bool is inteanded if the player intended to unequip all weapons

#### InitItems()
initilizes items for use throughout the game.

#### InitShop()
initilizes all shop to be used when exploring.

#### PrintInventory(Item[] items)
print player and shops inventory for the game.

#### OpenShopMenu(Shop shop,int shopInstance)
depended on shop pass through will return a option to choose to either change weapons or upgrade you old weapon.

*if place in wrong slot for players inventory will put the player at a disadvantenge.*

#### UpgradeWeapons(float level)
depended on level will upgrade the damage of all weapon based on type. 

will upgrade them every five round when it ask if you want to continue.

#### GenEnemy(int num, Item item)
generates a random enemy for the player to battle against.

#### GenItem(int num)
generates random item for the enemy to use against the player.

#### Intro()
introduces the player to the game and gives options to learn how the game works.

gives the player option to create a new game or continue with an old game.

#### Tutorial()
if player wants to learn the game this will explain it.

#### Battle(Entity enemy)
when player encounters an enemy this will initiate a scene where they will fight.

#### ChangeWeapons(Player player)
when player changes weapon this askes them what weapon they want to choose and equips that item.

#### Save()
save player and enemy stats and loadouts into a text file.

#### Load()
load player and enemy stats and loadouts from a text file.

#### Explore()
makes the player choose which direction to walk in a never ending forest.


### Shop
shop sells one item it's inventory in excange for gold.

### Entity
used to identify stats for players and enemies.

#### attack()
attacks opossing enemy.

#### TakeDamage()
changes the health to the entity based od damage.

### Player
player can interact with shop attack enemies equip items, interact with their own inventory.

