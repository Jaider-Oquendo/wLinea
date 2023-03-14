using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Jaider Andres Oquendo Zapata
/// 14 de Marzo del 2023
/// Formulario que dibuja lineas ingresando los puntos iniciales y finales en X y Y, Cada vez que de clic al botón “Dibujar línea”, se deberá dibujar y contar el numero de veces que se dinuje una linea.
/// </summary>

namespace wLineas
{
    public partial class fmrLinea : Form
    {
       
        public const double Xinicial = 0;
        public const double Yinicial = 0;
        public const double Xfinal = 0;
        public const double Yfinal = 0;

        Graphics grafico;

        public fmrLinea()
        {
            InitializeComponent();
            grafico = CreateGraphics();
        }

        private void btnDibujarLinea_Click(object sender, EventArgs e)
        {
            try
            {
                double Xinicial = double.Parse(txtXinicial.Text);
                double Yinicial = double.Parse(txtYinicial.Text);
                double Xfinal = double.Parse(txtXfinal.Text);
                double Yfinal = double.Parse(txtYfinal.Text);
                clsLinea Line = new clsLinea(Xinicial, Yinicial, Xfinal, Yfinal);

                Pen pen = new Pen(Brushes.Green);
                grafico.DrawLine(pen, Line.obtenXinicial(), Line.obtenYinicial(), Line.obtenXfinal(), Line.obtenYfinal());
                
                txtCantidadDeLineas.Text = Convert.ToString(clsLinea.obtenCuenta());
            }
            catch (Exception)
            {

                MessageBox.Show("Digite Numeros Validos");
            }
           

        }
    }
}
