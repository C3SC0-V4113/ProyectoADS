﻿namespace Proyec_ADS
{
    partial class frm_EditarUsuario
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
            this.lbl_CodigoUsuario = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_contraseña = new System.Windows.Forms.Label();
            this.lbl_verificacion = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.txt_verificarcontra = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_CodigoUsuario
            // 
            this.lbl_CodigoUsuario.AutoSize = true;
            this.lbl_CodigoUsuario.Location = new System.Drawing.Point(90, 173);
            this.lbl_CodigoUsuario.Name = "lbl_CodigoUsuario";
            this.lbl_CodigoUsuario.Size = new System.Drawing.Size(79, 13);
            this.lbl_CodigoUsuario.TabIndex = 0;
            this.lbl_CodigoUsuario.Text = "Codigo Usuario";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(90, 211);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(83, 13);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.Text = "Nombre Usuario";
            // 
            // lbl_contraseña
            // 
            this.lbl_contraseña.AutoSize = true;
            this.lbl_contraseña.Location = new System.Drawing.Point(90, 306);
            this.lbl_contraseña.Name = "lbl_contraseña";
            this.lbl_contraseña.Size = new System.Drawing.Size(61, 13);
            this.lbl_contraseña.TabIndex = 2;
            this.lbl_contraseña.Text = "Contraseña";
            // 
            // lbl_verificacion
            // 
            this.lbl_verificacion.AutoSize = true;
            this.lbl_verificacion.Location = new System.Drawing.Point(90, 346);
            this.lbl_verificacion.Name = "lbl_verificacion";
            this.lbl_verificacion.Size = new System.Drawing.Size(102, 13);
            this.lbl_verificacion.TabIndex = 3;
            this.lbl_verificacion.Text = "Verificar Contraseña";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Location = new System.Drawing.Point(90, 257);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(83, 13);
            this.lbl_apellido.TabIndex = 4;
            this.lbl_apellido.Text = "Apellido Usuario";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(93, 417);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 5;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(225, 173);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(100, 20);
            this.txt_codigo.TabIndex = 6;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(225, 211);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre.TabIndex = 7;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(225, 257);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(100, 20);
            this.txt_apellido.TabIndex = 8;
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Location = new System.Drawing.Point(225, 306);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(100, 20);
            this.txt_contraseña.TabIndex = 9;
            // 
            // txt_verificarcontra
            // 
            this.txt_verificarcontra.Location = new System.Drawing.Point(225, 346);
            this.txt_verificarcontra.Name = "txt_verificarcontra";
            this.txt_verificarcontra.Size = new System.Drawing.Size(100, 20);
            this.txt_verificarcontra.TabIndex = 10;
            // 
            // frm_EditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 551);
            this.Controls.Add(this.txt_verificarcontra);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.lbl_verificacion);
            this.Controls.Add(this.lbl_contraseña);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.lbl_CodigoUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_EditarUsuario";
            this.Text = "frm_EditarUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_CodigoUsuario;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_contraseña;
        private System.Windows.Forms.Label lbl_verificacion;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.TextBox txt_verificarcontra;
    }
}