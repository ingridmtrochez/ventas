using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Ventas
{
    public class EstadosBL
    {
        Contexto _contexto;

        public BindingList<EstadoCivil> ListaEstados { get; set; }
        public EstadosBL()
        {
            _contexto = new Contexto();
            ListaEstados = new BindingList<EstadoCivil>();

        }
        public BindingList<EstadoCivil> ObtenerEstados()
        {
            _contexto.EstadosCiv.Load();
            ListaEstados = _contexto.EstadosCiv.Local.ToBindingList();
            return ListaEstados;
        }
    }
    public class EstadoCivil
    {

        public int Id { get; set; }
        public string Estados { get; set; }
    }
}
