using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTopics.Exercise8
{
    public class Laptop : Computer
    {
        public Laptop(/*string brand, Color color, double resolution*/) /*: base(brand, color) */
        {
            //Resolution = resolution;
            BatteryLevel = 100;
        }

        public double Resolution { get; set; } = 13.3;
        public double BatteryLevel { get; private set; }
        public override Color DeviceColor { get; set; } = Color.Black;

        public void OpenLid()
        {
            Console.WriteLine("Lid is now open");
            PowerOn();
        }

        public void CloseLid()
        {
            Console.WriteLine("Lid is now closed");
        }

        public void ChargeBattery()
        {
            BatteryLevel = (BatteryLevel > 99) ? 100 : ++BatteryLevel;
        }

        public override void ExecuteProgram(string program)
        {
            base.ExecuteProgram(program);
            BatteryLevel = (BatteryLevel > 0) ? --BatteryLevel : 0;
        }

        public void Deconstruct(out int id, out string brand, out Color colour, out double resolution, out double batterylevel)
        {
            base.Deconstruct(out id, out brand, out colour);
            resolution = Resolution;
            batterylevel = BatteryLevel;
        }

        public override string ToString() =>
             $"{base.ToString()} and is a {nameof(Laptop)} with resolution {Resolution:00.0} and battery at {BatteryLevel:00.0}%";

    }
}
