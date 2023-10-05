using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergeticDevelopment.Plants
{
    public class SolarPlant : PowerPlant
    {
        public SolarPlant(int energyProduction) : base(energyProduction)
        {
            energyProduction = 2;
        }
    }
}
