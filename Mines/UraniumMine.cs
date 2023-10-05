using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergeticDevelopment.Mines
{
    public class UraniumMine : Mine
    {
        int UraniumProduction { get; set; } = 100;

        public UraniumMine(int uraniumProduction) : base()
        {
            UraniumProduction = uraniumProduction;
        }
    }
}
