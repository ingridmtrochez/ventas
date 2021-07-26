using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Ventas
{
    public class DepartamentosBL
    {
        Contexto _contexto;

        public BindingList<Departamento> ListaDepartamentos { get; set; } // lista categorias

        public DepartamentosBL()
        {
            _contexto = new Contexto();
            ListaDepartamentos = new BindingList<Departamento>();
        }

        public BindingList<Departamento> ObtenerDepartamentos()
        {
            _contexto.Departamentos.Load();
            ListaDepartamentos = _contexto.Departamentos.Local.ToBindingList();

            return ListaDepartamentos;
        }
    }

    public class Departamento // Propiedades de tabla categoria
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }
}
