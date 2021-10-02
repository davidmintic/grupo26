using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Veterinaria.App.Presentacion.Pages
{
    public class AdminVeterinarioModel : PageModel
    {

        public String titulo {get; set;}

        public List <Veterinario> listaVeterinarios = new List<Veterinario>();
       

        public void OnGet()
        {
           
           this.listaVeterinarios.Add(
             new Veterinario  {Index = this.listaVeterinarios.Count+1, Nombre= "Juan", Edad = 30, Telefono = "310", Correo = "juan@gmail.com"}
           );

            this.listaVeterinarios.Add(
               new Veterinario  {Index = this.listaVeterinarios.Count+1, Nombre= "Pedro", Edad = 25, Telefono = "320", Correo = "pedro@gmail.com"}
           );

            this.listaVeterinarios.Add(
                new Veterinario {Index = this.listaVeterinarios.Count+1, Nombre= "Antonio", Edad = 39, Telefono = "330", Correo = "antonio@gmail.com"}
           );

           this.listaVeterinarios.Add(
                new Veterinario {Index = this.listaVeterinarios.Count+1, Nombre= "Marlon", Edad = 35, Telefono = "340", Correo = "marlon@gmail.com"}
           );

            this.titulo = "Bienvenido a la administración de de veterinarios";
        }
    } 


    public class Veterinario{

        public int Index { get; set; }
        public String Nombre {get; set;}
        public String Telefono {get; set;}
        public int Edad {get; set;}
        public String Correo {get; set;}

    }

}
