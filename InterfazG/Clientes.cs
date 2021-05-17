using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Dominio;

namespace InterfazG
{
    public partial class Clientes : Form
    {
        N_ConsultasClientes objetoD = new N_ConsultasClientes();

        public Clientes()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void MostrarClientes()
        {
            dataGridView1.DataSource = objetoD.MostrarClie();

        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            MostrarClientes();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try { 
            objetoD.InsertarClie(txtNombre.Text, txtNIT.Text, txtDireccion.Text, txtCiudad.Text, txtTelefono.Text);
            MessageBox.Show("Se inserto correctamente");
            MostrarClientes();
        }
        catch (Exception ex) {
        MessageBox.Show("No se puede insertar los datos por: " +ex);     
          }


}

}
}

