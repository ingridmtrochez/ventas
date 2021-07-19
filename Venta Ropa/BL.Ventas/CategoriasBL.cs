using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Ventas
{
    public class CategoriasBL
    {
        Contexto _contexto;

        public BindingList<Categoria> ListaCategorias { get; set; } // lista categorias

        public CategoriasBL()
        {
            _contexto = new Contexto();
            ListaCategorias = new BindingList<Categoria>();
        }

        public BindingList<Categoria> ObtenerCategorias()
        {
            _contexto.Categorias.Load();
            ListaCategorias = _contexto.Categorias.Local.ToBindingList();

            return ListaCategorias;
        }
    }

    public class Categoria // Propiedades de tabla categoria
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }
}
