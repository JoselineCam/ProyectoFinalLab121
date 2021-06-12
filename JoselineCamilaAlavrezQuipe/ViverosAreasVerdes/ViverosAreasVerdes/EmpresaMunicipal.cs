using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ViverosAreasVerdes
   
{
    [Serializable]
    class EmpresaMunicipal
    {
        private String idEmpresaMunicipal,municipio, nombreEmpresa;
        private int cantViveros;
        private Vivero[] viveros = new Vivero[10];


        //Random r = new Random();


        public EmpresaMunicipal(string idEM, string m, string nomE)
        {
            this.idEmpresaMunicipal = idEM;
            this.municipio = m;
            this.nombreEmpresa = nomE;
            this.cantViveros = 1;
            for (int i = 1; i <= 9; i++)
                viveros[i] = new Vivero(i+"-VIV", "AV.A", "8721", "812");
        }
        public EmpresaMunicipal()
        {
            this.idEmpresaMunicipal = "187273 - EMAV";
            this.municipio = "La Paz";
            this.nombreEmpresa = "EMAVERDE";
            this.cantViveros = 4;
            for (int i = 1; i <= 9; i++)
                viveros[i] = new Vivero(i+"-VIV", "AV.A"+i, "8721"+i, "812"+i);
        }

        public string IdEmpresaMunicipal { get => idEmpresaMunicipal; set => idEmpresaMunicipal = value; }
        public string Municipio { get => municipio; set => municipio = value; }
        public string NombreEmpresa { get => nombreEmpresa; set => nombreEmpresa = value; }
        public int CantViveros { get => cantViveros; set => cantViveros = value; }

        public void mostrar()
        {
            Console.WriteLine("ID: " + idEmpresaMunicipal);
            Console.WriteLine("MUNICIPIO: " + municipio);
            Console.WriteLine("NOMBRE EMPRESA: " + nombreEmpresa);
            Console.WriteLine("NRO VIVEROS: " + cantViveros);

            
            for (int i = 1; i <= cantViveros; i++)
            {
                Console.WriteLine("================= VIVEROS =================");
                viveros[i].mostrar();
            }
                
        }

        public void cambiarDatos(String x, String y, String w, String z)
        {
            for (int i = 1; i <= cantViveros; i++)
            {
                if (x == viveros[i].CodigoVivero) {
                    viveros[i].Ubicacion = y;
                    viveros[i].Superficie = w;
                    viveros[i].Altitud = z;
                }
            }
        }

        

        public void anadirVivero(String y, String w, String z)
        {
            CantViveros++;
            viveros[CantViveros].CodigoVivero = cantViveros+"-VIV";
            viveros[CantViveros].Ubicacion = y;
            viveros[CantViveros].Superficie = w;
            viveros[CantViveros].Altitud = z;

        }

        public void escribir(BinaryWriter escritor)
        {
            escritor.Write(this.IdEmpresaMunicipal);
            escritor.Write(this.Municipio);
            escritor.Write(this.NombreEmpresa);
            escritor.Write(this.CantViveros);
           for (int i = 1; i <= CantViveros; i++)
              viveros[i].escribir(escritor);
        }
        

        public void lectura(BinaryReader lector)
        {
            this.IdEmpresaMunicipal = lector.ReadString();
            this.Municipio = lector.ReadString();
            this.NombreEmpresa = lector.ReadString();
           this.CantViveros = lector.ReadInt32();
          for (int i = 1; i <= CantViveros; i++)
                viveros[i].lectura(lector);
        }


        public String obtenerDat()
        {
            return (IdEmpresaMunicipal+"\n"+  NombreEmpresa+ "\n"+  Municipio + "\n" + cantViveros);
        }

        public String obtenerDatosUltimoVivero()
        {
            return (viveros[cantViveros].CodigoVivero + "\n" +viveros[cantViveros].Ubicacion + "\n" + viveros[cantViveros].Superficie + "\n" + viveros[cantViveros].Altitud + "\n" + viveros[cantViveros].CantCamRep + "\n" + viveros[cantViveros].CantAlmaciguera);
        }

        public String[] obtenerDatosViveros()
        {
            String[] x = new String[15];
            for (int i = 1; i <= CantViveros; i++)
            {
                x[i] = (viveros[i].CodigoVivero + "\n" + viveros[i].Ubicacion + "\n" + viveros[i].Superficie + "\n" + viveros[i].Altitud + "\n" + viveros[i].CantCamRep + "\n" + viveros[i].CantAlmaciguera);
            }

            return x;
        }

        public bool eliminarViv(String x)
        {
            bool sw = false;
            int r = 1;
            for (int i = 1; i <= CantViveros; i++)
            {
                if(viveros[i].CodigoVivero != x)
                {
                    viveros[r] = viveros[i];
                    r++;
                }
            }
                
            if(r-1 == cantViveros)
            {
                return false;

            }
            else
            {
                CantViveros = r - 1;
                return true;
            }
            
        }

        public void agregarAlmaciguera(String codV,  int l, int a, int porcH, string inicSiem)
        {
            for (int i = 1; i <= cantViveros; i++)
            {
                if (viveros[i].CodigoVivero == codV)
                {
                    viveros[i].anadirAlmaciguera(l,a,porcH,inicSiem);
                }
            }
        }

        public int cantidadAlm(String x)
        {
            for (int i = 1; i <= cantViveros; i++)
            {
                if (viveros[i].CodigoVivero == x)
                {
                    return viveros[i].CantAlmaciguera;
                }
            }
            return 0;
        }

        public String[] obtenerDatosAlmacigueras(String x)
        {
            String[] t = new string[10];
            for (int i = 1; i <= cantViveros; i++)
            {
                if (viveros[i].CodigoVivero == x)
                {
                    return viveros[i].obtenerdatosAl();
                }
            }
            return t;
            
        }

        public void modificarAlmaciguera(String codV, String codAl, int l, int a, int porcH, string inicSiem)
        {
            for (int i = 1; i <= cantViveros; i++)
            {
                if (viveros[i].CodigoVivero == codV)
                {
                    viveros[i].modificarAlmaciguera(codAl,l,  a, porcH, inicSiem);
                }
            }
        }
    }
}
