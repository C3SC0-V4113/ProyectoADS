﻿namespace Proyec_ADS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Asistencia));
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_materia = new System.Windows.Forms.ComboBox();
            this.dgv_asistencia = new System.Windows.Forms.DataGridView();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.btn_marcar = new System.Windows.Forms.Button();
            this.panel_RegistrodeAsistencia = new System.Windows.Forms.Panel();
            this.ptb_RegistrodeAsistencia = new System.Windows.Forms.PictureBox();
            this.lbl_RegistroAsistencia = new System.Windows.Forms.Label();
            this.btn_NuevaClase = new System.Windows.Forms.Button();
            this.dgv_invisible = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_asistencia)).BeginInit();
            this.panel_RegistrodeAsistencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_RegistrodeAsistencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_invisible)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo.Location = new System.Drawing.Point(70, 89);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(148, 24);
            this.lbl_codigo.TabIndex = 0;
            this.lbl_codigo.Text = "Codigo Alumno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Materia";
            // 
            // cmb_materia
            // 
            this.cmb_materia.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_materia.FormattingEnabled = true;
            this.cmb_materia.Location = new System.Drawing.Point(157, 159);
            this.cmb_materia.Name = "cmb_materia";
            this.cmb_materia.Size = new System.Drawing.Size(336, 32);
            this.cmb_materia.TabIndex = 2;
            // 
            // dgv_asistencia
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_asistencia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_asistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_asistencia.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_asistencia.Location = new System.Drawing.Point(74, 214);
            this.dgv_asistencia.Name = "dgv_asistencia";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_asistencia.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_asistencia.Size = new System.Drawing.Size(802, 331);
            this.dgv_asistencia.TabIndex = 3;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo.Location = new System.Drawing.Point(224, 86);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(269, 32);
            this.txt_codigo.TabIndex = 4;
            this.txt_codigo.TabStop = false;
            // 
            // btn_marcar
            // 
            this.btn_marcar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_marcar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_marcar.Image = ((System.Drawing.Image)(resources.GetObject("btn_marcar.Image")));
            this.btn_marcar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_marcar.Location = new System.Drawing.Point(634, 150);
            this.btn_marcar.Name = "btn_marcar";
            this.btn_marcar.Size = new System.Drawing.Size(242, 48);
            this.btn_marcar.TabIndex = 5;
            this.btn_marcar.Text = "Marcar";
            this.btn_marcar.UseVisualStyleBackColor = true;
            this.btn_marcar.Click += new System.EventHandler(this.btn_marcar_Click);
            // 
            // panel_RegistrodeAsistencia
            // 
            this.panel_RegistrodeAsistencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(229)))));
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
            // btn_NuevaClase
            // 
            this.btn_NuevaClase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NuevaClase.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NuevaClase.Image = ((System.Drawing.Image)(resources.GetObject("btn_NuevaClase.Image")));
            this.btn_NuevaClase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NuevaClase.Location = new System.Drawing.Point(634, 77);
            this.btn_NuevaClase.Name = "btn_NuevaClase";
            this.btn_NuevaClase.Size = new System.Drawing.Size(242, 48);
            this.btn_NuevaClase.TabIndex = 9;
            this.btn_NuevaClase.Text = "Nueva Sesión";
            this.btn_NuevaClase.UseVisualStyleBackColor = true;
            this.btn_NuevaClase.Click += new System.EventHandler(this.btn_NuevaClase_Click);
            // 
            // dgv_invisible
            // 
            this.dgv_invisible.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_invisible.Location = new System.Drawing.Point(-35, 277);
            this.dgv_invisible.Name = "dgv_invisible";
            this.dgv_invisible.Size = new System.Drawing.Size(240, 150);
            this.dgv_invisible.TabIndex = 10;
            // 
            // frm_Asistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Controls.Add(this.dgv_invisible);
            this.Controls.Add(this.btn_NuevaClase);
            this.Controls.Add(this.panel_RegistrodeAsistencia);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_invisible)).EndInit();
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
        private System.Windows.Forms.Panel panel_RegistrodeAsistencia;
        private System.Windows.Forms.Label lbl_RegistroAsistencia;
        private System.Windows.Forms.PictureBox ptb_RegistrodeAsistencia;
        private System.Windows.Forms.Button btn_NuevaClase;
        private System.Windows.Forms.DataGridView dgv_invisible;
    }
}