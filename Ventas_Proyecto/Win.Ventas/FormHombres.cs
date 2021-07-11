using BL.Ventas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.Ventas
{
    public partial class FormHombres : Form
    {
        HombresBL _producto;
        public FormHombres()
        {
            InitializeComponent();
            _producto = new HombresBL();
            hombreBindingSource.DataSource = _producto.obtener_Productos();

        }

        private void hombreBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            hombreBindingSource.EndEdit();//finaliza edicion
            var hombre = (Hombre)hombreBindingSource.Current;//Obtenemos las propiedades del producto actual de la clase Hombres

            var resultado = _producto.GuardarProdHombres(hombre);

            if (resultado.Exitoso == true)
            {
                hombreBindingSource.ResetBindings(false);//Guarda los nuevos cambios en la lista
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Elemento Guardado", "Mensaje de confirmacion");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _producto.AgregarProdHombres();
            hombreBindingSource.MoveLast();

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
            if (idTextBox.Text != "")//Para poder eliminar las listas deben  contener valores
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
            var resultado = _producto.EliminarProdHombres(id);
            if (resultado == true)
            {
                hombreBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar el producto");
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DeshabilitarHabilitarBotones(true);
            Eliminar(0);
        }

        private void FormHomb_Load(object sender, EventArgs e)
        {

        }
    }
}
