using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Ventas
{
    public class SeguridadBL
    {
        Contexto _contexto;
        public BindingList<Usuario> ListadeUsuarios { get; set; }


        public SeguridadBL()
        {
            _contexto = new Contexto();
            ListadeUsuarios = new BindingList<Usuario>();
        }

        public BindingList<Usuario> ObtenerUsuario()
        {
            _contexto.Usuarios.Load();
            ListadeUsuarios = _contexto.Usuarios.Local.ToBindingList();

            return ListadeUsuarios;
        }

        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }

        public Resultado GuardarUsuario(Usuario usuario)
        {
            var resultado = Validar(usuario);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();
            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarUsuario()
        {
            var nuevoUsuario = new Usuario();
            ListadeUsuarios.Add(nuevoUsuario);
        }

        public bool EliminarUsuario(int id)
        {
            foreach (var usuario in ListadeUsuarios.ToList())
            {
                if (usuario.Id == id)
                {
                    ListadeUsuarios.Remove(usuario);
                    _contexto.SaveChanges();
                    return true;
                }
            }

            return false;
        }

        private Resultado Validar(Usuario usuario)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (usuario == null)
            {
                resultado.Mensaje = "Agregue un usuario valido";
                resultado.Exitoso = false;

                return resultado;
            }

            if (string.IsNullOrEmpty(usuario.Nombre) == true)
            {
                resultado.Mensaje = "Ingrese el usuario";
                resultado.Exitoso = false;
            }
            if (string.IsNullOrEmpty(usuario.Contrasena) == true)
            {
                resultado.Mensaje = "Ingrese una contraseña";
                resultado.Exitoso = false;
            }
            return resultado;
        }






























        public Usuario Autorizar(string usuario, string contrasena)
        {
            var usuarios = _contexto.Usuarios.ToList(); // Traer la lista de usuarios del contexto

            foreach (var usuarioDB in usuarios)
            {
                if (usuario == usuarioDB.Nombre && contrasena == usuarioDB.Contrasena)
                {
                    return usuarioDB;
                }
            }

            return null;
        }
    }

    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contrasena { get; set; }
        public string TipoUsuario { get; set; }
    }

}



