
namespace EJ1
{
    partial class Form1
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
            this.RTBtxt = new System.Windows.Forms.RichTextBox();
            this.BTNCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RTBtxt
            // 
            this.RTBtxt.Location = new System.Drawing.Point(12, 12);
            this.RTBtxt.Name = "RTBtxt";
            this.RTBtxt.Size = new System.Drawing.Size(490, 267);
            this.RTBtxt.TabIndex = 0;
            this.RTBtxt.Text = "";
            // 
            // BTNCalcular
            // 
            this.BTNCalcular.Location = new System.Drawing.Point(398, 285);
            this.BTNCalcular.Name = "BTNCalcular";
            this.BTNCalcular.Size = new System.Drawing.Size(104, 33);
            this.BTNCalcular.TabIndex = 1;
            this.BTNCalcular.Text = "Calcular";
            this.BTNCalcular.UseVisualStyleBackColor = true;
            this.BTNCalcular.Click += new System.EventHandler(this.BTNCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 345);
            this.Controls.Add(this.BTNCalcular);
            this.Controls.Add(this.RTBtxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox RTBtxt;
        private System.Windows.Forms.Button BTNCalcular;
    }
}

