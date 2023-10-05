using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergeticDevelopment
{
    public class AnnihilationPlant : PowerPlant
    {
        int AntimatterConsumption { get; set; } = 1;

        public AnnihilationPlant(int energyProduction, int antimatterConsumption) : base(energyProduction)
        {
            energyProduction = 25000;
            AntimatterConsumption = antimatterConsumption;
        }
    }
}
