using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARCIAL_SEGUNDO.CLASES
{
    class clsenumcolumnas
    {
        internal static string Par1;
        internal static object Par3;
        internal static int parcial2;
        internal static int parcial3;
        internal static int correlativo;
        internal static int nombre;
        internal static int secciòn;

        public static object Par2 { get; internal set; }
        public static int Parcial1 { get; internal set; }
        public static int Correlativo { get; internal set; }
        public static int Nombre { get; internal set; }
        public static int Parcial2 { get; internal set; }
        public static int Parcial3 { get; internal set; }
        public static int Seccion { get; internal set; }

        public static class Clsenumcolumnas
        {
            public static int Correlativo = 0;
            public static int Nombre = 1;
            public static int Parcial1 = 2;
            public static int Parcial2 = 3;
            public static int Parcial3 = 4;
            public static int Sección = 5;
        }

    }

}

