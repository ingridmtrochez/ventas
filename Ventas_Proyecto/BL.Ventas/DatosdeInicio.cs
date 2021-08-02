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
            usuarioAdmin.Contrasena ="tienda";

            contexto.Usuarios.Add(usuarioAdmin);


            // Categorias de ropa

            var departamento1 = new Departamento();
            departamento1.Descripcion = "Niño";
            contexto.Departamentos.Add(departamento1);

            var departamento2 = new Departamento();
            departamento2.Descripcion = "Niña";
            contexto.Departamentos.Add(departamento2);

            var departamento3 = new Departamento();
            departamento3.Descripcion = "Hombre";
            contexto.Departamentos.Add(departamento3);

            var departamento4 = new Departamento();
            departamento4.Descripcion = "Mujer";
            contexto.Departamentos.Add(departamento4);

            var departamento5 = new Departamento();
            departamento5.Descripcion = "Deporte";
            contexto.Departamentos.Add(departamento5);

            // Tipos de ropa

            var seccion1 = new Seccion();
            seccion1.Descripcion = "Vestidos";
            contexto.Secciones.Add(seccion1);

            var seccion2 = new Seccion();
            seccion2.Descripcion = "Trajes";
            contexto.Secciones.Add(seccion2);

            var seccion3 = new Seccion();
            seccion3.Descripcion = "Camisas";
            contexto.Secciones.Add(seccion3);

            var seccion4 = new Seccion();
            seccion4.Descripcion = "Shorts";
            contexto.Secciones.Add(seccion4);

            var seccion5 = new Seccion();
            seccion5.Descripcion = "Faldas";
            contexto.Secciones.Add(seccion5);

            var seccion6 = new Seccion();
            seccion6.Descripcion = "Pantalones";
            contexto.Secciones.Add(seccion6);

            var seccion7 = new Seccion();
            seccion7.Descripcion = "Calzado";
            contexto.Secciones.Add(seccion7);

            var seccion8 = new Seccion();
            seccion8.Descripcion = "Ropa interior";
            contexto.Secciones.Add(seccion8);

            var seccion9 = new Seccion();
            seccion9.Descripcion = "Joyeria";
            contexto.Secciones.Add(seccion9);
    
            
            base.Seed(contexto);

        }
    }
}
