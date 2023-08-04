using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStratergyGame.Tiles.Lands
{
    internal class Land : Tile
    {
        public override string Icon { get; set; } = "+";
        public override TileType Type { get; set; } = TileType.Land;
        public Land() { }
    }
}
