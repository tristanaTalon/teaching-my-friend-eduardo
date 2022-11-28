using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
  class Persona
  {

    public string Nombres;
    public string ApellidoPaterno { get; set; }
    public string ApellidoMaterno { get; set; }
    public string DNI { get; set; }
    public DateTime FechaNacimiento { get; set; }

    public virtual string NombreCompleto
    {
      get
      {
        
        return this.ApellidoPaterno + " " + this.ApellidoMaterno + "," + this.Nombres;
      }
    }

    public int edad
    {
      get
      {
        return DateTime.Now.Year - this.FechaNacimiento.Year;
      }
    }

    public virtual void Leer()
    {
      Console.WriteLine("Nombres : ");
      this.Nombres = Console.ReadLine();
      Console.WriteLine("Apellido Paterno : ");
      this.ApellidoPaterno = Console.ReadLine();
      Console.WriteLine("Apellido Materno : ");
      this.ApellidoMaterno = Console.ReadLine();
      Console.WriteLine("DNI : ");
      this.DNI = Console.ReadLine();
      Console.WriteLine("Fecha de Nacimiento : ");
      this.FechaNacimiento = DateTime.Parse( Console.ReadLine());
    }

  }
}
