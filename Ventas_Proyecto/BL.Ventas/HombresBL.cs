using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Ventas
{
    public class HombresBL
    {
        public BindingList<Hombre> ListaProdHombres { get; set; }

        public HombresBL()
        {
            ListaProdHombres = new BindingList<Hombre>();

            var product1 = new Hombre();    //Instanciar objeto
            product1.Codigo = 001;         //Propiedades
            product1.Descripcion = "Camisa Formal";
            product1.Precio = 300;
            product1.Seccion = "Ropa";
            product1.Existencia = 50;
            product1.Activo = true;

            ListaProdHombres.Add(product1); //Agregar producto a la Lista

            var product2 = new Hombre();
            product2.Codigo = 002;
            product2.Descripcion = "Botines";
            product2.Precio = 850;
            product2.Seccion = "Zapatos";
            product2.Existencia = 30;
            product2.Activo = true;

            ListaProdHombres.Add(product2);

            var product3 = new Hombre();
            product3.Codigo = 003;
            product3.Descripcion = "Cadena de eslabones";
            product3.Precio = 320;
            product3.Seccion = "Joyeria";
            product3.Existencia = 150;
            product3.Activo = true;

            ListaProdHombres.Add(product3);
        }

        public BindingList<Hombre> obtener_Productos()
        {
            return ListaProdHombres;
        }
    }

        public class Hombre
        {
            public int Codigo { get; set; }
            public string Descripcion { get; set; }
            public double Precio { get; set; }
            public string Seccion { get; set; }
            public int Existencia { get; set; }
            public bool Activo { get; set; }
        }
    }