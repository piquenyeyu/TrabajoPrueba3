using System;
using Modelo;
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
    public partial class figura : Form
    {
        static string[] figurasbidi = { "Circulo", "Cuadrado",
            "Triangulo" };
        static string[] figurastridi = { "Esfera", "Cubo",
            "Tetraedro" };


        public figura()
        {
            InitializeComponent();
        }

        private void figura_Load(object sender, EventArgs e)
        {
            cbotridi.DataSource = figurastridi;
            cbobidi.DataSource = figurasbidi;
        }

        private void cbobidi_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiguraBidimencional objfb = new();
            double frm;
            frm = objfb.AsignaFigura();
        }

        private void btnbidi_Click(object sender, EventArgs e, double frm)
        {
            if (frm == 1)
            {
                frmCirculo frmCirculo = new frmCirculo();
                frmCirculo.ShowDialog();
            }
            else if (frm == 2)
            {
                frmcuadrado frmCuadrado = new frmcuadrado();
                frmCuadrado.ShowDialog();
            }
            else if (frm == 3)
            {
                frmtriangulo frmtriangulo = new frmtriangulo();
                frmtriangulo.ShowDialog();
            }
            else MessageBox.Show("Seleccione una opcion dentro de la figuras bidimencionales ");
        }

        private void cbotridi_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiguraTridimencional objft = new();
            double frm2;
            frm2 = objft.AsignaFigura();
        }

        private void btntridi_Click(object sender, EventArgs e, double frm2)
        {
            if (frm2 == 4)
            {
                frmesfera frmesfera = new frmesfera();
                frmesfera.ShowDialog();
            }
            else if (frm2 == 5)
            {
                frmcubo frmcubo = new frmcubo();
                frmcubo.ShowDialog();
            }
            else if (frm2 == 6)
            {
                frmtetraedro frmtetraedro = new frmtetraedro();
                frmtetraedro.ShowDialog();
            }
            else MessageBox.Show("Seleccione una opcion dentro de la figuras Tridimencionales ");
        }
    }
}
