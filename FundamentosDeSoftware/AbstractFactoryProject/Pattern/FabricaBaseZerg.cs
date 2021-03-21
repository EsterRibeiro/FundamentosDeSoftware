using AbstractFactoryProject.Concretos;
using AbstractFactoryProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryProject.Pattern
{
    public class FabricaBaseZerg : IFabricaBases
    {
        public FabricaBaseZerg()
        {
            CriarBase();
        }

        public void CriarBase()
        {
            RevestimentoBaseZerg revestimento = new RevestimentoBaseZerg();
            EnergiaBaseZerg energia = new EnergiaBaseZerg();

            revestimento.Composicao();
            energia.Composicao();

            Console.WriteLine("Base zerg criada com sucesso!");
        }
    }
}
