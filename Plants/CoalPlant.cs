using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergeticDevelopment.Plants
{
    public class CoalPlant : PowerPlant
    {
        int CoalConsumption { get; set; } = 100;

        public CoalPlant(int energyProduction, int coalConsumption) : base(energyProduction)
        {
            CoalConsumption = coalConsumption;
            energyProduction = 7;

        }
    }
}
