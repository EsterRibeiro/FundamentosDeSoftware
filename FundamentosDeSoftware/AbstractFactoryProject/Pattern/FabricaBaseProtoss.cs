using AbstractFactoryProject.Concretos;
using AbstractFactoryProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryProject.Pattern
{
    public class FabricaBaseProtoss : IFabricaBases
    {
        public FabricaBaseProtoss()
        {
            CriarBase();
        }

        public void CriarBase()
        {
            RevestimentoBaseProtoss revestimento = new RevestimentoBaseProtoss();
            EnergiaBaseProtoss energia = new EnergiaBaseProtoss();

            revestimento.Composicao();
            energia.Composicao();

            Console.WriteLine("Base Protoss criada com sucesso!");
        }
    }
}
