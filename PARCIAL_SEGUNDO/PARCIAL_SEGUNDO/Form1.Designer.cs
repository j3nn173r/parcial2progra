
namespace PARCIAL_SEGUNDO
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button3CARGARAR = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonotamayor = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonclasificacionalumno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button3CARGARAR
            // 
            this.button3CARGARAR.BackColor = System.Drawing.Color.Fuchsia;
            this.button3CARGARAR.Location = new System.Drawing.Point(12, 264);
            this.button3CARGARAR.Name = "button3CARGARAR";
            this.button3CARGARAR.Size = new System.Drawing.Size(90, 61);
            this.button3CARGARAR.TabIndex = 0;
            this.button3CARGARAR.Text = "CARGAR ARCHIVO";
            this.button3CARGARAR.UseVisualStyleBackColor = false;
            this.button3CARGARAR.Click += new System.EventHandler(this.button3CARGARAR_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Fuchsia;
            this.button4.Location = new System.Drawing.Point(202, 273);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 61);
            this.button4.TabIndex = 1;
            this.button4.Text = "PROMEDIO PARCIAL";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(71, 28);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(293, 225);
            this.listBox2.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(562, 32);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(248, 323);
            this.textBox2.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Fuchsia;
            this.button3.Location = new System.Drawing.Point(391, 347);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 54);
            this.button3.TabIndex = 4;
            this.button3.Text = "promedio por seccion";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonotamayor
            // 
            this.buttonotamayor.BackColor = System.Drawing.Color.Fuchsia;
            this.buttonotamayor.Location = new System.Drawing.Point(23, 353);
            this.buttonotamayor.Name = "buttonotamayor";
            this.buttonotamayor.Size = new System.Drawing.Size(105, 48);
            this.buttonotamayor.TabIndex = 5;
            this.buttonotamayor.Text = "promedio general";
            this.buttonotamayor.UseVisualStyleBackColor = false;
            this.buttonotamayor.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Fuchsia;
            this.button6.Location = new System.Drawing.Point(186, 350);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(156, 55);
            this.button6.TabIndex = 6;
            this.button6.Text = "nota mayor";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonclasificacionalumno
            // 
            this.buttonclasificacionalumno.BackColor = System.Drawing.Color.Fuchsia;
            this.buttonclasificacionalumno.Location = new System.Drawing.Point(548, 361);
            this.buttonclasificacionalumno.Name = "buttonclasificacionalumno";
            this.buttonclasificacionalumno.Size = new System.Drawing.Size(104, 40);
            this.buttonclasificacionalumno.TabIndex = 7;
            this.buttonclasificacionalumno.Text = "clasificacion por alumno";
            this.buttonclasificacionalumno.UseVisualStyleBackColor = false;
            this.buttonclasificacionalumno.Click += new System.EventHandler(this.buttonclasificacionalumno_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(886, 413);
            this.Controls.Add(this.buttonclasificacionalumno);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.buttonotamayor);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3CARGARAR);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3CARGARAR;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button buttonotamayor;
        private System.Windows.Forms.Button buttonclasificacionalumno;
    }
}

