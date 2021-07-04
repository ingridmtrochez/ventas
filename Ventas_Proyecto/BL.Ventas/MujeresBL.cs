using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Ventas
{
    public class MujeresBL
    {
        public BindingList<Mujer> ListaProdMujeres { get; set; } //Propiedad Listade productos

        public MujeresBL()
        {
            ListaProdMujeres = new BindingList<Mujer>();

            var producto1 = new Mujer();    //Instanciar objeto
            producto1.Codigo = 001;         //Propiedades
            producto1.Descripcion = "Camiseta manga corta";
            producto1.Precio = 250;
            producto1.Seccion = "Ropa";
            producto1.Existencia = 150;
            producto1.Activo = true;

            ListaProdMujeres.Add(producto1); //Agregar producto a la Lista

            var producto2 = new Mujer();
            producto2.Codigo = 002;
            producto2.Descripcion = "Adidas Women's";
            producto2.Precio = 4250;
            producto2.Seccion = "Zapatos";
            producto2.Existencia = 50;
            producto2.Activo = true;

            ListaProdMujeres.Add(producto2);

            var producto3 = new Mujer();
            producto3.Codigo = 003;
            producto3.Descripcion = "Pulseras de oro ";
            producto3.Precio = 450;
            producto3.Seccion = "Joyeria";
            producto3.Existencia = 150;
            producto3.Activo = true;

            ListaProdMujeres.Add(producto3);
        }

        public BindingList<Mujer> obtenerProductos()
        {
            return ListaProdMujeres;
        }

        public ResultadoMujer GuardarProdMujeres(Mujer mujer)
        {
            var resultado = Validar(mujer);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }
            if(mujer.Codigo == 0)
            {
                mujer.Codigo = ListaProdMujeres.Max(item => item.Codigo) + 1;// busca y aumenta el maximo codigo
            }
            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarProdMujeres()
        {
            var nuevoProdMujeres = new Mujer();
            ListaProdMujeres.Add(nuevoProdMujeres);//se agrega un nuevo producto a la lista
        }
        public bool EliminarProdMujeres(int codigo)
        {
            foreach (var prodMujer in ListaProdMujeres)//recorre la lista de los objetos
            {
                if (prodMujer.Codigo == codigo)
                {
                    ListaProdMujeres.Remove(prodMujer);
                    return true;
                }
            }
            return false;
        }
        private ResultadoMujer Validar(Mujer mujer)
        {
            var resultado = new ResultadoMujer();
            resultado.Exitoso = true;
            if (string.IsNullOrEmpty(mujer.Descripcion) == true)
            {
                resultado.Mensaje = "Ingrese una descripcion";
                resultado.Exitoso = false; 
            }
            if (string.IsNullOrEmpty(mujer.Seccion) == true)
            {
                resultado.Mensaje = "Ingrese la seccion";
                resultado.Exitoso = false;
            }

            if (mujer.Existencia < 0)
            {
                resultado.Mensaje = "La existencia debe ser mayor que cero";
                resultado.Exitoso = false;
            }
            if (mujer.Precio < 0)
            {
                resultado.Mensaje = "El precio debe ser mayor que cero";
                resultado.Exitoso = false;
            }
            return resultado;
        }
    }
    public class Mujer
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public string Seccion { get; set; }
        public int Existencia { get; set; }
        public bool Activo { get; set; }
      
    }
    public class ResultadoMujer
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }

    }
}
