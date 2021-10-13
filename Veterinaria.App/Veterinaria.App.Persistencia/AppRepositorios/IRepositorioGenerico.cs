
using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia{

    public interface IRepositorioGenerico{

        Object Agregar(Object objeto);
        Object Editar(Object objeto);
        Object GetRegistro(int id);
        void Eliminar(int id);
        IEnumerable <Object> GetTodosLosRegistros();


    }

}