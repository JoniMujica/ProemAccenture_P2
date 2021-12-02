
namespace EJ1
{
    partial class Modal
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
            this.txtTitulo1 = new System.Windows.Forms.Label();
            this.txtTitulo2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTitulo1
            // 
            this.txtTitulo1.AutoSize = true;
            this.txtTitulo1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txtTitulo1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTitulo1.Location = new System.Drawing.Point(190, 72);
            this.txtTitulo1.Name = "txtTitulo1";
            this.txtTitulo1.Size = new System.Drawing.Size(17, 25);
            this.txtTitulo1.TabIndex = 0;
            this.txtTitulo1.Text = " ";
            this.txtTitulo1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTitulo2
            // 
            this.txtTitulo2.AutoSize = true;
            this.txtTitulo2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTitulo2.Location = new System.Drawing.Point(190, 136);
            this.txtTitulo2.Name = "txtTitulo2";
            this.txtTitulo2.Size = new System.Drawing.Size(0, 21);
            this.txtTitulo2.TabIndex = 1;
            this.txtTitulo2.Click += new System.EventHandler(this.txtTitulo2_Click);
            // 
            // Modal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 256);
            this.Controls.Add(this.txtTitulo2);
            this.Controls.Add(this.txtTitulo1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Modal";
            this.Text = "Modal";
            this.Load += new System.EventHandler(this.Modal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtTitulo1;
        private System.Windows.Forms.Label txtTitulo2;
    }
}