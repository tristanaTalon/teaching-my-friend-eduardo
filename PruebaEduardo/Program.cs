using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Program
    {

        static List<Persona> personas = new List<Persona>();

        static void Main(string[] args)
        {
            ProbarColecciones();
            ListarMayoresEdad();
            BuscarPorDNI();
        }

        private static void ProbarColecciones()
        {
            Persona per;
            int cantidad;

            Console.WriteLine("¿Cuántas personas desea registrar?");
            cantidad = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < cantidad; i++)
            {
                per = CrearPersona();

                per.Leer();

                personas.Add(per);
            }

            Console.WriteLine("LISTA DE PERSONAS");
            Console.WriteLine("=================");
            foreach (var p in personas)
            {
                Console.WriteLine(p.NombreCompleto);
            }
            Console.WriteLine("=================");
            Console.ReadLine();
        }

        private static Persona CrearPersona()
        {
            Persona per = null;
            int tipo;

            Console.WriteLine("<1> Persona");
            Console.WriteLine("<2> Profesional");
            Console.WriteLine("Tipo :");
            tipo = Int32.Parse(Console.ReadLine());
            switch (tipo)
            {
                case 1: per = new Persona(); break;
                case 2: per = new Profesional(); break;
            }

            return per;
        }


        private static void ListarMayoresEdad()
        {
            Console.WriteLine("Listado de mayores de edad");
            foreach (var per in personas)
            {
                if (per.edad >= 18)
                {
                    Console.WriteLine(per.NombreCompleto + " - " + per.edad);
                }
            }
            Console.ReadLine();
        }

        private static void BuscarPorDNI()
        {
            Persona per;
            string DNI;

            Console.WriteLine("DNI a buscar : ");
            DNI = Console.ReadLine();
            per = BuscarDNI(DNI);

            if (per != null)
            {
                Console.WriteLine(per.NombreCompleto);
            }
            else
            {
                Console.WriteLine("No se encontró a la persona");
            }
            Console.ReadLine();
        }

        private static Persona BuscarDNI(string DNI)
        {
            foreach (var per in personas)
            {
                if (per.DNI.Equals(DNI) == true)
                {
                    return per;
                }
            }
            return null;
        }

        private static void Probar2()
        {
            Persona[] personas = new Persona[3];
            Persona per = null;

            for (int i = 0; i < personas.Length; i++)
            {
                per = new Persona();
                per.Leer();
                personas[i] = per;
            }
            Console.WriteLine("Presione enter para listar");
            Console.ReadLine();
            Console.WriteLine("LISTADO DE PERSONAS");
            for (int i = 0; i < personas.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + personas[i].NombreCompleto);
            }
            Console.ReadLine();
        }

        public static void Probar()
        {
            Persona per = null;
            Persona per2;

            per = new Persona();
            per.Nombres = "Jose";
            per.ApellidoPaterno = "Rodriguez";
            per.ApellidoMaterno = "Leon";
            Console.WriteLine("Fecha de Nacimiento : ");
            per.FechaNacimiento = DateTime.Parse(Console.ReadLine());

            per2 = per;
            per2.Nombres = "Carla";
            if (per.edad < 18)
            {
                Console.WriteLine(per.NombreCompleto + " es menor de edad");
            }
            else
            {
                Console.WriteLine(per.NombreCompleto + " es mayor de edad");
            }

            Console.ReadLine();
        }

    }
}
