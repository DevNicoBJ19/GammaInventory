
namespace InterfazG
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnprod = new System.Windows.Forms.Button();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.iconomaximizar = new System.Windows.Forms.PictureBox();
            this.iconorestaurar = new System.Windows.Forms.PictureBox();
            this.btnslide = new System.Windows.Forms.PictureBox();
            this.iconocerrar = new System.Windows.Forms.PictureBox();
            this.iconominimizar = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconomaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconorestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnslide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconocerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconominimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.DarkSalmon;
            this.MenuVertical.Controls.Add(this.pictureBox2);
            this.MenuVertical.Controls.Add(this.button3);
            this.MenuVertical.Controls.Add(this.button2);
            this.MenuVertical.Controls.Add(this.btnprod);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(261, 650);
            this.MenuVertical.TabIndex = 0;
            this.MenuVertical.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuVertical_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(255, 86);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 232);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(261, 48);
            this.button3.TabIndex = 2;
            this.button3.Text = "Clientes";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 320);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(261, 48);
            this.button2.TabIndex = 1;
            this.button2.Text = "Proveedores";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnprod
            // 
            this.btnprod.FlatAppearance.BorderSize = 0;
            this.btnprod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnprod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprod.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnprod.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnprod.Image = ((System.Drawing.Image)(resources.GetObject("btnprod.Image")));
            this.btnprod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnprod.Location = new System.Drawing.Point(0, 144);
            this.btnprod.Name = "btnprod";
            this.btnprod.Size = new System.Drawing.Size(261, 48);
            this.btnprod.TabIndex = 0;
            this.btnprod.Text = "Productos";
            this.btnprod.UseVisualStyleBackColor = true;
            this.btnprod.Click += new System.EventHandler(this.btnprod_Click);
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.Controls.Add(this.iconomaximizar);
            this.BarraTitulo.Controls.Add(this.iconorestaurar);
            this.BarraTitulo.Controls.Add(this.btnslide);
            this.BarraTitulo.Controls.Add(this.iconocerrar);
            this.BarraTitulo.Controls.Add(this.iconominimizar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(261, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1039, 50);
            this.BarraTitulo.TabIndex = 1;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // iconomaximizar
            // 
            this.iconomaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconomaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconomaximizar.Image = ((System.Drawing.Image)(resources.GetObject("iconomaximizar.Image")));
            this.iconomaximizar.Location = new System.Drawing.Point(981, 12);
            this.iconomaximizar.Name = "iconomaximizar";
            this.iconomaximizar.Size = new System.Drawing.Size(20, 20);
            this.iconomaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconomaximizar.TabIndex = 2;
            this.iconomaximizar.TabStop = false;
            this.iconomaximizar.Click += new System.EventHandler(this.iconomaximizar_Click);
            // 
            // iconorestaurar
            // 
            this.iconorestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconorestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconorestaurar.Image = ((System.Drawing.Image)(resources.GetObject("iconorestaurar.Image")));
            this.iconorestaurar.Location = new System.Drawing.Point(981, 12);
            this.iconorestaurar.Name = "iconorestaurar";
            this.iconorestaurar.Size = new System.Drawing.Size(20, 20);
            this.iconorestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconorestaurar.TabIndex = 4;
            this.iconorestaurar.TabStop = false;
            this.iconorestaurar.Visible = false;
            this.iconorestaurar.Click += new System.EventHandler(this.iconorestaurar_Click);
            // 
            // btnslide
            // 
            this.btnslide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnslide.Image = ((System.Drawing.Image)(resources.GetObject("btnslide.Image")));
            this.btnslide.Location = new System.Drawing.Point(6, 9);
            this.btnslide.Name = "btnslide";
            this.btnslide.Size = new System.Drawing.Size(35, 35);
            this.btnslide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnslide.TabIndex = 0;
            this.btnslide.TabStop = false;
            this.btnslide.Click += new System.EventHandler(this.btnslide_Click);
            // 
            // iconocerrar
            // 
            this.iconocerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconocerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconocerrar.Image = ((System.Drawing.Image)(resources.GetObject("iconocerrar.Image")));
            this.iconocerrar.Location = new System.Drawing.Point(1007, 12);
            this.iconocerrar.Name = "iconocerrar";
            this.iconocerrar.Size = new System.Drawing.Size(20, 20);
            this.iconocerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconocerrar.TabIndex = 1;
            this.iconocerrar.TabStop = false;
            this.iconocerrar.Click += new System.EventHandler(this.iconocerrar_Click);
            // 
            // iconominimizar
            // 
            this.iconominimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconominimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconominimizar.Image = ((System.Drawing.Image)(resources.GetObject("iconominimizar.Image")));
            this.iconominimizar.Location = new System.Drawing.Point(955, 12);
            this.iconominimizar.Name = "iconominimizar";
            this.iconominimizar.Size = new System.Drawing.Size(20, 20);
            this.iconominimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconominimizar.TabIndex = 3;
            this.iconominimizar.TabStop = false;
            this.iconominimizar.Click += new System.EventHandler(this.iconominimizar_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(261, 50);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1039, 600);
            this.panelContenedor.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconomaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconorestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnslide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconocerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconominimizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox btnslide;
        private System.Windows.Forms.PictureBox iconorestaurar;
        private System.Windows.Forms.PictureBox iconocerrar;
        private System.Windows.Forms.PictureBox iconomaximizar;
        private System.Windows.Forms.PictureBox iconominimizar;
        private System.Windows.Forms.Button btnprod;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

