using Newtonsoft.Json;
using Practica1.ModelJson;

internal class Program
{
    //variable para la ruta donde se va a guardar y leer el json
    private static string _path = @"..\Contacts.json";
    private static void Main(string[] args)
    {
        //System.Console.WriteLine("Hello, World!");
        //invocar el metodo para obtener la lista de contactos
        var contacts = GetContacts();
        SerializeJsonFile(contacts);

    }
    //crear una lista de objetos de tipo Contacto 
    public static List<Contact> GetContacts()
    {
        List<Contact> contacts = new List<Contact>
        {
            new Contact{ 
                Name= "Raul Steven",
                //DateOfBirth= DateTime.Now,
                DateOfBirth= new DateTime(2002,05,14),
                Address = new Adress{ 
                    Street = "Av principal",
                    Number = 2,
                    //City es un objeto que contiene mas propiedades 
                    City = new City{ 
                        Name="Quito",
                         Country = new Country{ 
                         Name ="Ecuador",
                         Code = "ECU"
                         }
                    }
                    
                },
                //Phone es una lista de Phones
                Phone = new List<Phone>{ 
                 new Phone{ 
                     Name="Personal",
                     Number="123"
                 },
                 new Phone{ 
                     Name="Work",
                     Number="321"
                 }
                }   
            }
        };
        //esta funcion devuelve una lista 
        return contacts;
    }
    //serializar el JSON creado para que pueda ser legible 
    public static void SerializeJsonFile(List<Contact> contacts) {
        //serializar el Json identico a como se escribio
        string contactsJson = JsonConvert.SerializeObject(contacts.ToArray(), Formatting
            .Indented);
        //la variable contactsJson ya serializada se puede usar tanto para guardarlo como para enviarlo a la base de datos
        System.Console.WriteLine("Json serializado:");
        System.Console.WriteLine(contactsJson);


        //si se quiere operar con el JSON se lo puede hacer mediante la variable contacts que se recibe como parametro 
        System.Console.WriteLine(string.Format("Primer nombre del contacto: {0} pais: {1}", contacts[0].Name, contacts[0].Address.City.Country.Name));

        //para enviarlo a la base de datos se enviaria serializado es decir: contactsJson
        //guardar el json en un archivo
    }
}