
namespace FrmPrincipal
{
    partial class FmrLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtBUsuario = new System.Windows.Forms.TextBox();
            this.BTNEnviar = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.LBLContrasenia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBUsuario
            // 
            this.txtBUsuario.Location = new System.Drawing.Point(109, 54);
            this.txtBUsuario.Name = "txtBUsuario";
            this.txtBUsuario.Size = new System.Drawing.Size(173, 23);
            this.txtBUsuario.TabIndex = 1;
            this.txtBUsuario.TextChanged += new System.EventHandler(this.txtBUsuario_TextChanged);
            // 
            // BTNEnviar
            // 
            this.BTNEnviar.Location = new System.Drawing.Point(109, 122);
            this.BTNEnviar.Name = "BTNEnviar";
            this.BTNEnviar.Size = new System.Drawing.Size(173, 55);
            this.BTNEnviar.TabIndex = 2;
            this.BTNEnviar.Text = "Enviar";
            this.BTNEnviar.UseVisualStyleBackColor = true;
            this.BTNEnviar.Click += new System.EventHandler(this.BTNEnviar_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(297, 57);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(62, 19);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Admin";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(426, 53);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(31, 19);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // LBLContrasenia
            // 
            this.LBLContrasenia.Location = new System.Drawing.Point(0, 0);
            this.LBLContrasenia.Name = "LBLContrasenia";
            this.LBLContrasenia.Size = new System.Drawing.Size(100, 23);
            this.LBLContrasenia.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contrasenia";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(173, 23);
            this.textBox1.TabIndex = 6;
            // 
            // FmrLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(615, 265);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LBLContrasenia);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.BTNEnviar);
            this.Controls.Add(this.txtBUsuario);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Brown;
            this.Name = "FmrLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBUsuario;
        private System.Windows.Forms.Button BTNEnviar;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label LBLContrasenia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

