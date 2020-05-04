namespace Proyec_ADS
{
    partial class frmRecuperarContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecuperarContraseña));
            this.label1 = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.iconominimizar = new System.Windows.Forms.PictureBox();
            this.iconocerrar = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRecuperar = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.iconominimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconocerrar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 1;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(42, 209);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 13);
            this.lblMensaje.TabIndex = 3;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(0)))));
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(273, 293);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(95, 40);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Visible = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // iconominimizar
            // 
            this.iconominimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconominimizar.Image = ((System.Drawing.Image)(resources.GetObject("iconominimizar.Image")));
            this.iconominimizar.Location = new System.Drawing.Point(564, 4);
            this.iconominimizar.Name = "iconominimizar";
            this.iconominimizar.Size = new System.Drawing.Size(25, 25);
            this.iconominimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconominimizar.TabIndex = 6;
            this.iconominimizar.TabStop = false;
            this.iconominimizar.Click += new System.EventHandler(this.iconominimizar_Click);
            // 
            // iconocerrar
            // 
            this.iconocerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconocerrar.Image = ((System.Drawing.Image)(resources.GetObject("iconocerrar.Image")));
            this.iconocerrar.Location = new System.Drawing.Point(595, 4);
            this.iconocerrar.Name = "iconocerrar";
            this.iconocerrar.Size = new System.Drawing.Size(25, 25);
            this.iconocerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconocerrar.TabIndex = 5;
            this.iconocerrar.TabStop = false;
            this.iconocerrar.Click += new System.EventHandler(this.iconocerrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRecuperar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(44, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 150);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresa tu nombre de Usuario";
            // 
            // txtRecuperar
            // 
            this.txtRecuperar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecuperar.Location = new System.Drawing.Point(101, 43);
            this.txtRecuperar.Name = "txtRecuperar";
            this.txtRecuperar.Size = new System.Drawing.Size(358, 22);
            this.txtRecuperar.TabIndex = 8;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(229)))));
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(280, 209);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(88, 37);
            this.btnEnviar.TabIndex = 9;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click_1);
            // 
            // frmRecuperarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(625, 345);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.iconominimizar);
            this.Controls.Add(this.iconocerrar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblMensaje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRecuperarContraseña";
            this.Text = "Recuperar Contraseña";
            this.Load += new System.EventHandler(this.frmRecuperarContraseña_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconominimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconocerrar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.PictureBox iconominimizar;
        private System.Windows.Forms.PictureBox iconocerrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRecuperar;
        private System.Windows.Forms.Button btnEnviar;
    }
}