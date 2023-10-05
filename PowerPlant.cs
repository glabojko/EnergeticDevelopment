using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergeticDevelopment
{
    public class PowerPlant
    {
        int EnergyProduction { get; set; }

        public PowerPlant(int energyProduction)
        {
            EnergyProduction = energyProduction;
        }
    }
}
