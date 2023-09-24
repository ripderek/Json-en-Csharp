using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.ModelJson
{
    public class Contact
    {
        public string Name { get; set; }
        public Adress Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        //lista de objetos de tipo phone 
        public List<Phone> Phone { get; set; }

    }
}
