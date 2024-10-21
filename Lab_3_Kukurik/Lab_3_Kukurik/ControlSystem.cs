using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Kukurik
{
    public class ControlSystem
    {
        private List<Sensor> _sensors;
        private FireSuppressionSystem _fireSuppressionSystem;

        public ControlSystem()
        {
            _sensors = new List<Sensor>();
            _fireSuppressionSystem = new FireSuppressionSystem();
        }


        public void AddSensor(Sensor sensor)
        {
            _sensors.Add(sensor);
            Console.WriteLine($"Sensor {sensor.Name} added to the system.");
        }


        public void CheckSensors()
        {
            foreach (var sensor in _sensors)
            {
                if (sensor.CheckSensor())
                {
                    Console.WriteLine($"Warning: {sensor.Name} detected a problem.");
                    _fireSuppressionSystem.Activate();
                    return;
                }
            }

            Console.WriteLine("All sensors are normal.");
        }
    }
}
