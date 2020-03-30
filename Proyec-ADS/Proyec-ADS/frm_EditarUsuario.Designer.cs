namespace Proyec_ADS
{
    partial class frm_EditarUsuario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_EditarUsuario));
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_contraseña = new System.Windows.Forms.Label();
            this.lbl_verificacion = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.txt_verificarcontra = new System.Windows.Forms.TextBox();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.lbl_correo = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel_Editarusuarios = new System.Windows.Forms.Panel();
            this.ptb_creacionusuarios = new System.Windows.Forms.PictureBox();
            this.lbl_Editarusuario = new System.Windows.Forms.Label();
            this.grb_Editarusuarios = new System.Windows.Forms.GroupBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel_Editarusuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_creacionusuarios)).BeginInit();
            this.grb_Editarusuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(50, 57);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(147, 22);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.Text = "Nombre Usuario";
            // 
            // lbl_contraseña
            // 
            this.lbl_contraseña.AutoSize = true;
            this.lbl_contraseña.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contraseña.Location = new System.Drawing.Point(49, 179);
            this.lbl_contraseña.Name = "lbl_contraseña";
            this.lbl_contraseña.Size = new System.Drawing.Size(107, 22);
            this.lbl_contraseña.TabIndex = 2;
            this.lbl_contraseña.Text = "Contraseña";
            // 
            // lbl_verificacion
            // 
            this.lbl_verificacion.AutoSize = true;
            this.lbl_verificacion.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_verificacion.Location = new System.Drawing.Point(49, 219);
            this.lbl_verificacion.Name = "lbl_verificacion";
            this.lbl_verificacion.Size = new System.Drawing.Size(181, 22);
            this.lbl_verificacion.TabIndex = 3;
            this.lbl_verificacion.Text = "Verificar Contraseña";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellido.Location = new System.Drawing.Point(49, 97);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(148, 22);
            this.lbl_apellido.TabIndex = 4;
            this.lbl_apellido.Text = "Apellido Usuario";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(285, 57);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre.TabIndex = 7;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(285, 97);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(100, 20);
            this.txt_apellido.TabIndex = 8;
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Location = new System.Drawing.Point(285, 182);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(100, 20);
            this.txt_contraseña.TabIndex = 9;
            // 
            // txt_verificarcontra
            // 
            this.txt_verificarcontra.Location = new System.Drawing.Point(285, 222);
            this.txt_verificarcontra.Name = "txt_verificarcontra";
            this.txt_verificarcontra.Size = new System.Drawing.Size(100, 20);
            this.txt_verificarcontra.TabIndex = 10;
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(285, 140);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(100, 20);
            this.txt_correo.TabIndex = 25;
            // 
            // lbl_correo
            // 
            this.lbl_correo.AutoSize = true;
            this.lbl_correo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_correo.Location = new System.Drawing.Point(49, 140);
            this.lbl_correo.Name = "lbl_correo";
            this.lbl_correo.Size = new System.Drawing.Size(169, 22);
            this.lbl_correo.TabIndex = 24;
            this.lbl_correo.Text = "Correo Electronico";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel_Editarusuarios
            // 
            this.panel_Editarusuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));
            this.panel_Editarusuarios.Controls.Add(this.ptb_creacionusuarios);
            this.panel_Editarusuarios.Controls.Add(this.lbl_Editarusuario);
            this.panel_Editarusuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Editarusuarios.Location = new System.Drawing.Point(0, 0);
            this.panel_Editarusuarios.Name = "panel_Editarusuarios";
            this.panel_Editarusuarios.Size = new System.Drawing.Size(950, 58);
            this.panel_Editarusuarios.TabIndex = 11;
            // 
            // ptb_creacionusuarios
            // 
            this.ptb_creacionusuarios.Image = ((System.Drawing.Image)(resources.GetObject("ptb_creacionusuarios.Image")));
            this.ptb_creacionusuarios.Location = new System.Drawing.Point(43, 0);
            this.ptb_creacionusuarios.Name = "ptb_creacionusuarios";
            this.ptb_creacionusuarios.Size = new System.Drawing.Size(86, 58);
            this.ptb_creacionusuarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_creacionusuarios.TabIndex = 2;
            this.ptb_creacionusuarios.TabStop = false;
            // 
            // lbl_Editarusuario
            // 
            this.lbl_Editarusuario.AutoSize = true;
            this.lbl_Editarusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Editarusuario.ForeColor = System.Drawing.Color.White;
            this.lbl_Editarusuario.Location = new System.Drawing.Point(239, 9);
            this.lbl_Editarusuario.Name = "lbl_Editarusuario";
            this.lbl_Editarusuario.Size = new System.Drawing.Size(200, 31);
            this.lbl_Editarusuario.TabIndex = 0;
            this.lbl_Editarusuario.Text = "Editar Usuarios";
            // 
            // grb_Editarusuarios
            // 
            this.grb_Editarusuarios.Controls.Add(this.btn_guardar);
            this.grb_Editarusuarios.Controls.Add(this.txt_nombre);
            this.grb_Editarusuarios.Controls.Add(this.txt_apellido);
            this.grb_Editarusuarios.Controls.Add(this.txt_correo);
            this.grb_Editarusuarios.Controls.Add(this.txt_verificarcontra);
            this.grb_Editarusuarios.Controls.Add(this.lbl_nombre);
            this.grb_Editarusuarios.Controls.Add(this.txt_contraseña);
            this.grb_Editarusuarios.Controls.Add(this.lbl_correo);
            this.grb_Editarusuarios.Controls.Add(this.lbl_contraseña);
            this.grb_Editarusuarios.Controls.Add(this.lbl_verificacion);
            this.grb_Editarusuarios.Controls.Add(this.lbl_apellido);
            this.grb_Editarusuarios.Location = new System.Drawing.Point(43, 64);
            this.grb_Editarusuarios.Name = "grb_Editarusuarios";
            this.grb_Editarusuarios.Size = new System.Drawing.Size(884, 378);
            this.grb_Editarusuarios.TabIndex = 12;
            this.grb_Editarusuarios.TabStop = false;
            // 
            // btn_guardar
            // 
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar.Location = new System.Drawing.Point(541, 179);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(187, 62);
            this.btn_guardar.TabIndex = 26;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_EditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 551);
            this.Controls.Add(this.grb_Editarusuarios);
            this.Controls.Add(this.panel_Editarusuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_EditarUsuario";
            this.Text = "frm_EditarUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel_Editarusuarios.ResumeLayout(false);
            this.panel_Editarusuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_creacionusuarios)).EndInit();
            this.grb_Editarusuarios.ResumeLayout(false);
            this.grb_Editarusuarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_contraseña;
        private System.Windows.Forms.Label lbl_verificacion;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.TextBox txt_verificarcontra;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.Label lbl_correo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel_Editarusuarios;
        private System.Windows.Forms.Label lbl_Editarusuario;
        private System.Windows.Forms.GroupBox grb_Editarusuarios;
        private System.Windows.Forms.PictureBox ptb_creacionusuarios;
        private System.Windows.Forms.Button btn_guardar;
    }
}