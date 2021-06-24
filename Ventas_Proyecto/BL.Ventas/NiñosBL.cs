using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Ventas
{
    public class NiñosBL
    {
        public BindingList<Niño> ListaProdNiños { get; set; }

        public NiñosBL()
        {
            ListaProdNiños = new BindingList<Niño>(); //Instanciar

            var prod1 = new Niño();    //Instanciar objeto
            prod1.Codigo = 001;         //Propiedades
            prod1.Descripcion = "Pantalón jean";
            prod1.Precio = 550;
            prod1.Seccion = "Ropa";
            prod1.Existencia = 100;
            prod1.Activo = true;

            ListaProdNiños.Add(prod1); //Agregar producto a la Lista

            var prod2 = new Niño();
            prod2.Codigo = 002;
            prod2.Descripcion = "Tenis Roller";
            prod2.Precio = 600;
            prod2.Seccion = "Zapatos";
            prod2.Existencia = 50;
            prod2.Activo = true;

            ListaProdNiños.Add(prod2);

            var prod3 = new Niño();
            prod3.Codigo = 003;
            prod3.Descripcion = "Collar con dije";
            prod3.Precio = 250;
            prod3.Seccion = "Joyeria";
            prod3.Existencia = 150;
            prod3.Activo = true;

            ListaProdNiños.Add(prod3);
        }

        public BindingList<Niño> ObtenerProductos()
        {
            return ListaProdNiños;
        }

        public class Niño
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
