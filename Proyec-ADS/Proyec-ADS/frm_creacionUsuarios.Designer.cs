namespace Proyec_ADS
{
    partial class frm_creacionUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_creacionUsuarios));
            this.txt_verificarcontra = new System.Windows.Forms.TextBox();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_verificacion = new System.Windows.Forms.Label();
            this.lbl_contraseña = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_CodigoUsuario = new System.Windows.Forms.Label();
            this.lbl_correo = new System.Windows.Forms.Label();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Panel_CreacionUsuarios = new System.Windows.Forms.Panel();
            this.ptb_creacionusuarios = new System.Windows.Forms.PictureBox();
            this.lbl_CreacionUsuarios = new System.Windows.Forms.Label();
            this.grb_Creaciondeusuarios = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.Panel_CreacionUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_creacionusuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_verificarcontra
            // 
            this.txt_verificarcontra.Location = new System.Drawing.Point(689, 131);
            this.txt_verificarcontra.Name = "txt_verificarcontra";
            this.txt_verificarcontra.Size = new System.Drawing.Size(100, 20);
            this.txt_verificarcontra.TabIndex = 21;
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Location = new System.Drawing.Point(616, 71);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(100, 20);
            this.txt_contraseña.TabIndex = 20;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(269, 151);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(100, 20);
            this.txt_apellido.TabIndex = 19;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(269, 105);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre.TabIndex = 18;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(269, 67);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(100, 20);
            this.txt_codigo.TabIndex = 17;
            this.txt_codigo.Leave += new System.EventHandler(this.txt_codigo_Leave);
            // 
            // btn_guardar
            // 
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar.Location = new System.Drawing.Point(592, 282);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(187, 62);
            this.btn_guardar.TabIndex = 16;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Location = new System.Drawing.Point(134, 151);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(83, 13);
            this.lbl_apellido.TabIndex = 15;
            this.lbl_apellido.Text = "Apellido Usuario";
            // 
            // lbl_verificacion
            // 
            this.lbl_verificacion.AutoSize = true;
            this.lbl_verificacion.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_verificacion.Location = new System.Drawing.Point(455, 131);
            this.lbl_verificacion.Name = "lbl_verificacion";
            this.lbl_verificacion.Size = new System.Drawing.Size(228, 27);
            this.lbl_verificacion.TabIndex = 14;
            this.lbl_verificacion.Text = "Verificar Contraseña";
            // 
            // lbl_contraseña
            // 
            this.lbl_contraseña.AutoSize = true;
            this.lbl_contraseña.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contraseña.Location = new System.Drawing.Point(455, 64);
            this.lbl_contraseña.Name = "lbl_contraseña";
            this.lbl_contraseña.Size = new System.Drawing.Size(136, 27);
            this.lbl_contraseña.TabIndex = 13;
            this.lbl_contraseña.Text = "Contraseña";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(134, 105);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(83, 13);
            this.lbl_nombre.TabIndex = 12;
            this.lbl_nombre.Text = "Nombre Usuario";
            // 
            // lbl_CodigoUsuario
            // 
            this.lbl_CodigoUsuario.AutoSize = true;
            this.lbl_CodigoUsuario.Location = new System.Drawing.Point(134, 67);
            this.lbl_CodigoUsuario.Name = "lbl_CodigoUsuario";
            this.lbl_CodigoUsuario.Size = new System.Drawing.Size(79, 13);
            this.lbl_CodigoUsuario.TabIndex = 11;
            this.lbl_CodigoUsuario.Text = "Codigo Usuario";
            // 
            // lbl_correo
            // 
            this.lbl_correo.AutoSize = true;
            this.lbl_correo.Location = new System.Drawing.Point(134, 190);
            this.lbl_correo.Name = "lbl_correo";
            this.lbl_correo.Size = new System.Drawing.Size(94, 13);
            this.lbl_correo.TabIndex = 22;
            this.lbl_correo.Text = "Correo Electronico";
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(269, 187);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(100, 20);
            this.txt_correo.TabIndex = 23;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Panel_CreacionUsuarios
            // 
            this.Panel_CreacionUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));
            this.Panel_CreacionUsuarios.Controls.Add(this.ptb_creacionusuarios);
            this.Panel_CreacionUsuarios.Controls.Add(this.lbl_CreacionUsuarios);
            this.Panel_CreacionUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_CreacionUsuarios.Location = new System.Drawing.Point(0, 0);
            this.Panel_CreacionUsuarios.Name = "Panel_CreacionUsuarios";
            this.Panel_CreacionUsuarios.Size = new System.Drawing.Size(950, 58);
            this.Panel_CreacionUsuarios.TabIndex = 22;
            // 
            // ptb_creacionusuarios
            // 
            this.ptb_creacionusuarios.Image = ((System.Drawing.Image)(resources.GetObject("ptb_creacionusuarios.Image")));
            this.ptb_creacionusuarios.Location = new System.Drawing.Point(43, 0);
            this.ptb_creacionusuarios.Name = "ptb_creacionusuarios";
            this.ptb_creacionusuarios.Size = new System.Drawing.Size(94, 58);
            this.ptb_creacionusuarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_creacionusuarios.TabIndex = 1;
            this.ptb_creacionusuarios.TabStop = false;
            this.ptb_creacionusuarios.Click += new System.EventHandler(this.ptb_creacionusuarios_Click);
            // 
            // lbl_CreacionUsuarios
            // 
            this.lbl_CreacionUsuarios.AutoSize = true;
            this.lbl_CreacionUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CreacionUsuarios.ForeColor = System.Drawing.Color.White;
            this.lbl_CreacionUsuarios.Location = new System.Drawing.Point(239, 9);
            this.lbl_CreacionUsuarios.Name = "lbl_CreacionUsuarios";
            this.lbl_CreacionUsuarios.Size = new System.Drawing.Size(270, 31);
            this.lbl_CreacionUsuarios.TabIndex = 0;
            this.lbl_CreacionUsuarios.Text = "Creacion de usuarios";
            // 
            // grb_Creaciondeusuarios
            // 
            this.grb_Creaciondeusuarios.Location = new System.Drawing.Point(43, 64);
            this.grb_Creaciondeusuarios.Name = "grb_Creaciondeusuarios";
            this.grb_Creaciondeusuarios.Size = new System.Drawing.Size(884, 378);
            this.grb_Creaciondeusuarios.TabIndex = 23;
            this.grb_Creaciondeusuarios.TabStop = false;
            this.grb_Creaciondeusuarios.UseCompatibleTextRendering = true;
            // 
            // frm_creacionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 551);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.lbl_correo);
            this.Controls.Add(this.txt_verificarcontra);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.lbl_verificacion);
            this.Controls.Add(this.lbl_contraseña);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.lbl_CodigoUsuario);
            this.Controls.Add(this.grb_Creaciondeusuarios);
            this.Controls.Add(this.Panel_CreacionUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_creacionUsuarios";
            this.Text = "frm_creacionUsuarios";
            this.Load += new System.EventHandler(this.frm_creacionUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.Panel_CreacionUsuarios.ResumeLayout(false);
            this.Panel_CreacionUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_creacionusuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_verificarcontra;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label lbl_verificacion;
        private System.Windows.Forms.Label lbl_contraseña;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_CodigoUsuario;
        private System.Windows.Forms.Label lbl_correo;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel Panel_CreacionUsuarios;
        private System.Windows.Forms.Label lbl_CreacionUsuarios;
        private System.Windows.Forms.GroupBox grb_Creaciondeusuarios;
        private System.Windows.Forms.PictureBox ptb_creacionusuarios;
    }
}