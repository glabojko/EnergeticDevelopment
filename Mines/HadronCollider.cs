using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergeticDevelopment.Mines
{
    public class HadronCollider
    {
        int AntimatterProduction { get; set; } = 1 / 7;

        public HadronCollider(int antimatterProduction)
        {
            AntimatterProduction = antimatterProduction;
        }
    }
}
