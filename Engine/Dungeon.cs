using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Dungeon : Location
    {
        public readonly int DimensionX;
        public readonly int DimensionY;
        public readonly int Floors;
        private Dictionary<Direction, int> Exits = new Dictionary<Direction, int>();
        public readonly bool IsExit;
        public readonly int BattleSpace;
        private List<Monster> MonsterList = new List<Monster>();
        private Dictionary<Monster, int> MonstersLevels = new Dictionary<Monster, int>();

        public Dungeon(LocationID id, string name, string description, int dimensionX, int dimensionY, int floors, int BattleSpace) : base(id, name, description)
        {
            DimensionX = dimensionX;
            DimensionY = dimensionY;
            Floors = floors;

            Exits[Direction.North] = 1;
            Exits[Direction.South] = 1;
            Exits[Direction.West] = 1;
            Exits[Direction.East] = 1;
        }

        public void SetExitTo(Direction direction, int floor)
        {
            if (floor > Floors)
            {
                floor = Floors;
            }

            if (floor < 1)
            {
                floor = 1;
            }

            Exits[direction] = floor; 
        }

        public void AddMonster(Monster monster, int level)
        {
            MonsterList.Add(monster);
            MonstersLevels.Add(monster, level);
        }

        public Monster GetMonster(Monster monster)
        {
            if (MonsterList.Contains(monster))
            {
                Monster MonsterInLevel;


            }

            return null;
        }
    }
}
