using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Veterinaria.App.Persistencia;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Presentacion.Pages
{
    public class AdminCuidadorModel : PageModel
    {
        private static IRepositorioGenerico repoCuidador = new RepositorioCuidador(new Persistencia.AppContext());

        public String isNombreValid = "0";

        public String titulo { get; set; } = "Bienvenido a la administración de cuidadores";

        // public List <EntidadCuidador> listaCuidadores = new List<EntidadCuidador>();

        public IEnumerable<EntidadCuidador> listaCuidadores;

        public EntidadCuidador cuidadorActual;

        public String modeForm { get; set; } = "adicion";


        public void OnGet(int id)
        {
            if (id != 0)
            {
                this.cuidadorActual = (EntidadCuidador)repoCuidador.GetRegistro(id);
                if (this.cuidadorActual != null)
                {
                    this.modeForm = "edicion";
                }
            }
            else
            {
                this.ActualizarDatos();
            }
        }


        // public void OnPostEdi(EntidadVeterinario veterinarioNuevo)
        // {

        //     var veterinarioEditado = repoCuidador.EditarVeterinario(veterinarioNuevo);

        //     if (veterinarioEditado != null)
        //     {
        //         this.listaCuidadores = repoCuidador.GetVeterinarios();
        //         Console.WriteLine("El veterinario ha sido editado");
        //     }
        //     else
        //     {
        //         Console.WriteLine("Ocurrió un error al editar el veterinario");
        //     }
        // }


        public void OnPostAdd(EntidadCuidador cuidador)
        {
            repoCuidador.Agregar(cuidador);
            this.ActualizarDatos();
        }



        // public void OnPostDel(int id)
        // {
        //     repoCuidador.EliminarVeterinario(id);
        //     this.listaCuidadores = repoCuidador.GetVeterinarios();
        // }


        public void ActualizarDatos()
        {
            this.listaCuidadores = (IEnumerable<EntidadCuidador>)repoCuidador.GetTodosLosRegistros();
        }

    }
}
