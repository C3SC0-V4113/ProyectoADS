namespace Proyec_ADS
{
    partial class ImportarEx
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
            this.Panel_Informes = new System.Windows.Forms.Panel();
            this.ptb_informes = new System.Windows.Forms.PictureBox();
            this.Lbl_informes = new System.Windows.Forms.Label();
            this.cb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnB = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.BtnI = new System.Windows.Forms.Button();
            this.Panel_Informes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_informes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.Panel_Informes.TabIndex = 10;
            // 
            // ptb_informes
            // 
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
            this.Lbl_informes.Location = new System.Drawing.Point(339, 9);
            this.Lbl_informes.Name = "Lbl_informes";
            this.Lbl_informes.Size = new System.Drawing.Size(292, 31);
            this.Lbl_informes.TabIndex = 0;
            this.Lbl_informes.Text = "Importar base de datos";
            // 
            // cb
            // 
            this.cb.FormattingEnabled = true;
            this.cb.Location = new System.Drawing.Point(479, 74);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(188, 21);
            this.cb.TabIndex = 11;
            this.cb.SelectedIndexChanged += new System.EventHandler(this.cb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Seleccione el archivo .xls a importar:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.btnB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cb);
            this.groupBox1.Location = new System.Drawing.Point(88, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 160);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(379, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 142);
            this.panel1.TabIndex = 15;
            // 
            // btnB
            // 
            this.btnB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(229)))));
            this.btnB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB.ForeColor = System.Drawing.Color.White;
            this.btnB.Location = new System.Drawing.Point(72, 74);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(202, 37);
            this.btnB.TabIndex = 14;
            this.btnB.Text = "Buscar en mi equipo";
            this.btnB.UseVisualStyleBackColor = false;
            this.btnB.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(463, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Seleccione la hoja de cálculo:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(88, 236);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(775, 264);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vista previa";
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView.Location = new System.Drawing.Point(11, 21);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(752, 237);
            this.dataGridView.TabIndex = 0;
            // 
            // BtnI
            // 
            this.BtnI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(229)))));
            this.BtnI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnI.ForeColor = System.Drawing.Color.White;
            this.BtnI.Location = new System.Drawing.Point(381, 518);
            this.BtnI.Name = "BtnI";
            this.BtnI.Size = new System.Drawing.Size(202, 37);
            this.BtnI.TabIndex = 16;
            this.BtnI.Text = "Importar datos";
            this.BtnI.UseVisualStyleBackColor = false;
            this.BtnI.Click += new System.EventHandler(this.BtnI_Click);
            // 
            // ImportarEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Controls.Add(this.BtnI);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Panel_Informes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ImportarEx";
            this.Text = "ImportarEx";
            this.Load += new System.EventHandler(this.ImportarEx_Load);
            this.Panel_Informes.ResumeLayout(false);
            this.Panel_Informes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_informes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Informes;
        private System.Windows.Forms.PictureBox ptb_informes;
        private System.Windows.Forms.Label Lbl_informes;
        private System.Windows.Forms.ComboBox cb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button BtnI;
    }
}