using System;
using System.Collections.Generic;
//ing System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvancedTopics.Exercise8;

namespace UnitTest.AdvancedTopic
{
    public class Exercise8
    {

        [Fact]
        public void Result_Computer_Return()
        {
            IEnumerable<Computer> computers = new List<Computer>()
            {
                new Laptop { Brand = "Dell", DeviceColor = Color.Black },
                new Laptop { Brand = "Lenovo", DeviceColor = Color.Black},
                new Desktop { Brand = "Asus", DeviceColor = Color.Transparant }
            };
            Computer[] pcs = computers.ToArray();
            string[] pcs = { "een", "twee", "drie" }; //will not be accepted -> string is not type Computer
            IList<Computer> pcs = computers.ToList();
            IEnumerable<Laptop> laptops = new List<Laptop>()
            {
                new Laptop { Brand = "Dell", DeviceColor = Color.Black },
                new Laptop { Brand = "Acer", DeviceColor = Color.White},
                new Laptop { Brand = "IBM", DeviceColor = Color.Beige}
            };


            Laptop[] pcs2 = laptops.ToArray();
            var (firstComputer, (secondComputer, (thirdComputer, _))) = pcs2;
            //Arrange
            // Act
            // Assert
        }

    }
}
