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
        private string idCliente = null;
        private bool Editar = false;
        
        

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
           //Este objeto es reutilizable, para que refresque la informacion
           //de las tablas al añadir un dato nuevo, y no la muestre dos veces
            N_ConsultasClientes objeto = new N_ConsultasClientes();
            dataGridView1.DataSource = objeto.MostrarClie();
            

        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            MostrarClientes();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //INSERTAR
            if (Editar == false)
            {
                try
                {
                    objetoD.InsertarClie(txtNombre.Text, txtNIT.Text, txtDireccion.Text, txtCiudad.Text, txtTelefono.Text);
                    MessageBox.Show("Se inserto correctamente");
                    MostrarClientes();    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo insertar los datos por: " + ex);
                }

            }
            //EDITAR
            if (Editar == true)
            {
                try
                {
                    objetoD.EditarClie(txtNombre.Text, txtNIT.Text, txtDireccion.Text, txtCiudad.Text, txtTelefono.Text, idCliente);
                    MessageBox.Show("se edito correctamente");
                    MostrarClientes();
                    limpiarForm();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo editar los datos por: " + ex);
                }
            }
        }

        public void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txtNIT.Text = dataGridView1.CurrentRow.Cells["nit"].Value.ToString();
                txtDireccion.Text = dataGridView1.CurrentRow.Cells["direccion"].Value.ToString();
                txtCiudad.Text = dataGridView1.CurrentRow.Cells["ciudad"].Value.ToString();
                txtTelefono.Text = dataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();
                idCliente = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }
        private void limpiarForm()
        {
            txtDireccion.Clear();
            txtNIT.Clear();
            txtNombre.Clear();
            txtCiudad.Clear();
            txtTelefono.Clear();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idCliente = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                objetoD.EliminarClie(idCliente);
                MessageBox.Show("Eliminado correctamente");

            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMo‌​de.Fill);
        }
    }
}



