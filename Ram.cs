namespace Garage
{
    public class Ram : Vehicle, IGasVehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            this.FuelCapacity = 100;
            Console.WriteLine($"Your {MainColor} Ram is now refueled to {this.FuelCapacity}% capacity.");        
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram cruises by you like lightning. SNORT SNORT GUZZLE GUZZLE I WILL END THE EARTH!!!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Ram does a wild {direction} turn and nearly flies off the road. Wish I was recording that rn, damn.");
        }

        
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Ram took forever to slow all the way down but finally came to a screeching roaring stop.");
        }

        public void CurrentTankPercentage()
        {
            Console.WriteLine($"The {MainColor} Ram's fuel tank is currently at {this.FuelCapacity}%.");
        }
    }
}