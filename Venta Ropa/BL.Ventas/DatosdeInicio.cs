using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Ventas
{
    // Agregando datos de inicio para combobox categoria y tipo

    public class DatosdeInicio : CreateDatabaseIfNotExists<Contexto> 
    {

        protected override void Seed(Contexto contexto)
        {
            var usuarioAdmin = new Usuario();
            usuarioAdmin.Nombre = "admin";
            usuarioAdmin.Contrasena = "123";

            contexto.Usuarios.Add(usuarioAdmin);


            // Categorias de ropa

            var categoria1 = new Categoria();
            categoria1.Descripcion = "Niño";
            contexto.Categorias.Add(categoria1);

            var categoria2 = new Categoria();
            categoria2.Descripcion = "Niña";
            contexto.Categorias.Add(categoria2);

            var categoria3 = new Categoria();
            categoria3.Descripcion = "Hombre";
            contexto.Categorias.Add(categoria3);

            var categoria4 = new Categoria();
            categoria4.Descripcion = "Mujer";
            contexto.Categorias.Add(categoria4);

            var categoria5 = new Categoria();
            categoria5.Descripcion = "Deporte";
            contexto.Categorias.Add(categoria5);

            // Tipos de ropa

            var tipo1 = new Tipo();
            tipo1.Descripcion = "Vestidos";
            contexto.Tipos.Add(tipo1);

            var tipo2 = new Tipo();
            tipo2.Descripcion = "Trajes";
            contexto.Tipos.Add(tipo2);

            var tipo3 = new Tipo();
            tipo3.Descripcion = "Camisas";
            contexto.Tipos.Add(tipo3);

            var tipo4 = new Tipo();
            tipo4.Descripcion = "Shorts";
            contexto.Tipos.Add(tipo4);

            var tipo5 = new Tipo();
            tipo5.Descripcion = "Faldas";
            contexto.Tipos.Add(tipo5);

            var tipo6 = new Tipo();
            tipo6.Descripcion = "Pantalones";
            contexto.Tipos.Add(tipo6);

            var tipo7 = new Tipo();
            tipo7.Descripcion = "Calzado";
            contexto.Tipos.Add(tipo7);

            var tipo8 = new Tipo();
            tipo8.Descripcion = "Ropa interior";
            contexto.Tipos.Add(tipo8);

            var tipo9 = new Tipo();
            tipo9.Descripcion = "Accesorios";
            contexto.Tipos.Add(tipo9);
    

            // Clientes

            var cliente1 = new Cliente();
            cliente1.Nombre = "Carlos Villagran";
            contexto.Clientes.Add(cliente1);

            var cliente2 = new Cliente();
            cliente2.Nombre = "Reina Arriaga";
            contexto.Clientes.Add(cliente2);

            base.Seed(contexto);

        }
    }
}
