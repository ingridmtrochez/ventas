using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Ventas
{
    public class HombresBL
    {
        Contexto _contexto;
        public BindingList<Hombre> ListaProdHombres { get; set; }

        public HombresBL()
        {
            _contexto = new Contexto();
            ListaProdHombres = new BindingList<Hombre>();

           
        }

        
        public BindingList<Hombre> obtener_Productos()
        {
            _contexto.Hombres.Load();
            ListaProdHombres = _contexto.Hombres.Local.ToBindingList();
            return ListaProdHombres;
        }
        public Resultado GuardarProdHombres(Hombre hombre)
        {
            var resultado = Validar(hombre);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }
            _contexto.SaveChanges();
            resultado.Exitoso = true;
            return resultado;
        }
        public void AgregarProdHombres()
        {
            var nuevoProdHombres = new Hombre();
            ListaProdHombres.Add(nuevoProdHombres);//se agrega un nuevo producto a la lista
        }
        public bool EliminarProdHombres(int id)
        {
            foreach (var hombre in ListaProdHombres)//recorre la lista de los objetos
            {
                if (hombre.Id==id)
                {
                    ListaProdHombres.Remove(hombre);
                    return true; 
                }
                
            }
            return false;
        }
        private Resultado Validar(Hombre hombre)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (string.IsNullOrEmpty(hombre.Descripcion)==true)
            {
                resultado.Mensaje = "ingrese una descripcion";
                resultado.Exitoso = false;
            }
            if (string.IsNullOrEmpty(hombre.Seccion) == true)
            {
                resultado.Mensaje = "ingrese la seccion";
                resultado.Exitoso = false;
            }
            if(hombre.Existencia < 0)
            {
                resultado.Mensaje = "La existencia debe ser mayor que 0";
                resultado.Exitoso = false;
            }
            if (hombre.Precio < 0)
            {
                resultado.Mensaje = "El precio debe ser mayor que 0";
                resultado.Exitoso = false;
            }
            return resultado;
        }
    }

   public class Hombre
   {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public string Seccion { get; set; }
        public int Existencia { get; set; }
        public byte[] Foto { get; set; }
        public bool Activo { get; set; }
    }
    public class Resultado:ResultadoNiños
    {
        
    }
}