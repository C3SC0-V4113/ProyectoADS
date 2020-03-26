namespace Proyec_ADS
{
    partial class frm_Informes
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
            this.lbl_fechainicial = new System.Windows.Forms.Label();
            this.lbl_fechafinal = new System.Windows.Forms.Label();
            this.lbl_clase = new System.Windows.Forms.Label();
            this.dtp_fechainicial = new System.Windows.Forms.DateTimePicker();
            this.dtp_fechafinal = new System.Windows.Forms.DateTimePicker();
            this.cmb_clase = new System.Windows.Forms.ComboBox();
            this.dgv_informes = new System.Windows.Forms.DataGridView();
            this.dgv_detalleasistencia = new System.Windows.Forms.DataGridView();
            this.btn_buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_informes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalleasistencia)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_fechainicial
            // 
            this.lbl_fechainicial.AutoSize = true;
            this.lbl_fechainicial.Location = new System.Drawing.Point(49, 48);
            this.lbl_fechainicial.Name = "lbl_fechainicial";
            this.lbl_fechainicial.Size = new System.Drawing.Size(67, 13);
            this.lbl_fechainicial.TabIndex = 0;
            this.lbl_fechainicial.Text = "Fecha Inicial";
            // 
            // lbl_fechafinal
            // 
            this.lbl_fechafinal.AutoSize = true;
            this.lbl_fechafinal.Location = new System.Drawing.Point(350, 48);
            this.lbl_fechafinal.Name = "lbl_fechafinal";
            this.lbl_fechafinal.Size = new System.Drawing.Size(62, 13);
            this.lbl_fechafinal.TabIndex = 1;
            this.lbl_fechafinal.Text = "Fecha Final";
            // 
            // lbl_clase
            // 
            this.lbl_clase.AutoSize = true;
            this.lbl_clase.Location = new System.Drawing.Point(642, 47);
            this.lbl_clase.Name = "lbl_clase";
            this.lbl_clase.Size = new System.Drawing.Size(33, 13);
            this.lbl_clase.TabIndex = 2;
            this.lbl_clase.Text = "Clase";
            // 
            // dtp_fechainicial
            // 
            this.dtp_fechainicial.Location = new System.Drawing.Point(123, 47);
            this.dtp_fechainicial.Name = "dtp_fechainicial";
            this.dtp_fechainicial.Size = new System.Drawing.Size(200, 20);
            this.dtp_fechainicial.TabIndex = 3;
            // 
            // dtp_fechafinal
            // 
            this.dtp_fechafinal.Location = new System.Drawing.Point(419, 47);
            this.dtp_fechafinal.Name = "dtp_fechafinal";
            this.dtp_fechafinal.Size = new System.Drawing.Size(200, 20);
            this.dtp_fechafinal.TabIndex = 4;
            // 
            // cmb_clase
            // 
            this.cmb_clase.FormattingEnabled = true;
            this.cmb_clase.Location = new System.Drawing.Point(697, 47);
            this.cmb_clase.Name = "cmb_clase";
            this.cmb_clase.Size = new System.Drawing.Size(121, 21);
            this.cmb_clase.TabIndex = 5;
            // 
            // dgv_informes
            // 
            this.dgv_informes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_informes.Location = new System.Drawing.Point(130, 190);
            this.dgv_informes.Name = "dgv_informes";
            this.dgv_informes.Size = new System.Drawing.Size(295, 236);
            this.dgv_informes.TabIndex = 6;
            // 
            // dgv_detalleasistencia
            // 
            this.dgv_detalleasistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detalleasistencia.Location = new System.Drawing.Point(508, 190);
            this.dgv_detalleasistencia.Name = "dgv_detalleasistencia";
            this.dgv_detalleasistencia.Size = new System.Drawing.Size(282, 236);
            this.dgv_detalleasistencia.TabIndex = 7;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(697, 92);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 8;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // frm_Informes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 551);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.dgv_detalleasistencia);
            this.Controls.Add(this.dgv_informes);
            this.Controls.Add(this.cmb_clase);
            this.Controls.Add(this.dtp_fechafinal);
            this.Controls.Add(this.dtp_fechainicial);
            this.Controls.Add(this.lbl_clase);
            this.Controls.Add(this.lbl_fechafinal);
            this.Controls.Add(this.lbl_fechainicial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Informes";
            this.Text = "frm_Informes";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_informes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalleasistencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_fechainicial;
        private System.Windows.Forms.Label lbl_fechafinal;
        private System.Windows.Forms.Label lbl_clase;
        private System.Windows.Forms.DateTimePicker dtp_fechainicial;
        private System.Windows.Forms.DateTimePicker dtp_fechafinal;
        private System.Windows.Forms.ComboBox cmb_clase;
        private System.Windows.Forms.DataGridView dgv_informes;
        private System.Windows.Forms.DataGridView dgv_detalleasistencia;
        private System.Windows.Forms.Button btn_buscar;
    }
}