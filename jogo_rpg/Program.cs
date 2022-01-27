using static System.Console;

namespace jogo_rpg.src.Entities
{
    class program
    {
        static void Main()
        {
            Knight knight = new Knight("Arus", 23, "Knight");
            WhiteWizzard whiteWizzard = new WhiteWizzard("Jenica", 23, "WhiteWizzard");
            Ninja ninja = new Ninja("Hanzo", 23, "Ninja");
            BlackWizzard blackWizzard = new BlackWizzard("Gorpo", 23, "BlackWizzard");
           
            WriteLine(knight.ToString());
            WriteLine(ninja.ToString());
            WriteLine(whiteWizzard.ToString());
            WriteLine(blackWizzard.ToString());
            
            WriteLine(knight.Moto().ToString());
            WriteLine(ninja.Moto().ToString());
            WriteLine(whiteWizzard.Moto().ToString());
            WriteLine(blackWizzard.Moto().ToString());
            
            WriteLine();

            WriteLine(knight.Action().ToString());
            WriteLine(ninja.Action().ToString());
            WriteLine(whiteWizzard.Action().ToString());
            WriteLine(blackWizzard.Action().ToString());
            
            WriteLine();

            WriteLine(knight.SpecialMove().ToString());
            WriteLine(ninja.SpecialMove().ToString());
            WriteLine(whiteWizzard.SpecialMove().ToString());
            WriteLine(blackWizzard.SpecialMove().ToString());
        }
    }
}
