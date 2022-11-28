using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
  class Profesional : Persona
  {

    public string Grado { get; set; }

    public override void Leer() 
    {
      Console.WriteLine("Grado : ");
      this.Grado = Console.ReadLine();
      base.Leer();
    }

    public override string NombreCompleto {
      get
      {
        return this.Grado + base.NombreCompleto;
      }
    }

  }
}
