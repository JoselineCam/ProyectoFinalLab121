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
    public partial class Form1 : Form
    {

        private Panel leftBorderB;
        private Button botn;
        public Form1()
        {
            InitializeComponent();
            leftBorderB = new Panel();
            leftBorderB.Size = new Size(7,60);
            panel1.Controls.Add(leftBorderB);

            barraMenu.Height = botonInfo.Height;
            barraMenu.Top = botonInfo.Top;
            ArchEmpVive ar = new ArchEmpVive(@"d:\datosEM.dat");

            string[] v = ar.datos().Split('\n');
            Console.WriteLine(ar.datos());
            nombreVivero.Text = v[1];

            
            
        }

        
        private void botonInfo_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void botonViv_Click(object sender, EventArgs e)
        {
            cambiarCol(botonPlant, botonInfo);
            barraMenu.Height = botonViv.Height;
            barraMenu.Top = botonViv.Top;
            botonViv.BackColor = Color.FromArgb(38, 149, 63, 0);

            FormViveros formV = new FormViveros();
            abrirFormHija(formV);
        }

        private void botonInfo_Click_1(object sender, EventArgs e)
        {
            cambiarCol(botonPlant, botonViv);
            barraMenu.Height = botonInfo.Height;
            barraMenu.Top = botonInfo.Top;
            botonInfo.BackColor = Color.FromArgb(38, 149, 63, 0);


            Info info = new Info();
      
            
            abrirFormHija(info);
            //info.datosEmpresa(em.IdEmpresaMunicipal, em.Municipio, em.NombreEmpresa);
        }


        private void abrirFormHija(Object x)
        {
            if (this.Contenedor.Controls.Count>0)
            {
                this.Contenedor.Controls.RemoveAt(0);
            }
            
            Form fh = x as Form;
            AddOwnedForm(fh);
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Contenedor.Controls.Add(fh);
            this.Contenedor.Tag = fh;
            fh.Show();

        }

        public void cambiarDatosTit(String x)
        {
            nombreVivero.Text = x;
        }

        private void botonInfo_EnabledChanged(object sender, EventArgs e)
        {

        }



        private void botonPlant_Click(object sender, EventArgs e)
        {
            cambiarCol(botonInfo, botonViv);
            barraMenu.Height = botonPlant.Height;
            barraMenu.Top = botonPlant.Top;
            botonPlant.BackColor = Color.FromArgb(38, 149, 63, 0);
        }

        public void cambiarCol(Button a, Button b)
        {
            a.BackColor = Color.FromArgb(150, 0, 0, 0);
            b.BackColor = Color.FromArgb(150, 0, 0, 0);

        }

    }
}
