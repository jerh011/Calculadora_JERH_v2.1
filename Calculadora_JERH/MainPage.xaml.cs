using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
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

        string cadena = "";

        public void Btn0(object sender, EventArgs e)
        {
            cadena += "0";
            Operacion.Text = cadena;
        }
        public void Btn1(object sender, EventArgs e)
        {
            cadena += "1";
            Operacion.Text = cadena;
        }
        public void Btn2(object sender, EventArgs e)
        {
            cadena += "2";
            Operacion.Text = cadena;
        }
        public void Btn3(object sender, EventArgs e)
        {
            cadena += "3";
            Operacion.Text = cadena;
        }
        public void Btn4(object sender, EventArgs e)
        {
            cadena += "4";
            Operacion.Text = cadena;
        }
        public void Btn5(object sender, EventArgs e)
        {
            cadena += "5";
            Operacion.Text = cadena;
        }
        public void Btn6(object sender, EventArgs e)
        {
            cadena += "6";
            Operacion.Text = cadena;
        }
        public void Btn7(object sender, EventArgs e)
        {
            cadena += "7";
            Operacion.Text = cadena;
        }
        public void Btn8(object sender, EventArgs e)
        {
            cadena += "8";
            Operacion.Text = cadena;
        }
        public void Btn9(object sender, EventArgs e)
        {
            cadena += "9";
            Operacion.Text = cadena;
        }
        public void BtnAc(object sender, EventArgs e)
        {
            cadena = "";
            Operacion.Text = cadena;
            respuesta.Text = cadena;
        }
        public void BtnPorcentaje(object sender, EventArgs e)
        {
        
        }
        public void BtnDiv(object sender, EventArgs e)
        {
            if (cadena == "")
                Operacion.Text = cadena;
            else if (cadena[cadena.Length - 1] != '/' && cadena[cadena.Length - 1] != 'x' && cadena[cadena.Length - 1] != '-' && cadena[cadena.Length - 1] != '+' && cadena[cadena.Length - 1] != '%' && cadena != "")
                cadena += "/";
            Operacion.Text = cadena;
        }
        public void BtnX(object sender, EventArgs e)
        {
            if (cadena == "")
                Operacion.Text = cadena;
            else if (cadena[cadena.Length - 1] != '/' && cadena[cadena.Length - 1] != 'x' && cadena[cadena.Length - 1] != '-' && cadena[cadena.Length - 1] != '+' && cadena[cadena.Length - 1] != '%' && cadena != "")
                cadena += "x";
            Operacion.Text = cadena;
        }
        public void BtnSuma(object sender, EventArgs e)
        {
            if (cadena == "")
                Operacion.Text = cadena;
            else if (cadena[cadena.Length - 1] != '/' && cadena[cadena.Length - 1] != 'x' && cadena[cadena.Length - 1] != '-' && cadena[cadena.Length - 1] != '+' && cadena[cadena.Length - 1] != '%')
                cadena += "+";

            Operacion.Text = cadena;
        }
        public void BtnPunto(object sender, EventArgs e)
        {
            cadena += ".";
            Operacion.Text = cadena;
        }
        public void BtnResta(object sender, EventArgs e)
        {
            if (cadena == "")
                Operacion.Text = cadena;
            else if (cadena[cadena.Length - 1] != '/' && cadena[cadena.Length - 1] != 'x' && cadena[cadena.Length - 1] != '-' && cadena[cadena.Length - 1] != '+' && cadena[cadena.Length - 1] != '%' && cadena != "")
                cadena += "-";
            Operacion.Text = cadena;
        }
        private void BtnBorrar(object sender, EventArgs e)
        {
            char[] caracteres = cadena.ToCharArray();
            if (caracteres.Length > 0)
            {
                Array.Resize(ref caracteres, caracteres.Length - 1);
            }
            cadena = new string(caracteres);
            Operacion.Text = cadena;
        }
        public void BtnResultado(object sender, EventArgs e)
        {

            Resultado();
        }

        public void Resultado()
        {
            string[] operadores = { "+", "-", "x", "/" };
            string[] elementos = cadena.Split(operadores, StringSplitOptions.RemoveEmptyEntries);
            string[] operadoresEnExpresion = cadena.Split(elementos, StringSplitOptions.RemoveEmptyEntries);

            double resultado = Convert.ToDouble(elementos[0]);

            for (int i = 0; i < operadoresEnExpresion.Length; i++)
            {
                double numero = Convert.ToDouble(elementos[i + 1]);
                string operador = operadoresEnExpresion[i];

                if (operador == "x") 
                {
                        resultado *= numero;
                        
                }
                else if (operador == "/") 
                {
                    if (numero == 0)
                    {
                        Operacion.Text = "No se puede dividir por cero.";
                        respuesta.Text = "No se puede dividir por cero.";
                    }
                    resultado /= numero;
                   
                }
                else if (operador == "+")
                {
                    resultado += numero;
                }
                else if (operador == "-")
                {
                    resultado -= numero;

                }
              
                respuesta.Text = resultado.ToString();
            }
        }
    }
}

