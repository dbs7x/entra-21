using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class ExemploDoProfessor
    {
        public void Executar()
        {
            // https://github.com/khalidabuhakmeh/ConsoleTables
            var table = new ConsoleTable("one", "two", "three");

            table.Configure(x => x.EnableCount = false);
            table.AddRow(1, 2, 3)
                 .AddRow("", "yes it is", "oh");

            table.Write();
        }
    }
}
