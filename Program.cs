using EnergeticDevelopment.Mines;
using EnergeticDevelopment.Plants;

namespace EnergeticDevelopment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var bobrek = new CoalMine(80);
            NuclearPlant zarnowiec = new NuclearPlant(0,0);
            Console.WriteLine(bobrek.ShowProduction());
            Console.WriteLine(zarnowiec.ShowEnergyProduction());
        }
    }
}

//1 energy unit is 1 MWh
//1 coal unit is 1000 tons of coal
//1 uranium unit is 100 kg of enriched uranium
//1 helium unit is 100 kg of helium-3
//1 antimatter unit is 1 gram of antimatter