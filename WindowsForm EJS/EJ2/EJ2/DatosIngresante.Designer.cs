
namespace EJ2
{
    partial class DatosIngresante
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
            this.LBLDatos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBLDatos
            // 
            this.LBLDatos.AutoSize = true;
            this.LBLDatos.Location = new System.Drawing.Point(100, 54);
            this.LBLDatos.Name = "LBLDatos";
            this.LBLDatos.Size = new System.Drawing.Size(0, 15);
            this.LBLDatos.TabIndex = 0;
            this.LBLDatos.Click += new System.EventHandler(this.label1_Click);
            // 
            // DatosIngresante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 332);
            this.Controls.Add(this.LBLDatos);
            this.Name = "DatosIngresante";
            this.Text = "DatosIngresante";
            this.Load += new System.EventHandler(this.DatosIngresante_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLDatos;
    }
}