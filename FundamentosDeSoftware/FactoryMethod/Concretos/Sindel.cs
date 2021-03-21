using FactoryMethodProject.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodProject.Concretos
{
    public class Sindel : IPersonagem
    {
        public void Escolhido()
        {
            Console.Write("Sindel");
        }

        
    }
}
