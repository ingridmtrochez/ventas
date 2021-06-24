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
    }
}
