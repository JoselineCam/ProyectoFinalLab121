using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ViverosAreasVerdes
{
    [Serializable]
    class Riego
    {
        private String tipoDeRiego, descripcion, horario;
        private int beneficio;

        public Riego(string tipR, string des, string h, int b)
        {
            this.tipoDeRiego = tipR;
            this.descripcion = des;
            this.horario = h;
            this.beneficio = b;
        }

        public string TipoDeRiego { get => tipoDeRiego; set => tipoDeRiego = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Horario { get => horario; set => horario = value; }
        public int Beneficio { get => beneficio; set => beneficio = value; }

        public void mostrar()
        {
            Console.WriteLine("TIPO RIEGO: " + tipoDeRiego);
            Console.WriteLine("DESCRIPCION: " + descripcion);
            Console.WriteLine("HORARIO: " + horario);
        }

        public void escribir(BinaryWriter escritor)
        {
            escritor.Write(this.tipoDeRiego);
            escritor.Write(this.Descripcion);
            escritor.Write(this.Horario);
        }

        public void lectura(BinaryReader lector)
        {
            this.TipoDeRiego = lector.ReadString();
            this.Descripcion = lector.ReadString();
            this.Horario = lector.ReadString();
        }
    }
}
