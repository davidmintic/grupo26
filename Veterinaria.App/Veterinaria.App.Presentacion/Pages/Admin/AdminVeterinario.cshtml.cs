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

        private static IRepositorioGenerico repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());

        public String isNombreValid = "0";

        public String titulo { get; set; } = "Bienvenido a la administración de de veterinarios";

        // public List <Veterinario> listaVeterinarios = new List<Veterinario>();

        public IEnumerable<EntidadVeterinario> listaVeterinarios;

        public EntidadVeterinario veterinarioActual;

        public String modeForm { get; set; } = "adicion";


        public void OnGet(int id)
        {
            if (id != 0)
            {
                this.veterinarioActual = (EntidadVeterinario)repoVeterinario.GetRegistro(id);
                if (this.veterinarioActual != null)
                {
                    this.modeForm = "edicion";
                }
            }
            else
            {
                this.ActualizarDatos();
            }
        }


        public void OnPostEdi(EntidadVeterinario veterinarioNuevo)
        {

            var veterinarioEditado = (EntidadVeterinario)repoVeterinario.Editar(veterinarioNuevo);

            if (veterinarioEditado != null)
            {
                this.ActualizarDatos();
                Console.WriteLine("El veterinario ha sido editado");
            }
            else
            {
                Console.WriteLine("Ocurrió un error al editar el veterinario");
            }
        }


        public void OnPostAdd(EntidadVeterinario veterinario)
        {
            repoVeterinario.Agregar(veterinario);
            this.ActualizarDatos();

        }

        public void OnPostDel(int id)
        {
            repoVeterinario.Eliminar(id);
            this.ActualizarDatos();
        }


        public void ActualizarDatos()
        {
            this.listaVeterinarios = (IEnumerable<EntidadVeterinario>)repoVeterinario.GetTodosLosRegistros();
        }


    }

}
