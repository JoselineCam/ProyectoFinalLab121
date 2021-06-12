using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ViverosAreasVerdes
{
    [Serializable]
    class Ornamental: Planta
    {
        private String colorFlores;
        private int cantdFlores;


        Random r = new Random();
        public Ornamental(): base()
        {
            colorFlores = "Amarillo";
            cantdFlores = r.Next(1, 11);
        }
        public Ornamental(String codP, String nom, double alt, int tiemp, String lugA, int e, int perdR, String colF, int cantFn) : base(codP, nom, alt, tiemp, lugA, e, perdR)
        {
            this.ColorFlores = colF;
            this.CantdFlores = cantFn;
        }

        public string ColorFlores { get => colorFlores; set => colorFlores = value; }
        public int CantdFlores { get => cantdFlores; set => cantdFlores = value; }

        public void mostrar()
        {
            base.mostrar();
            Console.WriteLine("\t" + colorFlores+"\t"+ cantdFlores);
        }

        public void escribir(BinaryWriter escritor)
        {
            base.escribir(escritor);
            escritor.Write(this.ColorFlores);
            escritor.Write(this.CantdFlores);
        }

        public void lectura(BinaryReader lector)
        {
            base.lectura(lector);
            this.ColorFlores = lector.ReadString();
            this.CantdFlores = lector.ReadInt32();
        }
    }
}
