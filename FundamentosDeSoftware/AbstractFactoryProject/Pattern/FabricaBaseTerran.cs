using AbstractFactoryProject.Concretos;
using AbstractFactoryProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryProject.Pattern
{
    public class FabricaBaseTerran : IFabricaBases
    {
        public FabricaBaseTerran()
        {
            CriarBase();
        }

        public void CriarBase()
        {      
            RevestimentoBaseTerran revestimento = new RevestimentoBaseTerran();
            EnergiaBaseTerran energia = new EnergiaBaseTerran();

            revestimento.Composicao();
            energia.Composicao();

            Console.WriteLine("Base Terran criada com sucesso!");
        }
    }
}
