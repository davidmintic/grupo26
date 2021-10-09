using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Veterinaria.App.Persistencia;
using Veterinaria.App.Dominio;
using System.ComponentModel.DataAnnotations;

namespace Veterinaria.App.Presentacion.Pages
{
    public class AdminVeterinarioModel : PageModel
    {

        private static IRepositorioVeterinario repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());

        public String isNombreValid = "0";

        public String titulo {get; set;} = "Bienvenido a la administración de de veterinarios";

        // public List <Veterinario> listaVeterinarios = new List<Veterinario>();

       public IEnumerable <EntidadVeterinario> listaVeterinarios;
       

        public void OnGet(int id)
        {
            if(id != 0){

            } else {

            }
           
            this.listaVeterinarios = repoVeterinario.GetVeterinarios();
                    
        }


        public void OnPostAdd(EntidadVeterinario veterinario) {            
            repoVeterinario.AgregarVeterinario(veterinario);
            this.listaVeterinarios = repoVeterinario.GetVeterinarios();      
        }



         public void OnPostDel(int id) {
            repoVeterinario.EliminarVeterinario(id);
            this.listaVeterinarios = repoVeterinario.GetVeterinarios();
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
