using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCommand
{
    // Alguns comandos podem implementar operações simples por conta própria.
    class SimpleCommand : ICommand
    {
        private string _payload = string.Empty; //criou uma variavel vazia

        public SimpleCommand(string payload) //Essa função recebe a string passada na program SetOnStart Olá Galera, que irá compor a variavel acima
        {
            this._payload = payload;
        }

        public void Execute()
        {
            Console.WriteLine($"SimpleCommand: Posso fazer coisas simples como imprimir ({this._payload})");
        }
    }
}
