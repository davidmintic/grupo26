
using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Veterinaria.App.Persistencia{


    public class RepositorioVeterinario : IRepositorioGenerico{

        private readonly AppContext appContext;  

        public RepositorioVeterinario(AppContext appContextParam){
            this.appContext = appContextParam;
        }

        // CRUD

        Object IRepositorioGenerico.Agregar(Object objeto) {

            EntidadVeterinario veterinario = (EntidadVeterinario)objeto;

            veterinario.FechaRegistro =  DateTime.Now;
            var veterinarioAgregado = this.appContext.Veterinarios.Add(veterinario);
            this.appContext.SaveChanges();
            return veterinarioAgregado.Entity;
        }

        
        Object IRepositorioGenerico.Editar(Object objeto) {

            EntidadVeterinario veterinarioNuevo = (EntidadVeterinario)objeto;

            var veterinarioEncontrado = this.appContext.Veterinarios.FirstOrDefault( p => p.Id == veterinarioNuevo.Id); 
            
            if(veterinarioEncontrado != null){
                veterinarioEncontrado.Nombre = veterinarioNuevo.Nombre != null ? veterinarioNuevo.Nombre : veterinarioEncontrado.Nombre;
                veterinarioEncontrado.Telefono = veterinarioNuevo.Telefono != null ? veterinarioNuevo.Telefono : veterinarioEncontrado.Telefono;
                veterinarioEncontrado.Edad = veterinarioNuevo.Edad != null ? veterinarioNuevo.Edad : veterinarioEncontrado.Edad;
                veterinarioEncontrado.Correo = veterinarioNuevo.Correo != null ? veterinarioNuevo.Correo : veterinarioEncontrado.Correo;
                veterinarioEncontrado.Especializacion = veterinarioNuevo.Especializacion != null ? veterinarioNuevo.Especializacion : veterinarioEncontrado.Especializacion;
                veterinarioEncontrado.TarjetaProfesional = veterinarioNuevo.TarjetaProfesional != null ? veterinarioNuevo.TarjetaProfesional : veterinarioEncontrado.TarjetaProfesional;
                this.appContext.SaveChanges();  
                return veterinarioEncontrado;              
            } else {
                return null;
            }          
        }


         Object IRepositorioGenerico.GetRegistro(int idVeterinario) {
            return this.appContext.Veterinarios.FirstOrDefault( p => p.Id == idVeterinario);           
        }



        void IRepositorioGenerico.Eliminar(int idVeterinario) {
           var veterinarioEncontrado = this.appContext.Veterinarios.FirstOrDefault( p => p.Id == idVeterinario); 

            if(veterinarioEncontrado != null) {
                this.appContext.Veterinarios.Remove(veterinarioEncontrado);
                this.appContext.SaveChanges();
            }

        }


        IEnumerable <Object> IRepositorioGenerico.GetTodosLosRegistros(){
            return this.appContext.Veterinarios;
        }



    }
}