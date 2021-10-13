using System;
using System.ComponentModel.DataAnnotations;

namespace Veterinaria.App.Dominio
{
    public class EntidadMascota {

       public int Id { get; set; }
       public String Nombre { get; set; }
       public String Raza { get; set; }
       public String FechaNacimiento { get; set; }

       public EntidadCuidador Cuidador { get; set; }
     
    }
    
}