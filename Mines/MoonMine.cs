using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergeticDevelopment.Mines
{
    public class MoonMine : Mine
    {
        int HeliumProduction { get; set; } = 10;

        public MoonMine(int heliumProduction) : base()
        {
            HeliumProduction = heliumProduction;
        }
    }
}
