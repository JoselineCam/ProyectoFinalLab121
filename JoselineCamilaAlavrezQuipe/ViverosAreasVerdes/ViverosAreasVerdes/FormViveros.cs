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
    public partial class FormViveros : Form
    {
        private int n = 0;

        public FormViveros()
        {
            InitializeComponent();
            ArchEmpVive ar = new ArchEmpVive(@"d:\datosEM.dat");
            ar.listar();
            actualizarViewGrid(true);
            buttonMostrarAlmacigueras.Enabled = false;
            buttonMostrarCamasDeRepique.Enabled = false;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //Boton Mostrar ALMACIGEURA
        private void button4_Click(object sender, EventArgs e)
        {
            FormMostrrarAlmaciguera fmostrar = new FormMostrrarAlmaciguera();
            AddOwnedForm(fmostrar);
            fmostrar.labelCodVivero.Text = textBoxCodVivero.Text;
            fmostrar.actualizarViewGrid(true, textBoxCodVivero.Text);
            fmostrar.Show();
        }

        // Añadir vivero
        private void butCambDat_Click(object sender, EventArgs e)
        {

            ArchEmpVive ar = new ArchEmpVive(@"d:\datosEM.dat");
            ar.anadirVivero(textBoxUbicaVivero.Text, TextBoxSuperficie.Text, textBoxAltitudVive.Text);
            ar.listar();

            
            //Adicionar nuevo renglon
            int n = dataGridViewViveros.Rows.Add();
            //Colocar Infomracion
            actualizarViewGrid(false);
            limpiar();
        }

        private void dataGridViewViveros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;
            if (n!=-1)
            {
                textBoxCodVivero.Text = (string)dataGridViewViveros.Rows[n].Cells[0].Value;
                textBoxUbicaVivero.Text = (string)dataGridViewViveros.Rows[n].Cells[1].Value;
                TextBoxSuperficie.Text = (string)dataGridViewViveros.Rows[n].Cells[2].Value;
                textBoxAltitudVive.Text = (string)dataGridViewViveros.Rows[n].Cells[3].Value;
                activarBotMostrar(true);
            }
        }

        // BORRAR
        private void button3_Click(object sender, EventArgs e)
        {
            if (n != -1)
            {
                dataGridViewViveros.Rows.RemoveAt(n);
            }
            ArchEmpVive ar = new ArchEmpVive(@"d:\datosEM.dat");
            if(ar.eliminarVivero(textBoxCodVivero.Text))
                MessageBox.Show("VIVERO CON CODIGO: " + textBoxCodVivero.Text + " FUE ELIMINADO...!!!!");
            else
                MessageBox.Show("VIVERO CON CODIGO: " + textBoxCodVivero.Text + " NO SE ENCONTRO...!!!!");

            actualizarViewGrid(false);
            limpiar();


        }

        //BOTON EDITAR
        private void button2_Click(object sender, EventArgs e)
        {
            ArchEmpVive ar = new ArchEmpVive(@"d:\datosEM.dat");
            ar.modificarDatoVivero(textBoxCodVivero.Text, textBoxUbicaVivero.Text, TextBoxSuperficie.Text, textBoxAltitudVive.Text);
            ar.listar();

            
            actualizarViewGrid(false);
            limpiar();

        }

        //BUSCAR
        private void button1_Click(object sender, EventArgs e)
        {
            bool sw = false;
            for (int i = 0; i< dataGridViewViveros.RowCount; i++)
            {
                if ((string)dataGridViewViveros.Rows[i].Cells[0].Value == textBoxBuscar.Text)
                {
                    sw = true;
                    textBoxCodVivero.Text = (string)dataGridViewViveros.Rows[i].Cells[0].Value;
                    textBoxUbicaVivero.Text = (string)dataGridViewViveros.Rows[i].Cells[1].Value;
                    TextBoxSuperficie.Text = (string)dataGridViewViveros.Rows[i].Cells[2].Value;
                    textBoxAltitudVive.Text = (string)dataGridViewViveros.Rows[i].Cells[3].Value;
                    MessageBox.Show("VIVERO CON CODIGO: "+ textBoxBuscar.Text+" FUE ENCONTRADO...!!!!");
                    break;
                }
            }
            if (!sw)
                MessageBox.Show("VIVERO NO ENCONTRADO...!!!!");
        }

        private void textBoxCodVivero_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewViveros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        public void actualizarViewGrid(bool sw)
        {
            ArchEmpVive ar = new ArchEmpVive(@"d:\datosEM.dat");
            ar.listar();
            //Console.WriteLine(ar.SetCantViveros());

            Console.WriteLine("==========================");
            Console.WriteLine(ar.SetCantViveros());
            String[] b = ar.ObtenerDatosViveros();
            for (int i = 0; i < ar.SetCantViveros(); i++)
            {
                //string[] v = x.Split('\n');
                string[] v = b[i + 1].Split('\n');
                //int i = 0;
                if (sw)
                {
                    int n = dataGridViewViveros.Rows.Add();
                }
                    
                dataGridViewViveros.Rows[i].Cells[0].Value = v[0];
                dataGridViewViveros.Rows[i].Cells[1].Value = v[1];
                dataGridViewViveros.Rows[i].Cells[2].Value = v[2];
                dataGridViewViveros.Rows[i].Cells[3].Value = v[3];
                dataGridViewViveros.Rows[i].Cells[4].Value = v[4];
                dataGridViewViveros.Rows[i].Cells[5].Value = v[5];
            }

            Console.WriteLine("================ ACTUALIZAR DATOS ================");
            ar.listar();
        }

        public void limpiar()
        {
            textBoxCodVivero.Text = "";
            textBoxUbicaVivero.Text = "";
            TextBoxSuperficie.Text = "";
            textBoxAltitudVive.Text = "";
            activarBotMostrar(false);
        }

        public void activarBotMostrar(bool x)
        {
            buttonMostrarAlmacigueras.Enabled = x;
            buttonMostrarCamasDeRepique.Enabled = x;
        }
    }
}
