using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergeticDevelopment.Consumers
{
    public class NewYork
    {
        int EnergyConsumption { get; set; } = 10000;

        public NewYork(int energyConsumption)
        {
            EnergyConsumption = energyConsumption;
        }
    }
}
