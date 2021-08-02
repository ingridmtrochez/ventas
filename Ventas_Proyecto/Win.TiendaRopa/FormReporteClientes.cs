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

namespace Win.TiendaRopa
{
    public partial class FormReporteClientes : Form
    {
        public FormReporteClientes()
        {
            InitializeComponent();

            var _clienteBL = new ClientesBL();
            var bindingSource = new BindingSource(); //Para enlazar en el reporte
            bindingSource.DataSource = _clienteBL.ObtenerClientes();

            var reporte = new ReporteClientes();
            reporte.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport(); //genera el reporte


        }
    }
}
