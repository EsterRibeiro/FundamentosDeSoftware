using AbstractFactoryProject.Interfaces;
using AbstractFactoryProject.Pattern;
using System;

namespace AbstractFactoryProject
{
    /// <summary>
    /// Abstract Factory: escopo de objetos
    /// Abstract Factory: agrupa diversos factories que possuem características semelhantes com uma única interface.
    /// Ex: tenho 3 personagens que criam a base da mesma forma, com características diferentes
    /// A partir da interface IFabricaBases, todas as classes tem o mesmo método implementado de acordo com o personagem escolhido.
    /// </summary>
    class Program
    {
        private static bool _op = true;

        static void Main(string[] args)
        {
            while(_op)
            {
                Fabricando();
                Console.WriteLine("Deseja finalizar? S/N");
                var sair = Console.ReadLine();

                if (sair == "S" || sair == "s")
                    _op = false;
                else
                    continue;
            }
            
        }

        public static void Fabricando()
        {

            IFabricaBases fabrica;

            Console.WriteLine("Escolha um dos personagens: 1 - Protoss | 2 - Zerg | 3 - Terranos");

            switch (Console.ReadLine())
            {
                case "1":
                    fabrica = new FabricaBaseProtoss();
                    break;
                case "2":
                    fabrica = new FabricaBaseZerg();
                    break;
                case "3":
                    fabrica = new FabricaBaseTerran();
                    break;
                default:
                    Console.WriteLine("Escolha uma opção válida");
                    break;
            }

        }
    }
}
