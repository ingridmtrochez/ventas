using BL.Ventas;
using System;
using System.Windows.Forms;

namespace Win.TiendaRopa
{
    public partial class FormUsuarios : Form
    {

        SeguridadBL _seguridadBL;

        public FormUsuarios()
        {
            InitializeComponent();

            _seguridadBL = new SeguridadBL();
            listadeUsuariosBindingSource.DataSource = _seguridadBL.ObtenerUsuario();            
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void listadeUsuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listadeUsuariosBindingSource.EndEdit();
            var usuario = (Usuario)listadeUsuariosBindingSource.Current;

            var resultado = _seguridadBL.GuardarUsuario(usuario);

            if (resultado.Exitoso == true)
            {
                listadeUsuariosBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Usuario guardado");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _seguridadBL.AgregarUsuario();
            listadeUsuariosBindingSource.MoveLast();

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
            toolStripButtonCancelar.Visible = !valor;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text != "")
            {
                var resultado = MessageBox.Show("Desea eliminar este usuario?", "Eliminar", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text);
                    Eliminar(id);
                }
            }
        }

        private void Eliminar(int id)
        {
            var resultado = _seguridadBL.EliminarUsuario(id);

            if (resultado == true)
            {
                listadeUsuariosBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar el Usuario");
            }
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            _seguridadBL.CancelarCambios();
            DeshabilitarHabilitarBotones(true);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
