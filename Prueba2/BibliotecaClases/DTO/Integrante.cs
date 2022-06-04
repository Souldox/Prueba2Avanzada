using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases.DTO
{
    public class Integrante
    {
        string nombreIntegrante, instrumentoIntegrante;

        public Integrante(string nombreIntegrante, string instrumentoIntegrante)
        {
            this.nombreIntegrante = nombreIntegrante;
            this.instrumentoIntegrante = instrumentoIntegrante;
        }

        public Integrante()
        {
            nombreIntegrante = "";
            instrumentoIntegrante = "";
        }

        public string InstrumentoIntegrante
        {
            get
            {
                return instrumentoIntegrante;
            }

            set
            {
                instrumentoIntegrante = value;
            }
        }

        public string NombreIntegrante
        {
            get
            {
                return nombreIntegrante;
            }

            set
            {
                nombreIntegrante = value;
            }
        }
    }
}
