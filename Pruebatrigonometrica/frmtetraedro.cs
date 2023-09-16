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
    public partial class frmtetraedro : Form
    {
        public frmtetraedro()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Tetraedro objtt = new();
            objtt.lado = double.Parse(txtlado.Text);
            txtarea.Text = objtt.CalculaArea().ToString();
            txtperimetro.Text = objtt.CalculaPerimetro().ToString();
        }
    }
}
