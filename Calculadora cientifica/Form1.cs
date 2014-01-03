using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_cientifica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Delcraramos las variables
        bool igual = true, inicio = true, operacion1 = true, operacion2 = true;
        double a, b, c, memoria = 0, resultado, valor1, valor2;
        string funciones, tipoOperaciones;

        //Botones numericos
        private void Button_N1_Click(object sender, EventArgs e)
        {
            //Codicion para la variable inicio
            if (inicio)
            {
                TextBox_Principal.Text = "";
                TextBox_Principal.Text = "1";
                inicio = false;
            }
            else
            {
                TextBox_Principal.Text = TextBox_Principal.Text + "1";
            }
        }

        private void Bottun_N2_Click(object sender, EventArgs e)
        {
            //Codicion para la variable inicio
            if (inicio)
            {
                TextBox_Principal.Text = "";
                TextBox_Principal.Text = "2";
                inicio = false;
            }
            else
            {
                TextBox_Principal.Text = TextBox_Principal.Text + "2";
            }
        }

        private void Bottun_N3_Click(object sender, EventArgs e)
        {
            //Codicion para la variable inicio
            if (inicio)
            {
                TextBox_Principal.Text = "";
                TextBox_Principal.Text = "3";
                inicio = false;
            }
            else
            {
                TextBox_Principal.Text = TextBox_Principal.Text + "3";
            }
        }

        private void Bottun_N4_Click(object sender, EventArgs e)
        {
            //Codicion para la variable inicio
            if (inicio)
            {
                TextBox_Principal.Text = "";
                TextBox_Principal.Text = "4";
                inicio = false;
            }
            else
            {
                TextBox_Principal.Text = TextBox_Principal.Text + "4";
            }
        }

        private void Bottun_N5_Click(object sender, EventArgs e)
        {
            //Codicion para la variable inicio
            if (inicio)
            {
                TextBox_Principal.Text = "";
                TextBox_Principal.Text = "5";
                inicio = false;
            }
            else
            {
                TextBox_Principal.Text = TextBox_Principal.Text + "5";
            }
        }

        private void Bottun_N6_Click(object sender, EventArgs e)
        {
            //Codicion para la variable inicio
            if (inicio)
            {
                TextBox_Principal.Text = "";
                TextBox_Principal.Text = "6";
                inicio = false;
            }
            else
            {
                TextBox_Principal.Text = TextBox_Principal.Text + "6";
            }
        }

        private void Bottun_N7_Click(object sender, EventArgs e)
        {
            //Codicion para la variable inicio
            if (inicio)
            {
                TextBox_Principal.Text = "";
                TextBox_Principal.Text = "7";
                inicio = false;
            }
            else
            {
                TextBox_Principal.Text = TextBox_Principal.Text + "7";
            }
        }

        private void Bottun_N8_Click(object sender, EventArgs e)
        {
            //Codicion para la variable inicio
            if (inicio)
            {
                TextBox_Principal.Text = "";
                TextBox_Principal.Text = "8";
                inicio = false;
            }
            else
            {
                TextBox_Principal.Text = TextBox_Principal.Text + "8";
            }
        }

        private void Bottun_N9_Click(object sender, EventArgs e)
        {
            //Codicion para la variable inicio
            if (inicio)
            {
                TextBox_Principal.Text = "";
                TextBox_Principal.Text = "9";
                inicio = false;
            }
            else
            {
                TextBox_Principal.Text = TextBox_Principal.Text + "9";
            }
        }

        private void Button_N0_Click(object sender, EventArgs e)
        {
            //Codicion para la variable inicio
            if (inicio)
            {
                TextBox_Principal.Text = "";
                TextBox_Principal.Text = "0";
                inicio = false;
            }
            else
            {
                TextBox_Principal.Text = TextBox_Principal.Text + "0";
            }
        }
        //Botón punto decimal 
        private void Button_Decimal_Click(object sender, EventArgs e)
        {
            //Contains devuelve un valor que indica si el punto especificado aparece dentro de esta cadena
            if (TextBox_Principal.Text.Contains("."))
            {

            }
            else
            {
                TextBox_Principal.Text = TextBox_Principal.Text + ".";
                inicio = false;
            }
        }
        //Botón de la función de  suma
        private void Button_Suma_Click(object sender, EventArgs e)
        {
            igual = true;
            inicio = true;
            //Condición para la variable opereacion1 
            if (operacion1)
            {
                valor1 = Convert.ToDouble(TextBox_Principal.Text);
                TextBox_Previo.Text = "";
                TextBox_Previo.Text = TextBox_Previo.Text + TextBox_Principal.Text + "+";
                operacion1 = false;
            }
            else
            {
                //Condición para la variable opereacion2
                if (operacion2)
                {
                    valor2 = Convert.ToDouble(TextBox_Principal.Text);
                    TextBox_Previo.Text = TextBox_Previo.Text + TextBox_Principal.Text + "+";
                    operacion2 = false;
                }
                else
                {
                    TextBox_Previo.Text = TextBox_Previo.Text + TextBox_Principal.Text + "+";
                    Operaciones(resultado, valor2);
                }
            }
            tipoOperaciones = "+";
        }
        //Botón de la función de  resta
        private void Button_Resta_Click(object sender, EventArgs e)
        {
            igual = true;
            inicio = true;
            //Condición para la variable opereacion1 
            if (operacion1)
            {
                valor1 = Convert.ToDouble(TextBox_Principal.Text);
                TextBox_Previo.Text = "";
                TextBox_Previo.Text = TextBox_Previo.Text + TextBox_Principal.Text + "-";
                operacion1 = false;
            }
            else
            {
                //Condición para la variable opereacion2
                if (operacion2)
                {
                    valor2 = Convert.ToDouble(TextBox_Principal.Text);
                    TextBox_Previo.Text = TextBox_Previo.Text + TextBox_Principal.Text + "-";
                    operacion2 = false;
                }
                else
                {
                    TextBox_Previo.Text = TextBox_Previo.Text + TextBox_Principal.Text + "-";
                    Operaciones(resultado, valor2);
                }
            }
            tipoOperaciones = "-";
        }
        //Botón de la función de  multiplicar
        private void Button_Multiplicacion_Click(object sender, EventArgs e)
        {
            igual = true;
            inicio = true;
            //Condición para la variable opereacion1 
            if (operacion1)
            {
                valor1 = Convert.ToDouble(TextBox_Principal.Text);
                TextBox_Previo.Text = "";
                TextBox_Previo.Text = TextBox_Previo.Text + TextBox_Principal.Text + "*";
                operacion1 = false;
            }
            else
            {
                //Condición para la variable opereacion2
                if (operacion2)
                {
                    valor2 = Convert.ToDouble(TextBox_Principal.Text);
                    TextBox_Previo.Text = TextBox_Previo.Text + TextBox_Principal.Text + "*";
                    operacion2 = false;
                }
                else
                {
                    TextBox_Previo.Text = TextBox_Previo.Text + TextBox_Principal.Text + "*";
                    Operaciones(resultado, valor2);
                }
            }
            tipoOperaciones = "*";
        }
        //Botón  de la función de dividir
        private void Button_Division_Click(object sender, EventArgs e)
        {
            igual = true;
            inicio = true;
            //Condición para la variable opereacion1 
            if (operacion1)
            {
                valor1 = Convert.ToDouble(TextBox_Principal.Text);
                TextBox_Previo.Text = "";
                TextBox_Previo.Text = TextBox_Previo.Text + TextBox_Principal.Text + "/";
                operacion1 = false;
            }
            else
            {
                //Condición para la variable opereacion2
                if (operacion2)
                {
                    valor2 = Convert.ToDouble(TextBox_Principal.Text);
                    TextBox_Previo.Text = TextBox_Previo.Text + TextBox_Principal.Text + "/";
                    operacion2 = false;
                }
                else
                {
                    TextBox_Previo.Text = TextBox_Previo.Text + TextBox_Principal.Text + "/";
                    Operaciones(resultado, valor2);
                }
            }
            tipoOperaciones = "/";
        }
        //Método con las operaciones de + - * / 
        private void Operaciones(double valor1, double valor2)
        {
            //Switch que evalúa la variable tipoOperacines
            switch (tipoOperaciones)
            {
                //Case de la SUMA 
                case "+":
                    resultado = valor1 + valor2;
                   TextBox_Principal.Text = resultado.ToString();
                    valor1 = Convert.ToDouble(TextBox_Principal.Text);
                    break;

                     //Case de la RESTA 
                case "-":
                    resultado = valor1 - valor2;
                   TextBox_Principal.Text = resultado.ToString();
                    valor1 = Convert.ToDouble(TextBox_Principal.Text);
                    break;

                //Case de la MULTIPLICAR 
                case "*":
                    resultado = valor1 * valor2;
                    TextBox_Principal.Text = resultado.ToString();
                    valor1 = Convert.ToDouble(TextBox_Principal.Text);
                    break;

                //Case de la RESTA 
                case "/":
                    if (valor2 == 0)
                    {
                        TextBox_Principal.Text = "Error";
                        break;
                    }
                    else
                    {
                        resultado = valor1 / valor2;
                        TextBox_Principal.Text = resultado.ToString();
                        valor1 = Convert.ToDouble(TextBox_Principal.Text);
                        break;
                    }
                //Case de la función que saca la potencia de un número
                case "potencia":
                    resultado = Math.Pow(valor1, valor2);
                    TextBox_Principal.Text = resultado.ToString();
                    break;
                //Case de la función que saca la raíz x de un número
                case "raizx":
                    if (valor2 <= 0)
                    {
                        TextBox_Principal.Text = "Error";
                        break;
                    }
                    else
                    {
                        TextBox_Previo.Text = valor2 + " " + TextBox_Previo.Text;
                        TextBox_Previo.Text = TextBox_Previo.Text.Remove(TextBox_Previo.Text.Count() - TextBox_Principal.Text.Count());
                        a = 1;
                        c = a / valor2;
                        TextBox_Principal.Text = Math.Pow(valor1, c).ToString();
                        break;
                    }
            }
        }
        //Botón  de la función de igual
        private void Button_gual_Click(object sender, EventArgs e)
        {
            inicio = true;
            operacion1 = true;
            if (igual)
            {
                if (tipoOperaciones == null)
                {

                }
                else
                {
                    valor2 = Convert.ToDouble(TextBox_Principal.Text);
                    TextBox_Previo.Text = TextBox_Previo.Text + TextBox_Principal.Text;
                    Operaciones(valor1, valor2);
                    igual = false;
                }
            }
        }
        //Botón con la función de RAIZ CUADRADA
        private void Button_RaizCuadrada_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(TextBox_Principal.Text);
            if (valor1 >= 0)
            {
                TextBox_Previo.Text = "sqrt( " + valor1 + " )";
                TextBox_Principal.Text = Convert.ToString(Math.Sqrt(valor1));
            }
            else
            {
                TextBox_Principal.Text = "Error";
            }
        }
        //Botón con la función de PORCENTAJE
        private void Button_Porcentaje_Click(object sender, EventArgs e)
        {
            valor2 = Convert.ToDouble(TextBox_Principal.Text);
            TextBox_Previo.Text = TextBox_Previo.Text + TextBox_Principal.Text;
            TextBox_Principal.Text = Convert.ToString((valor1 * valor2) / 100);
            igual = true;
        }
        //Botón que realiza la operacion inversa 1/x
        private void Button_1x_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(TextBox_Principal.Text);
            TextBox_Previo.Text = "reciproc( " + valor1.ToString() + " )";
            TextBox_Principal.Text = Convert.ToString(1 / valor1);
        }
        //Botón con la función de C
        private void Button_C_Click(object sender, EventArgs e)
        {
            TextBox_Principal.Text = "0";
            TextBox_Previo.Text = "";
            inicio = true;
            funciones = "";
            operacion1 = true;
            operacion2 = true;
            igual = true;
            valor1 = 0;
            valor2 = 0;
            resultado = 0;
        }
        //Botón con la función de CE
        private void Button_CE_Click(object sender, EventArgs e)
        {
            TextBox_Previo.Text = "";
            TextBox_Principal.Text = "0";
            inicio = true;
            funciones = "";
        }
        //Botón con la función de RETROCEDER
        private void Button_Retroceso_Click(object sender, EventArgs e)
        {
            if (TextBox_Principal.Text.Length > 1)
            {
                TextBox_Principal.Text = TextBox_Principal.Text.Remove(TextBox_Principal.Text.Length - 1, 1);
                if (TextBox_Principal.Text.Length == 1)
                {
                    TextBox_Principal.Text = "0";
                    inicio = true;
                }
                if (TextBox_Principal.Text == "0")
                {
                    
                }
            }
        }
        //Botón con la función de cambio de SIGNO
        private void Button_Signo_Click(object sender, EventArgs e)
        {
            TextBox_Principal.Text = Convert.ToString(0 - Convert.ToDouble(TextBox_Principal.Text));
        }

        //Funciones Trigonométricas
        private void Trigonometria()
        {
            if (RadioButton_Sexages.Checked)
            {
                //Switch que evalúa la variable funciones
                switch (funciones)
                {
                    //Seno
                    case "sin":
                        valor1 = Convert.ToDouble(TextBox_Principal.Text);
                        TextBox_Previo.Text = " sin( " + valor1.ToString() + " )";
                        TextBox_Principal.Text = Convert.ToString(Math.Sin(Math.PI * (valor1) / 180));
                        break;
                    //Seno inverso
                    case "asin":
                        valor1 = Convert.ToDouble(TextBox_Principal.Text);
                        TextBox_Previo.Text = " asin( " + valor1.ToString() + " )";
                        TextBox_Principal.Text = Convert.ToString(Math.Asin(valor1) * 180 / Math.PI);
                        break;

                    //Coseno
                    case "cos":
                        valor1 = Convert.ToDouble(TextBox_Principal.Text);
                        TextBox_Previo.Text = " cos( " + valor1.ToString() + " )";
                        TextBox_Principal.Text = Convert.ToString(Math.Cos(Math.PI * (valor1) / 180));
                        break;
                    //coseno inverso
                    case "acos":
                        valor1 = Convert.ToDouble(TextBox_Principal.Text);
                        TextBox_Previo.Text = " acos( " + valor1.ToString() + " )";
                        TextBox_Principal.Text = Convert.ToString(Math.Acos(valor1) * 180 / Math.PI);
                        break;

                    //Tangente
                    case "tan":
                        valor1 = Convert.ToDouble(TextBox_Principal.Text);
                        TextBox_Previo.Text = " tan( " + valor1.ToString() + " )";
                        TextBox_Principal.Text = Convert.ToString(Math.Tan(Math.PI * (valor1) / 180));
                        break;
                    //Tangente inverso
                    case "atan":
                        valor1 = Convert.ToDouble(TextBox_Principal.Text);
                        TextBox_Previo.Text = " atan( " + valor1.ToString() + " )";
                        TextBox_Principal.Text = Convert.ToString(Math.Atan(valor1) * 180 / Math.PI);
                        break;
                }
            }
            else
            {
                if (RadioButton_Radianes.Checked)
                {
                    //Switch que evalúa la variable funciones
                    switch (funciones)
                    {
                        //Seno
                        case "sin":
                            valor1 = Convert.ToDouble(TextBox_Principal.Text);
                            TextBox_Previo.Text = " sinr( " + valor1.ToString() + " )";
                            TextBox_Principal.Text = Convert.ToString(Math.Sin(valor1));
                            break;
                        //Seno inverso
                        case "asin":
                            valor1 = Convert.ToDouble(TextBox_Principal.Text);
                            TextBox_Previo.Text = " asinr( " + valor1.ToString() + " )";
                            TextBox_Principal.Text = Convert.ToString(Math.Asin(valor1));
                            break;

                        //Coseno
                        case "cos":
                            valor1 = Convert.ToDouble(TextBox_Principal.Text);
                            TextBox_Previo.Text = " cosr( " + valor1.ToString() + " )";
                            TextBox_Principal.Text = Convert.ToString(Math.Cos(valor1));
                            break;
                        //coseno inverso
                        case "acos":
                            valor1 = Convert.ToDouble(TextBox_Principal.Text);
                            TextBox_Previo.Text = " acosr( " + valor1.ToString() + " )";
                            TextBox_Principal.Text = Convert.ToString(Math.Acos(valor1));
                            break;

                        //Tangente
                        case "tan":
                            valor1 = Convert.ToDouble(TextBox_Principal.Text);
                            TextBox_Previo.Text = " tanr( " + valor1.ToString() + " )";
                            TextBox_Principal.Text = Convert.ToString(Math.Tan(valor1));
                            break;
                        //Tangente inverso
                        case "atan":
                            valor1 = Convert.ToDouble(TextBox_Principal.Text);
                            TextBox_Previo.Text = " atanr( " + valor1.ToString() + " )";
                            TextBox_Principal.Text = Convert.ToString(Math.Atan(valor1));
                            break;
                    }
                }
            }
        }
        //Botón seno
        private void Button_sin_Click(object sender, EventArgs e)
        {
            funciones = "sin";
            Trigonometria();
        }
        //Botón coseno
        private void Button_Cos_Click(object sender, EventArgs e)
        {
            funciones = "cos";
            Trigonometria();
        }
        //Botón tangente
        private void Button_Tan_Click(object sender, EventArgs e)
        {
            funciones = "tan";
            Trigonometria();
        }
        //Botón seno inverso
        private void Button_Asin_Click(object sender, EventArgs e)
        {
            funciones = "asin";
            Trigonometria();
        }
        //Botón coseno inverso
        private void Button_Acos_Click(object sender, EventArgs e)
        {
            funciones = "acos";
            Trigonometria();
        }
        //Botón tangente inverso
        private void Button_Atan_Click(object sender, EventArgs e)
        {
            funciones = "atan";
            Trigonometria();
        }
        //Botón que devuelve el valor de Pi
        private void BtnPi_Click(object sender, EventArgs e)
        {
            TextBox_Previo.Text = "";
            TextBox_Principal.Text = Math.PI.ToString();
        }
        //Botón que eleva a x a la -1
        private void Button_Xmenos1_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(TextBox_Principal.Text);
            TextBox_Previo.Text = valor1.ToString() + " ^ -1";
            TextBox_Principal.Text = Math.Pow(valor1, -1).ToString();
        }
        //Botón que eleva un numero a x Potencia
        private void Button_Exponente_Click(object sender, EventArgs e)
        {
            inicio = true;
            valor1 = Convert.ToDouble(TextBox_Principal.Text);
            TextBox_Previo.Text = valor1.ToString() + " ^";
            tipoOperaciones = "potencia";
            operacion1 = false;
            igual = true;
        }
        //Botón que devuelve el valor de e
        private void Btne_Click(object sender, EventArgs e)
        {
            TextBox_Previo.Text = "";
            TextBox_Principal.Text = Convert.ToString(Math.E);
        }
        //Botón que saca la raiz x de un numero
        private void Button_RaizX_Click(object sender, EventArgs e)
        {
            inicio = true;
            valor1 = Convert.ToDouble(TextBox_Principal.Text);
            TextBox_Previo.Text = " √ " + valor1;
            tipoOperaciones = "raizx";
            operacion1 = false;
            igual = true;
        }
        //Botón que eleva a x al cubo
        private void Button_Cubo_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(TextBox_Principal.Text);
            TextBox_Previo.Text = " cube( " + valor1.ToString() + " )";
            TextBox_Principal.Text = Math.Pow(valor1, 3).ToString();
        }
        //Botón que devuelve el factorial de un numero
        private void Button_Factorial_Click(object sender, EventArgs e)
        {
            a = 1;
            valor1 = Convert.ToDouble(TextBox_Principal.Text);
            TextBox_Previo.Text = "fact( " + valor1.ToString() + " )";
            for (b = 1; b <= valor1; b++)
            {
                a = a * b;
            }
            TextBox_Principal.Text = Convert.ToString(a);
        }
        //Botón de la raíz cubica
        private void Button_RaizCubica_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(TextBox_Principal.Text);
            a = 1;
            b = 3;
            c = a / b;
            TextBox_Principal.Text = Math.Pow(valor1, c).ToString();
            TextBox_Previo.Text = "cuberoot( " + valor1.ToString() + " )";
        }
        //Botón eleva a x al cuadrado
        private void Button_Cuadrado_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(TextBox_Principal.Text);
            TextBox_Previo.Text = " sqr( " + valor1.ToString() + " )";
            TextBox_Principal.Text = Math.Pow(valor1, 2).ToString();
        }
        //Botón que eleva 10 a la x potencia
        private void Button_10levarX_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(TextBox_Principal.Text);
            TextBox_Previo.Text = "powten( " + valor1.ToString() + " )";
            TextBox_Principal.Text = Convert.ToString(Math.Pow(10, valor1));
        }
        //Botón de la exponenciación neperiana
        private void Button_EXP_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(TextBox_Principal.Text);
            TextBox_Principal.Text = Convert.ToString(Math.Exp(valor1));
        }
        //Botón del logaritmo neperiano
        private void Button_log_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(TextBox_Principal.Text);
            TextBox_Previo.Text = "log( " + valor1.ToString() + " )";
            TextBox_Principal.Text = Convert.ToString(Math.Log10(valor1));
        }
        //Botón con la función MC
        private void Button_MC_Click(object sender, EventArgs e)
        {
            memoria = 0;
            Label_Memoria.Visible = false;
        }
        //Botón con la función MR
        private void Button_MR_Click(object sender, EventArgs e)
        {
            TextBox_Principal.Text = memoria.ToString();
        }
        //Botón con la función MS
        private void BtnMS_Click(object sender, EventArgs e)
        {
            memoria = Convert.ToDouble(TextBox_Principal.Text);
            Label_Memoria.Visible = true;
        }
        //Botón con la función M+
        private void Button_Mmas_Click(object sender, EventArgs e)
        {
            memoria = memoria + Convert.ToDouble(TextBox_Principal.Text);
            Label_Memoria.Visible = true;
        }
        //Botón con la función M-
        private void Button_Mmenos_Click(object sender, EventArgs e)
        {
            memoria = memoria - Convert.ToDouble(TextBox_Principal.Text);
            Label_Memoria.Visible = true;
        }
    }
}
