﻿namespace Pruebatrigonometrica
{
    partial class frmcuadrado
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
            txtLado = new TextBox();
            txtperimetro = new TextBox();
            txtarea = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btncalcular = new Button();
            SuspendLayout();
            // 
            // txtLado
            // 
            txtLado.Location = new Point(63, 98);
            txtLado.Name = "txtLado";
            txtLado.Size = new Size(200, 27);
            txtLado.TabIndex = 13;
            // 
            // txtperimetro
            // 
            txtperimetro.Location = new Point(299, 185);
            txtperimetro.Name = "txtperimetro";
            txtperimetro.Size = new Size(200, 27);
            txtperimetro.TabIndex = 12;
            // 
            // txtarea
            // 
            txtarea.Location = new Point(63, 185);
            txtarea.Name = "txtarea";
            txtarea.Size = new Size(200, 27);
            txtarea.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(337, 147);
            label4.Name = "label4";
            label4.Size = new Size(123, 23);
            label4.TabIndex = 10;
            label4.Text = "PERIMETRO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(124, 147);
            label3.Name = "label3";
            label3.Size = new Size(61, 23);
            label3.TabIndex = 9;
            label3.Text = "AREA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(63, 60);
            label2.Name = "label2";
            label2.Size = new Size(280, 23);
            label2.TabIndex = 8;
            label2.Text = "Medida del lado del cuadrado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(96, 22);
            label1.Name = "label1";
            label1.Size = new Size(397, 27);
            label1.TabIndex = 7;
            label1.Text = "CALCULO DE AREA Y PERIMETRO";
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(380, 90);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(141, 35);
            btncalcular.TabIndex = 14;
            btncalcular.Text = "CALCULAR";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // frmcuadrado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 239);
            Controls.Add(btncalcular);
            Controls.Add(txtLado);
            Controls.Add(txtperimetro);
            Controls.Add(txtarea);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmcuadrado";
            Text = "Cuadrado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLado;
        private TextBox txtperimetro;
        private TextBox txtarea;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btncalcular;
    }
}