
namespace InterfazG
{
    partial class Productos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            this.label1 = new System.Windows.Forms.Label();
            this.btncrear = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtdato = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(398, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRODUCTOS";
            // 
            // btncrear
            // 
            this.btncrear.BackColor = System.Drawing.Color.DarkSalmon;
            this.btncrear.FlatAppearance.BorderSize = 0;
            this.btncrear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btncrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncrear.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btncrear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncrear.Image = ((System.Drawing.Image)(resources.GetObject("btncrear.Image")));
            this.btncrear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncrear.Location = new System.Drawing.Point(165, 345);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(261, 48);
            this.btncrear.TabIndex = 1;
            this.btncrear.Text = "CREAR";
            this.btncrear.UseVisualStyleBackColor = false;
            this.btncrear.Click += new System.EventHandler(this.btncrear_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.AutoSize = true;
            this.btnCerrar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCerrar.Location = new System.Drawing.Point(895, 9);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(18, 20);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "X";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.Color.White;
            this.txtuser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtuser.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtuser.Location = new System.Drawing.Point(285, 139);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(336, 27);
            this.txtuser.TabIndex = 3;
            this.txtuser.Text = "ingrese producto nuevo";
            this.txtuser.TextChanged += new System.EventHandler(this.txtuser_TextChanged);
            // 
            // txtdato
            // 
            this.txtdato.BackColor = System.Drawing.Color.White;
            this.txtdato.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtdato.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtdato.Location = new System.Drawing.Point(285, 202);
            this.txtdato.Name = "txtdato";
            this.txtdato.Size = new System.Drawing.Size(336, 27);
            this.txtdato.TabIndex = 5;
            this.txtdato.Text = "Dato almacenado";
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnguardar.FlatAppearance.BorderSize = 0;
            this.btnguardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnguardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnguardar.Image = ((System.Drawing.Image)(resources.GetObject("btnguardar.Image")));
            this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardar.Location = new System.Drawing.Point(467, 345);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(261, 48);
            this.btnguardar.TabIndex = 6;
            this.btnguardar.Text = "GUARDAR";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnmostrar
            // 
            this.btnmostrar.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnmostrar.FlatAppearance.BorderSize = 0;
            this.btnmostrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnmostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmostrar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnmostrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnmostrar.Image = ((System.Drawing.Image)(resources.GetObject("btnmostrar.Image")));
            this.btnmostrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmostrar.Location = new System.Drawing.Point(314, 420);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(261, 48);
            this.btnmostrar.TabIndex = 7;
            this.btnmostrar.Text = "MOSTRAR";
            this.btnmostrar.UseVisualStyleBackColor = false;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 503);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtdato);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btncrear);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Productos";
            this.Text = "PRODUCTOS";
            this.Load += new System.EventHandler(this.Productos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncrear;
        private System.Windows.Forms.Label btnCerrar;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtdato;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnmostrar;
    }
}