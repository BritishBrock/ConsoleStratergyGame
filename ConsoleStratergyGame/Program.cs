using ConsoleStratergyGame.Map;
using ConsoleStratergyGame.Tiles;
using ConsoleStratergyGame.Tiles.Units;
using ConsoleStratergyGame.Tiles.Units.Classes;
using ConsoleStratergyGame.Tiles.Units.Movements;

namespace ConsoleStratergyGame {
    class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            MapHandler.genNewMap(10,10);
            MapHandler.populateMap();
            MapHandler.Map[0, 0] = new Assasin(UnitType.Friendly,new Position(0,0));
            Assasin choice = (Assasin)MapHandler.Map[0, 0];
            Movement.moveUnit(new Position(4,4), choice);
            choice.Movements.showMovesMap(choice);
            MapHandler.showMap();
            MapHandler.saveMap();
            Console.ReadLine();
        }
    }
}