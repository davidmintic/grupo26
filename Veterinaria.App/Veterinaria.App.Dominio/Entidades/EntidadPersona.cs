using System;
using System.ComponentModel.DataAnnotations;

namespace Veterinaria.App.Dominio
{
    public class EntidadPersona {

       
       public int Id {get; set;}

    //    [Required] 
       [Required(ErrorMessage = "First Number is required.")]  
       public  String Nombre  {get; set;}

       public String Telefono  {get; set;}
       public int Edad  {get; set;}      
       public String Correo {get; set;}
       public String Contrasenia {get; set;}
       public DateTime FechaRegistro  {get; set;} 
    }
    
}