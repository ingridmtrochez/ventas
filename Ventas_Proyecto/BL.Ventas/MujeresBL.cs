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

        public class Mujer
        {
            public int Codigo { get; set; }
            public string Descripcion { get; set; }
            public double Precio { get; set; }
            public string Seccion { get; set; }
            public int Existencia { get; set; }
            public bool Activo { get; set; }
        }
    }
}
