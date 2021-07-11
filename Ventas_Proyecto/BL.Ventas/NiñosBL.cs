using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Ventas
{
    public class NiñosBL
    {
        Contexto _contexto;
        public BindingList<Niños> ListaProdNiños { get; set; }

        public NiñosBL()
        {
            _contexto = new Contexto();
            ListaProdNiños = new BindingList<Niños>(); //Instanciar

        }

        public BindingList<Niños> ObtenerProductos()
        {
            _contexto.Niño.Load();
            ListaProdNiños = _contexto.Niño.Local.ToBindingList();
            return ListaProdNiños;
        }
        public ResultadoNiños GuardarProdNiños(Niños niños)
        {
            var resultadoNiños = Validar(niños);
            if (resultadoNiños.Exitoso == false)
            {
                return resultadoNiños;
            }
            _contexto.SaveChanges();
            resultadoNiños.Exitoso = true;
            return resultadoNiños;
        }
        public void AgregarProdNiños()
        {
            var nuevoProdNiños = new Niños();
            ListaProdNiños.Add(nuevoProdNiños);//se agrega un nuevo producto a la lista
        }
        public bool EliminarProdNiños(int id)
        {
            foreach (var prodNiño in ListaProdNiños)//recorre la lista de los objetos
            {
                if (prodNiño.Id==id)
                {
                    ListaProdNiños.Remove(prodNiño);
                    return true;
                }
            }
            return false;
        }
        private ResultadoNiños Validar(Niños niños)
        {
            var resultadoNiños = new ResultadoNiños();
            resultadoNiños.Exitoso = true;
            if(string.IsNullOrEmpty(niños.Descripcion)==true)
            {
                resultadoNiños.Mensaje = "Ingrese una descripcion";
                resultadoNiños.Exitoso = false;
            }
            if (string.IsNullOrEmpty(niños.Seccion) == true)
            {
                resultadoNiños.Mensaje = "Ingrese la seccion";
                resultadoNiños.Exitoso = false;
            }
            if (niños.Existencia <0)
            {
                resultadoNiños.Mensaje = "La existencia debe ser mayor que cero";
                resultadoNiños.Exitoso = false;
            }
            if (niños.Precio < 0)
            {
                resultadoNiños.Mensaje = "El precio debe ser mayor que cero";
                resultadoNiños.Exitoso = false;
            }
            return resultadoNiños;
        }
    }
    
    public class Niños
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public string Seccion { get; set; }
        public int Existencia { get; set; }
        public byte[] Foto { get; set; }
        public bool Activo { get; set; }


    }
    public class ResultadoNiños:ResultadoMujer
    {
       
    }
}
