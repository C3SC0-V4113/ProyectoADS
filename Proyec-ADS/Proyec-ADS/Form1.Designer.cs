namespace Proyec_ADS
{
    partial class frm_menu
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_menu));
            this.panel_menulateral = new System.Windows.Forms.Panel();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_acercade = new System.Windows.Forms.Button();
            this.panel_asistencia = new System.Windows.Forms.Panel();
            this.btn_regasistencia = new System.Windows.Forms.Button();
            this.btn_tomarasistencia = new System.Windows.Forms.Button();
            this.btn_asistencia = new System.Windows.Forms.Button();
            this.panel_estudiantes = new System.Windows.Forms.Panel();
            this.btn_consulta = new System.Windows.Forms.Button();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.btn_estudiantes = new System.Windows.Forms.Button();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.picbx_usuario = new System.Windows.Forms.PictureBox();
            this.label_hora = new System.Windows.Forms.Label();
            this.label_fecha = new System.Windows.Forms.Label();
            this.fecha_hora = new System.Windows.Forms.Timer(this.components);
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.menuprincipal = new System.Windows.Forms.Label();
            this.iconominimizar = new System.Windows.Forms.PictureBox();
            this.iconocerrar = new System.Windows.Forms.PictureBox();
            this.panel_menulateral.SuspendLayout();
            this.panel_asistencia.SuspendLayout();
            this.panel_estudiantes.SuspendLayout();
            this.panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_usuario)).BeginInit();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconominimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconocerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_menulateral
            // 
            this.panel_menulateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.panel_menulateral.Controls.Add(this.btn_salir);
            this.panel_menulateral.Controls.Add(this.btn_acercade);
            this.panel_menulateral.Controls.Add(this.panel_asistencia);
            this.panel_menulateral.Controls.Add(this.btn_asistencia);
            this.panel_menulateral.Controls.Add(this.panel_estudiantes);
            this.panel_menulateral.Controls.Add(this.btn_estudiantes);
            this.panel_menulateral.Controls.Add(this.panel_logo);
            this.panel_menulateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menulateral.Location = new System.Drawing.Point(0, 0);
            this.panel_menulateral.Name = "panel_menulateral";
            this.panel_menulateral.Size = new System.Drawing.Size(250, 600);
            this.panel_menulateral.TabIndex = 0;
            // 
            // btn_salir
            // 
            this.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_salir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_salir.FlatAppearance.BorderSize = 0;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.ForeColor = System.Drawing.Color.White;
            this.btn_salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_salir.Image")));
            this.btn_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_salir.Location = new System.Drawing.Point(0, 546);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(250, 54);
            this.btn_salir.TabIndex = 6;
            this.btn_salir.Text = "LogOut";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_acercade
            // 
            this.btn_acercade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_acercade.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_acercade.FlatAppearance.BorderSize = 0;
            this.btn_acercade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_acercade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_acercade.ForeColor = System.Drawing.Color.White;
            this.btn_acercade.Image = ((System.Drawing.Image)(resources.GetObject("btn_acercade.Image")));
            this.btn_acercade.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_acercade.Location = new System.Drawing.Point(0, 387);
            this.btn_acercade.Name = "btn_acercade";
            this.btn_acercade.Size = new System.Drawing.Size(250, 40);
            this.btn_acercade.TabIndex = 5;
            this.btn_acercade.Text = "Acerca de";
            this.btn_acercade.UseVisualStyleBackColor = true;
            this.btn_acercade.Click += new System.EventHandler(this.btn_acercade_Click);
            // 
            // panel_asistencia
            // 
            this.panel_asistencia.Controls.Add(this.btn_regasistencia);
            this.panel_asistencia.Controls.Add(this.btn_tomarasistencia);
            this.panel_asistencia.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_asistencia.Location = new System.Drawing.Point(0, 301);
            this.panel_asistencia.Name = "panel_asistencia";
            this.panel_asistencia.Size = new System.Drawing.Size(250, 86);
            this.panel_asistencia.TabIndex = 4;
            this.panel_asistencia.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_regasistencia
            // 
            this.btn_regasistencia.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_regasistencia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_regasistencia.FlatAppearance.BorderSize = 0;
            this.btn_regasistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_regasistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_regasistencia.ForeColor = System.Drawing.Color.White;
            this.btn_regasistencia.Location = new System.Drawing.Point(0, 40);
            this.btn_regasistencia.Name = "btn_regasistencia";
            this.btn_regasistencia.Size = new System.Drawing.Size(250, 40);
            this.btn_regasistencia.TabIndex = 1;
            this.btn_regasistencia.Text = "Registro de asistencia";
            this.btn_regasistencia.UseVisualStyleBackColor = false;
            this.btn_regasistencia.Click += new System.EventHandler(this.btn_regasistencia_Click);
            // 
            // btn_tomarasistencia
            // 
            this.btn_tomarasistencia.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_tomarasistencia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_tomarasistencia.FlatAppearance.BorderSize = 0;
            this.btn_tomarasistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tomarasistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tomarasistencia.ForeColor = System.Drawing.Color.White;
            this.btn_tomarasistencia.Location = new System.Drawing.Point(0, 0);
            this.btn_tomarasistencia.Name = "btn_tomarasistencia";
            this.btn_tomarasistencia.Size = new System.Drawing.Size(250, 40);
            this.btn_tomarasistencia.TabIndex = 0;
            this.btn_tomarasistencia.Text = "Tomar Asistencia";
            this.btn_tomarasistencia.UseVisualStyleBackColor = false;
            this.btn_tomarasistencia.Click += new System.EventHandler(this.btn_tomarasistencia_Click);
            // 
            // btn_asistencia
            // 
            this.btn_asistencia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_asistencia.FlatAppearance.BorderSize = 0;
            this.btn_asistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_asistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_asistencia.ForeColor = System.Drawing.Color.White;
            this.btn_asistencia.Image = ((System.Drawing.Image)(resources.GetObject("btn_asistencia.Image")));
            this.btn_asistencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_asistencia.Location = new System.Drawing.Point(0, 256);
            this.btn_asistencia.Name = "btn_asistencia";
            this.btn_asistencia.Size = new System.Drawing.Size(250, 45);
            this.btn_asistencia.TabIndex = 3;
            this.btn_asistencia.Text = "Asistencia";
            this.btn_asistencia.UseVisualStyleBackColor = true;
            this.btn_asistencia.Click += new System.EventHandler(this.btn_asistencia_Click);
            // 
            // panel_estudiantes
            // 
            this.panel_estudiantes.Controls.Add(this.btn_consulta);
            this.panel_estudiantes.Controls.Add(this.btn_registrar);
            this.panel_estudiantes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_estudiantes.Location = new System.Drawing.Point(0, 172);
            this.panel_estudiantes.Name = "panel_estudiantes";
            this.panel_estudiantes.Size = new System.Drawing.Size(250, 84);
            this.panel_estudiantes.TabIndex = 2;
            // 
            // btn_consulta
            // 
            this.btn_consulta.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_consulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_consulta.FlatAppearance.BorderSize = 0;
            this.btn_consulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consulta.ForeColor = System.Drawing.Color.White;
            this.btn_consulta.Location = new System.Drawing.Point(0, 40);
            this.btn_consulta.Name = "btn_consulta";
            this.btn_consulta.Size = new System.Drawing.Size(250, 40);
            this.btn_consulta.TabIndex = 1;
            this.btn_consulta.Text = "Consultar estudiante";
            this.btn_consulta.UseVisualStyleBackColor = false;
            this.btn_consulta.Click += new System.EventHandler(this.btn_consulta_Click);
            // 
            // btn_registrar
            // 
            this.btn_registrar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_registrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_registrar.FlatAppearance.BorderSize = 0;
            this.btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar.ForeColor = System.Drawing.Color.White;
            this.btn_registrar.Location = new System.Drawing.Point(0, 0);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(250, 40);
            this.btn_registrar.TabIndex = 0;
            this.btn_registrar.Text = "Registrar nuevo alumno";
            this.btn_registrar.UseVisualStyleBackColor = false;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // btn_estudiantes
            // 
            this.btn_estudiantes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_estudiantes.FlatAppearance.BorderSize = 0;
            this.btn_estudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_estudiantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_estudiantes.ForeColor = System.Drawing.Color.White;
            this.btn_estudiantes.Image = ((System.Drawing.Image)(resources.GetObject("btn_estudiantes.Image")));
            this.btn_estudiantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_estudiantes.Location = new System.Drawing.Point(0, 127);
            this.btn_estudiantes.Name = "btn_estudiantes";
            this.btn_estudiantes.Size = new System.Drawing.Size(250, 45);
            this.btn_estudiantes.TabIndex = 1;
            this.btn_estudiantes.Text = "Estudiantes";
            this.btn_estudiantes.UseVisualStyleBackColor = true;
            this.btn_estudiantes.Click += new System.EventHandler(this.btn_estudiantes_Click);
            // 
            // panel_logo
            // 
            this.panel_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.panel_logo.Controls.Add(this.lblemail);
            this.panel_logo.Controls.Add(this.lblnombre);
            this.panel_logo.Controls.Add(this.picbx_usuario);
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(250, 127);
            this.panel_logo.TabIndex = 0;
            this.panel_logo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_logo_Paint);
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.ForeColor = System.Drawing.Color.White;
            this.lblemail.Location = new System.Drawing.Point(138, 68);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(42, 16);
            this.lblemail.TabIndex = 4;
            this.lblemail.Text = "Email";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.ForeColor = System.Drawing.Color.White;
            this.lblnombre.Location = new System.Drawing.Point(138, 33);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(57, 16);
            this.lblnombre.TabIndex = 3;
            this.lblnombre.Text = "Nombre";
            // 
            // picbx_usuario
            // 
            this.picbx_usuario.Image = ((System.Drawing.Image)(resources.GetObject("picbx_usuario.Image")));
            this.picbx_usuario.Location = new System.Drawing.Point(12, 3);
            this.picbx_usuario.Name = "picbx_usuario";
            this.picbx_usuario.Size = new System.Drawing.Size(100, 106);
            this.picbx_usuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbx_usuario.TabIndex = 1;
            this.picbx_usuario.TabStop = false;
            // 
            // label_hora
            // 
            this.label_hora.AutoSize = true;
            this.label_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hora.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label_hora.Location = new System.Drawing.Point(564, 408);
            this.label_hora.Name = "label_hora";
            this.label_hora.Size = new System.Drawing.Size(109, 39);
            this.label_hora.TabIndex = 1;
            this.label_hora.Text = "label1";
            // 
            // label_fecha
            // 
            this.label_fecha.AutoSize = true;
            this.label_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fecha.ForeColor = System.Drawing.Color.Gray;
            this.label_fecha.Location = new System.Drawing.Point(465, 468);
            this.label_fecha.Name = "label_fecha";
            this.label_fecha.Size = new System.Drawing.Size(102, 37);
            this.label_fecha.TabIndex = 2;
            this.label_fecha.Text = "label2";
            // 
            // fecha_hora
            // 
            this.fecha_hora.Enabled = true;
            this.fecha_hora.Tick += new System.EventHandler(this.fecha_hora_Tick);
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BarraTitulo.Controls.Add(this.menuprincipal);
            this.BarraTitulo.Controls.Add(this.iconominimizar);
            this.BarraTitulo.Controls.Add(this.iconocerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(250, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(950, 49);
            this.BarraTitulo.TabIndex = 3;
            // 
            // menuprincipal
            // 
            this.menuprincipal.AutoSize = true;
            this.menuprincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuprincipal.Location = new System.Drawing.Point(60, 9);
            this.menuprincipal.Name = "menuprincipal";
            this.menuprincipal.Size = new System.Drawing.Size(136, 24);
            this.menuprincipal.TabIndex = 4;
            this.menuprincipal.Text = "Menú Principal";
            
            // 
            // iconominimizar
            // 
            this.iconominimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconominimizar.Image = ((System.Drawing.Image)(resources.GetObject("iconominimizar.Image")));
            this.iconominimizar.Location = new System.Drawing.Point(882, 3);
            this.iconominimizar.Name = "iconominimizar";
            this.iconominimizar.Size = new System.Drawing.Size(25, 25);
            this.iconominimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconominimizar.TabIndex = 3;
            this.iconominimizar.TabStop = false;
            this.iconominimizar.Click += new System.EventHandler(this.iconominimizar_Click);
            // 
            // iconocerrar
            // 
            this.iconocerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconocerrar.Image = ((System.Drawing.Image)(resources.GetObject("iconocerrar.Image")));
            this.iconocerrar.Location = new System.Drawing.Point(913, 3);
            this.iconocerrar.Name = "iconocerrar";
            this.iconocerrar.Size = new System.Drawing.Size(25, 25);
            this.iconocerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconocerrar.TabIndex = 0;
            this.iconocerrar.TabStop = false;
            this.iconocerrar.Click += new System.EventHandler(this.iconocerrar_Click);
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.label_fecha);
            this.Controls.Add(this.label_hora);
            this.Controls.Add(this.panel_menulateral);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "frm_menu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_menulateral.ResumeLayout(false);
            this.panel_asistencia.ResumeLayout(false);
            this.panel_estudiantes.ResumeLayout(false);
            this.panel_logo.ResumeLayout(false);
            this.panel_logo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_usuario)).EndInit();
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconominimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconocerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_menulateral;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.PictureBox picbx_usuario;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Panel panel_estudiantes;
        private System.Windows.Forms.Button btn_consulta;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.Button btn_estudiantes;
        private System.Windows.Forms.Button btn_asistencia;
        private System.Windows.Forms.Panel panel_asistencia;
        private System.Windows.Forms.Button btn_regasistencia;
        private System.Windows.Forms.Button btn_tomarasistencia;
        private System.Windows.Forms.Label label_hora;
        private System.Windows.Forms.Label label_fecha;
        private System.Windows.Forms.Timer fecha_hora;
        private System.Windows.Forms.Button btn_acercade;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Label menuprincipal;
        private System.Windows.Forms.PictureBox iconominimizar;
        private System.Windows.Forms.PictureBox iconocerrar;
    }
}

