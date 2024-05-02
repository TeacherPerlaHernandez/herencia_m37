
namespace herencia
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.suma = new System.Windows.Forms.Button();
            this.resta = new System.Windows.Forms.Button();
            this.Mulriplicar = new System.Windows.Forms.Button();
            this.dividir = new System.Windows.Forms.Button();
            this.Limpa = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor 1/ # A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Resultado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor 2/ # B";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(147, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 29);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(148, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 29);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(146, 125);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 29);
            this.textBox3.TabIndex = 5;
            // 
            // suma
            // 
            this.suma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suma.Location = new System.Drawing.Point(268, 12);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(134, 46);
            this.suma.TabIndex = 6;
            this.suma.Text = "Sumar";
            this.suma.UseVisualStyleBackColor = true;
            this.suma.Click += new System.EventHandler(this.suma_Click);
            // 
            // resta
            // 
            this.resta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resta.Location = new System.Drawing.Point(268, 64);
            this.resta.Name = "resta";
            this.resta.Size = new System.Drawing.Size(134, 46);
            this.resta.TabIndex = 7;
            this.resta.Text = "Restar";
            this.resta.UseVisualStyleBackColor = true;
            this.resta.Click += new System.EventHandler(this.resta_Click);
            // 
            // Mulriplicar
            // 
            this.Mulriplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mulriplicar.Location = new System.Drawing.Point(268, 116);
            this.Mulriplicar.Name = "Mulriplicar";
            this.Mulriplicar.Size = new System.Drawing.Size(134, 46);
            this.Mulriplicar.TabIndex = 8;
            this.Mulriplicar.Text = "Multiplicar.";
            this.Mulriplicar.UseVisualStyleBackColor = true;
            this.Mulriplicar.Click += new System.EventHandler(this.Mulriplicar_Click);
            // 
            // dividir
            // 
            this.dividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividir.Location = new System.Drawing.Point(268, 168);
            this.dividir.Name = "dividir";
            this.dividir.Size = new System.Drawing.Size(134, 47);
            this.dividir.TabIndex = 9;
            this.dividir.Text = "Dividir";
            this.dividir.UseVisualStyleBackColor = true;
            // 
            // Limpa
            // 
            this.Limpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpa.Location = new System.Drawing.Point(25, 180);
            this.Limpa.Name = "Limpa";
            this.Limpa.Size = new System.Drawing.Size(99, 47);
            this.Limpa.TabIndex = 10;
            this.Limpa.Text = "Limpar";
            this.Limpa.UseVisualStyleBackColor = true;
            this.Limpa.Click += new System.EventHandler(this.Limpa_Click);
            // 
            // salir
            // 
            this.salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.Location = new System.Drawing.Point(147, 180);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(99, 47);
            this.salir.TabIndex = 11;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 252);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.Limpa);
            this.Controls.Add(this.dividir);
            this.Controls.Add(this.Mulriplicar);
            this.Controls.Add(this.resta);
            this.Controls.Add(this.suma);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CALCULADORA BASICA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button suma;
        private System.Windows.Forms.Button resta;
        private System.Windows.Forms.Button Mulriplicar;
        private System.Windows.Forms.Button dividir;
        private System.Windows.Forms.Button Limpa;
        private System.Windows.Forms.Button salir;
    }
}

