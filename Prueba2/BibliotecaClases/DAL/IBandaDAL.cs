using Api;
using BibliotecaClases.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases.DAL
{
    interface IBandaDAL
    {

        void InsertarBanda(Banda banda);
        void InsertarIntegrante(Integrante integrante , Integrante instrumentoIntegrante);

        Banda ConsultarBanda(int id);

        Datos ConsultarToken(string token);





    }
}
