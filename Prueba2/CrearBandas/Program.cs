using Api;
using BibliotecaClases.DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CrearBandas
{
   public partial class Program
    {
        static void Main(string[] args)
        {
            string token = "";
            Console.WriteLine("Bienvenido , ingrese sus credenciales");
            string miCredencial = Console.ReadLine();

            List<Datos> data = new List<Datos>();
            

            WebClient ws = new WebClient();

            string url = "http://codigo-alfa.cl/Api/getDataGruposMusicales/"+miCredencial;
            string responseAPI = ws.DownloadString(url);
            ResponseDatos rd  = JsonConvert.DeserializeObject<ResponseDatos>(responseAPI);


            

            Console.WriteLine("Desea crear una Banda"); //el tipico si no etc....
            Banda bn = new Banda();
            Integrante i = new Integrante();



            Console.WriteLine("Ingrese nombre de la banda");
            bn.NombreBanda = Console.ReadLine();

           //formulario creacion
            foreach (Datos d in rd.results)
            {

                Console.WriteLine("Ingrese la fecha de creacion de la banda");
                bn.FechaCreacion = Console.ReadLine(); 

                Console.WriteLine("Seleccione el nombre del integrante" + d.Musicos);
                i.NombreIntegrante = Console.ReadLine();

                Console.WriteLine("Ingrese el  Instrumento del integrante"+d.Instrumentos);
                i.NombreIntegrante = Console.ReadLine();

                token = d.token;


            }

            //Salida
            Console.WriteLine("Gracias usuario " + token +"por usar la app");






          








        }
    }
}
