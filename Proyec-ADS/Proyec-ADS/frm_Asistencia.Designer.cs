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
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_materia = new System.Windows.Forms.ComboBox();
            this.dgv_asistencia = new System.Windows.Forms.DataGridView();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.btn_marcar = new System.Windows.Forms.Button();
            this.rbtn_entrada = new System.Windows.Forms.RadioButton();
            this.rbtn_salida = new System.Windows.Forms.RadioButton();
            this.panel_RegistrodeAsistencia = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_asistencia)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Location = new System.Drawing.Point(22, 96);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(78, 13);
            this.lbl_codigo.TabIndex = 0;
            this.lbl_codigo.Text = "Codigo Alumno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Materia";
            // 
            // cmb_materia
            // 
            this.cmb_materia.FormattingEnabled = true;
            this.cmb_materia.Location = new System.Drawing.Point(97, 142);
            this.cmb_materia.Name = "cmb_materia";
            this.cmb_materia.Size = new System.Drawing.Size(121, 21);
            this.cmb_materia.TabIndex = 2;
            // 
            // dgv_asistencia
            // 
            this.dgv_asistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_asistencia.Location = new System.Drawing.Point(408, 154);
            this.dgv_asistencia.Name = "dgv_asistencia";
            this.dgv_asistencia.Size = new System.Drawing.Size(428, 266);
            this.dgv_asistencia.TabIndex = 3;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(118, 93);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(100, 20);
            this.txt_codigo.TabIndex = 4;
            this.txt_codigo.TextChanged += new System.EventHandler(this.txt_codigo_TextChanged);
            // 
            // btn_marcar
            // 
            this.btn_marcar.Location = new System.Drawing.Point(542, 96);
            this.btn_marcar.Name = "btn_marcar";
            this.btn_marcar.Size = new System.Drawing.Size(75, 23);
            this.btn_marcar.TabIndex = 5;
            this.btn_marcar.Text = "Marcar";
            this.btn_marcar.UseVisualStyleBackColor = true;
            // 
            // rbtn_entrada
            // 
            this.rbtn_entrada.AutoSize = true;
            this.rbtn_entrada.Location = new System.Drawing.Point(50, 250);
            this.rbtn_entrada.Name = "rbtn_entrada";
            this.rbtn_entrada.Size = new System.Drawing.Size(62, 17);
            this.rbtn_entrada.TabIndex = 6;
            this.rbtn_entrada.TabStop = true;
            this.rbtn_entrada.Text = "Entrada";
            this.rbtn_entrada.UseVisualStyleBackColor = true;
            // 
            // rbtn_salida
            // 
            this.rbtn_salida.AutoSize = true;
            this.rbtn_salida.Location = new System.Drawing.Point(164, 250);
            this.rbtn_salida.Name = "rbtn_salida";
            this.rbtn_salida.Size = new System.Drawing.Size(54, 17);
            this.rbtn_salida.TabIndex = 7;
            this.rbtn_salida.TabStop = true;
            this.rbtn_salida.Text = "Salida";
            this.rbtn_salida.UseVisualStyleBackColor = true;
            // 
            // panel_RegistrodeAsistencia
            // 
            this.panel_RegistrodeAsistencia.Location = new System.Drawing.Point(74, 13);
            this.panel_RegistrodeAsistencia.Name = "panel_RegistrodeAsistencia";
            this.panel_RegistrodeAsistencia.Size = new System.Drawing.Size(200, 100);
            this.panel_RegistrodeAsistencia.TabIndex = 8;
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
    }
}