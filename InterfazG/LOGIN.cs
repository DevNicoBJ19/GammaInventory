using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using Dominio;
using CapaComun.Cache;

namespace InterfazG
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "USUARIO")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.DimGray;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "USUARIO";
                txtuser.ForeColor = Color.DimGray;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "CONTRASEÑA")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.DimGray;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "CONTRASEÑA";
                txtpass.ForeColor = Color.DimGray;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void LOGIN_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtuser.Text != "USUARIO")
            {
                if (txtpass.Text != "CONTRASEÑA")
                {
                    ModeloUsuario usuario = new ModeloUsuario();
                    var validLogin = usuario.LoginUser(txtuser.Text, txtpass.Text);
                    if (validLogin == true)
                    {
                        this.Hide();
                        FormBienvenida bienvenida = new FormBienvenida();
                        bienvenida.ShowDialog();
                        FormPrincipal mainMenu = new FormPrincipal();
                        
                        mainMenu.Show();
                        mainMenu.FormClosed += logout;
                        this.Hide();
                    }
                    else
                    {
                        MsgError("     Usuario o contraseña incorrectos.  \n        Por favor intente de nuevo.");
                        txtpass.Text = "Contraseña";
                        txtuser.Focus();
                    }     
                }
                else MsgError("     Por favor ingrese su contraseña");
            }
            else MsgError("     Por favor ingrese su usuario");
        }
        private void MsgError(String msg)
        {
            lblErrorMessage.Text = " " + msg;
            lblErrorMessage.Visible = true;
        }
        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }
        private void logout(object sender, FormClosedEventArgs e)
        {
            txtpass.Text = "CONTRASEÑA";
            txtpass.UseSystemPasswordChar = false;
            txtuser.Text = "USUARIO";
            lblErrorMessage.Visible = false;
            this.Show();
        }
    }
}