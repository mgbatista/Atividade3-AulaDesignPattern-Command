using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCommand
{
    // No entanto, alguns comandos podem delegar operações mais complexas a outros
    // objetos, chamados de "receptores".
    class ComplexCommand : ICommand
    {
        private Receiver _receiver;

        // Dados de contexto, necessários para lançar os métodos do receptor.
        private string _a;

        private string _b;

        // Comandos complexos podem aceitar um ou vários objetos receptores junto
        // com quaisquer dados de contexto por meio do construtor.
        public ComplexCommand(Receiver receiver, string a, string b) //função que irá receber as strings passadas junto com receiver no complexcommand
        {
            this._receiver = receiver;
            this._a = a;
            this._b = b;
        }

        // Os comandos podem delegar a qualquer método de um receptor.
        public void Execute()
        {
            Console.WriteLine("ComplexCommand: Coisas complexas devem ser feitas por um objeto receptor.");
            this._receiver.DoSomething(this._a);
            this._receiver.DoSomethingElse(this._b);
        }
    }
}
