using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViverosAreasVerdes
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
            ArchEmpVive ar = new ArchEmpVive(@"d:\datosEM.dat");
            string[] v = ar.datos().Split('\n');
            for (int i =0;i<4;i++)
            {
                Console.WriteLine(v[i]);
            }
            Console.WriteLine(ar.datos());
            IDEmpre.Text = v[0];
            InfNombreVivero.Text = v[1];
            municipioEmpr.Text = v[2];
            cantidadViveros.Text = v[3];
        }

        private void butCambDat_Click(object sender, EventArgs e)
        {
            FormCambiarDatos formCD = new FormCambiarDatos();
            AddOwnedForm(formCD);
            ArchEmpVive ar = new ArchEmpVive(@"d:\datosEM.dat");
            string[] v = ar.datos().Split('\n');
            formCD.textBoxCamId.Text = v[0];
            formCD.textBoxCamNom.Text = v[1];
            formCD.textBoxCambMun.Text = v[2];

            formCD.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InfNombreVivero_Click(object sender, EventArgs e)
        {

        }

        public void datosEmpresa(String x, String y, String z)
        {
            ArchEmpVive ar = new ArchEmpVive(@"d:\datosEM.dat");
            string[] v = ar.datos().Split('\n');

            IDEmpre.Text = x;
            InfNombreVivero.Text = y;
            municipioEmpr.Text = z;
            cantidadViveros.Text = v[3];
            
            Form1 form = Owner as Form1;
            form.cambiarDatosTit(y);

        }

        private void IDEmpre_Click(object sender, EventArgs e)
        {

        }

        private void cantidadViveros_Click(object sender, EventArgs e)
        {

        }
    }
}
