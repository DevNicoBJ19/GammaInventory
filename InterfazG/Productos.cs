using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Linq;


namespace InterfazG
{
    public partial class Productos : Form

    {
        Pilas objeto = new Pilas();
        

        public Productos()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtuser_TextChanged(object sender, EventArgs e)      
        {
        }

        private void Productos_Load(object sender, EventArgs e)
        {
        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            string m = (txtuser.Text);
            objeto = new Pilas(m);
            MessageBox.Show("Pila Creada");
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string n = (txtdato.Text);
            objeto.push(n);
            txtdato.Clear();
            txtdato.Focus();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            string n;
            n = objeto.pop();
            MessageBox.Show("Salio:" + n);
        }
    }
}
