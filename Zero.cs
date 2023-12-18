namespace Garage
{
    public class Zero : Vehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            Console.WriteLine($"Your Zero is now charged to {this.BatteryKWh}KWh");        
        }

        public override void Drive()
        {
            Console.WriteLine($"WOW THAT {this.MainColor.ToUpper()} ZERO IS REALLY STRUGGLING!!! CRACK SNAP POP THAT DOESNT SOUND GOOD!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The {this.MainColor} Zero does a wicked {direction} turn and then looks back at you all cool and impressively. Wow. What a moment.");
        }

        
        public override void Stop()
        {
            Console.WriteLine($"The {this.MainColor} Zero stopped pretty good I guess. Wasn't spectacular or anything. Pretty basic.");
        }        
    }
}