using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ViverosAreasVerdes
{
    [Serializable]
    class Almaciguera
    {
        private String codAlmaciguera, inicioDeSiembra;
        private int largo, ancho, porcDeHumedad;
        private int nroSemillas;
        private Semilla[] semillas = new Semilla[50];
        private Riego riego;
        

        public string CodAlmaciguera { get => codAlmaciguera; set => codAlmaciguera = value; }
        public string InicioDeSiembra { get => inicioDeSiembra; set => inicioDeSiembra = value; }
        public int Largo { get => largo; set => largo = value; }
        public int Ancho { get => ancho; set => ancho = value; }
        public int PorcDeHumedad { get => porcDeHumedad; set => porcDeHumedad = value; }
        public int NroSemillas { get => nroSemillas; set => nroSemillas = value; }

        public Almaciguera(string codA, int l, int a, int porcH, string inicSiem)
        {
            this.codAlmaciguera = codA;
            this.inicioDeSiembra = inicSiem;
            this.largo = l;
            this.ancho = a;
            this.porcDeHumedad = porcH;
            this.nroSemillas = 0;
            riego = new Riego("chorros", "Crecimiento", "12:00", 1);
            for (int i = 1; i <= 49; i++)
                semillas[i] = new Semilla(i+"-SM","Tip"+i,i);
        }

        public void mostrar()
        {
            Console.WriteLine("CODIGO ALMACIGUERA: " + codAlmaciguera);
            Console.WriteLine("LARGO: " + largo);
            Console.WriteLine("ANCHO: " + ancho);
            Console.WriteLine("PORCENTAJE DE HUMEDAD: " + porcDeHumedad);
            Console.WriteLine("INICIO DE SIEMBRA: " + inicioDeSiembra);

            Console.WriteLine("================= SEMILLAS =================");
            for (int i = 1; i <= nroSemillas; i++)
                semillas[i].mostrar();
                //Console.WriteLine("================= RIEGO =================");
               // riego.mostrar();
            
        }


        public void anadirRiego(string tipR, string des, string h, int b)
        {
            riego.TipoDeRiego = tipR;
            riego.Descripcion = des;
            riego.Horario = h;
            riego.Beneficio = b;
        }

        public void escribir(BinaryWriter escritor)
        {
            escritor.Write(this.CodAlmaciguera);
            escritor.Write(this.Largo);
            escritor.Write(this.Ancho);
            escritor.Write(this.NroSemillas);
            //for (int i = 1; i <= nroSemillas; i++)
               // semillas[i].escribir(escritor);
            escritor.Write(this.PorcDeHumedad);
            escritor.Write(this.InicioDeSiembra);
            //riego.escribir(escritor);

        }

        public void lectura(BinaryReader lector)
        {
            this.CodAlmaciguera = lector.ReadString();
            this.Largo = lector.ReadInt32();
            this.Ancho = lector.ReadInt32();
            this.NroSemillas = lector.ReadInt32();
           // for (int i = 1; i <= nroSemillas; i++)
             //   semillas[i].lectura(lector);
            this.PorcDeHumedad = lector.ReadInt32();
            this.InicioDeSiembra = lector.ReadString();
            //riego.lectura(lector);
        }
    }
}
