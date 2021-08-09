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
    public partial class FormReporteVentas : Form
    {
        public FormReporteVentas()
        {
            InitializeComponent();

            var _facturaBL = new FacturaBL();
            var bindingSource = new BindingSource();
            bindingSource.DataSource = _facturaBL.ObtenerFacturas();

            var reporte = new ReporteVentas();
            reporte.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
