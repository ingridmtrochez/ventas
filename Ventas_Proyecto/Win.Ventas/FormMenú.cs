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
    public partial class FormMenú : Form
    {
        public FormMenú()
        {
            InitializeComponent();
        }

        private void FormMenú_Load(object sender, EventArgs e) // Form Login
        {
            Login();
        }

        private void reporteDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e) // Form Mujeres
        {
            var formMujeres = new FormMujeres();
            formMujeres.MdiParent = this;
            formMujeres.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e) // Form Login
        {
            Login();
        }

        private void Login()
        {
            var form1 = new Form1();
            form1.ShowDialog();
        }

        private void hombresToolStripMenuItem_Click(object sender, EventArgs e) // Form Hombres
        {
            var formHombres = new FormHombres();
            formHombres.MdiParent = this;
            formHombres.Show();
        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e) // Form Niños
        {
            var formNiños = new FormNiños();
            formNiños.MdiParent = this;
            formNiños.Show();
        }

        private void reportesRopaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
