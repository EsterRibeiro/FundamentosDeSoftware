using AbstractFactoryProject.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryProject
{
    public class EnergiaBaseZerg : IEnergia
    {
        public void Composicao()
        {
            Console.WriteLine("Energia de sustentação da base pela terra");
        }
    }
}
