using ConsoleStratergyGame.Tiles.Units.Movements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStratergyGame.Tiles.Units.Classes
{
    internal class Assasin : Unit
    {
        public override Movement Movements { get ; set; }
        public override UnitType Unit_Type { get ; set; }
        public override ClassType Class_Type { get; set; } = ClassType.Assasin;
        
        public Assasin(UnitType unit_type,Position pos) : base(pos){ 
            Unit_Type = unit_type;
            Movements = new Movement(Class_Type);
        }


    }
}
