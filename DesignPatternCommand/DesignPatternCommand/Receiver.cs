using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCommand
{
    // As classes Receiver contêm algumas lógicas de negócios importantes. Eles sabem como
    // realizar todos os tipos de operações, associadas à realização de uma
    // solicitação. Na verdade, qualquer classe pode servir como Receptor.
    class Receiver
    {
        public void DoSomething(string a)
        {
            Console.WriteLine($"Receiver: Trabalhando em ({a}.)");
        }

        public void DoSomethingElse(string b)
        {
            Console.WriteLine($"Receiver: Trabalhando também em ({b}.)");
        }
    }
}
