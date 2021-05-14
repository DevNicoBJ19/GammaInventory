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
            ListarCategorias();
            ListarMarcas();
        }
        private void ListarCategorias()
        {
            ClsProductos objProd = new ClsProductos();
            cmbCategoria.DataSource = objProd.ListarCategorias();
            cmbCategoria.DisplayMember = "CATEGORIAS";
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
    }
}
