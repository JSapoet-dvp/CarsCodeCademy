using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsCodeCademy
{
    class Truck : Vehicle, IAutomobile
    {
        public double Weight            // why only get? Check CodeCademy
        { get; }

        public Truck(double speed, double weight) : base (speed)
        {
            Weight = weight;
            Wheels = Weight > 400 ? 12 : 8;
        }

        public override string Describe()
        {
            return $"This Truck has {Wheels} wheels and is moving {Speed} km/h, with license plate {LicensePlate}\n";
        }
    }
}
