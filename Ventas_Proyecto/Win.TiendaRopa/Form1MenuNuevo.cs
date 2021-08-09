using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Win.TiendaRopa
{
    public partial class Form1MenuNuevo : Form
    {
        public Form1MenuNuevo()
        {
            
            InitializeComponent();
            
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd,int wmsg, int wparm,int lparam);

        private void Form1MenuNuevo_Load(object sender, EventArgs e)
        {
            Etiqueta.Text = "INICIO";
            Login();
        }
        
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void AbrirFormulario(object Formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;

            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
            Etiqueta.Text = fh.Text;
            {

            }
        }

        private void Producto_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormProductos());
            
     
            DeshabilitarPaneles();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormFactura());
            
            
            DeshabilitarPaneles();
            
        }
      
        private void buttonReportes_Click(object sender, EventArgs e)
        {
            DeshabilitarPaneles();
            panelSubmenuReportes.Visible = true;
            
        }

        private void buttonRventas_Click(object sender, EventArgs e)
        {
            
            DeshabilitarPaneles();

            AbrirFormulario(new FormReporteVentas());
        }

        private void DeshabilitarPaneles()
        {
            panelSubmenuReportes.Visible = false;
            panelSeguridad.Visible = false;
        }

        private void buttonRproductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormReporteProductos());
            
            DeshabilitarPaneles();
            
        }

        private void buttonRclientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormReporteClientes());
            
            DeshabilitarPaneles();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeshabilitarPaneles();
        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            Etiqueta.Text = "Clientes";
            AbrirFormulario(new FormClientes());
            DeshabilitarPaneles();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            panelSubmenuReportes.Visible = false;
            Etiqueta.Text = "Seguridad";
            panelSeguridad.Visible = true;
        }

        private void Login()
        {
            var formLogin = new FormLogin();
            formLogin.ShowDialog();

            toolStripStatusLabel1.Text = "Usuario: " + Utilidades.NombreUsuario;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            Login();
            panelSeguridad.Visible = false;
            
        }

        private void panelLateralizquierdo_Click(object sender, EventArgs e)
        {
            DeshabilitarPaneles();
            Etiqueta.Text = "INICIO";

        }

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            Hora.Text = DateTime.Now.ToLongTimeString();

        }

        
        private void panelContenedor_Click(object sender, EventArgs e)
        {
            Etiqueta.Text = "INICIO";
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Etiqueta.Text = "INICIO";
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            AbrirFormulario(new FormUsuarios());

            DeshabilitarPaneles();

        }
    }
}
