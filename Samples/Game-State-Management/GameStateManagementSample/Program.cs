using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameStateManagementSample
{
#if WINDOWS || XBOX
    static class Program
    {
        static void Main(string[] args)
        {
            using (GameStateManagementSampleGame game = new GameStateManagementSampleGame())
                game.Run();
        }
    }
#endif
}
