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
        int EnergyProduction { get; set; } = 30000;

        public NuclearPlant(int energyProduction, int uraniumConsumption) : base(energyProduction)
        {
            UraniumConsumption = uraniumConsumption;
            energyProduction = 10000;
        }

        public string ShowEnergyProduction()
        {
            return $"Our nuclear plant can produce up to {EnergyProduction} MWh per day.";
        }
    }
}
