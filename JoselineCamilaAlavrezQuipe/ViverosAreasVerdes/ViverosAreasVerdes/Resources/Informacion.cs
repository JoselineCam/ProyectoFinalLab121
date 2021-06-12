using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViverosAreasVerdes.Resources
{
    public partial class Informacion : UserControl
    {
        public Informacion()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserControl camD = new CambiarDatosInfo();
            camD.BringToFront();
        }

        private void Informacion_Load(object sender, EventArgs e)
        {

        }
    }
}
