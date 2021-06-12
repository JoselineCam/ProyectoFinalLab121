using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ViverosAreasVerdes
{
    [Serializable]
    class Vivero
    {
        private String codigoVivero, ubicacion, superficie, altitud;
        private int cantAlmaciguera, cantCamRep;
        private Almaciguera[] almacigueras = new Almaciguera[50];
        private CamaDeRepique[] camRepique = new CamaDeRepique[50];

        public Vivero(string codV, string u, string s, string a)
        {
            this.codigoVivero = codV;
            this.ubicacion = u;
            this.superficie = s;
            this.altitud = a;
            this.cantAlmaciguera = 3;
            this.cantCamRep = 3;
            for (int i = 1; i <= 49; i++)
                almacigueras[i]= new Almaciguera(i+"-AL",i,i,i,"11/06/2021");
            for (int i = 1; i <= 49; i++)
                camRepique[i] = new CamaDeRepique(i+"-CR",i,i,i);
        }

        public string CodigoVivero { get => codigoVivero; set => codigoVivero = value; }
        public string Ubicacion { get => ubicacion; set => ubicacion = value; }
        public string Superficie { get => superficie; set => superficie = value; }
        public string Altitud { get => altitud; set => altitud = value; }
        public int CantAlmaciguera { get => cantAlmaciguera; set => cantAlmaciguera = value; }
        public int CantCamRep { get => cantCamRep; set => cantCamRep = value; }

        public void mostrar()
        {
            Console.WriteLine("CODIGO VIVERO: " + codigoVivero);
            Console.WriteLine("UBICACION: " + ubicacion);
            Console.WriteLine("SUPERFICIE: " + superficie);
            Console.WriteLine("ALTITUD: " + altitud);
            Console.WriteLine("cantCAMARE: " + cantCamRep);
            Console.WriteLine("CANT ALMA: " + cantAlmaciguera);


           // Console.WriteLine("================= CAMAS DE REPIQUE =================");
           // for (int i = 1; i <= cantCamRepique; i++)
             //   camRepique[i].mostrar();

            Console.WriteLine("================= ALMACIGUERAS =================");
            for (int i = 1; i <= cantAlmaciguera; i++)
                almacigueras[i].mostrar();
        }

        public void anadirAlmaciguera( int l, int a, int porcH, string inicSiem)
        {
            cantAlmaciguera++;
            almacigueras[CantAlmaciguera].Largo = l;
            almacigueras[CantAlmaciguera].Ancho = a;
            almacigueras[CantAlmaciguera].PorcDeHumedad = porcH;
            almacigueras[CantAlmaciguera].InicioDeSiembra = inicSiem;

        }

        public void modificarAlmaciguera(String codAl, int l, int a, int porcH, string inicSiem)
        {
            for (int i = 1; i <= cantAlmaciguera; i++)
                if (almacigueras[i].CodAlmaciguera == codAl) { 
            almacigueras[i].Largo = l;
            almacigueras[i].Ancho = a;
            almacigueras[i].PorcDeHumedad = porcH;
            almacigueras[i].InicioDeSiembra = inicSiem;
        }


        }
        public void anadirCamaRepique(double prof, double larg, double anch)
        {
            cantCamRep++;
            camRepique[CantAlmaciguera].ProfundidadCamaRepique = prof;
            camRepique[CantAlmaciguera].AnchoCamaRepique = larg;
            camRepique[CantAlmaciguera].LargoCamaRepique = anch;
        }

        public void escribir(BinaryWriter escritor)
        {
            escritor.Write(this.CodigoVivero);
            escritor.Write(this.Ubicacion);
            escritor.Write(this.Superficie);
            escritor.Write(this.Altitud);
            escritor.Write(this.CantAlmaciguera);
            for (int i = 1; i <= cantAlmaciguera; i++)
                almacigueras[i].escribir(escritor);
            escritor.Write(this.CantAlmaciguera);
            //for (int i = 1; i <= CantCamRepique; i++)
             //   camRepique[i].escribir(escritor);

        }

        public void lectura(BinaryReader lector)
        {
            this.CodigoVivero = lector.ReadString();
            this.Ubicacion = lector.ReadString();
            this.Superficie = lector.ReadString();
            this.Altitud = lector.ReadString();
            this.CantAlmaciguera = lector.ReadInt32();
            for (int i = 1; i <= cantAlmaciguera; i++)
                almacigueras[i].lectura(lector);
            this.cantCamRep = lector.ReadInt32();
            //for (int i = 1; i <= cantCamRepique; i++)
              //  camRepique[i].lectura(lector);
        }

        public String[] obtenerdatosAl()
        {
            String[] x = new String[15];
            for (int i = 1; i <= CantAlmaciguera; i++)
            {
                x[i] = (almacigueras[i].CodAlmaciguera + "\n" + almacigueras[i].Largo + "\n" + almacigueras[i].Ancho + "\n" + almacigueras[i].NroSemillas + "\n" + almacigueras[i].PorcDeHumedad + "\n" +almacigueras[i].InicioDeSiembra); ;
            }

            return x;
        }

    }
}
