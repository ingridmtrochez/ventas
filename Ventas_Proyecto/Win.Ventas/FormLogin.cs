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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //Botón Salir
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e) //Botón Aceptar
        {
            string usuario;
            string contraseña;

            usuario = textBox1.Text;
            contraseña = textBox2.Text;
            if (usuario == "admin" && contraseña == "tienda")
            {
                this.Close();
            }
            else if (usuario == "caja" && contraseña == "caja1")
            {
                this.Close();
            }
            else
            { 
            MessageBox.Show("Usuario o Contraseña Incorrecta");
            }
        }
    }
}
