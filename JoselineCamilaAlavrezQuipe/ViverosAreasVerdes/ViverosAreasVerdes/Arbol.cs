using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ViverosAreasVerdes
{
    [Serializable]
    class Arbol: Planta
    {
        private double diametroTronco;

        public Arbol(String codP, String nom, double alt, int tiemp, String lugA, int e, int perdR, double diamTron) :base(codP, nom, alt, tiemp, lugA, e, perdR)
        {
            this.diametroTronco = diamTron;
        }

        public double DiametroTronco { get => diametroTronco; set => diametroTronco = value; }

        public void mostrar()
        {
            base.mostrar();
            Console.WriteLine("\t"+ diametroTronco);
        }

        public void escribir(BinaryWriter escritor)
        {
            base.escribir(escritor);
            escritor.Write(this.DiametroTronco);
        }

        public void lectura(BinaryReader lector)
        {
            base.lectura(lector);
            this.DiametroTronco = lector.ReadDouble();
        }
    }
}
