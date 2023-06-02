using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Credenciales
    {
        public Credenciales()
        {
            
        }

        public Credenciales(int id, string usuario, string contraseña)
        {
            Id = id;
            Usuario = usuario;
            Contraseña = contraseña;
        }

        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
    }
}
