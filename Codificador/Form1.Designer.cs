namespace Codificador
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mensaje_Acod = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mensaje_cod = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.mensaje_Decod = new System.Windows.Forms.RichTextBox();
            this.mensaje_aDecod = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_codificar = new System.Windows.Forms.Button();
            this.btn_decodificar = new System.Windows.Forms.Button();
            this.txt_llave = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mensaje_Acod
            // 
            this.mensaje_Acod.Location = new System.Drawing.Point(10, 47);
            this.mensaje_Acod.Name = "mensaje_Acod";
            this.mensaje_Acod.Size = new System.Drawing.Size(308, 124);
            this.mensaje_Acod.TabIndex = 0;
            this.mensaje_Acod.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Introduce el mensaje";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_codificar);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.mensaje_cod);
            this.panel1.Controls.Add(this.mensaje_Acod);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(23, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(999, 180);
            this.panel1.TabIndex = 2;
            // 
            // mensaje_cod
            // 
            this.mensaje_cod.Location = new System.Drawing.Point(667, 47);
            this.mensaje_cod.Name = "mensaje_cod";
            this.mensaje_cod.ReadOnly = true;
            this.mensaje_cod.Size = new System.Drawing.Size(308, 124);
            this.mensaje_cod.TabIndex = 2;
            this.mensaje_cod.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(675, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mensaje Codificado";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_decodificar);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.mensaje_Decod);
            this.panel2.Controls.Add(this.mensaje_aDecod);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(23, 250);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(999, 199);
            this.panel2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(674, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mensaje Decodificado";
            // 
            // mensaje_Decod
            // 
            this.mensaje_Decod.Location = new System.Drawing.Point(666, 47);
            this.mensaje_Decod.Name = "mensaje_Decod";
            this.mensaje_Decod.ReadOnly = true;
            this.mensaje_Decod.Size = new System.Drawing.Size(308, 124);
            this.mensaje_Decod.TabIndex = 2;
            this.mensaje_Decod.Text = "";
            // 
            // mensaje_aDecod
            // 
            this.mensaje_aDecod.Location = new System.Drawing.Point(10, 47);
            this.mensaje_aDecod.Name = "mensaje_aDecod";
            this.mensaje_aDecod.Size = new System.Drawing.Size(308, 124);
            this.mensaje_aDecod.TabIndex = 0;
            this.mensaje_aDecod.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Introduce el mensaje";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(325, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(286, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "-> Codificar mensaje ->";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(320, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(314, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "-> Decodificar mensaje ->";
            // 
            // btn_codificar
            // 
            this.btn_codificar.Location = new System.Drawing.Point(415, 118);
            this.btn_codificar.Name = "btn_codificar";
            this.btn_codificar.Size = new System.Drawing.Size(120, 37);
            this.btn_codificar.TabIndex = 5;
            this.btn_codificar.Text = "Codificar";
            this.btn_codificar.UseVisualStyleBackColor = true;
            this.btn_codificar.Click += new System.EventHandler(this.btn_codificar_Click);
            // 
            // btn_decodificar
            // 
            this.btn_decodificar.Location = new System.Drawing.Point(415, 118);
            this.btn_decodificar.Name = "btn_decodificar";
            this.btn_decodificar.Size = new System.Drawing.Size(120, 37);
            this.btn_decodificar.TabIndex = 6;
            this.btn_decodificar.Text = "Decodificar";
            this.btn_decodificar.UseVisualStyleBackColor = true;
            this.btn_decodificar.Click += new System.EventHandler(this.btn_decodificar_Click);
            // 
            // txt_llave
            // 
            this.txt_llave.Location = new System.Drawing.Point(352, 209);
            this.txt_llave.Name = "txt_llave";
            this.txt_llave.Size = new System.Drawing.Size(460, 22);
            this.txt_llave.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(238, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ingresa la llave";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 464);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_llave);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox mensaje_Acod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox mensaje_cod;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox mensaje_Decod;
        private System.Windows.Forms.RichTextBox mensaje_aDecod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_codificar;
        private System.Windows.Forms.Button btn_decodificar;
        private System.Windows.Forms.TextBox txt_llave;
        private System.Windows.Forms.Label label7;
    }
}

