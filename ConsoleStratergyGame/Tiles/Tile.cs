using ConsoleStratergyGame.Tiles.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStratergyGame.Tiles
{
    abstract class Tile
    {

        public enum TileType
        {
            Unit,
            Land,
            Item,
        }

        public abstract string Icon { get; set; }

        public abstract TileType Type { get; set; }

        public object returnAsType(object obj) {

            return obj as Unit;
        }


    }

    
}
