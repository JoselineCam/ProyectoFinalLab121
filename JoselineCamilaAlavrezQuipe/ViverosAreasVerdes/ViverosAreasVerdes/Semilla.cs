using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ViverosAreasVerdes
{
    [Serializable]
    class Semilla
    {
        private String codSemilla, tipoSemilla;
        private int estadoSemilla;
        private double tamanoSemilla;

        public Semilla()
        {
            this.codSemilla = "162h";
            this.tipoSemilla = "";
            this.estadoSemilla = 0;
            this.tamanoSemilla = 0.2;
        }
        public Semilla(string codS, string tipS, double tamS)
        {
            this.codSemilla = codS;
            this.tipoSemilla = tipS;
            this.estadoSemilla = 0;
            this.tamanoSemilla = tamS;
        }

        public string CodSemilla { get => codSemilla; set => codSemilla = value; }
        public string TipoSemilla { get => tipoSemilla; set => tipoSemilla = value; }
        public int EstadoSemilla { get => estadoSemilla; set => estadoSemilla = value; }
        public double TamanoSemilla { get => tamanoSemilla; set => tamanoSemilla = value; }

        public void mostrar()
        {
            Console.WriteLine("CODIGO: " + codSemilla+"\t"+tipoSemilla+"\t"+estadoSemilla+"\t" +tamanoSemilla);
        }
        public void escribir(BinaryWriter escritor)
        {
            escritor.Write(this.CodSemilla);
            escritor.Write(this.TipoSemilla);
            escritor.Write(this.TamanoSemilla);
            escritor.Write(this.EstadoSemilla);
        }

        public void lectura(BinaryReader lector)
        {
            this.CodSemilla = lector.ReadString();
            this.TipoSemilla = lector.ReadString();
            this.TamanoSemilla = lector.ReadDouble();
            this.EstadoSemilla = lector.ReadInt32();
        }
    }
}
