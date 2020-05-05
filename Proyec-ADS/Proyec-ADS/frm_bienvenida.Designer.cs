namespace Proyec_ADS
{
    partial class frm_bienvenida
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
            this.menuprincipal = new System.Windows.Forms.Label();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.label_fecha = new System.Windows.Forms.Label();
            this.label_hora = new System.Windows.Forms.Label();
            this.fecha_hora = new System.Windows.Forms.Timer(this.components);
            this.BarraTitulo.SuspendLayout();
            this.SuspendLayout();
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
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(229)))));
            this.BarraTitulo.Controls.Add(this.menuprincipal);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(950, 49);
            this.BarraTitulo.TabIndex = 4;
            // 
            // label_fecha
            // 
            this.label_fecha.AutoSize = true;
            this.label_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fecha.ForeColor = System.Drawing.Color.Gray;
            this.label_fecha.Location = new System.Drawing.Point(401, 335);
            this.label_fecha.Name = "label_fecha";
            this.label_fecha.Size = new System.Drawing.Size(102, 37);
            this.label_fecha.TabIndex = 6;
            this.label_fecha.Text = "label2";
            // 
            // label_hora
            // 
            this.label_hora.AutoSize = true;
            this.label_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hora.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label_hora.Location = new System.Drawing.Point(500, 275);
            this.label_hora.Name = "label_hora";
            this.label_hora.Size = new System.Drawing.Size(109, 39);
            this.label_hora.TabIndex = 5;
            this.label_hora.Text = "label1";
            // 
            // fecha_hora
            // 
            this.fecha_hora.Enabled = true;
            this.fecha_hora.Tick += new System.EventHandler(this.fecha_hora_Tick);
            // 
            // frm_bienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Controls.Add(this.label_fecha);
            this.Controls.Add(this.label_hora);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_bienvenida";
            this.Text = "frm_bienvenida";
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label menuprincipal;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Label label_fecha;
        private System.Windows.Forms.Label label_hora;
        private System.Windows.Forms.Timer fecha_hora;
    }
}