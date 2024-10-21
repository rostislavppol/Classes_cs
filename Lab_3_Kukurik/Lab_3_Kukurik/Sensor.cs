using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Kukurik
{
    public abstract class Sensor
    {
        public string Name { get; set; }
        public bool IsActive { get; set; }

        public Sensor(string name)
        {
            Name = name;
            IsActive = false;
        }

        public void Activate()
        {
            IsActive = true;
            Console.WriteLine($"{Name} activated.");
        }

        public void Deactivate()
        {
            IsActive = false;
            Console.WriteLine($"{Name} deactivated.");
        }

        public abstract bool CheckSensor();
    }

    public class FireSensor : Sensor
    {
        private bool _isFireDetected;

        public FireSensor(string name) : base(name)
        {
            _isFireDetected = false;
        }


        public void DetectFire()
        {
            _isFireDetected = true;
            Console.WriteLine($"{Name} detected fire!");
        }

        public override bool CheckSensor()
        {
            return _isFireDetected;
        }
    }
}
