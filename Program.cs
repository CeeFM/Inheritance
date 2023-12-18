using System;
using System.Collections.Generic;

namespace Garage {
    class Program {
        static void Main (string[] args) {
            Zero fxs = new Zero ();
            Tesla modelS = new Tesla ();
            Ram truck = new Ram ();
            Cessna wtf = new Cessna ();

            fxs.MainColor = "green";
            modelS.MainColor = "bright red and orange";
            truck.MainColor = "white";
            wtf.MainColor = "pink camo";

            fxs.Drive();
            fxs.Turn("right");
            fxs.Stop();
            Console.WriteLine();
            modelS.Drive();
            modelS.Turn("left");
            modelS.Stop();
            Console.WriteLine();
            truck.Drive();
            truck.Turn("right");
            truck.Stop();
            Console.WriteLine();
            wtf.Drive();
            wtf.Turn("left");
            wtf.Stop();

        }
    }
}