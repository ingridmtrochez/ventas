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
        NiñosBL _prod;

        public FormNiños()
        {
            InitializeComponent();
            _prod = new NiñosBL();//Inicializar
            listaProdNiñosBindingSource.DataSource = _prod.ObtenerProductos();
        }

        private void listaProdNiñosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaProdNiñosBindingSource.EndEdit(); //finaliza edicion
            var niños = (Niños)listaProdNiñosBindingSource.Current;//Obtenemos las propiedades del producto actual de la clase Niños

            var resultadoNiños = _prod.GuardarProdNiños(niños);

            if (resultadoNiños.Exitoso==true)
            {
                listaProdNiñosBindingSource.ResetBindings(false);//Guarda los nuevos cambios en la lista
                DeshabilitarHabilitarBotones(true);
            }
            else
            {
                MessageBox.Show(resultadoNiños.Mensaje);
            }
        }


        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _prod.AgregarProdNiños();
            listaProdNiñosBindingSource.MoveLast();

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
          
            if (CodigoTextBox.Text !="")//Para poder eliminar las listas deben  contener valores
            {
                var resultadoNiños = MessageBox.Show("Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (resultadoNiños == DialogResult.Yes)
                {
                    var codigo = Convert.ToInt32(CodigoTextBox.Text);
                    Eliminar(codigo);
                }
                
            }
        }

        private void Eliminar(int codigo)
        {
            
            var resultadoNiños = _prod.EliminarProdNiños(codigo);
            if (resultadoNiños == true)
            {
                listaProdNiñosBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error eliminar al producto");
            }
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarHabilitarBotones(true);
            Eliminar(0);
        }
    }
}
