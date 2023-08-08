using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Unicode;
namespace ConsoleStratergyGame.Tiles.Units.Movements
{
    internal class UnitMoveTile : Tile
    {
        public override string Icon { get; set; } = "■";
        public override TileType Type { get; set; } = TileType.Land;
        public override ConsoleColor Tile_Color { get ; set; }

        public UnitMoveTile(Position pos,Boolean inUnitMoveList):base(pos) { 
            if(inUnitMoveList) Tile_Color = ConsoleColor.Yellow;
            else Tile_Color = ConsoleColor.Red;
        }
    }
}
