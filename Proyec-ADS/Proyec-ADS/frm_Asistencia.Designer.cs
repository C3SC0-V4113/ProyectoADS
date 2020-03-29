namespace Proyec_ADS
{
    partial class frm_Asistencia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Asistencia));
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_materia = new System.Windows.Forms.ComboBox();
            this.dgv_asistencia = new System.Windows.Forms.DataGridView();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.btn_marcar = new System.Windows.Forms.Button();
            this.rbtn_entrada = new System.Windows.Forms.RadioButton();
            this.rbtn_salida = new System.Windows.Forms.RadioButton();
            this.panel_RegistrodeAsistencia = new System.Windows.Forms.Panel();
            this.ptb_RegistrodeAsistencia = new System.Windows.Forms.PictureBox();
            this.lbl_RegistroAsistencia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_asistencia)).BeginInit();
            this.panel_RegistrodeAsistencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_RegistrodeAsistencia)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo.Location = new System.Drawing.Point(80, 87);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(176, 27);
            this.lbl_codigo.TabIndex = 0;
            this.lbl_codigo.Text = "Codigo Alumno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(447, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Materia";
            // 
            // cmb_materia
            // 
            this.cmb_materia.FormattingEnabled = true;
            this.cmb_materia.Location = new System.Drawing.Point(556, 93);
            this.cmb_materia.Name = "cmb_materia";
            this.cmb_materia.Size = new System.Drawing.Size(121, 21);
            this.cmb_materia.TabIndex = 2;
            // 
            // dgv_asistencia
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_asistencia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgv_asistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_asistencia.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgv_asistencia.Location = new System.Drawing.Point(64, 234);
            this.dgv_asistencia.Name = "dgv_asistencia";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_asistencia.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgv_asistencia.Size = new System.Drawing.Size(833, 279);
            this.dgv_asistencia.TabIndex = 3;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(262, 87);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(128, 20);
            this.txt_codigo.TabIndex = 4;
            this.txt_codigo.TabStop = false;
            this.txt_codigo.TextChanged += new System.EventHandler(this.txt_codigo_TextChanged);
            // 
            // btn_marcar
            // 
            this.btn_marcar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_marcar.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_marcar.Image = ((System.Drawing.Image)(resources.GetObject("btn_marcar.Image")));
            this.btn_marcar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_marcar.Location = new System.Drawing.Point(604, 170);
            this.btn_marcar.Name = "btn_marcar";
            this.btn_marcar.Size = new System.Drawing.Size(184, 48);
            this.btn_marcar.TabIndex = 5;
            this.btn_marcar.Text = "Marcar";
            this.btn_marcar.UseVisualStyleBackColor = true;
            // 
            // rbtn_entrada
            // 
            this.rbtn_entrada.AutoSize = true;
            this.rbtn_entrada.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_entrada.Location = new System.Drawing.Point(287, 159);
            this.rbtn_entrada.Name = "rbtn_entrada";
            this.rbtn_entrada.Size = new System.Drawing.Size(115, 31);
            this.rbtn_entrada.TabIndex = 6;
            this.rbtn_entrada.TabStop = true;
            this.rbtn_entrada.Text = "Entrada";
            this.rbtn_entrada.UseVisualStyleBackColor = true;
            // 
            // rbtn_salida
            // 
            this.rbtn_salida.AutoSize = true;
            this.rbtn_salida.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_salida.Location = new System.Drawing.Point(430, 159);
            this.rbtn_salida.Name = "rbtn_salida";
            this.rbtn_salida.Size = new System.Drawing.Size(97, 31);
            this.rbtn_salida.TabIndex = 7;
            this.rbtn_salida.TabStop = true;
            this.rbtn_salida.Text = "Salida";
            this.rbtn_salida.UseVisualStyleBackColor = true;
            // 
            // panel_RegistrodeAsistencia
            // 
            this.panel_RegistrodeAsistencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));
            this.panel_RegistrodeAsistencia.Controls.Add(this.ptb_RegistrodeAsistencia);
            this.panel_RegistrodeAsistencia.Controls.Add(this.lbl_RegistroAsistencia);
            this.panel_RegistrodeAsistencia.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_RegistrodeAsistencia.Location = new System.Drawing.Point(0, 0);
            this.panel_RegistrodeAsistencia.Name = "panel_RegistrodeAsistencia";
            this.panel_RegistrodeAsistencia.Size = new System.Drawing.Size(950, 49);
            this.panel_RegistrodeAsistencia.TabIndex = 8;
            // 
            // ptb_RegistrodeAsistencia
            // 
            this.ptb_RegistrodeAsistencia.Image = ((System.Drawing.Image)(resources.GetObject("ptb_RegistrodeAsistencia.Image")));
            this.ptb_RegistrodeAsistencia.Location = new System.Drawing.Point(64, 0);
            this.ptb_RegistrodeAsistencia.Name = "ptb_RegistrodeAsistencia";
            this.ptb_RegistrodeAsistencia.Size = new System.Drawing.Size(124, 49);
            this.ptb_RegistrodeAsistencia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_RegistrodeAsistencia.TabIndex = 1;
            this.ptb_RegistrodeAsistencia.TabStop = false;
            this.ptb_RegistrodeAsistencia.Click += new System.EventHandler(this.ptb_RegistrodeAsistencia_Click);
            // 
            // lbl_RegistroAsistencia
            // 
            this.lbl_RegistroAsistencia.AutoSize = true;
            this.lbl_RegistroAsistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RegistroAsistencia.ForeColor = System.Drawing.Color.White;
            this.lbl_RegistroAsistencia.Location = new System.Drawing.Point(208, 9);
            this.lbl_RegistroAsistencia.Name = "lbl_RegistroAsistencia";
            this.lbl_RegistroAsistencia.Size = new System.Drawing.Size(282, 31);
            this.lbl_RegistroAsistencia.TabIndex = 0;
            this.lbl_RegistroAsistencia.Text = "Registro de asistencia";
            // 
            // frm_Asistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 551);
            this.Controls.Add(this.panel_RegistrodeAsistencia);
            this.Controls.Add(this.rbtn_salida);
            this.Controls.Add(this.rbtn_entrada);
            this.Controls.Add(this.btn_marcar);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.dgv_asistencia);
            this.Controls.Add(this.cmb_materia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_codigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Asistencia";
            this.Text = "frm_Asistencia";
            this.Load += new System.EventHandler(this.frm_Asistencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_asistencia)).EndInit();
            this.panel_RegistrodeAsistencia.ResumeLayout(false);
            this.panel_RegistrodeAsistencia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_RegistrodeAsistencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_materia;
        private System.Windows.Forms.DataGridView dgv_asistencia;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Button btn_marcar;
        private System.Windows.Forms.RadioButton rbtn_entrada;
        private System.Windows.Forms.RadioButton rbtn_salida;
        private System.Windows.Forms.Panel panel_RegistrodeAsistencia;
        private System.Windows.Forms.Label lbl_RegistroAsistencia;
        private System.Windows.Forms.PictureBox ptb_RegistrodeAsistencia;
    }
}