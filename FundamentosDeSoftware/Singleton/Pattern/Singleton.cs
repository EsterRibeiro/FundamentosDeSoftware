using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonProject.Pattern
{
    //sealded - impede que outras classes herdem dela
    public sealed class Singleton
    {
        private static Singleton _instancia = null;

        public static Singleton GetInstancia
        {
            get
            { 
                if(_instancia == null)
                {
                    _instancia = new Singleton();
                    Console.WriteLine("Bola em jogo");
                }

                return _instancia;
            }
        }

        public void Mensagem(string mensg)
        {
            Console.WriteLine(mensg);
        }
    }
}
