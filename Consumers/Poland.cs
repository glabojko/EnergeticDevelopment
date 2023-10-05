using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergeticDevelopment.Consumers
{
    public class Poland
    {
        int EnergyConsumption { get; set; } = 40000;

        public Poland(int energyConsumption)
        {
            EnergyConsumption = energyConsumption;
        }
    }
}
