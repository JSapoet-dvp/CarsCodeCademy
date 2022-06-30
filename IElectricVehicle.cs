using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsCodeCademy
{
    interface IElectricVehicle
    {
        double Battery { get; }
        double DistancePotential { get; }
    }
}
