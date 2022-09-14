namespace Calculadora
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
            this.textResultado = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.borraruno = new System.Windows.Forms.Button();
            this.borrarTodo = new System.Windows.Forms.Button();
            this.borrar_unoA_uno = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnMas_Menos = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnElevada = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.btnSumar = new System.Windows.Forms.Button();
            this.btnRestar = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textResultado
            // 
            this.textResultado.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textResultado.Location = new System.Drawing.Point(2, 12);
            this.textResultado.Multiline = true;
            this.textResultado.Name = "textResultado";
            this.textResultado.Size = new System.Drawing.Size(353, 49);
            this.textResultado.TabIndex = 0;
            this.textResultado.Text = "0";
            this.textResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 239);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(57, 53);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.agregarNumeros);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(75, 239);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(57, 53);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.agregarNumeros);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(138, 239);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(57, 53);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.agregarNumeros);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(138, 180);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(57, 53);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.agregarNumeros);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(75, 180);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(57, 53);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.agregarNumeros);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(12, 180);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(57, 53);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.agregarNumeros);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(138, 121);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(57, 53);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.agregarNumeros);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(75, 121);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(57, 53);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.agregarNumeros);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(12, 121);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(57, 53);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.agregarNumeros);
            // 
            // borraruno
            // 
            this.borraruno.Location = new System.Drawing.Point(12, 67);
            this.borraruno.Name = "borraruno";
            this.borraruno.Size = new System.Drawing.Size(57, 48);
            this.borraruno.TabIndex = 10;
            this.borraruno.Text = "CE";
            this.borraruno.UseVisualStyleBackColor = true;
            this.borraruno.Click += new System.EventHandler(this.borraruno_Click);
            // 
            // borrarTodo
            // 
            this.borrarTodo.Location = new System.Drawing.Point(75, 67);
            this.borrarTodo.Name = "borrarTodo";
            this.borrarTodo.Size = new System.Drawing.Size(57, 48);
            this.borrarTodo.TabIndex = 11;
            this.borrarTodo.Text = "C";
            this.borrarTodo.UseVisualStyleBackColor = true;
            this.borrarTodo.Click += new System.EventHandler(this.borrarTodo_Click);
            // 
            // borrar_unoA_uno
            // 
            this.borrar_unoA_uno.Location = new System.Drawing.Point(138, 67);
            this.borrar_unoA_uno.Name = "borrar_unoA_uno";
            this.borrar_unoA_uno.Size = new System.Drawing.Size(57, 48);
            this.borrar_unoA_uno.TabIndex = 12;
            this.borrar_unoA_uno.Text = "<=";
            this.borrar_unoA_uno.UseVisualStyleBackColor = true;
            this.borrar_unoA_uno.Click += new System.EventHandler(this.borrar_unoA_uno_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDecimal.Location = new System.Drawing.Point(138, 298);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(57, 53);
            this.btnDecimal.TabIndex = 15;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.btnDecimal_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(75, 298);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(60, 53);
            this.btn0.TabIndex = 16;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.agregarNumeros);
            // 
            // btnMas_Menos
            // 
            this.btnMas_Menos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMas_Menos.Location = new System.Drawing.Point(12, 298);
            this.btnMas_Menos.Name = "btnMas_Menos";
            this.btnMas_Menos.Size = new System.Drawing.Size(57, 53);
            this.btnMas_Menos.TabIndex = 13;
            this.btnMas_Menos.Text = "+/-";
            this.btnMas_Menos.UseVisualStyleBackColor = true;
            this.btnMas_Menos.Click += new System.EventHandler(this.btnMas_Menos_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDividir.Location = new System.Drawing.Point(235, 145);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(57, 53);
            this.btnDividir.TabIndex = 17;
            this.btnDividir.Tag = "/";
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMultiplicar.Location = new System.Drawing.Point(298, 145);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(57, 53);
            this.btnMultiplicar.TabIndex = 16;
            this.btnMultiplicar.Tag = "X";
            this.btnMultiplicar.Text = "X";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnElevada
            // 
            this.btnElevada.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnElevada.Location = new System.Drawing.Point(298, 76);
            this.btnElevada.Name = "btnElevada";
            this.btnElevada.Size = new System.Drawing.Size(57, 53);
            this.btnElevada.TabIndex = 19;
            this.btnElevada.Tag = "²";
            this.btnElevada.Text = "x²";
            this.btnElevada.UseVisualStyleBackColor = true;
            this.btnElevada.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnRaiz
            // 
            this.btnRaiz.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRaiz.Location = new System.Drawing.Point(235, 76);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(57, 53);
            this.btnRaiz.TabIndex = 18;
            this.btnRaiz.Tag = "√";
            this.btnRaiz.Text = "√";
            this.btnRaiz.UseVisualStyleBackColor = true;
            this.btnRaiz.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnSumar
            // 
            this.btnSumar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSumar.Location = new System.Drawing.Point(298, 216);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(57, 53);
            this.btnSumar.TabIndex = 21;
            this.btnSumar.Tag = "+";
            this.btnSumar.Text = "+";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnRestar
            // 
            this.btnRestar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRestar.Location = new System.Drawing.Point(235, 216);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(57, 53);
            this.btnRestar.TabIndex = 20;
            this.btnRestar.Tag = "-";
            this.btnRestar.Text = "-";
            this.btnRestar.UseVisualStyleBackColor = true;
            this.btnRestar.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnIgual
            // 
            this.btnIgual.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIgual.Location = new System.Drawing.Point(235, 298);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(120, 53);
            this.btnIgual.TabIndex = 22;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 366);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.btnRestar);
            this.Controls.Add(this.btnElevada);
            this.Controls.Add(this.btnRaiz);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnMas_Menos);
            this.Controls.Add(this.borrar_unoA_uno);
            this.Controls.Add(this.borrarTodo);
            this.Controls.Add(this.borraruno);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.textResultado);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textResultado;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button borraruno;
        private Button borrarTodo;
        private Button borrar_unoA_uno;
        private Button btnDecimal;
        private Button btn0;
        private Button btnMas_Menos;
        private Button btnDividir;
        private Button btnMultiplicar;
        private Button btnElevada;
        private Button btnRaiz;
        private Button btnSumar;
        private Button btnRestar;
        private Button btnIgual;
    }
}