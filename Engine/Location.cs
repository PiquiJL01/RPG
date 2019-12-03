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

        public void SetAdjacent(Direction direction, Location adjacent, bool SetBoth = true)
        {
            Adjacents[direction] = adjacent;

            if (adjacent != null && SetBoth)
            {
                switch (direction)
                {
                    case Direction.North:
                        Adjacents[direction].SetAdjacent(Direction.South, this, false);
                        break;
                    case Direction.South:
                        Adjacents[direction].SetAdjacent(Direction.North, this, false);
                        break;
                    case Direction.East:
                        Adjacents[direction].SetAdjacent(Direction.West, this, false);
                        break;
                    case Direction.West:
                        Adjacents[direction].SetAdjacent(Direction.East, this, false);
                        break;
                    default:
                        break;
                }
            }
        }

        public Location AdjacentToThe(Direction direction)
        {
            return Adjacents[direction];
        }
    }
}
