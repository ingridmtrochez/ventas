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
        public BindingList<Niños> ListaProdNiños { get; set; }

        public NiñosBL()
        {
            ListaProdNiños = new BindingList<Niños>(); //Instanciar

            var prod1 = new Niños();    //Instanciar objeto
            prod1.Codigo = 001;         //Propiedades
            prod1.Descripcion = "Pantalón jean";
            prod1.Precio = 550;
            prod1.Seccion = "Ropa";
            prod1.Existencia = 100;
            prod1.Activo = true;

            ListaProdNiños.Add(prod1); //Agregar producto a la Lista

            var prod2 = new Niños();
            prod2.Codigo = 002;
            prod2.Descripcion = "Tenis Roller";
            prod2.Precio = 600;
            prod2.Seccion = "Zapatos";
            prod2.Existencia = 50;
            prod2.Activo = true;

            ListaProdNiños.Add(prod2);

            var prod3 = new Niños();
            prod3.Codigo = 003;
            prod3.Descripcion = "Collar con dije";
            prod3.Precio = 250;
            prod3.Seccion = "Joyeria";
            prod3.Existencia = 150;
            prod3.Activo = true;

            ListaProdNiños.Add(prod3);
        }

        public BindingList<Niños> ObtenerProductos()
        {
            return ListaProdNiños;
        }
        public ResultadoNiños GuardarProdNiños(Niños niños)
        {
            var resultadoNiños = Validar(niños);
            if (resultadoNiños.Exitoso == false)
            {
                return resultadoNiños;
            }
            if(niños.Codigo==0)
            {
                niños.Codigo = ListaProdNiños.Max(item => item.Codigo) + 1;// busca y aumenta el maximo codigo
            }
            resultadoNiños.Exitoso = true;
            return resultadoNiños;
        }
        public void AgregarProdNiños()
        {
            var nuevoProdNiños = new Niños();
            ListaProdNiños.Add(nuevoProdNiños);//se agrega un nuevo producto a la lista
        }
        public bool EliminarProdNiños(int codigo)
        {
            foreach (var prodNiño in ListaProdNiños)//recorre la lista de los objetos
            {
                if (prodNiño.Codigo==codigo)
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
            public int Codigo { get; set; }
            public string Descripcion { get; set; }
            public double Precio { get; set; }
            public string Seccion { get; set; }
            public int Existencia { get; set; }
            public bool Activo { get; set; }
        
    }
    public class ResultadoNiños
    {
        public bool Exitoso{ get; set; }
        public string Mensaje { get; set; }
    }
}
