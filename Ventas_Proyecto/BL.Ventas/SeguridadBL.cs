using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Ventas
{
    public class SeguridadBL
    {
        public bool Autorizar(string usuario, string contraseña)
        {
            if(usuario == "admin" && contraseña == "tienda")
            {
                return true;
            }
            else
            {
                if (usuario == "caja" && contraseña == "caja1")
                {
                    return true;
                }
            }
            return false;
        }
    }
}
