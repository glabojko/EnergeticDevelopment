using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergeticDevelopment.Consumers
{
    public class World
    {
        int EnergyConsumption { get; set; } = 6000000;

        public World(int energyConsumption)
        {
            EnergyConsumption = energyConsumption;
        }
    }
}
