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
            Tile[,] MovesMap = new Tile[MapHandler.Map.GetLength(0), MapHandler.Map.GetLength(1)];


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
                        Console.WriteLine(j + "   " + i);
                        MovesMap[j, i] =new UnitMoveTile(new Position(j,i),ConsoleColor.Yellow);
                        k = Moves.GetLength(0);
                    }
                    else
                    {
                        MovesMap[j, i] = new UnitMoveTile(new Position(j, i), ConsoleColor.Red);
                    }
                }
            }
            MovesMap[self.Pos.Y, self.Pos.X] = new UnitMoveTile(new Position(self.Pos.Y, self.Pos.X), ConsoleColor.Blue); ;


            showMovesMap(MovesMap);

              //TODO: After showing you the map you can choose the square by moving your cursor tile to the location you want to move to.
              ConsoleKeyInfo input;
            Tile myPiece = MovesMap[self.Pos.Y, self.Pos.X];
            do
            {
                input = Console.ReadKey(true);
                switch (input.Key.ToString().ToLower())
                {
                    case "a":
                        checkAndMovePiece(0, -1, MovesMap, myPiece, self);
                        break;
                    case "d":
                        checkAndMovePiece(0, 1, MovesMap, myPiece, self);
                        break;
                    case "w":
                        checkAndMovePiece(-1, 0,  MovesMap,myPiece, self);
                        break;
                    case "s":
                        checkAndMovePiece(1,0,  MovesMap,myPiece, self);
                        
                        break;
                }
            } while (input.Key.ToString().ToLower() != "enter");

            moveUnit(new Position(myPiece.Pos.Y,myPiece.Pos.X), self);
        }

        public void checkAndMovePiece(int y,int x, Tile[,] MovesMap, Tile myPiece, Tile self) {
            
            if (MovesMap[myPiece.Pos.Y + y, myPiece.Pos.X+x].Tile_Color == ConsoleColor.Yellow)
            {
                MovesMap[myPiece.Pos.Y, myPiece.Pos.X] = new UnitMoveTile(new Position(self.Pos.Y, self.Pos.X), ConsoleColor.Yellow);
                myPiece.Pos = new Position(myPiece.Pos.Y+y, myPiece.Pos.X+x);
                MovesMap[myPiece.Pos.Y, myPiece.Pos.X] = new UnitMoveTile(new Position(self.Pos.Y, self.Pos.X), ConsoleColor.Blue);
                showMovesMap(MovesMap);
            }
        }


        public void showMovesMap(Tile[,]MovesMap) {
            Console.Clear();
            for (int i = 0, j = 0; (j * i) < ((MovesMap.GetLength(0)) * (MovesMap.GetLength(1) - 1)); i++)
            {
                if (i > MovesMap.GetLength(1) - 1)
                {
                    j++;
                    i = 0;
                    Console.WriteLine();
                }
                Console.ForegroundColor = MovesMap[j, i].Tile_Color;
                Console.Write(MovesMap[j, i].Icon + " ");
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
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
                                                { 3, 0 },   
                                                { 2, 0 },               
                                                { 1,0},
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
