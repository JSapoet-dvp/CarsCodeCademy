using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsCodeCademy
{
    class Hybrid : Vehicle, IAutomobile, IElectricVehicle
    {
        public double Battery
        { get; private set; }
        public double DistancePotential
        { get; private set; }

        public Hybrid(double speed, double battery) : base(speed)
        {
            Battery = battery;
            DistancePotential = (battery / 5) + 150;
            Wheels = 4;
        }

        public override void SpeedUp()
        {
            Speed += 10;
        }

        public override void SlowDown()
        {
            Speed -= 10;
        }

        public override string Describe()
        {
            return $"This Hybrid moves on {Wheels} wheels with {Speed} km/h. With a battery power of {Battery}, it has a distance potential of {DistancePotential} km.\n";
        }
    }
}
