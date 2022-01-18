using System;

namespace Hello_Game
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new HelloGame())
                game.Run();
        }
    }
}
