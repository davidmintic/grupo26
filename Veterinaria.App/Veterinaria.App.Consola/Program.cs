using System;
using Veterinaria.App.Dominio;
using Veterinaria.App.Persistencia;

namespace Veterinaria.App.Consola
{
    class Program
    {
        
        private static IRepositorioGenerico repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // AgregarVeterinario();
            // EditarVeterinario(2);
            // EliminarVeterinario(1);
            // BuscarVeterinario(1);

        }

        // private static void AgregarVeterinario(){

        //     EntidadVeterinario veterinario = new EntidadVeterinario {
        //         // Id = 10,
        //         Nombre = "Evelyn",
        //         Telefono = "1020",
        //         Edad = 15,
        //         // Direccion= "",
        //         Correo = "evel@x.com",
        //         Contrasenia = "khsdhksdhkds",
        //         FechaRegistro = new DateTime(2021, 09, 21),
        //         Especializacion = "prueba",
        //         TarjetaProfesional = "kjashksa656"
        //     };

        //     repoVeterinario.AgregarVeterinario(veterinario);

        // }


        // private static void EditarVeterinario(int idVeterinario){

        //     EntidadVeterinario veterinario = new EntidadVeterinario {
        //         Id = idVeterinario,
        //         Nombre = "Tatiana",
        //         Telefono = "1030",
        //         Edad = 35,
        //         // Direccion= "",
        //         Correo = "evel@x.com",
        //         Contrasenia = "khsdhksdhkds",
        //         FechaRegistro = new DateTime(2021, 09, 21),
        //         Especializacion = "prueba",
        //         TarjetaProfesional = "kjashksa656"
        //     };

        //     repoVeterinario.EditarVeterinario(veterinario);

        // }

        // private static void BuscarVeterinario(int idVeterinario) {

        // //    var veterinarioEncontrado = ()repoVeterinario.GetRegistro(idVeterinario);
        //    Console.WriteLine("El nombre del veterinario es: " + veterinarioEncontrado.Nombre);
        // }

        // private static void EliminarVeterinario(int idVeterinario) {
        //     repoVeterinario.Eliminar(idVeterinario);
        // }



    }
}
