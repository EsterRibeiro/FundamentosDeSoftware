using SingletonProject.Pattern;
using System;


namespace SingletonProject
{
    /// <summary>
    /// Singleton - escopo objeto
    /// Singleton - Garantir que apenas uma única instância de objeto seja criada
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Singleton jogador1 = Singleton.GetInstancia;
            jogador1.Mensagem("A bola está comigo no meio do campo!");

            Singleton jogador2 = Singleton.GetInstancia;
            jogador2.Mensagem("Jogador2 recebeu a bola");

            Singleton jogador3 = Singleton.GetInstancia;
            jogador3.Mensagem("Jogador3 tomou a bola");

            Console.ReadKey();
        }
    }
}
