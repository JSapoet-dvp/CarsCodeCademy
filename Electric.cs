using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsCodeCademy
{
     class Electric : Vehicle, IAutomobile, IElectricVehicle
    {
        public double Battery
        { get; private set; }
        public double DistancePotential
        { get; private set; }

        public Electric(double speed, double battery) : base(speed)
        {
            Battery = battery;
            DistancePotential = (battery / 6) + 100;
        }

        public override void SpeedUp()
        {
            Speed += 11;
        }

        public override void SlowDown()
        {
            Speed -= 8;
        }

        public override string Describe()
        {
            return $"This Electric moves on {Wheels} wheels with {Speed} km/h. With a battery power of {Battery}, it has a distance potential of {DistancePotential} km.\n";
        }
    }
}
