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
        HombresBL _product;

        public FormHombres()
        {
            InitializeComponent();
            _product = new HombresBL();
            listaProdHombresBindingSource.DataSource = _product.obtener_Productos();

        }

        private void listaProdHombresBindingNavigatorSaveItem1_Click(object sender, EventArgs e)
        {
            listaProdHombresBindingSource.EndEdit();//finaliza edicion
            var hombre = (Hombre)listaProdHombresBindingSource.Current;//Obtenemos las propiedades del producto actual de la clase Hombres

            var resultado = _product.GuardarProdHombres(hombre);

            if (resultado.Exitoso == true)
            {
                listaProdHombresBindingSource.ResetBindings(false);//Guarda los nuevos cambios en la lista
                DeshabilitarHabilitarBotones(true);
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void bindingNavigatorAddNewItem1_Click(object sender, EventArgs e)
        {
            _product.AgregarProdHombres();
            listaProdHombresBindingSource.MoveLast();

            DeshabilitarHabilitarBotones(false);
        }

        private void DeshabilitarHabilitarBotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;

            bindingNavigatorAddNewItem1.Enabled = valor;
            bindingNavigatorDeleteItem1.Enabled = valor;
            toolStripButtonCancelar1.Visible =! valor;

        }

        private void bindingNavigatorDeleteItem1_Click(object sender, EventArgs e)
        {
        
            if(codigoTextBox.Text != "")//Para poder eliminar las listas deben  contener valores
            {
                var resultado = MessageBox.Show("Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var codigo = Convert.ToInt32(codigoTextBox.Text);

                    Eliminar(codigo);
                }
             }
        }
        private void Eliminar(int codigo)
        {
            var resultado = _product.EliminarProdHombres(codigo);
            if (resultado == true)
            {
                listaProdHombresBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar el producto");
            }
        }
        private void toolStripButtonCancelar1_Click(object sender, EventArgs e)
        {
            DeshabilitarHabilitarBotones(true);
            Eliminar(0);
        }
    }
}
