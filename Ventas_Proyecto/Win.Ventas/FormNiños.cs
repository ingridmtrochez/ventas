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
    public partial class FormNiños : Form
    {
        NiñosBL _producto;
        public FormNiños()
        {
            InitializeComponent();
            _producto = new NiñosBL();//Inicializar
            niñosBindingSource.DataSource = _producto.ObtenerProductos();
        }

        private void niñosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            niñosBindingSource.EndEdit(); //finaliza edicion
            var niños = (Niños)niñosBindingSource.Current;//Obtenemos las propiedades del producto actual de la clase Niños

            var resultadoNiños = _producto.GuardarProdNiños(niños);

            if (resultadoNiños.Exitoso == true)
            {
                niñosBindingSource.ResetBindings(false);//Guarda los nuevos cambios en la lista
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Elemento Guardado", "Mensaje de confirmacion");
            }
            else
            {
                MessageBox.Show(resultadoNiños.Mensaje);
            }
        }


        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _producto.AgregarProdNiños();
            niñosBindingSource.MoveLast();
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
                var resultadoNiños = MessageBox.Show("Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (resultadoNiños == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text);
                    Eliminar(id);
                }

            }
        }
        private void Eliminar(int id)
        {

            var resultadoNiños = _producto.EliminarProdNiños(id);
            if (resultadoNiños == true)
            {
                niñosBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error eliminar al producto");
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DeshabilitarHabilitarBotones(true);
            Eliminar(0);
        }

        private void FormNiñ_Load(object sender, EventArgs e)
        {

        }
    }
}
