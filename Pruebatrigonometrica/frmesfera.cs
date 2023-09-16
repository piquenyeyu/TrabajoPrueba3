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
    public partial class frmesfera : Form
    {
        public frmesfera()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Esfera obje = new();
            obje.lado = double.Parse(txtradio.Text);
            txtarea.Text = obje.CalculaArea().ToString();
            txtvolumen.Text = obje.CalculaPerimetro().ToString();
        }
    }
}
