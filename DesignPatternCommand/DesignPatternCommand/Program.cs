using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            // O código do cliente pode parametrizar um invocador com quaisquer comandos.
            Invoker invoker = new Invoker(); // Invoker invoca o comando simplecommand abaixo
            invoker.SetOnStart(new SimpleCommand("Olá Galera!"));
            Receiver receiver = new Receiver(); //Receiver vai orquestrar o cmplexcommand, mostra em que etapa o complexcommand está
            invoker.SetOnFinish(new ComplexCommand(receiver, "Envio de e-mail", "Salvar relatório"));

            invoker.DoSomethingImportant();
        }
    }
}
