namespace Pruebatrigonometrica
{
    partial class frmCirculo
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtarea = new TextBox();
            txtperimetro = new TextBox();
            txtradio = new TextBox();
            btncalcular = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(92, 9);
            label1.Name = "label1";
            label1.Size = new Size(397, 27);
            label1.TabIndex = 0;
            label1.Text = "CALCULO DE AREA Y PERIMETRO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(62, 60);
            label2.Name = "label2";
            label2.Size = new Size(162, 23);
            label2.TabIndex = 1;
            label2.Text = "Radio del circulo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(123, 135);
            label3.Name = "label3";
            label3.Size = new Size(61, 23);
            label3.TabIndex = 2;
            label3.Text = "AREA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(366, 135);
            label4.Name = "label4";
            label4.Size = new Size(123, 23);
            label4.TabIndex = 3;
            label4.Text = "PERIMETRO";
            // 
            // txtarea
            // 
            txtarea.Location = new Point(62, 173);
            txtarea.Name = "txtarea";
            txtarea.Size = new Size(200, 27);
            txtarea.TabIndex = 4;
            // 
            // txtperimetro
            // 
            txtperimetro.Location = new Point(328, 173);
            txtperimetro.Name = "txtperimetro";
            txtperimetro.Size = new Size(200, 27);
            txtperimetro.TabIndex = 5;
            // 
            // txtradio
            // 
            txtradio.Location = new Point(62, 98);
            txtradio.Name = "txtradio";
            txtradio.Size = new Size(200, 27);
            txtradio.TabIndex = 6;
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(361, 76);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(141, 35);
            btncalcular.TabIndex = 7;
            btncalcular.Text = "CALCULAR";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // frmCirculo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 237);
            Controls.Add(btncalcular);
            Controls.Add(txtradio);
            Controls.Add(txtperimetro);
            Controls.Add(txtarea);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmCirculo";
            Text = "Calculo de circulo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtarea;
        private TextBox txtperimetro;
        private TextBox txtradio;
        private Button btncalcular;
    }
}