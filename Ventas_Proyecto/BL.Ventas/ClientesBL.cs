using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;

namespace BL.Ventas
{
    public class ClientesBL
    {
        Contexto _contexto;

        public BindingList<Cliente> ListaClientes { get; set; }

        public ClientesBL()
        {
            _contexto = new Contexto();
            ListaClientes = new BindingList<Cliente>();
        }

        public BindingList<Cliente> ObtenerClientes()
        {
            _contexto.Clientes.Load();
            ListaClientes = _contexto.Clientes.Local.ToBindingList();

            return ListaClientes;
        }

        public BindingList<Cliente> ObtenerClientes(string buscar)
        {
            var query = _contexto.Clientes
                .Where(cliente => cliente.Nombre.ToLower().Contains(buscar.ToLower()))
                .OrderBy(cliente => cliente.Nombre)
                .ToList();

            ListaClientes = new BindingList<Cliente>(query);

            return ListaClientes;
        }


        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }

        public Resultado GuardarCliente(Cliente cliente)
        {
            var resultado = Validar(cliente);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();
            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarCliente()
        {
            var nuevoCliente = new Cliente();
            ListaClientes.Add(nuevoCliente);
        }

        public bool EliminarCliente(int id)
        {
            foreach (var cliente in ListaClientes.ToList())
            {
                if (cliente.Id == id)
                {
                    ListaClientes.Remove(cliente);
                    _contexto.SaveChanges();
                    return true;
                }
            }

            return false;
        }

        private Resultado Validar(Cliente cliente)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (cliente == null)
            {
                resultado.Mensaje = "Agregue un cliente valido";
                resultado.Exitoso = false;

                return resultado;
            }

            if (string.IsNullOrEmpty(cliente.Nombre) == true)
            {
                resultado.Mensaje = "Ingrese el nombre del cliente";
                resultado.Exitoso = false;
            }
            if (cliente.Telefono == "")
            {
                resultado.Mensaje = "Ingrese el Telefono";
                resultado.Exitoso = false;
            }
            if (string.IsNullOrEmpty(cliente.Direccion) == true)
            {
                resultado.Mensaje = "Ingrese una direccion valida";
                resultado.Exitoso = false;
            }

            return resultado;
        }
    }

    
    public class Cliente  // Propiedades de clientes, incompleto...
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int EstadoCivilId { get; set; }
        public EstadoCivil EstadoCivil { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string CodigoCliente { get; set; }
        public string Direccion { get; set; }
        public bool Activo { get; set; }

        public Cliente()
        {
            Activo = true;
            FechaNacimiento = DateTime.Now;
        }

    }

    
    
}
