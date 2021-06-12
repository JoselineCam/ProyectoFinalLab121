using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ViverosAreasVerdes
{
    [Serializable]
    class CamaDeRepique
    {
        private String codCamaRepique;
        private double profundidadCamaRepique, largoCamaRepique, anchoCamaRepique;
        private int nroPlantas;
        private Planta[] plantas = new Planta[50];
        private CambioDeBolsa cambioBolsa;
        private Riego riego;
        public CamaDeRepique(string codCR, double prof, double larg, double anch)
        {
            this.CodCamaRepique = codCR;
            this.nroPlantas = 0;
            this.ProfundidadCamaRepique = prof;
            this.LargoCamaRepique = larg;
            this.AnchoCamaRepique = anch;
            for (int i = 1; i <= 49; i++)
                plantas[i] = new Planta();
            riego = new Riego("chorros", "Crecimiento", "12:00", 1);
            cambioBolsa = new CambioDeBolsa(15.5,"polietileno","negro","abono");
        }

        public string CodCamaRepique { get => codCamaRepique; set => codCamaRepique = value; }
        public int NroPlantas { get => nroPlantas; set => nroPlantas = value; }
        public double ProfundidadCamaRepique { get => profundidadCamaRepique; set => profundidadCamaRepique = value; }
        public double LargoCamaRepique { get => largoCamaRepique; set => largoCamaRepique = value; }
        public double AnchoCamaRepique { get => anchoCamaRepique; set => anchoCamaRepique = value; }

        public void mostrar()
        {
            Console.WriteLine("CODIGO: "+ codCamaRepique);

            Console.WriteLine("NRO PLANTAS: " + codCamaRepique);
            Console.WriteLine("================= PLANTAS =================");
            for (int i = 1; i <= nroPlantas; i++)
                plantas[i].mostrar();
            
            Console.WriteLine("PROFUNDIDAD: " + profundidadCamaRepique);
            Console.WriteLine("LARGO: " + largoCamaRepique);
            Console.WriteLine("ANCHO: " + anchoCamaRepique);
                if (riego != null)
                {
                    Console.WriteLine("================= RIEGO =================");
                    riego.mostrar();
                }
            if (cambioBolsa != null)
            {
                Console.WriteLine("================= CAMBIO BOLSA =================");
                cambioBolsa.mostrar();
            }

        }

        public void anadirCambioBolsa(double tamB, string matB, string colB, string desTier)
        {
            cambioBolsa.TamBolsa = tamB;
            cambioBolsa.MaterialBolsa = matB;
            cambioBolsa.ColorBolsa = colB;
            cambioBolsa.DescripTierra = desTier;
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
            escritor.Write(this.CodCamaRepique);
            escritor.Write(this.NroPlantas);

            for (int i = 1; i <= NroPlantas; i++)
                plantas[i].escribir(escritor);

            escritor.Write(this.ProfundidadCamaRepique);
            escritor.Write(this.LargoCamaRepique);
            escritor.Write(this.AnchoCamaRepique);
                riego.escribir(escritor);

                cambioBolsa.escribir(escritor);
        }

        public void lectura(BinaryReader lector)
        {
            this.CodCamaRepique = lector.ReadString();
            this.NroPlantas = lector.ReadInt32();
            for (int i = 1; i <= NroPlantas; i++)
                plantas[i].lectura(lector);

            this.ProfundidadCamaRepique = lector.ReadDouble();
            this.LargoCamaRepique = lector.ReadDouble();
            this.AnchoCamaRepique = lector.ReadDouble();

                riego.lectura(lector);

                cambioBolsa.lectura(lector);
            
        }
    }
}
