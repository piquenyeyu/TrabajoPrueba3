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
    public partial class frmtriangulo : Form
    {
        public frmtriangulo()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Triangulo objt = new();
            objt.lado = double.Parse(txtlado.Text);
            txtarea.Text = objt.CalculaArea().ToString();
            txtperimetro.Text = objt.CalculaPerimetro().ToString();
        }
    }
}
