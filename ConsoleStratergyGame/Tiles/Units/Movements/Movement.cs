using ConsoleStratergyGame.Map;
using ConsoleStratergyGame.Tiles.Lands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleStratergyGame.Tiles.Units;
using System.Runtime.CompilerServices;

namespace ConsoleStratergyGame.Tiles.Units.Movements
{
    public class Movement
    {

        public int[,] Moves { get; set; }
        public Movement(ClassType Class_Type)
        {
            Moves = genMoves(Class_Type);
        }

        public static void moveUnit(Position goTo, Tile self)
        { 
            MapHandler.Map[self.Pos.Y, self.Pos.X] = new Land(new Position(self.Pos.Y, self.Pos.X));
            self.Pos = goTo;
            MapHandler.Map[goTo.Y, goTo.X] = self;

        }





        public void showMovesMap(in Tile self) {
            int[,] MovesMap = new int[MapHandler.Map.GetLength(0), MapHandler.Map.GetLength(1)];


            for (int i = 0, j = 0; (j * i) < ((MapHandler.Map.GetLength(0)) * (MapHandler.Map.GetLength(1) - 1)); i++)
            {
                if (i > MovesMap.GetLength(1) - 1)
                {
                    j++;
                    i = 0;
                }
                for (int k = 0; k < Moves.GetLength(0); k++)
                {

                    if ((j == (self.Pos.Y + Moves[k, 0])) && (i == (self.Pos.X + Moves[k, 1])))
                    {
                        MovesMap[j, i] =1;
                    }
                }
            }

            MovesMap[self.Pos.Y, self.Pos.X] = 3;


            StringBuilder mapString = new StringBuilder();
            for (int i = 0, j = 0; (j * i) < ((MovesMap.GetLength(0)) * (MovesMap.GetLength(1) - 1)); i++)
            {
                if (i > MovesMap.GetLength(1) - 1)
                {
                    j++;
                    i = 0;
                    mapString.Append("\n");
                }
                mapString.Append(MovesMap[j, i]);
            }
            Console.WriteLine(mapString.ToString());


        }



        //Not sure if to put the moves of the unit in their own class might change latter;
        public int[,] genMoves(ClassType Class_Type)
        {
            //This is the method that generates the moved used by the different unit_Type
            switch (Class_Type)
            {
                case ClassType.Assasin:
                    return new int[,]
                    {
                      {0,-1}, {0,-2}, {0,-3}, { 0,0},{0,1}, {0,2}, {0,3}
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
}
