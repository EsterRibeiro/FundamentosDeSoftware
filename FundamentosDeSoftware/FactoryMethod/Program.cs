using FactoryMethodProject.Interface;
using FactoryMethodProject.Pattern;
using System;


namespace FactoryMethodProject
{
    /// <summary>
    /// Factory Method/ Construtor virtual: Escopo - classe
    /// Objetivo: Criar uma fábrica de classes em tempo de execução e deixar que
    /// a classe decida seu tipo dinamicamente.
    /// </summary>
    class Program
    {
        static void Main(String[] args)
        {
            FactoryMethod factoryMethod = new FactoryMethod();

            Console.WriteLine("Mileena | Sindel | Jade");

            Console.WriteLine("Escolha seu personagem: ");
            string escolha = Console.ReadLine();

            IPersonagem personagem = factoryMethod.EscolherPersonagem(escolha);
            Console.WriteLine($"Você vai jogar com: {escolha}");
        }
    }
}
