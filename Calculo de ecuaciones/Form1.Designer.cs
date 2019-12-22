namespace Calculo_de_ecuaciones
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtb = new System.Windows.Forms.TextBox();
            this.txtc = new System.Windows.Forms.TextBox();
            this.btnresolver = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdiscriminante = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.txtX1i = new System.Windows.Forms.TextBox();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.txtX2i = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtX2i);
            this.groupBox1.Controls.Add(this.txtX2);
            this.groupBox1.Controls.Add(this.txtX1i);
            this.groupBox1.Controls.Add(this.txtX1);
            this.groupBox1.Controls.Add(this.txtX);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtdiscriminante);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnresolver);
            this.groupBox1.Controls.Add(this.txtc);
            this.groupBox1.Controls.Add(this.txtb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 506);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dada la ecuacion ax2+bx+c=0, introduce los coeficientes a,b,c ; para calcular los" +
    " posibles valores de X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coeficiente a";
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(80, 75);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(100, 26);
            this.txta.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Coeficiente b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(554, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Coeficiente c";
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(330, 75);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(100, 26);
            this.txtb.TabIndex = 4;
            // 
            // txtc
            // 
            this.txtc.Location = new System.Drawing.Point(558, 75);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(100, 26);
            this.txtc.TabIndex = 5;
            // 
            // btnresolver
            // 
            this.btnresolver.Location = new System.Drawing.Point(278, 141);
            this.btnresolver.Name = "btnresolver";
            this.btnresolver.Size = new System.Drawing.Size(200, 48);
            this.btnresolver.TabIndex = 6;
            this.btnresolver.Text = "Resolver la Ecuacion";
            this.btnresolver.UseVisualStyleBackColor = true;
            this.btnresolver.Click += new System.EventHandler(this.btnresolver_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Discriminante";
            // 
            // txtdiscriminante
            // 
            this.txtdiscriminante.Location = new System.Drawing.Point(378, 232);
            this.txtdiscriminante.Name = "txtdiscriminante";
            this.txtdiscriminante.Size = new System.Drawing.Size(137, 26);
            this.txtdiscriminante.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(213, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "X1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(418, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "X2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(188, 396);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "X1 ( i )";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(405, 396);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "X2 ( i )";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(249, 294);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 26);
            this.txtX.TabIndex = 14;
            // 
            // txtX1
            // 
            this.txtX1.Location = new System.Drawing.Point(249, 344);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(100, 26);
            this.txtX1.TabIndex = 15;
            // 
            // txtX1i
            // 
            this.txtX1i.Location = new System.Drawing.Point(249, 396);
            this.txtX1i.Name = "txtX1i";
            this.txtX1i.Size = new System.Drawing.Size(100, 26);
            this.txtX1i.TabIndex = 16;
            // 
            // txtX2
            // 
            this.txtX2.Location = new System.Drawing.Point(473, 341);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(100, 26);
            this.txtX2.TabIndex = 17;
            // 
            // txtX2i
            // 
            this.txtX2i.Location = new System.Drawing.Point(473, 395);
            this.txtX2i.Name = "txtX2i";
            this.txtX2i.Size = new System.Drawing.Size(100, 26);
            this.txtX2i.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 19;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(106, 456);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 40);
            this.button2.TabIndex = 20;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 529);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Solucionador de ecuaciones";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtX2i;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.TextBox txtX1i;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdiscriminante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnresolver;
        private System.Windows.Forms.TextBox txtc;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.Label label1;
    }
}

