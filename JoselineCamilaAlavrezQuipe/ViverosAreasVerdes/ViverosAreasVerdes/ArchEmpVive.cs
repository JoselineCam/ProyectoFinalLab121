using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ViverosAreasVerdes
{
    class ArchEmpVive
    {
		private String nomEV;

		public ArchEmpVive(String n)
		{
			nomEV = n;
		}

		public void crearNuevo()
		{

			/// BASICOS===============================
			/// =======================================
			/// =====================================
			if (System.IO.File.Exists(nomEV))
			{
				/*Console.WriteLine("Realmente quiere borrar el archivo?. s/n");
				if (Console.ReadKey().KeyChar == 's')*/
					//System.IO.File.Delete(nomEV);
			}
            else
            {
				Console.WriteLine("El archivo no existe.");
				EmpresaMunicipal e = new EmpresaMunicipal();
				adicionar(e);
			}
				

		}

		public void adicionar(EmpresaMunicipal p)
		{
			// Abrimos el archivo o se crea un nuevo archivo si no existe
			Stream arch = File.Open(nomEV, FileMode.Append);
			BinaryWriter escribe = new BinaryWriter(arch);
			try
			{
					p.escribir(escribe);
			}
			catch (Exception)
			{
				Console.WriteLine("Fallo en adicionar el objeto !!!");
			}
			finally
			{
				arch.Close();
			}
		}

		public void listar()
		{
			// Abrimos el archivo o se crea un nuevo archivo si no existe
			Stream arch = File.Open(nomEV, FileMode.OpenOrCreate);
			BinaryReader lee = new BinaryReader(arch);
			EmpresaMunicipal p = new EmpresaMunicipal();
			Console.WriteLine("\n Listado de EMPRESA VIVERO....");
			try
			{
				while (true)
				{
					//lectura fisica desde el archivo
					p.lectura(lee);
					p.mostrar();
				}
			}
			catch (Exception)
			{
				Console.WriteLine("Fin de archivo ...");
			}
			finally
			{
				arch.Close();
			}
		}


		public void modificar(String ID, String nom, String mun)
		{
			bool sw = false;
			try
			{
				// Abrimos el archivo o se crea un nuevo archivo si no existe
				Stream arch = File.Open(nomEV, FileMode.OpenOrCreate);
				Stream archTemporal = File.Open(@"d:\temp.dat", FileMode.OpenOrCreate);
				BinaryReader lee = new BinaryReader(arch);
				BinaryWriter escribeTemp = new BinaryWriter(archTemporal);
				EmpresaMunicipal reg = new EmpresaMunicipal();
				try
				{
					reg.IdEmpresaMunicipal=ID;
					reg.Municipio=mun;
					reg.NombreEmpresa=nom;
					reg.escribir(escribeTemp);
					
				}
				catch (Exception)
				{
					// No hace nada.
				}
				finally
				{
					arch.Close();
					archTemporal.Close();
					File.Replace(@"d:\temp.dat", nomEV, nomEV + ".bak");
				}
			}
			catch (Exception)
			{
				Console.WriteLine("El archivo no se puede acceder !!!");
			}
		}


		public String datos()
		{
			Stream arch = File.Open(nomEV, FileMode.OpenOrCreate);
			BinaryReader lee = new BinaryReader(arch);
			EmpresaMunicipal p = new EmpresaMunicipal();
			String cad = "";
			try
			{
				while (true)
				{
					p.lectura(lee);
					cad = cad + p.obtenerDat();
				}
			}
			catch (Exception)
			{
				Console.WriteLine("Fin de archivo ...");
			}
			finally
			{
				arch.Close();
			}
			return cad;
		}


		/// VIVERO ===============================
		/// =======================================
		/// =====================================
		public void modificarDatoVivero(String x, String y, String w, String z)
		{
			bool sw = false;
			try
			{
				// Abrimos el archivo o se crea un nuevo archivo si no existe
				Stream arch = File.Open(nomEV, FileMode.OpenOrCreate);
				Stream archTemporal = File.Open(@"d:\temp.dat", FileMode.OpenOrCreate);
				BinaryReader lee = new BinaryReader(arch);
				BinaryWriter escribeTemp = new BinaryWriter(archTemporal);
				EmpresaMunicipal reg = new EmpresaMunicipal();
				try
				{
					while (true)
					{
						reg.lectura(lee);
						reg.cambiarDatos(x,y,w,z);
						//reg.anadirVivero(x, y, w, z);
						reg.escribir(escribeTemp);
					}


				}
				catch (Exception)
				{
					// No hace nada.
				}
				finally
				{
					arch.Close();
					archTemporal.Close();
					File.Replace(@"d:\temp.dat", nomEV, nomEV + ".bak");
				}
			}
			catch (Exception)
			{
				Console.WriteLine("El archivo no se puede acceder !!!");
			}
		}



		public void anadirVivero( String y, String w, String z)
		{
			bool sw = false;
			try
			{
				// Abrimos el archivo o se crea un nuevo archivo si no existe
				Stream arch = File.Open(nomEV, FileMode.OpenOrCreate);
				Stream archTemporal = File.Open(@"d:\temp.dat", FileMode.OpenOrCreate);
				BinaryReader lee = new BinaryReader(arch);
				BinaryWriter escribeTemp = new BinaryWriter(archTemporal);
				EmpresaMunicipal reg = new EmpresaMunicipal();
				try
				{
					while (true)
					{
						reg.lectura(lee);
						//reg.CantViveros = reg.CantViveros + 1;
						reg.anadirVivero(y,w,z);
						reg.escribir(escribeTemp);
					}
					

				}
				catch (Exception)
				{
					// No hace nada.
				}
				finally
				{
					arch.Close();
					archTemporal.Close();
					File.Replace(@"d:\temp.dat", nomEV, nomEV + ".bak");
				}
			}
			catch (Exception)
			{
				Console.WriteLine("El archivo no se puede acceder !!!");
			}
		}

		

		public String ObtenerDatosUltimoViveros()
		{
			Stream arch = File.Open(nomEV, FileMode.OpenOrCreate);
			BinaryReader lee = new BinaryReader(arch);
			EmpresaMunicipal p = new EmpresaMunicipal();
			String t = "";
			try
			{
				while (true)
				{
					
					p.lectura(lee);
					t= t+ p.obtenerDatosUltimoVivero();
				}
			}
			catch (Exception)
			{
				Console.WriteLine("Fin de archivo ...");
			}
			finally
			{
				arch.Close();
			}
			return t;
		}




		//----------------TODOS
		public String[] ObtenerDatosViveros()
		{
			Stream arch = File.Open(nomEV, FileMode.OpenOrCreate);
			BinaryReader lee = new BinaryReader(arch);
			EmpresaMunicipal p = new EmpresaMunicipal();
			String[] t = new String[20];
			try
			{
				while (true)
				{

					p.lectura(lee);
					t = p.obtenerDatosViveros();
				}
			}
			catch (Exception)
			{
				Console.WriteLine("Fin de archivo ...");
			}
			finally
			{
				arch.Close();
			}
			return t;
		}

		public int SetCantViveros()
		{
			Stream arch = File.Open(nomEV, FileMode.OpenOrCreate);
			BinaryReader lee = new BinaryReader(arch);
			EmpresaMunicipal p = new EmpresaMunicipal();
			int x = 0;
			try
			{
				while (true)
				{
					p.lectura(lee);
					x = p.CantViveros;
				}
			}
			catch (Exception)
			{
				Console.WriteLine("Fin de archivo ...");
			}
			finally
			{
				arch.Close();
			}
			return x;
		}

		

		public bool eliminarVivero(String codigo)
		{
			bool sw = false;
			try
			{
				// Abrimos el archivo o se crea un nuevo archivo si no existe
				Stream arch = File.Open(nomEV, FileMode.OpenOrCreate);
				Stream archTemporal = File.Open(@"d:\temp.dat", FileMode.OpenOrCreate);
				BinaryReader lee = new BinaryReader(arch);
				BinaryWriter escribeTemp = new BinaryWriter(archTemporal);
				EmpresaMunicipal reg = new EmpresaMunicipal();

				try
				{
					while (true)
					{
						reg.lectura(lee);
						if (reg.eliminarViv(codigo))
						{
							reg.escribir(escribeTemp);
							sw = true;
						}
						else
						{
							sw = false;
						}
					}
				}
				catch (Exception)
				{
					// No hace nada.
				}
				finally
				{
					arch.Close();
					archTemporal.Close();
					File.Replace(@"d:\temp.dat", nomEV, nomEV + ".bak");
				}
			}
			catch (Exception)
			{
				Console.WriteLine("El archivo no se puede acceder !!!");
			}
			return sw;
		}




		/// ALMACIGUERA------------------------
		/// -----------------------------------
		/// ----------------------------------
		public void AgregarAlmacigueraViveroX(String codigo, int l, int a, int porcH, string inicSiem)
		{
			try
			{
				// Abrimos el archivo o se crea un nuevo archivo si no existe
				Stream arch = File.Open(nomEV, FileMode.OpenOrCreate);
				Stream archTemporal = File.Open(@"d:\temp.dat", FileMode.OpenOrCreate);
				BinaryReader lee = new BinaryReader(arch);
				BinaryWriter escribeTemp = new BinaryWriter(archTemporal);
				EmpresaMunicipal reg = new EmpresaMunicipal();
				try
				{
					while (true)
					{
						reg.lectura(lee);
						reg.agregarAlmaciguera(codigo, l, a, porcH, inicSiem);
						reg.escribir(escribeTemp);
					}
				}
				catch (Exception)
				{
					// No hace nada.
				}
				finally
				{
					arch.Close();
					archTemporal.Close();
					File.Replace(@"d:\temp.dat", nomEV, nomEV + ".bak");
				}
			}
			catch (Exception)
			{
				Console.WriteLine("El archivo no se puede acceder !!!");
			}

		}


		public int SetCantAmacigueras(String cod)
		{
			Stream arch = File.Open(nomEV, FileMode.OpenOrCreate);
			BinaryReader lee = new BinaryReader(arch);
			EmpresaMunicipal p = new EmpresaMunicipal();
			int x = 0;
			try
			{
				while (true)
				{
					p.lectura(lee);
					x = p.cantidadAlm(cod);
				}
			}
			catch (Exception)
			{
				Console.WriteLine("Fin de archivo ...");
			}
			finally
			{
				arch.Close();
			}
			return x;
		}


		public String[] ObtenerDatosAlmacigueras( String cod)
		{
			Stream arch = File.Open(nomEV, FileMode.OpenOrCreate);
			BinaryReader lee = new BinaryReader(arch);
			EmpresaMunicipal p = new EmpresaMunicipal();
			String[] t = new String[20];
			try
			{
				while (true)
				{

					p.lectura(lee);
					t = p.obtenerDatosAlmacigueras(cod);
				}
			}
			catch (Exception)
			{
				Console.WriteLine("Fin de archivo ...");
			}
			finally
			{
				arch.Close();
			}
			return t;
		}

		public void modificarDatoAlmaciguera(String cod,String codAl, int l, int a, int porcH, string inicSiem)
		{
			bool sw = false;
			try
			{
				// Abrimos el archivo o se crea un nuevo archivo si no existe
				Stream arch = File.Open(nomEV, FileMode.OpenOrCreate);
				Stream archTemporal = File.Open(@"d:\temp.dat", FileMode.OpenOrCreate);
				BinaryReader lee = new BinaryReader(arch);
				BinaryWriter escribeTemp = new BinaryWriter(archTemporal);
				EmpresaMunicipal reg = new EmpresaMunicipal();
				try
				{
					while (true)
					{
						reg.lectura(lee);
						reg.modificarAlmaciguera(cod, codAl,l, a, porcH, inicSiem);
						reg.escribir(escribeTemp);
					}


				}
				catch (Exception)
				{
					// No hace nada.
				}
				finally
				{
					arch.Close();
					archTemporal.Close();
					File.Replace(@"d:\temp.dat", nomEV, nomEV + ".bak");
				}
			}
			catch (Exception)
			{
				Console.WriteLine("El archivo no se puede acceder !!!");
			}
		}


	}
}
