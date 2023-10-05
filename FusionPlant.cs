using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergeticDevelopment
{
    public class FusionPlant : PowerPlant
    {
        int HeliumConsumption { get; set; }  = 1;

        public FusionPlant(int energyProduction, int heluimConsumption) : base(energyProduction)
        {
            energyProduction = 20000;
            HeliumConsumption = heluimConsumption;
        }
    }
}
