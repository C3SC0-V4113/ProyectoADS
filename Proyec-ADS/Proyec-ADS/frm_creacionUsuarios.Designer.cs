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
            this.Panel_CreacionUsuarios = new System.Windows.Forms.Panel();
            this.lbl_CreacionUsuarios = new System.Windows.Forms.Label();
            this.grb_Creaciondeusuarios = new System.Windows.Forms.GroupBox();
            this.Panel_CreacionUsuarios.SuspendLayout();
            this.grb_Creaciondeusuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_verificarcontra
            // 
            this.txt_verificarcontra.Location = new System.Drawing.Point(689, 131);
            this.txt_verificarcontra.Name = "txt_verificarcontra";
            this.txt_verificarcontra.Size = new System.Drawing.Size(176, 20);
            this.txt_verificarcontra.TabIndex = 21;
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Location = new System.Drawing.Point(616, 71);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(197, 20);
            this.txt_contraseña.TabIndex = 20;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(222, 204);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(174, 20);
            this.txt_apellido.TabIndex = 19;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(213, 131);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(183, 20);
            this.txt_nombre.TabIndex = 18;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(213, 64);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(183, 20);
            this.txt_codigo.TabIndex = 17;
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
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellido.Location = new System.Drawing.Point(29, 197);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(187, 27);
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
            this.lbl_nombre.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(30, 124);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(186, 27);
            this.lbl_nombre.TabIndex = 12;
            this.lbl_nombre.Text = "Nombre Usuario";
            // 
            // lbl_CodigoUsuario
            // 
            this.lbl_CodigoUsuario.AutoSize = true;
            this.lbl_CodigoUsuario.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CodigoUsuario.Location = new System.Drawing.Point(30, 57);
            this.lbl_CodigoUsuario.Name = "lbl_CodigoUsuario";
            this.lbl_CodigoUsuario.Size = new System.Drawing.Size(177, 27);
            this.lbl_CodigoUsuario.TabIndex = 11;
            this.lbl_CodigoUsuario.Text = "Codigo Usuario";
            // 
            // Panel_CreacionUsuarios
            // 
            this.Panel_CreacionUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));
            this.Panel_CreacionUsuarios.Controls.Add(this.lbl_CreacionUsuarios);
            this.Panel_CreacionUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_CreacionUsuarios.Location = new System.Drawing.Point(0, 0);
            this.Panel_CreacionUsuarios.Name = "Panel_CreacionUsuarios";
            this.Panel_CreacionUsuarios.Size = new System.Drawing.Size(950, 49);
            this.Panel_CreacionUsuarios.TabIndex = 22;
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
            this.grb_Creaciondeusuarios.Controls.Add(this.lbl_CodigoUsuario);
            this.grb_Creaciondeusuarios.Controls.Add(this.txt_codigo);
            this.grb_Creaciondeusuarios.Controls.Add(this.btn_guardar);
            this.grb_Creaciondeusuarios.Controls.Add(this.txt_verificarcontra);
            this.grb_Creaciondeusuarios.Controls.Add(this.lbl_nombre);
            this.grb_Creaciondeusuarios.Controls.Add(this.txt_contraseña);
            this.grb_Creaciondeusuarios.Controls.Add(this.lbl_verificacion);
            this.grb_Creaciondeusuarios.Controls.Add(this.txt_nombre);
            this.grb_Creaciondeusuarios.Controls.Add(this.txt_apellido);
            this.grb_Creaciondeusuarios.Controls.Add(this.lbl_apellido);
            this.grb_Creaciondeusuarios.Controls.Add(this.lbl_contraseña);
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
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 551);
            this.Controls.Add(this.grb_Creaciondeusuarios);
            this.Controls.Add(this.Panel_CreacionUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_creacionUsuarios";
            this.Text = "frm_creacionUsuarios";
            this.Load += new System.EventHandler(this.frm_creacionUsuarios_Load);
            this.Panel_CreacionUsuarios.ResumeLayout(false);
            this.Panel_CreacionUsuarios.PerformLayout();
            this.grb_Creaciondeusuarios.ResumeLayout(false);
            this.grb_Creaciondeusuarios.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel Panel_CreacionUsuarios;
        private System.Windows.Forms.Label lbl_CreacionUsuarios;
        private System.Windows.Forms.GroupBox grb_Creaciondeusuarios;
    }
}