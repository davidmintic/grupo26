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
    public class AdminMascotaModel : PageModel
    {

        private static RepositorioCuidador repoCuidador = new RepositorioCuidador(new Persistencia.AppContext());

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
                this.cuidadorActual = (EntidadCuidador)repoCuidador.GetCuidadorConMascotas(id);

                this.titulo =  "Mascotas de " + this.cuidadorActual.Nombre;
                // if (this.cuidadorActual != null)
                // {
                //     this.modeForm = "edicion";
                // }
            }
            else
            {
                // this.ActualizarDatos();
            }
        }

    }
}
