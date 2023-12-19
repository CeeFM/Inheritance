using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main (string[] args)
        {

            Zero fxs = new Zero();
            Zero fx = new Zero();
            Tesla modelS = new Tesla();
            fxs.MainColor = "Green";
            fx.MainColor = "Blue";
            modelS.MainColor = "Red and Orange";

            List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>() {
                fx, fxs, modelS
            };

            Console.WriteLine("Electric Vehicles");
            Console.WriteLine("=================");
            Console.WriteLine();
            foreach(IElectricVehicle ev in electricVehicles)
            {
                ev.CurrentChargePercentage();            }
            Console.WriteLine();

            foreach(IElectricVehicle ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }
            Console.WriteLine();

            foreach(IElectricVehicle ev in electricVehicles)
            {
                ev.CurrentChargePercentage();
            }
            Console.WriteLine();

            /***********************************************/

            Ram ram = new Ram ();
            Cessna cessna150 = new Cessna ();
            ram.MainColor = "Purple";
            cessna150.MainColor = "Fuchsia";

            List<IGasVehicle> gasVehicles = new List<IGasVehicle>() {
                ram, cessna150
            };

            Console.WriteLine("Gas Vehicles");
            Console.WriteLine("=================");
            Console.WriteLine();
            foreach(IGasVehicle gv in gasVehicles)
            {
                gv.CurrentTankPercentage();
            }
            Console.WriteLine();            

            foreach(IGasVehicle gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }
            Console.WriteLine();
            foreach(IGasVehicle gv in gasVehicles)
            {
                gv.CurrentTankPercentage();
            }
        }
    }
}