using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace wLineas
{
    class clsLinea
    {
        private int Xinicial;
        private int Yinicial;
        private int Xfinal;
        private int Yfinal;
        public static int contar=0;

        public clsLinea()
        {
            Xinicial = 0;
            Yinicial = 0;
            Xfinal = 0;
            Yfinal = 0;
        }
        public clsLinea(int Xinicial, int Yinicial, int Xfinal, int Yfinal)
        {
            this.Xfinal = Xfinal;
            this.Yfinal = Yfinal;
            this.Xinicial = Xinicial;
            this.Yinicial = Yinicial;
        }
        public clsLinea(double Xinicial, double Yinicial, double Xfinal, double Yfinal)
        {
            this.Xfinal = (int) Xfinal;
            this.Yfinal = (int) Yfinal;
            this.Xinicial = (int) Xinicial;
            this.Yinicial = (int) Yinicial;
        }
        public int obtenXinicial()
        {
            return Xinicial;
        }

        public int obtenYinicial()
        {
            return Yinicial;
        }
        public int obtenXfinal()
        {
            return Xfinal;
        }
        public int obtenYfinal()
        {
            return Yfinal;
        }
        public void cambiarXinicial(int Xinicial)
        {
            this.Xinicial = Xinicial;
            
        }
        public void cambiarYinicial(int Yinicial)
        {
            this.Yinicial = Yinicial;

        }
        public void cambiarXfinal(int Xfinal)
        {
            this.Xfinal = Xfinal;

        }
        public void cambiarYfinal(int Yfinal)
        {
            this.Yfinal = Yfinal;

        }
        public static int obtenCuenta()
        {
            contar += 1;
            return contar;
        }
    }
   
}
