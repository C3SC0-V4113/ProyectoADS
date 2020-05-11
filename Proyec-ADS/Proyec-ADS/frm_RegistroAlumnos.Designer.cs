namespace Proyec_ADS
{
    partial class frm_registroAlumnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_registroAlumnos));
            this.lbl_Carnet = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_correo = new System.Windows.Forms.Label();
            this.txt_carnet = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.PanelRegistroAlumnos = new System.Windows.Forms.Panel();
            this.Ptb_Estudiante = new System.Windows.Forms.PictureBox();
            this.lbl_RegAlumnos = new System.Windows.Forms.Label();
            this.btn_registraralumno = new System.Windows.Forms.Button();
            this.grb_Registrodealumnos = new System.Windows.Forms.GroupBox();
            this.PanelRegistroAlumnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Estudiante)).BeginInit();
            this.grb_Registrodealumnos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Carnet
            // 
            this.lbl_Carnet.AutoSize = true;
            this.lbl_Carnet.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Carnet.Location = new System.Drawing.Point(260, 52);
            this.lbl_Carnet.Name = "lbl_Carnet";
            this.lbl_Carnet.Size = new System.Drawing.Size(73, 24);
            this.lbl_Carnet.TabIndex = 0;
            this.lbl_Carnet.Text = "Carnet";
            this.lbl_Carnet.Click += new System.EventHandler(this.lbl_Carnet_Click);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(260, 139);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(82, 24);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellido.Location = new System.Drawing.Point(260, 225);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(82, 24);
            this.lbl_apellido.TabIndex = 2;
            this.lbl_apellido.Text = "Apellido";
            // 
            // lbl_correo
            // 
            this.lbl_correo.AutoSize = true;
            this.lbl_correo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_correo.Location = new System.Drawing.Point(170, 318);
            this.lbl_correo.Name = "lbl_correo";
            this.lbl_correo.Size = new System.Drawing.Size(186, 24);
            this.lbl_correo.TabIndex = 3;
            this.lbl_correo.Text = "Correo Electrónico";
            // 
            // txt_carnet
            // 
            this.txt_carnet.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_carnet.Location = new System.Drawing.Point(362, 49);
            this.txt_carnet.Name = "txt_carnet";
            this.txt_carnet.Size = new System.Drawing.Size(166, 32);
            this.txt_carnet.TabIndex = 5;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(362, 136);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(178, 32);
            this.txt_nombre.TabIndex = 6;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellido.Location = new System.Drawing.Point(362, 222);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(177, 32);
            this.txt_apellido.TabIndex = 7;
            // 
            // txt_correo
            // 
            this.txt_correo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_correo.Location = new System.Drawing.Point(362, 310);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(179, 32);
            this.txt_correo.TabIndex = 8;
            // 
            // PanelRegistroAlumnos
            // 
            this.PanelRegistroAlumnos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));
            this.PanelRegistroAlumnos.Controls.Add(this.Ptb_Estudiante);
            this.PanelRegistroAlumnos.Controls.Add(this.lbl_RegAlumnos);
            this.PanelRegistroAlumnos.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelRegistroAlumnos.Location = new System.Drawing.Point(0, 0);
            this.PanelRegistroAlumnos.Name = "PanelRegistroAlumnos";
            this.PanelRegistroAlumnos.Size = new System.Drawing.Size(950, 49);
            this.PanelRegistroAlumnos.TabIndex = 11;
            // 
            // Ptb_Estudiante
            // 
            this.Ptb_Estudiante.Image = ((System.Drawing.Image)(resources.GetObject("Ptb_Estudiante.Image")));
            this.Ptb_Estudiante.Location = new System.Drawing.Point(32, 3);
            this.Ptb_Estudiante.Name = "Ptb_Estudiante";
            this.Ptb_Estudiante.Size = new System.Drawing.Size(100, 44);
            this.Ptb_Estudiante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Ptb_Estudiante.TabIndex = 1;
            this.Ptb_Estudiante.TabStop = false;
            // 
            // lbl_RegAlumnos
            // 
            this.lbl_RegAlumnos.AutoSize = true;
            this.lbl_RegAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RegAlumnos.ForeColor = System.Drawing.Color.White;
            this.lbl_RegAlumnos.Location = new System.Drawing.Point(138, 9);
            this.lbl_RegAlumnos.Name = "lbl_RegAlumnos";
            this.lbl_RegAlumnos.Size = new System.Drawing.Size(265, 31);
            this.lbl_RegAlumnos.TabIndex = 0;
            this.lbl_RegAlumnos.Text = "Registro de Alumnos";
            // 
            // btn_registraralumno
            // 
            this.btn_registraralumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registraralumno.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registraralumno.ForeColor = System.Drawing.Color.Black;
            this.btn_registraralumno.Image = ((System.Drawing.Image)(resources.GetObject("btn_registraralumno.Image")));
            this.btn_registraralumno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_registraralumno.Location = new System.Drawing.Point(416, 509);
            this.btn_registraralumno.Name = "btn_registraralumno";
            this.btn_registraralumno.Size = new System.Drawing.Size(187, 62);
            this.btn_registraralumno.TabIndex = 10;
            this.btn_registraralumno.Text = "Registrar";
            this.btn_registraralumno.UseVisualStyleBackColor = true;
            this.btn_registraralumno.Click += new System.EventHandler(this.btn_registraralumno_Click);
            // 
            // grb_Registrodealumnos
            // 
            this.grb_Registrodealumnos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grb_Registrodealumnos.Controls.Add(this.lbl_Carnet);
            this.grb_Registrodealumnos.Controls.Add(this.txt_carnet);
            this.grb_Registrodealumnos.Controls.Add(this.lbl_nombre);
            this.grb_Registrodealumnos.Controls.Add(this.txt_nombre);
            this.grb_Registrodealumnos.Controls.Add(this.txt_correo);
            this.grb_Registrodealumnos.Controls.Add(this.lbl_apellido);
            this.grb_Registrodealumnos.Controls.Add(this.txt_apellido);
            this.grb_Registrodealumnos.Controls.Add(this.lbl_correo);
            this.grb_Registrodealumnos.Location = new System.Drawing.Point(75, 96);
            this.grb_Registrodealumnos.Name = "grb_Registrodealumnos";
            this.grb_Registrodealumnos.Size = new System.Drawing.Size(807, 394);
            this.grb_Registrodealumnos.TabIndex = 12;
            this.grb_Registrodealumnos.TabStop = false;
            // 
            // frm_registroAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Controls.Add(this.grb_Registrodealumnos);
            this.Controls.Add(this.PanelRegistroAlumnos);
            this.Controls.Add(this.btn_registraralumno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_registroAlumnos";
            this.Text = "frm_RegistroAlumnos";
            this.Load += new System.EventHandler(this.frm_registroAlumnos_Load);
            this.PanelRegistroAlumnos.ResumeLayout(false);
            this.PanelRegistroAlumnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Estudiante)).EndInit();
            this.grb_Registrodealumnos.ResumeLayout(false);
            this.grb_Registrodealumnos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Carnet;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label lbl_correo;
        private System.Windows.Forms.TextBox txt_carnet;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.Panel PanelRegistroAlumnos;
        private System.Windows.Forms.Label lbl_RegAlumnos;
        private System.Windows.Forms.PictureBox Ptb_Estudiante;
        private System.Windows.Forms.Button btn_registraralumno;
        private System.Windows.Forms.GroupBox grb_Registrodealumnos;
    }
}