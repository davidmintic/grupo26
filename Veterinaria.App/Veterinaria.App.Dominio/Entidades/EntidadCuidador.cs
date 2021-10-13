using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Veterinaria.App.Dominio
{
    public class EntidadCuidador : EntidadPersona
    {

        public DateTime FechaRegistro { get; set; }
        public List<EntidadMascota> Mascotas { get; set; }

    }

}