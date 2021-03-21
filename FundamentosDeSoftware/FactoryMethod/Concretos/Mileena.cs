using FactoryMethodProject.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodProject.Concretos
{
    public class Mileena : IPersonagem
    {
        public void Escolhido()
        {
            Console.Write("Mileena");
        }
    }
}
