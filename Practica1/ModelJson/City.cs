using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.ModelJson
{
    public class City
    {
        //propiedades de la clase 
        public string Name { get; set; }
        //se hace referencia a la clase Country 
        public Country Country { get; set; }
    }
}
