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
    public partial class FormCambiarDatos : Form
    {
        bool sw = false;
        public FormCambiarDatos()
        {
            InitializeComponent();
        }

        private void Inf1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            ArchEmpVive arch = new ArchEmpVive(@"d:\datosEM.dat");

            arch.modificar(textBoxCamId.Text, textBoxCamNom.Text, textBoxCambMun.Text);
            Info p = Owner as Info;
            p.datosEmpresa(textBoxCamId.Text, textBoxCamNom.Text, textBoxCambMun.Text);
            Close();
            

        }
        
    }
}
