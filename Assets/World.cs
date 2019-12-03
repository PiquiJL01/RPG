 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine;

namespace Assets
{
    public class World
    {
        private static readonly List<Ability> Abilities = new List<Ability>();
        private static readonly List<Location> Locations = new List<Location>();
        private static readonly List<Dungeon> Dungeons = new List<Dungeon>();
        private static readonly List<HealingItem> HealingItems = new List<HealingItem>();
        private static readonly List<Equipment> Equipments = new List<Equipment>();
        private readonly List<Monster> BaseMonsters = new List<Monster>();

        public World()
        {
            SetItems();
            SetAttacks();
            SetBaseMonsters();
            SetLocations();
        }

        private void SetAttacks()
        {

        }

        private void SetBaseMonsters()
        {
            Monster Slime = new Slime();

            //add attacks

            BaseMonsters.Add(Slime);
        }

        private void SetLocations()
        {
            Location Home = new Location(LocationID.Home, "Home", "Home, sweet home"); //Missing Locations and Special Statuses
            Location TownOfBeginnings = new Location(LocationID.TownOfBeginnings, "Town Of Beginnings", "Every adventure starts somewhere");
            Location Bridge = new Location(LocationID.Bridge, "Bridge", "Bridge from the Town of Beginings to the Spider's Forest");
            //Dungeon SpidersForest = new Dungeon((int)Sites.SpiderForest, "Spider's Forest", "Self-Explanatory", 1, 3, 1,, Dungeon.Up, true);

            Home.SetAdjacent(Direction.North, TownOfBeginnings);

            TownOfBeginnings.SetAdjacent(Direction.East, Bridge);

            //Bridge.LocationEast = SpidersForest;

            //SpidersForest.LocationWest = Bridge;

            Locations.Add(Home);
            Locations.Add(TownOfBeginnings);
            Locations.Add(Bridge);
            //Locations.Add(SpidersForest);
        }

        private void SetItems()
        {
            Potion potion = new Potion();

            HealingItems.Add(potion);
        }

        public Attack AttackByID(AbilityID id)
        {
            foreach (Ability ability in Abilities)
            {
                if (ability.ID == id)
                {
                    return ability;
                }
            }

            return null;
        }

        public Monster MonsterByID(MonsterID id)
        {
            foreach (Monster monster in BaseMonsters)
            {
                if (monster.ID == id)
                {
                    return monster;
                }
            }

            return null;
        }

        public Item ItemByID(ItemID id)
        {
            foreach (Item item in Items)
            {
                if (item.ID == id)
                {
                    return item;
                }
            }

            return null;
        }
    }
}


