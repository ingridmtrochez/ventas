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
        MujeresBL _productos;

        public FormMujeres()
        {
            InitializeComponent();

            _productos = new MujeresBL();//Inicializar
            listaProdMujeresBindingSource.DataSource = _productos.obtenerProductos();
        }
    }
}
