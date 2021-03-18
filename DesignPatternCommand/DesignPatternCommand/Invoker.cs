using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCommand
{
    // O Invoker está associado a um ou vários comandos. Envia um pedido ao comando.
    class Invoker
    {
        private ICommand _onStart;

        private ICommand _onFinish;

        // Inicializa os comandos
        public void SetOnStart(ICommand command) //invoker passa requisição que inicia o comando simple command
        {
            this._onStart = command;
        }

        public void SetOnFinish(ICommand command)
        {
            this._onFinish = command;
        }

        // O Invoker não depende de classes concretas de comando ou receptor.
        // O Invoker passa uma solicitação a um receptor indiretamente, executando um comando
        
        public void DoSomethingImportant()
        {
            Console.WriteLine("Invoker: Alguém precisa de algo que seja mais importante do que o que estou fazendo?");
            if (this._onStart is ICommand)
            {
                this._onStart.Execute();
            }

            Console.WriteLine("Invoker: ...fazendo algo realmente importante...");

            Console.WriteLine("Invoker: Alguém precisa que eu faça algo depois que eu terminar o que já estou fazendo?");
            if (this._onFinish is ICommand)
            {
                this._onFinish.Execute();
            }
        }
    }
}
