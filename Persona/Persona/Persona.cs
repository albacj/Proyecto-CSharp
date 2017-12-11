using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    interface Persona
    {
        String dni { get; set; }

        String nombre { get; set; }

        String apellidos { get; set; }

        int edad { get; set; }

        Double altura { get; set; }

        Char sexo { get; set; }
    }
}
