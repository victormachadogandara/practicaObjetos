using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Contacto contacto1 = new Contacto();

            contacto1.Nombre = "Sebastian Encinas";
            contacto1.TelefonoCasa = "(420) 115 - 2514";
            contacto1.Direccion = "Orion 1401";

            Console.WriteLine("Nombre: " + contacto1.Nombre);
            Console.WriteLine("Telefono de casa: " + contacto1.TelefonoCasa);

            Contacto contacto2 = new Contacto("Sebastian");
            Console.WriteLine("Contacto 2");
            Console.WriteLine("Nombre: " + contacto2.Nombre);

            Contacto contacto3 = new Contacto("Sebas", "123456789", "1234567890", "veracruz ulsa", "sebas_nit_040899@hotmail.com");
            Console.WriteLine("contacto 3");
            Console.WriteLine("Nombre: " + contacto3.Nombre);
            Console.WriteLine("Numero de casa: " + contacto3.TelefonoCasa);
            Console.WriteLine("Numero celular: " + contacto3.TelefonoCelular);
            Console.WriteLine("Direccion: " + contacto3.Direccion);
            Console.WriteLine("Correo electronico: " + contacto3.CorreoElectronico);


            Console.ReadLine();
        }
    }
}