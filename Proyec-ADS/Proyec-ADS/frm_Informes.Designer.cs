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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Informes));
            this.lbl_fechainicial = new System.Windows.Forms.Label();
            this.lbl_fechafinal = new System.Windows.Forms.Label();
            this.lbl_clase = new System.Windows.Forms.Label();
            this.dtp_fechainicial = new System.Windows.Forms.DateTimePicker();
            this.dtp_fechafinal = new System.Windows.Forms.DateTimePicker();
            this.cmb_clase = new System.Windows.Forms.ComboBox();
            this.dgv_informes = new System.Windows.Forms.DataGridView();
            this.dgv_detalleasistencia = new System.Windows.Forms.DataGridView();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.Panel_Informes = new System.Windows.Forms.Panel();
            this.ptb_informes = new System.Windows.Forms.PictureBox();
            this.Lbl_informes = new System.Windows.Forms.Label();
            this.slp_contenedor = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_informes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalleasistencia)).BeginInit();
            this.Panel_Informes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_informes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slp_contenedor)).BeginInit();
            this.slp_contenedor.Panel1.SuspendLayout();
            this.slp_contenedor.Panel2.SuspendLayout();
            this.slp_contenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_fechainicial
            // 
            this.lbl_fechainicial.AutoSize = true;
            this.lbl_fechainicial.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fechainicial.Location = new System.Drawing.Point(12, 82);
            this.lbl_fechainicial.Name = "lbl_fechainicial";
            this.lbl_fechainicial.Size = new System.Drawing.Size(129, 24);
            this.lbl_fechainicial.TabIndex = 0;
            this.lbl_fechainicial.Text = "Fecha Inicial";
            // 
            // lbl_fechafinal
            // 
            this.lbl_fechafinal.AutoSize = true;
            this.lbl_fechafinal.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fechafinal.Location = new System.Drawing.Point(12, 147);
            this.lbl_fechafinal.Name = "lbl_fechafinal";
            this.lbl_fechafinal.Size = new System.Drawing.Size(120, 24);
            this.lbl_fechafinal.TabIndex = 1;
            this.lbl_fechafinal.Text = "Fecha Final";
            // 
            // lbl_clase
            // 
            this.lbl_clase.AutoSize = true;
            this.lbl_clase.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_clase.Location = new System.Drawing.Point(577, 82);
            this.lbl_clase.Name = "lbl_clase";
            this.lbl_clase.Size = new System.Drawing.Size(64, 24);
            this.lbl_clase.TabIndex = 2;
            this.lbl_clase.Text = "Clase";
            // 
            // dtp_fechainicial
            // 
            this.dtp_fechainicial.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fechainicial.Location = new System.Drawing.Point(147, 79);
            this.dtp_fechainicial.Name = "dtp_fechainicial";
            this.dtp_fechainicial.Size = new System.Drawing.Size(379, 32);
            this.dtp_fechainicial.TabIndex = 3;
            // 
            // dtp_fechafinal
            // 
            this.dtp_fechafinal.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fechafinal.Location = new System.Drawing.Point(147, 141);
            this.dtp_fechafinal.Name = "dtp_fechafinal";
            this.dtp_fechafinal.Size = new System.Drawing.Size(379, 32);
            this.dtp_fechafinal.TabIndex = 4;
            // 
            // cmb_clase
            // 
            this.cmb_clase.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_clase.FormattingEnabled = true;
            this.cmb_clase.Location = new System.Drawing.Point(667, 79);
            this.cmb_clase.Name = "cmb_clase";
            this.cmb_clase.Size = new System.Drawing.Size(201, 32);
            this.cmb_clase.TabIndex = 5;
            // 
            // dgv_informes
            // 
            this.dgv_informes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_informes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_informes.Location = new System.Drawing.Point(0, 0);
            this.dgv_informes.Name = "dgv_informes";
            this.dgv_informes.Size = new System.Drawing.Size(482, 356);
            this.dgv_informes.TabIndex = 6;
            // 
            // dgv_detalleasistencia
            // 
            this.dgv_detalleasistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detalleasistencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_detalleasistencia.Location = new System.Drawing.Point(0, 0);
            this.dgv_detalleasistencia.Name = "dgv_detalleasistencia";
            this.dgv_detalleasistencia.Size = new System.Drawing.Size(464, 356);
            this.dgv_detalleasistencia.TabIndex = 7;
            // 
            // btn_buscar
            // 
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buscar.Location = new System.Drawing.Point(667, 139);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(169, 40);
            this.btn_buscar.TabIndex = 8;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // Panel_Informes
            // 
            this.Panel_Informes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));
            this.Panel_Informes.Controls.Add(this.ptb_informes);
            this.Panel_Informes.Controls.Add(this.Lbl_informes);
            this.Panel_Informes.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Informes.Location = new System.Drawing.Point(0, 0);
            this.Panel_Informes.Name = "Panel_Informes";
            this.Panel_Informes.Size = new System.Drawing.Size(950, 49);
            this.Panel_Informes.TabIndex = 9;
            // 
            // ptb_informes
            // 
            this.ptb_informes.Image = ((System.Drawing.Image)(resources.GetObject("ptb_informes.Image")));
            this.ptb_informes.Location = new System.Drawing.Point(71, 0);
            this.ptb_informes.Name = "ptb_informes";
            this.ptb_informes.Size = new System.Drawing.Size(124, 49);
            this.ptb_informes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_informes.TabIndex = 1;
            this.ptb_informes.TabStop = false;
            // 
            // Lbl_informes
            // 
            this.Lbl_informes.AutoSize = true;
            this.Lbl_informes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_informes.ForeColor = System.Drawing.Color.White;
            this.Lbl_informes.Location = new System.Drawing.Point(213, 9);
            this.Lbl_informes.Name = "Lbl_informes";
            this.Lbl_informes.Size = new System.Drawing.Size(120, 31);
            this.Lbl_informes.TabIndex = 0;
            this.Lbl_informes.Text = "Informes";
            // 
            // slp_contenedor
            // 
            this.slp_contenedor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.slp_contenedor.Location = new System.Drawing.Point(0, 244);
            this.slp_contenedor.Name = "slp_contenedor";
            // 
            // slp_contenedor.Panel1
            // 
            this.slp_contenedor.Panel1.Controls.Add(this.dgv_informes);
            // 
            // slp_contenedor.Panel2
            // 
            this.slp_contenedor.Panel2.Controls.Add(this.dgv_detalleasistencia);
            this.slp_contenedor.Size = new System.Drawing.Size(950, 356);
            this.slp_contenedor.SplitterDistance = 482;
            this.slp_contenedor.TabIndex = 10;
            // 
            // frm_Informes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Controls.Add(this.slp_contenedor);
            this.Controls.Add(this.Panel_Informes);
            this.Controls.Add(this.btn_buscar);
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
            this.Panel_Informes.ResumeLayout(false);
            this.Panel_Informes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_informes)).EndInit();
            this.slp_contenedor.Panel1.ResumeLayout(false);
            this.slp_contenedor.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.slp_contenedor)).EndInit();
            this.slp_contenedor.ResumeLayout(false);
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
        private System.Windows.Forms.Panel Panel_Informes;
        private System.Windows.Forms.Label Lbl_informes;
        private System.Windows.Forms.PictureBox ptb_informes;
        private System.Windows.Forms.SplitContainer slp_contenedor;
    }
}