using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Location
    {
        public readonly LocationID ID;
        public readonly string Name;
        public readonly string Description;
        public readonly int MyProperty;
        private Dictionary<Direction, Location> Adjacents = new Dictionary<Direction, Location>();
        public readonly bool IsSafeZone;
        public readonly bool IsStore;

        public Location(LocationID id, string name, string description, bool isSafeZone = false, bool isStore = false)
        {
            ID = id;
            Name = name;
            Description = description;
            IsSafeZone = isSafeZone;
            IsStore = isStore;
        }

        public void SetAdjacents(Location north, Location south, Location east, Location west)
        {
            Adjacents[Direction.North] = north;
            Adjacents[Direction.South] = south;
            Adjacents[Direction.East] = east;
            Adjacents[Direction.West] = west;

        }

        public Location AdjacentToThe(Direction direction)
        {
            return Adjacents[direction];
        }
    }

    public enum Direction
    {
        North,
        South,
        East,
        West
    }

    public enum LocationID
    {
        nill,
        Home,
        TownOfBeginnings,
        Bridge,
        SpiderForest
    } 
}
