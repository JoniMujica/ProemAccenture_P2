
namespace EJ2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LBLEdad = new System.Windows.Forms.Label();
            this.edadList = new System.Windows.Forms.NumericUpDown();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.LBLDireccion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.LBLNombre = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RadNobin = new System.Windows.Forms.RadioButton();
            this.RadFemenino = new System.Windows.Forms.RadioButton();
            this.RadMasculino = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CHOp3 = new System.Windows.Forms.CheckBox();
            this.CHOp2 = new System.Windows.Forms.CheckBox();
            this.CHOp1 = new System.Windows.Forms.CheckBox();
            this.Paises = new System.Windows.Forms.ListBox();
            this.BTNIngresar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edadList)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LBLEdad);
            this.groupBox1.Controls.Add(this.edadList);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.LBLDireccion);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.LBLNombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 186);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles del Usuario";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // LBLEdad
            // 
            this.LBLEdad.AutoSize = true;
            this.LBLEdad.Location = new System.Drawing.Point(20, 116);
            this.LBLEdad.Name = "LBLEdad";
            this.LBLEdad.Size = new System.Drawing.Size(33, 15);
            this.LBLEdad.TabIndex = 5;
            this.LBLEdad.Text = "Edad";
            // 
            // edadList
            // 
            this.edadList.Location = new System.Drawing.Point(92, 114);
            this.edadList.Name = "edadList";
            this.edadList.Size = new System.Drawing.Size(120, 23);
            this.edadList.TabIndex = 4;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(92, 74);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(140, 23);
            this.txtDireccion.TabIndex = 3;
            // 
            // LBLDireccion
            // 
            this.LBLDireccion.AutoSize = true;
            this.LBLDireccion.Location = new System.Drawing.Point(20, 77);
            this.LBLDireccion.Name = "LBLDireccion";
            this.LBLDireccion.Size = new System.Drawing.Size(57, 15);
            this.LBLDireccion.TabIndex = 2;
            this.LBLDireccion.Text = "Direccion";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(92, 38);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(140, 23);
            this.txtNombre.TabIndex = 1;
            // 
            // LBLNombre
            // 
            this.LBLNombre.AutoSize = true;
            this.LBLNombre.Location = new System.Drawing.Point(20, 41);
            this.LBLNombre.Name = "LBLNombre";
            this.LBLNombre.Size = new System.Drawing.Size(51, 15);
            this.LBLNombre.TabIndex = 0;
            this.LBLNombre.Text = "Nombre";
            this.LBLNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RadNobin);
            this.groupBox2.Controls.Add(this.RadFemenino);
            this.groupBox2.Controls.Add(this.RadMasculino);
            this.groupBox2.Location = new System.Drawing.Point(317, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(115, 137);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Genero";
            // 
            // RadNobin
            // 
            this.RadNobin.AutoSize = true;
            this.RadNobin.Location = new System.Drawing.Point(7, 90);
            this.RadNobin.Name = "RadNobin";
            this.RadNobin.Size = new System.Drawing.Size(81, 19);
            this.RadNobin.TabIndex = 2;
            this.RadNobin.TabStop = true;
            this.RadNobin.Text = "No Binario";
            this.RadNobin.UseVisualStyleBackColor = true;
            // 
            // RadFemenino
            // 
            this.RadFemenino.AutoSize = true;
            this.RadFemenino.Location = new System.Drawing.Point(7, 64);
            this.RadFemenino.Name = "RadFemenino";
            this.RadFemenino.Size = new System.Drawing.Size(78, 19);
            this.RadFemenino.TabIndex = 1;
            this.RadFemenino.TabStop = true;
            this.RadFemenino.Text = "Femenino";
            this.RadFemenino.UseVisualStyleBackColor = true;
            // 
            // RadMasculino
            // 
            this.RadMasculino.AutoSize = true;
            this.RadMasculino.Location = new System.Drawing.Point(7, 38);
            this.RadMasculino.Name = "RadMasculino";
            this.RadMasculino.Size = new System.Drawing.Size(80, 19);
            this.RadMasculino.TabIndex = 0;
            this.RadMasculino.TabStop = true;
            this.RadMasculino.Text = "Masculino";
            this.RadMasculino.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CHOp3);
            this.groupBox3.Controls.Add(this.CHOp2);
            this.groupBox3.Controls.Add(this.CHOp1);
            this.groupBox3.Location = new System.Drawing.Point(317, 166);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(115, 126);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cursos";
            // 
            // CHOp3
            // 
            this.CHOp3.AutoSize = true;
            this.CHOp3.Location = new System.Drawing.Point(7, 75);
            this.CHOp3.Name = "CHOp3";
            this.CHOp3.Size = new System.Drawing.Size(78, 19);
            this.CHOp3.TabIndex = 2;
            this.CHOp3.Text = "JavaScript";
            this.CHOp3.UseVisualStyleBackColor = true;
            // 
            // CHOp2
            // 
            this.CHOp2.AutoSize = true;
            this.CHOp2.Location = new System.Drawing.Point(7, 49);
            this.CHOp2.Name = "CHOp2";
            this.CHOp2.Size = new System.Drawing.Size(50, 19);
            this.CHOp2.TabIndex = 1;
            this.CHOp2.Text = "C++";
            this.CHOp2.UseVisualStyleBackColor = true;
            // 
            // CHOp1
            // 
            this.CHOp1.AutoSize = true;
            this.CHOp1.Location = new System.Drawing.Point(7, 23);
            this.CHOp1.Name = "CHOp1";
            this.CHOp1.Size = new System.Drawing.Size(41, 19);
            this.CHOp1.TabIndex = 0;
            this.CHOp1.Text = "C#";
            this.CHOp1.UseVisualStyleBackColor = true;
            // 
            // Paises
            // 
            this.Paises.FormattingEnabled = true;
            this.Paises.ItemHeight = 15;
            this.Paises.Location = new System.Drawing.Point(12, 215);
            this.Paises.Name = "Paises";
            this.Paises.Size = new System.Drawing.Size(279, 94);
            this.Paises.TabIndex = 3;
            this.Paises.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // BTNIngresar
            // 
            this.BTNIngresar.Location = new System.Drawing.Point(330, 286);
            this.BTNIngresar.Name = "BTNIngresar";
            this.BTNIngresar.Size = new System.Drawing.Size(75, 23);
            this.BTNIngresar.TabIndex = 4;
            this.BTNIngresar.Text = "Ingresar";
            this.BTNIngresar.UseVisualStyleBackColor = true;
            this.BTNIngresar.Click += new System.EventHandler(this.BTNIngresar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 331);
            this.Controls.Add(this.BTNIngresar);
            this.Controls.Add(this.Paises);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edadList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LBLNombre;
        private System.Windows.Forms.Label LBLEdad;
        private System.Windows.Forms.NumericUpDown edadList;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label LBLDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RadNobin;
        private System.Windows.Forms.RadioButton RadFemenino;
        private System.Windows.Forms.RadioButton RadMasculino;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox CHOp3;
        private System.Windows.Forms.CheckBox CHOp2;
        private System.Windows.Forms.CheckBox CHOp1;
        private System.Windows.Forms.ListBox Paises;
        private System.Windows.Forms.Button BTNIngresar;
    }
}

