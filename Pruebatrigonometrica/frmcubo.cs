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
    public partial class frmcubo : Form
    {
        public frmcubo()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            cubo objcb = new();
            objcb.lado = double.Parse(txtlado.Text);
            txtarea.Text = objcb.CalculaArea().ToString();
            txtvolumen.Text = objcb.CalculaPerimetro().ToString();
        }
    }
}
