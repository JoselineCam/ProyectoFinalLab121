using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ViverosAreasVerdes
{
    [Serializable]
    class Planta
    {
        protected String codPlanta, nombre, lugarAdaptable;
        protected int tiempoDeVida, periodoRiego, estado;
        protected double altura;

        public Planta()
        {
            this.codPlanta = "12";
            this.nombre = "Pensamiento";
            this.altura = 1.2;
            this.tiempoDeVida = 6;
            this.lugarAdaptable = "Frio";
            this.estado = 3;
            this.periodoRiego = 3;
        }
        public Planta(String codP, String nom, double alt, int tiemp, String lugA, int e, int perdR)
        {
            this.codPlanta = codP;
            this.nombre = nom;
            this.altura = alt;
            this.tiempoDeVida = tiemp;
            this.lugarAdaptable = lugA;
            this.estado = e;
            this.periodoRiego = perdR;

        }

        public string CodPlanta { get => codPlanta; set => codPlanta = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string LugarAdaptable { get => lugarAdaptable; set => lugarAdaptable = value; }
        public int Estado { get => estado; set => estado = value; }
        public int TiempoDeVida { get => tiempoDeVida; set => tiempoDeVida = value; }
        public int PeriodoRiego { get => periodoRiego; set => periodoRiego = value; }
        public double Altura { get => altura; set => altura = value; }

        public void mostrar()
        {
            Console.Write(codPlanta + "\t" + nombre + "\t" + lugarAdaptable + "\t" + estado + "\t" + tiempoDeVida + "\t" + periodoRiego + "\t" + altura);
        }

        public void escribir(BinaryWriter escritor)
        {
            escritor.Write(this.CodPlanta);
            escritor.Write(this.Nombre);
            escritor.Write(this.Altura);
            escritor.Write(this.TiempoDeVida);
            escritor.Write(this.LugarAdaptable);
            escritor.Write(this.Estado);
            escritor.Write(this.PeriodoRiego);
        }

        public void lectura(BinaryReader lector)
        {
            this.CodPlanta = lector.ReadString();
            this.Nombre = lector.ReadString();
            this.Altura = lector.ReadDouble();
            this.TiempoDeVida = lector.ReadInt32();
            this.LugarAdaptable = lector.ReadString();
            this.Estado = lector.ReadInt32();
            this.PeriodoRiego = lector.ReadInt32();
        }
    }
}
