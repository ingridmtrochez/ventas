﻿using BL.Ventas;
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
        SeguridadBL _seguridad;

        public Form1()
        {
            InitializeComponent();

            _seguridad = new SeguridadBL();
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

            var resultado = _seguridad.Autorizar(usuario,contraseña);

            if (resultado)
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
