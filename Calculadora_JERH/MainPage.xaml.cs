using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculadora_JERH
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        string cadena="";


        public void Btn0(object sender, EventArgs e)
        {
            cadena += "0";
        }
        public void Btn1(object sender, EventArgs e)
        {
            cadena += "1";
        }
        public void Btn2(object sender, EventArgs e)
        {
            cadena += "2";
        }
        public void Btn3(object sender, EventArgs e)
        {
            cadena += "3";
        }
        public void Btn4(object sender, EventArgs e) {
            cadena += "4";
        }
        public void Btn5(object sender, EventArgs e)
        {
            cadena += "5";
        }
        public void Btn6(object sender, EventArgs e)
        {
            cadena += "6";
        }
        public void Btn7(object sender, EventArgs e)
        {
            cadena += "7";
        }
        public void Btn8(object sender, EventArgs e)
        {
            cadena += "8";
        }
        public void Btn9(object sender, EventArgs e)
        {
            cadena += "9";
        }
        public void BtnAc(object sender, EventArgs e)
        {
            cadena="";
        }
        public void BtnPorcentaje(object sender, EventArgs e)
        {
            cadena += "%";
        }
        public void BtnDiv(object sender, EventArgs e)
        {
            cadena += "/";
        }
        public void BtnX(object sender, EventArgs e)
        {
            cadena += "X";
        }
      
        public void BtnSuma(object sender, EventArgs e)
        {
            cadena += "+";
        }
        public void BtnResultado(object sender, EventArgs e)
        {
            cadena += "=";
        }
        public void BtnPunto(object sender, EventArgs e)
        {
            cadena += ".";
        }
        public void BtnResta(object sender, EventArgs e)
        {
            cadena += "-";
        }


    }
}
