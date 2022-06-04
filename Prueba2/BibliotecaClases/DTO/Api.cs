using Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Api
{

    public class Datos
    {
        public int status { get; set; }
        public string token { get; set; }
        public List<string> Instrumentos { get; set; }
        public List<string> Musicos { get; set; }
    }

    public class ResponseDatos
    {
        public int Count { get; set;}
        public object next { get; set; }
        public object previous { get; set; }
        public List<Datos> results { get; set; }


    }




}