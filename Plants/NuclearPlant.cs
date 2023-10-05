using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergeticDevelopment.Plants
{
    public class NuclearPlant : PowerPlant
    {
        int UraniumConsumption { get; set; } = 1;

        public NuclearPlant(int energyProduction, int uraniumConsumption) : base(energyProduction)
        {
            UraniumConsumption = uraniumConsumption;
            energyProduction = 10000;
        }
    }
}
