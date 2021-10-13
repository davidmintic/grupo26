
using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Veterinaria.App.Persistencia{


    public class RepositorioCuidador : IRepositorioGenerico{

        private readonly AppContext appContext;  

        public RepositorioCuidador(AppContext appContextParam){
            this.appContext = appContextParam;
        }

        // CRUD

        Object IRepositorioGenerico.Agregar(Object objeto) {

            EntidadCuidador cuidador = (EntidadCuidador)objeto;

            cuidador.FechaRegistro =  DateTime.Now;
            var veterinarioAgregado = this.appContext.Cuidadores.Add(cuidador);
            this.appContext.SaveChanges();
            return veterinarioAgregado.Entity;
        }

        
        Object IRepositorioGenerico.Editar(Object objeto) {

            EntidadCuidador cuidadorNuevo = (EntidadCuidador)objeto;

            var cuidadorEncontrado = this.appContext.Cuidadores.FirstOrDefault( p => p.Id == cuidadorNuevo.Id); 
            
            if(cuidadorEncontrado != null){
                cuidadorEncontrado.Nombre = cuidadorNuevo.Nombre != null ? cuidadorNuevo.Nombre : cuidadorEncontrado.Nombre;
                cuidadorEncontrado.Telefono = cuidadorNuevo.Telefono != null ? cuidadorNuevo.Telefono : cuidadorEncontrado.Telefono;
                cuidadorEncontrado.Edad = cuidadorNuevo.Edad != null ? cuidadorNuevo.Edad : cuidadorEncontrado.Edad;
                cuidadorEncontrado.Correo = cuidadorNuevo.Correo != null ? cuidadorNuevo.Correo : cuidadorEncontrado.Correo;                
                this.appContext.SaveChanges();  
                return cuidadorEncontrado;              
            } else {
                return null;
            }          
        }


         Object IRepositorioGenerico.GetRegistro(int idCuidador) {
            return this.appContext.Cuidadores.FirstOrDefault( p => p.Id == idCuidador);           
        }



        void IRepositorioGenerico.Eliminar(int idCuidador) {
           var cuidadorEncontrado = this.appContext.Cuidadores.FirstOrDefault( p => p.Id == idCuidador); 

            if(cuidadorEncontrado != null) {
                this.appContext.Cuidadores.Remove(cuidadorEncontrado);
                this.appContext.SaveChanges();
            }

        }


        IEnumerable <Object> IRepositorioGenerico.GetTodosLosRegistros(){
            return this.appContext.Cuidadores;
        }


        public Object GetCuidadorConMascotas(int idObjeto){
            var registroEncontrado = this.appContext.Cuidadores.Include("Mascotas").FirstOrDefault( p => p.Id == idObjeto);
            return registroEncontrado;
        }






    }
}