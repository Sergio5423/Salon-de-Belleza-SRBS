using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public interface ICliente<T>
    {
        void Agregar(T cliente);        
        List<T> Consultar();
        T Buscar(string dato);
        void Borrar(string dato);        
    }
}
