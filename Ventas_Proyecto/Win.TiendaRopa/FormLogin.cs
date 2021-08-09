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
    public partial class FormLogin : Form
    {
        SeguridadBL _seguridad;

        public FormLogin()
        {
            InitializeComponent();

            _seguridad = new SeguridadBL();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
        
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            string usuario;
            string contrasena;

            usuario = textBox1.Text;
            contrasena = textBox2.Text;

            buttonAceptar.Enabled = false;
            buttonAceptar.Text = "Verificando...";
            Application.DoEvents();

            var usuarioDB = _seguridad.Autorizar(usuario, contrasena);

            if (usuarioDB != null)
            {
                Utilidades.NombreUsuario = usuarioDB.Nombre;
                this.Close();

            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }

            buttonAceptar.Enabled = true;
            buttonAceptar.Text = "Aceptar";
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    textBox2.Focus();
                }
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox2.Text != "")
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    buttonAceptar.PerformClick();
                }
            }
        }
    }
}
