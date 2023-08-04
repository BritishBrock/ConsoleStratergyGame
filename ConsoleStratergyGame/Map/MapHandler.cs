
using ConsoleStratergyGame;
using ConsoleStratergyGame.Tiles;
using ConsoleStratergyGame.Tiles.Lands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStratergyGame.Map
{
    static class MapHandler
    {
        public static Tile[,] Map { get; set; } 
        public static void genNewMap(int sizeY = 100, int sizeX = 100) => Map = new Tile[sizeY,sizeX];
        public static void populateMap()
        {
            for (int i = 0, j = 0; (j * i) < ((Map.GetLength(0)) * (Map.GetLength(1) - 1)); i++)
            {
                if (i > Map.GetLength(1) - 1)
                {
                    j++;
                    i = 0;
                  
                }
                Map[j, i] = new Land();
            }
        }
        public static void showMap()
        {
            StringBuilder mapString = new StringBuilder();
            for(int i = 0,j = 0; (j*i) < ((Map.GetLength(0)) *(Map.GetLength(1)-1)) ;i++)
            {
                if ( i > Map.GetLength(1)-1)
                {
                    j++;
                    i = 0;
                    mapString.Append("\n");
                }
                mapString.Append(Map[j,i].Icon);
            }
            Console.WriteLine(mapString.ToString());
        }
    }
}
