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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel_Editarusuarios = new System.Windows.Forms.Panel();
            this.lbl_Editarusuario = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grb_Editarusuarios = new System.Windows.Forms.GroupBox();
            this.CN = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NU = new System.Windows.Forms.ComboBox();
            this.AU = new System.Windows.Forms.ComboBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.txt_verificarcontra = new System.Windows.Forms.TextBox();
            this.lbl_correo = new System.Windows.Forms.Label();
            this.lbl_contraseña = new System.Windows.Forms.Label();
            this.lbl_verificacion = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.U = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.pNC = new System.Windows.Forms.Panel();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCA = new System.Windows.Forms.TextBox();
            this.txtNC = new System.Windows.Forms.TextBox();
            this.txtCC = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel_Editarusuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grb_Editarusuarios.SuspendLayout();
            this.pNC.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel_Editarusuarios
            // 
            this.panel_Editarusuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(229)))));
            this.panel_Editarusuarios.Controls.Add(this.lbl_Editarusuario);
            this.panel_Editarusuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Editarusuarios.Location = new System.Drawing.Point(0, 0);
            this.panel_Editarusuarios.Name = "panel_Editarusuarios";
            this.panel_Editarusuarios.Size = new System.Drawing.Size(950, 58);
            this.panel_Editarusuarios.TabIndex = 11;
            // 
            // lbl_Editarusuario
            // 
            this.lbl_Editarusuario.AutoSize = true;
            this.lbl_Editarusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Editarusuario.ForeColor = System.Drawing.Color.White;
            this.lbl_Editarusuario.Location = new System.Drawing.Point(445, 9);
            this.lbl_Editarusuario.Name = "lbl_Editarusuario";
            this.lbl_Editarusuario.Size = new System.Drawing.Size(108, 31);
            this.lbl_Editarusuario.TabIndex = 0;
            this.lbl_Editarusuario.Text = "Usuario";
            this.lbl_Editarusuario.Click += new System.EventHandler(this.lbl_Editarusuario_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(413, 70);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(176, 20);
            this.label15.TabIndex = 50;
            this.label15.Text = "Mi información personal";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(324, 90);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(337, 13);
            this.label16.TabIndex = 49;
            this.label16.Text = "_______________________________________________________";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(63, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 236);
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // grb_Editarusuarios
            // 
            this.grb_Editarusuarios.BackColor = System.Drawing.Color.White;
            this.grb_Editarusuarios.Controls.Add(this.btn_aceptar);
            this.grb_Editarusuarios.Controls.Add(this.U);
            this.grb_Editarusuarios.Controls.Add(this.label2);
            this.grb_Editarusuarios.Controls.Add(this.CN);
            this.grb_Editarusuarios.Controls.Add(this.label1);
            this.grb_Editarusuarios.Controls.Add(this.NU);
            this.grb_Editarusuarios.Controls.Add(this.AU);
            this.grb_Editarusuarios.Controls.Add(this.txt_nombre);
            this.grb_Editarusuarios.Controls.Add(this.txt_correo);
            this.grb_Editarusuarios.Controls.Add(this.txt_verificarcontra);
            this.grb_Editarusuarios.Controls.Add(this.lbl_correo);
            this.grb_Editarusuarios.Controls.Add(this.lbl_verificacion);
            this.grb_Editarusuarios.Controls.Add(this.lbl_apellido);
            this.grb_Editarusuarios.Location = new System.Drawing.Point(331, 124);
            this.grb_Editarusuarios.Name = "grb_Editarusuarios";
            this.grb_Editarusuarios.Size = new System.Drawing.Size(555, 240);
            this.grb_Editarusuarios.TabIndex = 53;
            this.grb_Editarusuarios.TabStop = false;
            this.grb_Editarusuarios.Enter += new System.EventHandler(this.grb_Editarusuarios_Enter_1);
            // 
            // CN
            // 
            this.CN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.CN.Enabled = false;
            this.CN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CN.FormattingEnabled = true;
            this.CN.Location = new System.Drawing.Point(196, 73);
            this.CN.Name = "CN";
            this.CN.Size = new System.Drawing.Size(258, 24);
            this.CN.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 52;
            this.label1.Text = "Nombre:";
            // 
            // NU
            // 
            this.NU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.NU.Enabled = false;
            this.NU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NU.FormattingEnabled = true;
            this.NU.Location = new System.Drawing.Point(196, 114);
            this.NU.Name = "NU";
            this.NU.Size = new System.Drawing.Size(258, 24);
            this.NU.TabIndex = 29;
            // 
            // AU
            // 
            this.AU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.AU.Enabled = false;
            this.AU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AU.FormattingEnabled = true;
            this.AU.Location = new System.Drawing.Point(196, 155);
            this.AU.Name = "AU";
            this.AU.Size = new System.Drawing.Size(258, 24);
            this.AU.TabIndex = 28;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(692, 43);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(201, 32);
            this.txt_nombre.TabIndex = 7;
            // 
            // txt_correo
            // 
            this.txt_correo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_correo.Location = new System.Drawing.Point(462, 243);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(201, 32);
            this.txt_correo.TabIndex = 25;
            // 
            // txt_verificarcontra
            // 
            this.txt_verificarcontra.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_verificarcontra.Location = new System.Drawing.Point(305, 240);
            this.txt_verificarcontra.Name = "txt_verificarcontra";
            this.txt_verificarcontra.Size = new System.Drawing.Size(201, 32);
            this.txt_verificarcontra.TabIndex = 10;
            // 
            // lbl_correo
            // 
            this.lbl_correo.AutoSize = true;
            this.lbl_correo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_correo.Location = new System.Drawing.Point(44, 161);
            this.lbl_correo.Name = "lbl_correo";
            this.lbl_correo.Size = new System.Drawing.Size(143, 18);
            this.lbl_correo.TabIndex = 24;
            this.lbl_correo.Text = "Correo Electrónico:";
            // 
            // lbl_contraseña
            // 
            this.lbl_contraseña.AutoSize = true;
            this.lbl_contraseña.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contraseña.Location = new System.Drawing.Point(82, 61);
            this.lbl_contraseña.Name = "lbl_contraseña";
            this.lbl_contraseña.Size = new System.Drawing.Size(138, 18);
            this.lbl_contraseña.TabIndex = 2;
            this.lbl_contraseña.Text = "Contraseña actual:";
            // 
            // lbl_verificacion
            // 
            this.lbl_verificacion.AutoSize = true;
            this.lbl_verificacion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_verificacion.Location = new System.Drawing.Point(74, 243);
            this.lbl_verificacion.Name = "lbl_verificacion";
            this.lbl_verificacion.Size = new System.Drawing.Size(151, 18);
            this.lbl_verificacion.TabIndex = 3;
            this.lbl_verificacion.Text = "Verificar Contraseña";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellido.Location = new System.Drawing.Point(44, 120);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(69, 18);
            this.lbl_apellido.TabIndex = 4;
            this.lbl_apellido.Text = "Apellido:";
            // 
            // U
            // 
            this.U.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.U.Enabled = false;
            this.U.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.U.FormattingEnabled = true;
            this.U.Location = new System.Drawing.Point(196, 37);
            this.U.Name = "U";
            this.U.Size = new System.Drawing.Size(258, 24);
            this.U.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 54;
            this.label2.Text = "Usuario";
            // 
            // btn_guardar
            // 
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar.Location = new System.Drawing.Point(534, 80);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(190, 53);
            this.btn_guardar.TabIndex = 56;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click_1);
            // 
            // pNC
            // 
            this.pNC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pNC.Controls.Add(this.txtCC);
            this.pNC.Controls.Add(this.txtNC);
            this.pNC.Controls.Add(this.txtCA);
            this.pNC.Controls.Add(this.label5);
            this.pNC.Controls.Add(this.label4);
            this.pNC.Controls.Add(this.label3);
            this.pNC.Controls.Add(this.btn_guardar);
            this.pNC.Controls.Add(this.lbl_contraseña);
            this.pNC.Location = new System.Drawing.Point(81, 402);
            this.pNC.Name = "pNC";
            this.pNC.Size = new System.Drawing.Size(805, 186);
            this.pNC.TabIndex = 57;
            this.pNC.Visible = false;
            this.pNC.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            this.btn_aceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.ForeColor = System.Drawing.Color.White;
            this.btn_aceptar.Location = new System.Drawing.Point(239, 199);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(169, 35);
            this.btn_aceptar.TabIndex = 57;
            this.btn_aceptar.Text = "Cambiar contraseña";
            this.btn_aceptar.UseVisualStyleBackColor = false;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(335, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 18);
            this.label3.TabIndex = 58;
            this.label3.Text = "Ingrese los nuevos datos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 18);
            this.label4.TabIndex = 59;
            this.label4.Text = "Nueva contraseña:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(82, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 18);
            this.label5.TabIndex = 61;
            this.label5.Text = "Confirmar contraseña:";
            // 
            // txtCA
            // 
            this.txtCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCA.Location = new System.Drawing.Point(246, 55);
            this.txtCA.Name = "txtCA";
            this.txtCA.Size = new System.Drawing.Size(211, 24);
            this.txtCA.TabIndex = 63;
            this.txtCA.Leave += new System.EventHandler(this.txtCA_Leave);
            // 
            // txtNC
            // 
            this.txtNC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNC.Location = new System.Drawing.Point(246, 95);
            this.txtNC.Name = "txtNC";
            this.txtNC.PasswordChar = '*';
            this.txtNC.Size = new System.Drawing.Size(211, 24);
            this.txtNC.TabIndex = 64;
            // 
            // txtCC
            // 
            this.txtCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCC.Location = new System.Drawing.Point(246, 134);
            this.txtCC.Name = "txtCC";
            this.txtCC.PasswordChar = '*';
            this.txtCC.Size = new System.Drawing.Size(212, 24);
            this.txtCC.TabIndex = 65;
            // 
            // frm_EditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Controls.Add(this.pNC);
            this.Controls.Add(this.grb_Editarusuarios);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.panel_Editarusuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_EditarUsuario";
            this.Text = "frm_EditarUsuario";
            this.Load += new System.EventHandler(this.frm_EditarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel_Editarusuarios.ResumeLayout(false);
            this.panel_Editarusuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grb_Editarusuarios.ResumeLayout(false);
            this.grb_Editarusuarios.PerformLayout();
            this.pNC.ResumeLayout(false);
            this.pNC.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel_Editarusuarios;
        private System.Windows.Forms.Label lbl_Editarusuario;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox grb_Editarusuarios;
        private System.Windows.Forms.ComboBox U;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox NU;
        private System.Windows.Forms.ComboBox AU;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.TextBox txt_verificarcontra;
        private System.Windows.Forms.Label lbl_correo;
        private System.Windows.Forms.Label lbl_contraseña;
        private System.Windows.Forms.Label lbl_verificacion;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pNC;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCC;
        private System.Windows.Forms.TextBox txtNC;
        private System.Windows.Forms.TextBox txtCA;
    }
}