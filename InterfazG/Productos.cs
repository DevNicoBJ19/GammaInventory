using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Linq;
using DataAcceso;


namespace InterfazG
{
    public partial class Productos : Form

    {

        ClsProductos objProducto = new ClsProductos();

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
            ListarCategorias();
            ListarMarcas();
            ListarProductos();
        }
        private void ListarCategorias()
        {
            ClsProductos objProd = new ClsProductos();
            cmbCategoria.DataSource = objProd.ListarCategorias();
            cmbCategoria.DisplayMember = "CATEGORIA";
            cmbCategoria.ValueMember = "IDCATEG";
        }
        private void ListarMarcas()
        {
            ClsProductos objProd = new ClsProductos();
            cmbMarca.DataSource = objProd.ListarMarcas();
            cmbMarca.DisplayMember = "MARCA";
            cmbMarca.ValueMember = "IDMARCA";
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            objProducto.InsertarProductos(
                Convert.ToInt32(cmbCategoria.SelectedValue),
                Convert.ToInt32(cmbMarca.SelectedValue),
                txtdescripcion.Text,
                Convert.ToDouble(txtprecio.Text));
            MessageBox.Show("Dato almacenado correctamente");
            ListarProductos();
        }
        private void ListarProductos()
        {
            ClsProductos objPro = new ClsProductos();
            dataGridView1.DataSource = objPro.ListarProductos();
        }
    }
}
