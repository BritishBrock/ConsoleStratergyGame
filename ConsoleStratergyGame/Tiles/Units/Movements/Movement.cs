using ConsoleStratergyGame.Map;
using ConsoleStratergyGame.Tiles.Lands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleStratergyGame.Tiles.Units;

namespace ConsoleStratergyGame.Tiles.Units.Movements
{
    public class Movement
    {

        public int[,] Moves { get; set; }
        public Movement(ClassType Class_Type) {
            Moves = genMoves(Class_Type);
        }

        public static void moveUnit(Position goTo, Unit self)
        {
            MapHandler.Map[self.Pos.Y, self.Pos.X] = new Land(Position(self.Pos.Y,self.Pos.X));
        }









        //Not sure if to put the moves of the unit in their own class might change latter;
        public int[,] genMoves(ClassType Class_Type)
        {
            //This is the method that generates the moved used by the different unit_Type
           switch(Class_Type)
            {
                case ClassType.Assasin:
                    return new int[,]
                    {
                        { 0,0}
                    };
                    break;
                default:
                    return new int[,]
                    {
                        { 0,0}
                    };
                break;
            }
    }
}
