using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsCodeCademy
{
    abstract class Vehicle
    {
        public string LicensePlate
        { get; protected set; }
        public double Speed
        { get; protected set; }
        public int Wheels
        { get; protected set; }
        public static int NumVehicles
        { get; private set; }

        public Vehicle(double speed)
        {
            Speed = speed;
            LicensePlate = "IM-341-CL";
            NumVehicles++;
        }

        public virtual void SpeedUp()
        {
            Speed += 5;
        }

        public virtual void SlowDown()
        {
            Speed -= 5;
        }

        public void Honk()
        {
            Console.WriteLine("HONK!!!!");
        }

        public abstract string Describe();
    }
}
