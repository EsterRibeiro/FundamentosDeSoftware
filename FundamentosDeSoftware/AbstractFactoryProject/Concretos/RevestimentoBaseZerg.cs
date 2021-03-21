using AbstractFactoryProject.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryProject.Concretos
{
    public class RevestimentoBaseZerg : IRevestimento
    {
        public void Composicao()
        {
            Console.WriteLine("Base revestida pela cor vermelha");
        }
    }
}
