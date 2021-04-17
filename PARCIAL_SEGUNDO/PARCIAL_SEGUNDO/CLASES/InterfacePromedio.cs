using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARCIAL_SEGUNDO.CLASES
{
    interface InterfacePromedio
    {
        /// <summary>
        /// retorna el promedio a na columna especial 
        /// </summary>
        /// <param name="matriz"></param>
        /// <param name="columna_parcial"></param>
        /// <returns></returns>
        int promedios_por_parcial(string[,] matriz, int columna_parcial);

        /// <summary>
        /// retorna el promedio de un parcial en especial y una seccion en especial
        /// </summary>
        /// <param name="matriz"></param>
        /// <param name="columna_parcial"></param>
        /// <param name="seccion"></param>
        /// <returns></returns>
        int promedios_por_sección(string[,] matriz, int columna_parcial, string seccion);

        /// <summary>
        /// sacar el promedio general por alumos por seccion
        /// </summary>
        /// <param name="matriz"></param>
        /// <param name="columna_parcial"></param>
        /// <param name="seccion"></param>
        /// <returns></returns>
        int promedios_general_sección(string[,] matriz, int columna_parcial, string seccion);

        /// <summary>
        /// retornar una matriz de 2 columnas con el nombre y la otra es la sumatoria del parcial 1 al 3
        /// </summary>
        /// <param name="matriz"></param>
        /// <param name="sección"></param>
        /// <returns></returns>
        string[,] Clasificar_Alumnos(string[,] matriz, string sección);
        /// <summary>
        /// buscar el sobresaliente general o por secciòn
        /// </summary>
        /// <param name="matriz"></param>
        /// <returns></returns>

        string nombre_nota_mayor(string[,] matriz);

        string nombre_nota_mayor(string[,] matriz, string sección);

    }
}
