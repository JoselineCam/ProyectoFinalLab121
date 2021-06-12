using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ViverosAreasVerdes
{
    [Serializable]
    class CambioDeBolsa
    {
        private double tamBolsa;
        private String materialBolsa, colorBolsa, descripTierra;
        public CambioDeBolsa(double tamB, string matB, string colB, string desTier)
        {
            this.TamBolsa = tamB;
            this.MaterialBolsa = matB;
            this.ColorBolsa = colB;
            this.DescripTierra = desTier;
        }

        public double TamBolsa { get => tamBolsa; set => tamBolsa = value; }
        public string MaterialBolsa { get => materialBolsa; set => materialBolsa = value; }
        public string ColorBolsa { get => colorBolsa; set => colorBolsa = value; }
        public string DescripTierra { get => descripTierra; set => descripTierra = value; }

        public void mostrar()
        {
            Console.WriteLine("TAMAÑO BOLSA: " + tamBolsa);
            Console.WriteLine("MATERIAL: " + materialBolsa);
            Console.WriteLine("COLOR: " + colorBolsa);
            Console.WriteLine("DESCRIPCION: " + descripTierra);
        }
        public void escribir(BinaryWriter escritor)
        {
            escritor.Write(this.TamBolsa);
            escritor.Write(this.MaterialBolsa);
            escritor.Write(this.ColorBolsa);
            escritor.Write(this.DescripTierra);
        }

        public void lectura(BinaryReader lector)
        {
            this.TamBolsa = lector.ReadDouble();
            this.MaterialBolsa = lector.ReadString();
            this.ColorBolsa = lector.ReadString();
            this.DescripTierra = lector.ReadString();

        }
    }
}
