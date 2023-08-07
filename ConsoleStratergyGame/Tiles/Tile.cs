using ConsoleStratergyGame.Tiles.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleStratergyGame.Tiles.Units.Unit;

namespace ConsoleStratergyGame.Tiles
{
    public abstract class Tile
    {

        public enum TileType
        {
            Unit,
            Land,
            Item,
        }

        public abstract string Icon { get; set; }

        public abstract TileType Type { get; set; }

        public Position Pos { get; set; }
        
        public WalkingCost Walking_Cost { get; set; }
        public Boolean isWalkable { get; set; }
        public Tile(Position pos)
        {
            Pos = pos;
        }


        public object returnAsType(object obj) {

            return obj as Unit;
        }


    }

    public enum WalkingCost {
        Normal,
        Hard,
        Easy,
    }


    public struct Position
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Position(int y,int x)
        {
            X = x;
            Y = y;
        }
    }
}
