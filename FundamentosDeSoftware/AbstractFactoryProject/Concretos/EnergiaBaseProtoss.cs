
using AbstractFactoryProject.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryProject
{
    public class EnergiaBaseProtoss : IEnergia
    {
        public void Composicao()
        {
            Console.WriteLine("Energia de sustentação da base cristais");
        }
    }
}
