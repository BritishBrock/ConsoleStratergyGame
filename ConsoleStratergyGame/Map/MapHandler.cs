
using ConsoleStratergyGame.Tiles;
using ConsoleStratergyGame.Tiles.Lands;
using System.Text;
using Newtonsoft.Json;

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
                Map[j, i] = new Land(new Position(j,i));
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
        public static void saveMap()
        {
            string path = "C:\\Users\\Devnubbius\\source\\repos\\ConsoleStratergyGame\\ConsoleStratergyGame\\Map\\out.json";
            StreamWriter sr = new StreamWriter(path);
            string json = JsonConvert.SerializeObject(Map);
            sr.Write(json);
            sr.Close();
        }


        //Not in use currently using the netwonsfot package
        //public static List<Tile> serializeMap()
        //{
        //    List<Tile> mapSerialized = new List<Tile>();
        //    for (int i = 0, j = 0; (j * i) < ((Map.GetLength(0)) * (Map.GetLength(1) - 1)); i++)
        //    {
        //        if (i > Map.GetLength(1) - 1)
        //        {
        //            j++;
        //            i = 0;
                   
        //        }
        //        mapSerialized.Add(Map[j,i]);
        //    }
        //    return mapSerialized;

        //}
    }
}
