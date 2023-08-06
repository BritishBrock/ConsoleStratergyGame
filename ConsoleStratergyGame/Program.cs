using ConsoleStratergyGame.Map;

namespace ConsoleStratergyGame {
    class Program
    {
        public static void Main()
        {
            MapHandler.genNewMap(10,10);
            MapHandler.populateMap();
            MapHandler.showMap();
            MapHandler.saveMap();
            Console.ReadLine();
        }
    }
}