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

        string cadena = "";
        string cadena2 = "";
        int operacopmes = 0;
        int suma = 0;
        int resta = 0;
        int divicion = 0;
        int multiplicacion = 0;

        char[] operadorArray ;
        string[] numeros; 
        int[] posiscion;
        string[] reposiscion;

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
        public void Btn4(object sender, EventArgs e) {
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
            cadena="";
            Operacion.Text = cadena;
        }
        public void BtnPorcentaje(object sender, EventArgs e)
        {
            if (cadena == "")
                Operacion.Text = cadena;
            else if (cadena[cadena.Length - 1] != '/' && cadena[cadena.Length - 1] != 'x' && cadena[cadena.Length - 1] != '-' && cadena[cadena.Length - 1] != '+' && cadena[cadena.Length - 1] != '%' && cadena != "")
                cadena += "%";
            Operacion.Text = cadena;
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
            if(cadena == "")
                Operacion.Text = cadena;
            else  if (cadena[cadena.Length - 1] != '/' && cadena[cadena.Length - 1] != 'x' && cadena[cadena.Length - 1] != '-' && cadena[cadena.Length - 1] != '+' && cadena[cadena.Length - 1] != '%')
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
            else if (cadena[cadena.Length-1]!='/'&& cadena[cadena.Length - 1] != 'x' && cadena[cadena.Length - 1] != '-' && cadena[cadena.Length - 1] != '+' && cadena[cadena.Length - 1] != '%' && cadena != "")
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
            Contadores();
            Resultado.Text = Convert.ToString(operacopmes);
            operacopmes = 0;
        }
        private void Contadores()
        {
                for (int i = 0; i < cadena.Length; i++)
                {
                    if (cadena[i] == '+')
                        suma++;
                    else if (cadena[i] == '-')
                        resta++;
                    else if (cadena[i] == '/')
                        divicion++;
                    else if (cadena[i] == 'x')
                        multiplicacion++;
                }
            operacopmes=suma+resta+divicion+multiplicacion;
            Separador(operacopmes/*, suma, resta, divicion, multiplicacion*/);
            reposiscionamiento();
          //Operaciones();

            suma =0;
            resta=0;
            divicion = 0; 
           multiplicacion = 0;
        }
      
        public void Separador(int operacopmes/*, int suma, int resta, int divicion, int multiplicacion*/)
        {
            operadorArray = new char[operacopmes];
            numeros = new string[operacopmes + 1];
            posiscion = new int[operacopmes];

           
            int x = 0;
            for (int i = 0; i < cadena.Length; i++) 
            if (cadena2[i] == '%' || cadena2[i] == '/' || cadena2[i] == 'x' || cadena2[i] == '-' || cadena2[i] == '+')
            {
                operadorArray[x] = cadena[i];
                posiscion[x]=i;
                x++;
            }
            for (int y = 0; y < numeros.Length; y++)
            {
                if (y == numeros.Length - 1)
                    numeros[y] =cadena2.Substring(posiscion[y - 1] + 1, (cadena2.Length - 1) - posiscion[y - 1]);
                else if (y == 0)//incio
                    numeros[y] = cadena.Substring(y, posiscion[y]);
                else if (y != numeros.Length && y != 0)
                    numeros[y] = cadena.Substring(posiscion[y - 1] + 1, posiscion[y] - posiscion[y - 1] - 1);
            }
           
            

        }
        public void reposiscionamiento()
        {
            reposiscion = new string[(operacopmes * 2) + 1];
            //numeros
            //posiscion
            int X = 0;
            for (int i = 0; i < numeros.Length; i++)
            {

                reposiscion[X] = numeros[i];
                if (i < operadorArray.Length)
                {
                    X++;
                    reposiscion[X] = Convert.ToString(operadorArray[i]);
                }

                X++;
            }

        }
            public void Operaciones() {
          
            }
    }
}
