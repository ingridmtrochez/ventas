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
    public partial class FormMujeres : Form
    {
        MujeresBL _product;
        public FormMujeres()
        {
            
            InitializeComponent();
            _product = new MujeresBL();
            mujerBindingSource.DataSource = _product.obtenerProductos();
        }

        private void FormProducto_Load(object sender, EventArgs e)
        {

        }

        private void mujerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            mujerBindingSource.EndEdit();//finaliza edicion
            var hombre = (Mujer)mujerBindingSource.Current;//Obtenemos las propiedades del producto actual de la clase Hombres

            var resultado = _product.GuardarProdMujeres(hombre);

            if (resultado.Exitoso == true)
            {
                mujerBindingSource.ResetBindings(false);//Guarda los nuevos cambios en la lista
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Elemento Guardado","Mensaje de confirmacion");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _product.AgregarProdMujeres();
            mujerBindingSource.MoveLast();

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

        private void Eliminar(int codigo)
        {
            var resultado = _product.EliminarProdMujeres(codigo);
            if (resultado == true)
            {
                mujerBindingSource.ResetBindings(false);
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
    }
    }
