using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases.DTO
{
    public class Banda
    {

        string nombreBanda, fechaCreacion;
        int id;

        public string NombreBanda
        {
            get
            {
                return nombreBanda;
            }

            set
            {
                nombreBanda = value;
            }
        }

        public string FechaCreacion
        {
            get
            {
                return fechaCreacion;
            }

            set
            {
                fechaCreacion = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public Banda(string nombreBanda, string fechaCreacion, int id)
        {
            this.NombreBanda = nombreBanda;
            this.FechaCreacion = fechaCreacion;
            this.Id = id;
        }

        public Banda()
        {
            nombreBanda = "";
            fechaCreacion = "";
            id = 0;
        }



    }
}
