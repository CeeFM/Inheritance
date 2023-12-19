namespace Garage
{
    public class Cessna : Vehicle, IGasVehicle
    {
        public double FuelCapacity { get; set; }

        
        public override void Drive()
        {
            Console.WriteLine($"The {this.MainColor} Cessna zooms past you in an aggressive and borderline offensive fashion. WHOOOSH WHOOOOSH SPLASH FRICKIN PUDDLE IN YOUR FACE!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {this.MainColor} Cessna flips a sick {direction} turn and flips you off. Boss move but sucks to be you tho.");
        }

        
        public override void Stop()
        {
            Console.WriteLine($"The {this.MainColor} Cessna freakin skrrrtt skrrrrt skrrrtttttssss to a stop in front of you all baller like!");
        }


        public void RefuelTank()
        {
            this.FuelCapacity = 100;
            Console.WriteLine($"Your {MainColor} Cessna is now refueled to {this.FuelCapacity}% capacity.");         
        }

        public void CurrentTankPercentage()
        {
            Console.WriteLine($"The {this.MainColor} Cessna's fuel tank is currently at {this.FuelCapacity}%.");
        }
    }
}