using PARCIAL_SEGUNDO.CLASES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PARCIAL_SEGUNDO
{
    public partial class Form1 : Form
    {


        private string[] ArregloNotas;

        public Form1()
        {
            InitializeComponent();
        }

        private void button3CARGARAR_Click(object sender, EventArgs e)
        {

            CLSArchivos ar = new CLSArchivos();
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "seleciona tu archivo plano porfavor";
            ofd.InitialDirectory = @"C:\Users\HP-PC\Documents\documento plano";
            ofd.Filter = "Archivo Plano (.csv)|.csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var archivo = ofd.FileName;
                String resultado = ar.LeertodoArchivo(archivo);
                ArregloNotas = ar.LeerArchivo(archivo);
                textBox1.Text = resultado;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clsINTERFAZ pro = new clsINTERFAZ();
            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length, 6];
            int NumeroLinea = 0;

            foreach (string linea in ArregloNotas)
            {
                string[] DatosUnitarios = linea.Split(';');

                ArregloDosDimensiones[NumeroLinea, clsenumcolumnas.Parcial1] = DatosUnitarios[2];
                ArregloDosDimensiones[NumeroLinea, clsenumcolumnas.parcial2] = DatosUnitarios[3];
                ArregloDosDimensiones[NumeroLinea, clsenumcolumnas.parcial3] = DatosUnitarios[4];
                NumeroLinea++;
            }
            int Prome1 = pro.promedio_por_parcial(ArregloDosDimensiones, 2);
            int Prome2 = pro.promedio_por_parcial(ArregloDosDimensiones, 3);
            int Prome3 = pro.promedio_por_parcial(ArregloDosDimensiones, 4);
            listBox2.Items.Add($"Promedio de Tercer Parcial: {Prome3}");
            listBox2.Items.Add($"Promedio de Segundo Parcial: {Prome2}");
            listBox2.Items.Add($"Promedio de Primer Parcial: {Prome1}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Promedio promedio = new Promedio();
            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length, 6];
            int NumeroLinea = 0;

            foreach (string linea in ArregloNotas)
            {

                string[] DatosUnitarios = linea.Split(';');
                ArregloDosDimensiones[NumeroLinea, clsenumcolumnas.Correlativo] = DatosUnitarios[0];
                ArregloDosDimensiones[NumeroLinea, clsenumcolumnas.Nombre] = DatosUnitarios[1];
                ArregloDosDimensiones[NumeroLinea, clsenumcolumnas.Parcial1] = DatosUnitarios[2];
                ArregloDosDimensiones[NumeroLinea, clsenumcolumnas.Parcial2] = DatosUnitarios[3];
                ArregloDosDimensiones[NumeroLinea, clsenumcolumnas.Parcial3] = DatosUnitarios[4];
                ArregloDosDimensiones[NumeroLinea, clsenumcolumnas.Seccion] = DatosUnitarios[5];
                NumeroLinea++;
            }

            int promedioSAP1 = promedio.promedio_por_seccion(ArregloDosDimensiones, clsenumcolumnas.Par1, "A");
            int promedioSAP2 = promedio.promedio_por_seccion(ArregloDosDimensiones, clsenumcolumnas.Par2, "A");
            int promedioSAP3 = promedio.promedio_por_seccion(ArregloDosDimensiones, clsenumcolumnas.Par3, "A");
            int promedioSBP1 = promedio.promedio_por_seccion(ArregloDosDimensiones, clsenumcolumnas.Par1, "B");
            int promedioSBP2 = promedio.promedio_por_seccion(ArregloDosDimensiones, clsenumcolumnas.Par2, "B");
            int promedioSBP3 = promedio.promedio_por_seccion(ArregloDosDimensiones, clsenumcolumnas.Par3, "B");
            int promedioSCP1 = promedio.promedio_por_seccion(ArregloDosDimensiones, clsenumcolumnas.Par1, "C");
            int promedioSCP2 = promedio.promedio_por_seccion(ArregloDosDimensiones, clsenumcolumnas.Par2, "C");
            int promedioSCP3 = promedio.promedio_por_seccion(ArregloDosDimensiones, clsenumcolumnas.Par3, "C");

            listBox2.Items.Add($"Promedio Sección A, Parcial 1: {promedioSAP1}");
            listBox2.Items.Add($"Promedio Sección A, Parcial 2: {promedioSAP2}");
            listBox2.Items.Add($"Promedio Sección A, Parcial 3: {promedioSAP3}");

            listBox2.Items.Add($"Promedio Sección B, Parcial 1: {promedioSBP1}");
            listBox2.Items.Add($"Promedio Sección B, Parcial 2: {promedioSBP2}");
            listBox2.Items.Add($"Promedio Sección B, Parcial 3: {promedioSBP3}");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Promedio promedio = new Promedio();
            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length, 6];
            int NumeroLinea = 0;

            foreach (string linea in ArregloNotas)
            {

                string[] DatosUnitarios = linea.Split(';');
                ArregloDosDimensiones[NumeroLinea, clsenumcolumnas.Correlativo] = DatosUnitarios[0];
                ArregloDosDimensiones[NumeroLinea, clsenumcolumnas.Nombre] = DatosUnitarios[1];
                ArregloDosDimensiones[NumeroLinea, clsenumcolumnas.Parcial1] = DatosUnitarios[2];
                ArregloDosDimensiones[NumeroLinea, clsenumcolumnas.Parcial2] = DatosUnitarios[3];
                ArregloDosDimensiones[NumeroLinea, clsenumcolumnas.Parcial3] = DatosUnitarios[4];
                ArregloDosDimensiones[NumeroLinea, clsenumcolumnas.Seccion] = DatosUnitarios[5];
                NumeroLinea++;
            }

            int promedioGeneralA = promedio.promedio_general_seccion(ArregloDosDimensiones, "A");
            int promedioGeneralB = promedio.promedio_general_seccion(ArregloDosDimensiones, "B");
            int promedioGeneralC = promedio.promedio_general_seccion(ArregloDosDimensiones, "C");

            listBox2.Items.Add($"Promedio General Sección A: {promedioGeneralA}");
            listBox2.Items.Add($"Promedio General Sección B: {promedioGeneralB}");
            listBox2.Items.Add($"Promedio General Sección C: {promedioGeneralC}");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Promedio promedio = new Promedio();
            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length, 6];
            int NumeroLinea = 0;

            foreach (string linea in ArregloNotas)
            {

                string[] DatosUnitarios = linea.Split(';');
                ArregloDosDimensiones[NumeroLinea, clsenumcolumnas.Correlativo] = DatosUnitarios[0];
                ArregloDosDimensiones[NumeroLinea, clsenumcolumnas.Nombre] = DatosUnitarios[1];
                ArregloDosDimensiones[NumeroLinea, clsenumcolumnas.Parcial1] = DatosUnitarios[2];
                ArregloDosDimensiones[NumeroLinea, clsenumcolumnas.Parcial2] = DatosUnitarios[3];
                ArregloDosDimensiones[NumeroLinea, clsenumcolumnas.Parcial3] = DatosUnitarios[4];
                ArregloDosDimensiones[NumeroLinea, clsenumcolumnas.Seccion] = DatosUnitarios[5];
                NumeroLinea++;
            }

            string mayor = promedio.nombre_nota_mayor(ArregloDosDimensiones, "C");

            listBox2.Items.Add($" --- ALUMNO CON PROMEDIO MAYOR SECCIÓN C ---");
            listBox2.Items.Add($"Nombre: {mayor}");
        }

        private void buttonNotaMayorGeneral_Click(object sender, EventArgs e)
        {

            Promedio promedio = new Promedio();
            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length, 6];
            int NumeroLinea = 0;

            foreach (string linea in ArregloNotas)
            {

                string[] DatosUnitarios = linea.Split(';');
                ArregloDosDimensiones[NumeroLinea, clsenumcolumnas.Correlativo] = DatosUnitarios[0];
                ArregloDosDimensiones[NumeroLinea, clsenumcolumnas.Nombre] = DatosUnitarios[1];
                ArregloDosDimensiones[NumeroLinea, clsenumcolumnas.Parcial1] = DatosUnitarios[2];
                ArregloDosDimensiones[NumeroLinea, clsenumcolumnas.Parcial2] = DatosUnitarios[3];
                ArregloDosDimensiones[NumeroLinea, clsenumcolumnas.Parcial3] = DatosUnitarios[4];
                ArregloDosDimensiones[NumeroLinea, clsenumcolumnas.Seccion] = DatosUnitarios[5];
                NumeroLinea++;
            }

            string mayor = promedio.nombre_nota_mayor(ArregloDosDimensiones);

            listBox2.Items.Add($" --- ALUMNO CON PROMEDIO MAYOR ---");
            listBox2.Items.Add($"Nombre: {mayor}");
        }

        private void buttonclasificacionalumno_Click(object sender, EventArgs e)
        {
            Promedio promedio = new Promedio();
            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length, 6];
            int NumeroLinea = 0;

            foreach (string linea in ArregloNotas)
            {

                string[] DatosUnitarios = linea.Split(';');
                ArregloDosDimensiones[NumeroLinea, clsenumcolumnas.Correlativo] = DatosUnitarios[0];
                ArregloDosDimensiones[NumeroLinea, clsenumcolumnas.Nombre] = DatosUnitarios[1];
                ArregloDosDimensiones[NumeroLinea, clsenumcolumnas.Parcial1] = DatosUnitarios[2];
                ArregloDosDimensiones[NumeroLinea, clsenumcolumnas.Parcial2] = DatosUnitarios[3];
                ArregloDosDimensiones[NumeroLinea, clsenumcolumnas.Parcial3] = DatosUnitarios[4];
                ArregloDosDimensiones[NumeroLinea, clsenumcolumnas.Seccion] = DatosUnitarios[5];
                NumeroLinea++;
            }

            string[,] alumnoClasificado = promedio.Clasificar_Alumnos(ArregloDosDimensiones, "B");
            string nombre = alumnoClasificado[0, 0];
            string nota = alumnoClasificado[0, 1];

            listBox2.Items.Add($" --- ALUMNOS CON MEJORES NOTAS ---");
            listBox2.Items.Add($"SECCIÓN B:");
            listBox2.Items.Add($"Nombre: {nombre}");
            listBox2.Items.Add($"Sumatoria de los parciales: {nota}");
        }
    }
}

       
