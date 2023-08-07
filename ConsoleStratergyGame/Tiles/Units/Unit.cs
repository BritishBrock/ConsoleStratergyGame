using ConsoleStratergyGame.Tiles.Units.Movements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStratergyGame.Tiles.Units;

public abstract class Unit : Tile
{
    public abstract Movement Movements { get; set; }
    public abstract UnitType Unit_Type { get; set; }
    public abstract ClassType Class_Type { get; set; }
    public override string Icon { get; set; } = "x";
    public override TileType Type { get; set; } = TileType.Unit;


    public Unit(Position pos) : base(pos)
    {
       
    }
 
}

public enum ClassType
{
    Sniper,
    Assasin,
    Rogue,
}
public enum UnitType
{
    Friendly,
    Enemy,
}
