using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public interface IOperacionesBD<T>
    {
        void Agregar(T t);
        void Actualizar(T t);
        void Borrar(int id);       
    }
}
