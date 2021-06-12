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
    
    public partial class FormMostrrarAlmaciguera : Form
    {
        private String codVi = "";
        private int n = 0;
        public string CodVi { get => codVi; set => codVi = value; }

        public FormMostrrarAlmaciguera()
        {
            InitializeComponent();
            ArchEmpVive ar = new ArchEmpVive(@"d:\datosEM.dat");
            ar.listar();
            //actualizarViewGrid(true);
            buttonAdicionarSemillas.Enabled = false;
            buttonMostrarSemillas.Enabled = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelCodVivero_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonMostrarCamasDeRepique_Click(object sender, EventArgs e)
        {

        }

        private void butAnadir_Click(object sender, EventArgs e)
        {
            ArchEmpVive ar = new ArchEmpVive(@"d:\datosEM.dat");
            
            ar.AgregarAlmacigueraViveroX(labelMostrarCodigo.Text, int.Parse(TextBoxLargo.Text), int.Parse(textBoxAncho.Text), int.Parse(textBoxHumedad.Text), textBoxInicioSiembra.Text);


            //Adicionar nuevo renglon
            int n = dataGridViewAlvacigueras.Rows.Add();
            //Colocar Infomracion
            actualizarViewGrid(false, labelMostrarCodigo.Text);
            limpiar();
        }


        public void actualizarViewGrid(bool sw, String x)
        {
            codVi = x;
            ArchEmpVive ar = new ArchEmpVive(@"d:\datosEM.dat");
            ar.listar();
            Console.WriteLine("==========================");
            //FormViveros formv = Owner as FormViveros;
            Console.WriteLine(ar.SetCantAmacigueras(labelCodVivero.Text)+"  "+x);
            String[] b = ar.ObtenerDatosAlmacigueras(labelCodVivero.Text);
            for (int i = 0; i < ar.SetCantAmacigueras(labelCodVivero.Text); i++)
            {
                //string[] v = x.Split('\n');
                string[] v = b[i + 1].Split('\n');
                //int i = 0;
                if (sw)
                {
                    int n = dataGridViewAlvacigueras.Rows.Add();
                }

                dataGridViewAlvacigueras.Rows[i].Cells[0].Value = v[0];
                dataGridViewAlvacigueras.Rows[i].Cells[1].Value = v[1];
                dataGridViewAlvacigueras.Rows[i].Cells[2].Value = v[2];
                dataGridViewAlvacigueras.Rows[i].Cells[3].Value = v[3];
                dataGridViewAlvacigueras.Rows[i].Cells[4].Value = v[4];
                dataGridViewAlvacigueras.Rows[i].Cells[5].Value = v[5];

            }

            Console.WriteLine("================ ACTUALIZAR DATOS ================");
            ar.listar();
        }

        public void limpiar()
        {
            labelMostrarCodigo.Text = "________";
            TextBoxLargo.Text = "";
            textBoxAncho.Text = "";
            textBoxHumedad.Text = "";
            textBoxInicioSiembra.Text = "";
            activarBotMostrar(false);
        }

        public void activarBotMostrar(bool x)
        {
            buttonMostrarSemillas.Enabled = x;
            buttonAdicionarSemillas.Enabled = x;
        }

        private void dataGridViewViveros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            ArchEmpVive ar = new ArchEmpVive(@"d:\datosEM.dat");
            FormViveros f = Owner as FormViveros;
            
            ar.modificarDatoAlmaciguera(f.textBoxCodVivero.Text, labelMostrarCodigo.Text, int.Parse(TextBoxLargo.Text), int.Parse(textBoxAncho.Text), int.Parse(textBoxHumedad.Text), textBoxInicioSiembra.Text);
            ar.listar();

            actualizarViewGrid(false, codVi);
            limpiar();
        }


        private void dataGridViewAlvacigueras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;
            if (n != -1)
            {
                labelMostrarCodigo.Text = (string)dataGridViewAlvacigueras.Rows[n].Cells[0].Value;
                TextBoxLargo.Text = (string)dataGridViewAlvacigueras.Rows[n].Cells[1].Value;
                textBoxAncho.Text = (string)dataGridViewAlvacigueras.Rows[n].Cells[2].Value;
                textBoxHumedad.Text = (string)dataGridViewAlvacigueras.Rows[n].Cells[3].Value;
                textBoxInicioSiembra.Text = (string)dataGridViewAlvacigueras.Rows[n].Cells[4].Value;

                activarBotMostrar(true);
            }
        }
    }
}
