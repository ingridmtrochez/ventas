using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Ventas
{
    public class ProductosBL
    {

        Contexto _contexto;

        public BindingList<Producto> ListaProductos { get; set; }

        public ProductosBL()
        {
            _contexto = new Contexto();
            ListaProductos = new BindingList<Producto>();

        }

        public BindingList<Producto> ObtenerProductos()
        {
            _contexto.Productos.Load();
            ListaProductos = _contexto.Productos.Local.ToBindingList();

            return ListaProductos;
        }

        public BindingList<Producto> ObtenerProductos(string buscar)
        {
            var query = _contexto.Productos
                .Where(producto => producto.Descripcion.ToLower().Contains(buscar.ToLower()))
                .OrderBy(producto => producto.Descripcion)
                .ToList();

            ListaProductos = new BindingList<Producto>(query);

            return ListaProductos;
        }

        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }

        public Resultado GuardarProducto(Producto producto) // Metodo para el guardado de productos
        {
            var resultado = Validar(producto);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();
            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarProducto() // Metodo para el agregado de productos
        {
            var nuevoProducto = new Producto();
            ListaProductos.Add(nuevoProducto);
        }

        public bool EliminarProducto(int id) // Metodo para la eliminacion de un producto
        {
            foreach (var producto in ListaProductos)
            {
                if (producto.Id == id)
                {
                    ListaProductos.Remove(producto);
                    _contexto.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        private Resultado Validar(Producto producto) // Metodo para la validacion de datos
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (string.IsNullOrEmpty(producto.Descripcion) == true)
            {
                resultado.Mensaje = "Ingrese una descripcion";
                resultado.Exitoso = false;
            }

            if (producto.Existencia < 0)
            {
                resultado.Mensaje = "La existencia deber ser mayor que 0";
                resultado.Exitoso = false;
            }

            if (producto.Precio < 0)
            {
                resultado.Mensaje = "El precio deber ser mayor que 0";
                resultado.Exitoso = false;
            }

            if (producto.DepartamentosId == 0)
            {
                resultado.Mensaje = "Seleccione una categoria";
                resultado.Exitoso = false;
            }

            if (producto.SeccionId == 0)
            {
                resultado.Mensaje = "Seleccione un tipo";
                resultado.Exitoso = false;
            }

            return resultado;
        }
           
    }

   

    public class Producto // Propiedades de producto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Existencia { get; set; }
        public int DepartamentosId { get; set; } // campo foraneo para hacer relacion con la tabla categoria
        public Departamento Departamento { get; set; }
        public int SeccionId { get; set; } // Campo foraneo para hacer relacion con la tabla Tipo
        public Seccion Seccion { get; set; }
        public byte[] Foto { get; set; } // Campo para imagen
        public bool Activo { get; set; }

        public Producto()
        {
            Activo = true;
        }
    }

    public class Resultado
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    }
}
