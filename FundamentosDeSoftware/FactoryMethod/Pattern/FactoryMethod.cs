
using FactoryMethodProject.Concretos;
using FactoryMethodProject.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodProject.Pattern
{
    public class FactoryMethod
    {
        public IPersonagem EscolherPersonagem(string personagem)
        {
            switch (personagem)
            {
                case "Sindel":
                    return new Sindel();
                case "Mileena":
                    return new Mileena();
                case "Jade":
                    return new Jade();
                default:
                    return null;
            }
        }
    }
}
