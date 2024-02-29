
namespace AdvancedTopics.Exercise8
{
    public partial class Computer : Base, IComputer
    {
        public Computer(/*string brand, Color color*/)
        {
            //Brand = brand;
            //DeviceColor = color;

            Id = new Random().Next(1, 2000);
        }

        public string Brand { get; set; } = "HP";
        public virtual Color DeviceColor { get; set; } = Color.Beige;
        public bool? PoweredOn { get; private set; }

        public void PowerOn()
        {
            PoweredOn ??= true;
        }
    }

    public partial class Computer : Base, IComputer
    {
        //in case you want to support a deconstruction 
        public void Deconstruct(out int id, out string brand, out Color colour)
        {
            id = Id;
            brand = Brand;
            colour = DeviceColor;
        }

        public virtual void ExecuteProgram(string program)
        {
            PowerOn();
            Console.WriteLine($"Program {program} is executing...");
        }

        public override string ToString() => 
            $"This {nameof(Computer)}: {Id}, {Brand}, {DeviceColor}, {((PoweredOn == true) ? " is On" : "is Off")} ";
    }
}
