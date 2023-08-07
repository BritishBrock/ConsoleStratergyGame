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


        public Tile(Position pos)
        {
            Pos = pos;
        }


        public object returnAsType(object obj) {

            return obj as Unit;
        }


    }

    public struct Position
    {
        int X { get; set; }
        int Y { get; set; }
        public Position(int x,int y)
        {
            X = x;
            Y = y;
        }
    }
}
