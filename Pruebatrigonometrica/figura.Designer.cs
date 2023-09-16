namespace Pruebatrigonometrica
{
    partial class figura
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
            label1 = new Label();
            cbobidi = new ComboBox();
            cbotridi = new ComboBox();
            btnbidi = new Button();
            btntridi = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(135, 19);
            label1.Name = "label1";
            label1.Size = new Size(251, 27);
            label1.TabIndex = 0;
            label1.Text = "Figura Trigonometrica";
            // 
            // cbobidi
            // 
            cbobidi.FormattingEnabled = true;
            cbobidi.Items.AddRange(new object[] { "Circulo", "Cuadrado", "Triangulo" });
            cbobidi.Location = new Point(84, 121);
            cbobidi.Name = "cbobidi";
            cbobidi.Size = new Size(133, 28);
            cbobidi.TabIndex = 1;
            cbobidi.Text = "{selecciona}";
            cbobidi.SelectedIndexChanged += cbobidi_SelectedIndexChanged;
            // 
            // cbotridi
            // 
            cbotridi.FormattingEnabled = true;
            cbotridi.Items.AddRange(new object[] { "Esfera", "Cubo", "Tetraedro" });
            cbotridi.Location = new Point(280, 121);
            cbotridi.Name = "cbotridi";
            cbotridi.Size = new Size(133, 28);
            cbotridi.TabIndex = 2;
            cbotridi.Text = "{selecciona}";
            cbotridi.SelectedIndexChanged += cbotridi_SelectedIndexChanged;
            // 
            // btnbidi
            // 
            btnbidi.Location = new Point(82, 81);
            btnbidi.Name = "btnbidi";
            btnbidi.Size = new Size(136, 28);
            btnbidi.TabIndex = 3;
            btnbidi.Text = "Bidimencional";
            btnbidi.UseVisualStyleBackColor = true;
            btnbidi.Click += btnbidi_Click;
            // 
            // btntridi
            // 
            btntridi.Location = new Point(280, 81);
            btntridi.Name = "btntridi";
            btntridi.Size = new Size(136, 28);
            btntridi.TabIndex = 4;
            btntridi.Text = "Tridimencional";
            btntridi.UseVisualStyleBackColor = true;
            btntridi.Click += btntridi_Click;
            // 
            // figura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1;
            ClientSize = new Size(535, 173);
            Controls.Add(btntridi);
            Controls.Add(btnbidi);
            Controls.Add(cbotridi);
            Controls.Add(cbobidi);
            Controls.Add(label1);
            Name = "figura";
            Text = "Calculo De Figuras";
            Load += figura_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void btntridi_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnbidi_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private ComboBox cbobidi;
        private ComboBox cbotridi;
        private Button btnbidi;
        private Button btntridi;
    }
}