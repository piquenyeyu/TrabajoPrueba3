using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pruebatrigonometrica
{
    public partial class frmcuadrado : Form
    {
        public frmcuadrado()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Cuadrado objcd = new();
            objcd.radio = double.Parse(txtLado.Text);
            txtarea.Text = objcd.CalculaArea().ToString("0.00");
            txtperimetro.Text = objcd.CalculaPerimetro().ToString("0.00");
        }
    }
}
