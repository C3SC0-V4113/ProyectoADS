namespace Proyec_ADS
{
    partial class frm_login
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
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_contraseña = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.linklbl_olvido = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Location = new System.Drawing.Point(61, 136);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(43, 13);
            this.lbl_usuario.TabIndex = 0;
            this.lbl_usuario.Text = "Usuario";
            // 
            // lbl_contraseña
            // 
            this.lbl_contraseña.AutoSize = true;
            this.lbl_contraseña.Location = new System.Drawing.Point(64, 188);
            this.lbl_contraseña.Name = "lbl_contraseña";
            this.lbl_contraseña.Size = new System.Drawing.Size(61, 13);
            this.lbl_contraseña.TabIndex = 1;
            this.lbl_contraseña.Text = "Contraseña";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(150, 136);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(100, 20);
            this.txt_usuario.TabIndex = 2;
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Location = new System.Drawing.Point(150, 188);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(100, 20);
            this.txt_contraseña.TabIndex = 3;
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.Location = new System.Drawing.Point(96, 267);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(110, 33);
            this.btn_iniciar.TabIndex = 4;
            this.btn_iniciar.Text = "Iniciar Sesion";
            this.btn_iniciar.UseVisualStyleBackColor = true;
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(96, 320);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(110, 39);
            this.btn_salir.TabIndex = 5;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            // 
            // linklbl_olvido
            // 
            this.linklbl_olvido.AutoSize = true;
            this.linklbl_olvido.Location = new System.Drawing.Point(90, 251);
            this.linklbl_olvido.Name = "linklbl_olvido";
            this.linklbl_olvido.Size = new System.Drawing.Size(131, 13);
            this.linklbl_olvido.TabIndex = 6;
            this.linklbl_olvido.TabStop = true;
            this.linklbl_olvido.Text = "¿Olvidaste tu contraseña?";
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 411);
            this.Controls.Add(this.linklbl_olvido);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_iniciar);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.lbl_contraseña);
            this.Controls.Add(this.lbl_usuario);
            this.Name = "frm_login";
            this.Text = "frm_login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label lbl_contraseña;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.LinkLabel linklbl_olvido;
    }
}