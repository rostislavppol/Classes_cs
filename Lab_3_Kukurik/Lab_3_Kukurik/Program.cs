

namespace Lab_3_Kukurik
{
    class Program
    {
        static void Main(string[] args)
        {

            ControlSystem controlSystem = new ControlSystem();

            FireSensor fireSensor1 = new FireSensor("Fire Sensor 1");
            FireSensor fireSensor2 = new FireSensor("Fire Sensor 2");

            controlSystem.AddSensor(fireSensor1);
            controlSystem.AddSensor(fireSensor2);

            fireSensor1.Activate();
            fireSensor2.Activate();

            Console.WriteLine("Перевірка стану сенсорів (без виявлення пожежі):");
            controlSystem.CheckSensors();

            Console.WriteLine("\nСимуляція виявлення пожежі:");
            fireSensor1.DetectFire();


            controlSystem.CheckSensors();

            // Деактивація сенсорів
            fireSensor1.Deactivate();
            fireSensor2.Deactivate();

            Console.WriteLine("\nСенсори деактивовані.");
        }
    }
}
