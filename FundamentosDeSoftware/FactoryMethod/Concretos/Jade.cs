using FactoryMethodProject.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodProject.Concretos
{
    public class Jade : IPersonagem
    {
        public void Escolhido()
        {
            Console.Write("Jade");
        }
    }
}
