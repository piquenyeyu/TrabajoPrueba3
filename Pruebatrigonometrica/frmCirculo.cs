using Modelo;

namespace Pruebatrigonometrica
{
    public partial class frmCirculo : Form
    {
        public frmCirculo()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Circulo objc = new ();
            objc.radio = double.Parse(txtradio.Text);
            txtarea.Text = objc.CalculaArea().ToString("0.00");
            txtperimetro.Text = objc.CalculaPerimetro().ToString("0.00");
        }
    }
}