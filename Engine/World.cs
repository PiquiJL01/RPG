 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class World
    {
        private static readonly List<Attack> Attacks = new List<Attack>();
        private static readonly List<Location> Locations = new List<Location>();
        private static readonly List<Dungeon> Dungeons = new List<Dungeon>();
        private static readonly List<Item> Items = new List<Item>();
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
            Monster Slime = new Monster(MonsterID.Slime, "Slime", "Slimes", 1, 1, 10, 10, 2,2,2,2,2,2,2,2,2,2, 20);

            //add attacks

            BaseMonsters.Add(Slime);
        }

        private void SetLocations()
        {
            Location Home = new Location(LocationID.Home, "Home", "Home, sweet home"); //Missing Locations and Special Statuses
            Location TownOfBeginnings = new Location(LocationID.TownOfBeginnings, "Town Of Beginnings", "Every adventure starts somewhere");
            Location Bridge = new Location(LocationID.Bridge, "Bridge", "Bridge from the Town of Beginings to the Spider's Forest");
            //Dungeon SpidersForest = new Dungeon((int)Sites.SpiderForest, "Spider's Forest", "Self-Explanatory", 1, 3, 1,, Dungeon.Up, true);

            Home.LocationNorth = TownOfBeginnings;

            TownOfBeginnings.LocationSouth = Home;
            TownOfBeginnings.LocationEast = Bridge;

            Bridge.LocationWest = TownOfBeginnings;
            //Bridge.LocationEast = SpidersForest;

            //SpidersForest.LocationWest = Bridge;

            Locations.Add(Home);
            Locations.Add(TownOfBeginnings);
            Locations.Add(Bridge);
            //Locations.Add(SpidersForest);
        }

        private void SetItems()
        {
            Item Potion = new HealingItem(ItemID.Potion, "Potion", "potions", 20);

            Items.Add(Potion);
        }

        public Attack AttackByID(AttackID id)
        {
            foreach (Attack attack in Attacks)
            {
                if (attack.ID == id)
                {
                    return attack;
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

    public enum Element
    {
        Nill,
        Fire,
        Water,
        Earth,
        Wind
    }

    public enum EffectID
    {
        Stun
    }
}


