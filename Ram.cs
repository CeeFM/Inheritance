namespace Garage
{
    public class Ram : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            Console.WriteLine($"Your Ram is now refueled to {this.FuelCapacity}% capacity.");        
        }

        public override void Drive()
        {
            Console.WriteLine($"The {this.MainColor} Ram cruises by you like lightning. SNORT SNORT GUZZLE GUZZLE I WILL END THE EARTH!!!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {this.MainColor} Ram does a wild {direction} turn and nearly flies off the road. Wish I was recording that rn, damn.");
        }

        
        public override void Stop()
        {
            Console.WriteLine($"The {this.MainColor} Ram took forever to slow all the way down but finally came to a screeching roaring stop.");
        }
    }
}