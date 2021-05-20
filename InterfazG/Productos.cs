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
        string Operacion = "Insertar";
        string idprod;

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
        private void LimpiarFormulario()
        {
            txtdescripcion.Clear();
            txtprecio.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(Operacion =="Insertar")
            {

                objProducto.InsertarProductos(
                Convert.ToInt32(cmbCategoria.SelectedValue),
                Convert.ToInt32(cmbMarca.SelectedValue),
                txtdescripcion.Text,
                Convert.ToDouble(txtprecio.Text));
            MessageBox.Show("Dato almacenado correctamente");
            
        }
            else if (Operacion == "Editar")
            {
                objProducto.EditarProductos(Convert.ToInt32(idprod) ,
                    Convert.ToInt32(cmbCategoria.SelectedValue),
                    Convert.ToInt32(cmbMarca.SelectedValue),
                    txtdescripcion.Text,
                    Convert.ToDouble(txtprecio.Text));
                    Operacion = "Insertar";
                MessageBox.Show("Se edito correctamente");
            }
                ListarProductos();
                LimpiarFormulario();
            
        }
        private void ListarProductos()
        {
            ClsProductos objPro = new ClsProductos();
            dataGridView1.DataSource = objPro.ListarProductos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Operacion = "Editar";
                cmbCategoria.Text = dataGridView1.CurrentRow.Cells["CATEGORIA"].Value.ToString();
                cmbMarca.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtdescripcion.Text = dataGridView1.CurrentRow.Cells["DESCRIPCION"].Value.ToString();
                txtprecio.Text = dataGridView1.CurrentRow.Cells["PRECIO"].Value.ToString();
                idprod = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
            }
            else
                MessageBox.Show("Debe seleccionar una fila");
        }
    }
}
