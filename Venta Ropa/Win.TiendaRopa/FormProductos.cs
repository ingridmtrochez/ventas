using BL.Ventas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.TiendaRopa
{
    public partial class FormProductos : Form
    {
        ProductosBL _productos;
        DepartamentosBL _departamentoBL;
        SeccionBL _seccionBL;

        public FormProductos()
        {
            InitializeComponent();

            _productos = new ProductosBL();
            listaProductosBindingSource.DataSource = _productos.ObtenerProductos();

            _departamentoBL = new DepartamentosBL();
            listaDepartamentosBindingSource.DataSource = _departamentoBL.ObtenerDepartamentos();

            _seccionBL = new SeccionBL();
            listaSeccionBindingSource.DataSource = _seccionBL.ObtenerSeccion();

        }

        private void FormProductos_Load(object sender, EventArgs e)
        {

        }

        private void listaProductosBindingNavigatorSaveItem_Click(object sender, EventArgs e) // Click en boton Guardar
        {
            listaProductosBindingSource.EndEdit();
            var producto = (Producto)listaProductosBindingSource.Current;

            if (fotoPictureBox.Image !=  null)
            {
                producto.Foto = Program.imageToByteArray(fotoPictureBox.Image); // si la caja de imagen no esta vacia convertira en campo en arreglo
        
            }
            else
            {
                producto.Foto = null; // si la caja de imagen esta vacia dejara el campo foto como vacio
            }

            var resultado = _productos.GuardarProducto(producto);

            if (resultado.Exitoso == true)
            {
                listaProductosBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Producto guardado");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e) // Click en boton Agregar
        {
            _productos.AgregarProducto();
            listaProductosBindingSource.MoveLast();

            DeshabilitarHabilitarBotones(false);
        }

        private void DeshabilitarHabilitarBotones(bool valor) // Metodo para habilitar o deshabilitar barra de opciones
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

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e) // Click en boton Eliminar
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

        private void Eliminar(int id) // Metodo para eliminar una entrada o un producto de la lista
        {
            
            var resultado = _productos.EliminarProducto(id);

            if (resultado == true)
            {
                listaProductosBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar el producto");
            }
        }

        private void toolStripButtoncancelar_Click(object sender, EventArgs e) // Click en boton Cancelar
        {
            _productos.CancelarCambios();
            DeshabilitarHabilitarBotones(true);
        }

        private void button1_Click(object sender, EventArgs e) // Click en boton agregar foto
        {
            var producto = (Producto)listaProductosBindingSource.Current;

            if (producto != null)
            {
                openFileDialog1.ShowDialog(); // Abrir un cuadro de dialogo para agregar archivos
                var archivo = openFileDialog1.FileName; // Declaracion de variable "archivo"

                if (archivo != "")
                {
                    var fileInfo = new FileInfo(archivo);
                    var fileStream = fileInfo.OpenRead();

                    fotoPictureBox.Image = Image.FromStream(fileStream);
                }
            }
            else
            {
                MessageBox.Show("Cree un producto antes de asignar una imagen");
            }
           
        }

        private void button2_Click(object sender, EventArgs e) // Click en boton remover imagen
        {
            fotoPictureBox.Image = null; // deja vacia la caja de imagen
        }
    }
}
