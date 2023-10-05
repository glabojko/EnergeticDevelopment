using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergeticDevelopment.Mines
{
    internal class CoalMine : Mine
    {
        int CoalProduction { get; set; } = 40;

        public CoalMine(int coalProduction) : base()
        {
            CoalProduction = coalProduction;
        }
    }
}
