using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Ventas
{
    public class TiposBL
    {
        Contexto _contexto;

        public BindingList<Tipo> ListaTipos { get; set; } // lista de Tipos

        public TiposBL()
        {
            _contexto = new Contexto();
            ListaTipos = new BindingList<Tipo>();
        }

        public BindingList<Tipo> ObtenerTipos()
        {
            _contexto.Tipos.Load(); // Cargar Tipos del contexto
            ListaTipos = _contexto.Tipos.Local.ToBindingList(); // Llenar la lista tipos segun el contexto y convertir en BindingList

            return ListaTipos;
        }
    }

    public class Tipo
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }
}
