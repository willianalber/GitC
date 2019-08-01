using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormGrid.Classes
{
    class ClasseUsuario
    {
        int ID;
        string Nome { get; set; }
        bool Ativo { get; set; }
        int UsuInc { get; set; }
        int UsuAlt { get; set; }
        DateTime DataInc { get; set; }
        DateTime DataAlt { get; set; }
    }
}
