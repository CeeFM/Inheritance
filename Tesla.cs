namespace Garage
{
    public class Tesla : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            this.BatteryKWh = 100;
            Console.WriteLine($"Your {MainColor} Tesla is now charged to {this.BatteryKWh}KWh");
        }
        public override void Drive()
        {
            Console.WriteLine($"OH SHIT! THIS {this.MainColor.ToUpper()} TESLA IS ON FIRE! GET OUT!!! WHY IS IT DRIVING TOWARDS THAT PEDESTRIAN!!!! NOOOO TESLAA NOOOOOOOO!!!!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The {this.MainColor} Tesla starts to turn {direction} but stops mid-turn because it is fully engulfed in flames and for some reason is actively targeting pedestrians to drive at.");
        }

        
        public override void Stop()
        {
            Console.WriteLine($"The {this.MainColor} Tesla really stopped quickly. Not sure if it was reacting to the brake pedal or if it was truly just too covered in literal fire to continue operating. Either way, 10/10.");
        }    
        public void CurrentChargePercentage()
        {
            Console.WriteLine($"The {this.MainColor} Tesla's battery charge is currently at {this.BatteryKWh}%. Also, it is on fire and attempting to murder pedestrians. Great company!");
        }    
    }
}