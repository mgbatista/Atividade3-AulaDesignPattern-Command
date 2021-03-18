using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCommand
{
    // A interface Command declara um método para executar um comando.
    public interface ICommand
    {
        void Execute();
    }
}
