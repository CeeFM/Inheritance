namespace Garage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        public virtual void Drive() 
        {
            Console.WriteLine("Vroooom!");
        }

        public virtual void Turn(string direction)
        {
            Console.WriteLine($"Dang that {this.MainColor} vehicle really turned {direction}!");
        }

        public virtual void Stop()
        {
            Console.WriteLine($"Dang that {this.MainColor} vehicle really stopped!");
        }
    }
}