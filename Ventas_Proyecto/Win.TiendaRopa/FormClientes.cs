using System;
using BL.Ventas;
using System.Windows.Forms;

namespace Win.TiendaRopa
{
    public partial class FormClientes : Form
    {
        ClientesBL _clientesBL;
        EstadosBL _estadosBL;

        public FormClientes()
        {
            InitializeComponent();

            _clientesBL = new ClientesBL();
            listaClientesBindingSource.DataSource = _clientesBL.ObtenerClientes();

            _estadosBL = new EstadosBL();
            listaEstadosBindingSource.DataSource = _estadosBL.ObtenerEstados();
        }

        private void listaClientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaClientesBindingSource.EndEdit();
            var cliente = (Cliente)listaClientesBindingSource.Current;

            var resultado = _clientesBL.GuardarCliente(cliente);

            if (resultado.Exitoso == true)
            {
                listaClientesBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Cliente guardado");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {


            _clientesBL.AgregarCliente();
            listaClientesBindingSource.MoveLast();

            DeshabilitarHabilitarBotones(false);
        }



        private void DeshabilitarHabilitarBotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;

            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
            toolStripButtoncancelar.Visible = !valor;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text != "")
            {
                var resultado = MessageBox.Show("Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text);
                    Eliminar(id);
                }
            }
        }

        private void Eliminar(int id)
        {
            var resultado = _clientesBL.EliminarCliente(id);

            if (resultado == true)
            {
                listaClientesBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar el Cliente");
            }
        }

        private void toolStripButtoncancelar_Click(object sender, EventArgs e)
        {
            _clientesBL.CancelarCambios();
            DeshabilitarHabilitarBotones(true);
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {

                Buscar();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Buscar();
        }
        private void Buscar()
        {
            var busqueda = textBox1.Text;

            if (busqueda != "")
            {
                listaClientesBindingSource.DataSource = _clientesBL.ObtenerClientes(busqueda);
            }
            else
            {
                listaClientesBindingSource.DataSource = _clientesBL.ObtenerClientes();
            }
        }
    }
    }
    



