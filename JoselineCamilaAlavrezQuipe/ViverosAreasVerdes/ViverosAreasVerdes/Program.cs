using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViverosAreasVerdes
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ArchEmpVive ar = new ArchEmpVive(@"d:\datosEM.dat");
            ar.crearNuevo();
            ar.listar();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
           
            /*ArchEmpVive ae = new ArchEmpVive(@"d:\datosA.dat");
            

            Console.WriteLine("=====================================");
           ae.AgregarAlmacigueraViveroX("1-VIV", 29, 193, 219, "11/06/2021");
            
            Console.WriteLine("=====================================");
            Console.WriteLine("=====================================");
            Console.WriteLine("=====================================");
            Console.WriteLine("=====================================");

            ae.listar();*/

        }
    }
}
