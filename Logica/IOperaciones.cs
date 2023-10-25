﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Logica
{
    public interface IOperaciones<T>
    {
        void Agregar(T t);

        void Borrar(string t);

        void Actualizar(string s,T t);
    }
}
