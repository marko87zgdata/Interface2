using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2
{
    class Mp3Player: Device, IPrenosivi
    {
        public string Model { get; set; }
        public int BatteryCapacity { get; set; }
        public int MemorySize { get; set; }

        public Mp3Player(string model, int batteryCapacity, int memorySize)
        {
            Model = model;
            BatteryCapacity = batteryCapacity;
            MemorySize = memorySize;
        }

        public void GetModel()
        {
            Console.WriteLine(Model);
        }

        public void GetBatteryCapacity()
        {
            Console.WriteLine(BatteryCapacity);
        }
    }
}
