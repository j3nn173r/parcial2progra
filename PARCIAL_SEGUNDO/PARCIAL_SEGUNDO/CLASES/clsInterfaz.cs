using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARCIAL_SEGUNDO.CLASES
{
    class clsInterfaz
    {
         
        public string[,] clasificar_Alumnos(string[,] matriz, string seccion)
        {
            throw new NotImplementedException();
        }
        public string nombre_nota_mayor(string[,] matriz)
        {
            throw new NotImplementedException();
        }
        public string nombre_nota_mayor(string[,] matriz, string seccion)
        {
            throw new NotImplementedException();
        }
        public int promedios_general_seccion(string[,] matriz, int columna_parcial, string seccion)
        {
            throw new NotImplementedException();
        }
        public int promedios_por_parcial(string[,] matriz, int columna_parcial, string seccion)
        {

            int Acumula = 0;
            int Prome;
            int TotalFilas = matriz.GetLength(0);
            int TotalColumnas = matriz.GetLength(1);
            for (int fila = 1; fila < TotalFilas; fila++)
            {
                Acumula = Acumula + Convert.ToInt32(matriz[fila, columna_parcial]);
            }
            Prome = Acumula / (TotalFilas - 1);
            return Prome;
        }

        public int promedios_por_seccion(string[,] matriz, int columna_parcial, string seccion)
        {

            int Acumula = 0;
            int Prome;
            int TotalFilas = matriz.GetLength(0);
            int TotalColumnas = matriz.GetLength(1);
            for (int fila = 1; fila < TotalFilas; fila++)
            {
                Acumula = Acumula + Convert.ToInt32(matriz[fila, columna_parcial]);
            }
            Prome = Acumula / (TotalFilas - 1);
            return Prome;
        }

        internal int promedios_por_parcial(string[,] arregloDosDimensiones, int v)
        {
            throw new NotImplementedException();
        }

        internal int prome_por_parcial(string[,] arregloDosDimensiones, int v)
        {
            throw new NotImplementedException();
        }

        internal int promedio_por_parcial(string[,] arregloDosDimensiones, int v)
        {
            throw new NotImplementedException();
        }
    }
}
    

