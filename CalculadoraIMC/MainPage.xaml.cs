using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalculadoraIMC
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Button_Click(System.Object sender, System.EventArgs e)
        {
            if(!string.IsNullOrEmpty(Altura.Text) && !string.IsNullOrEmpty(Peso.Text))
            {
                var altura = double.Parse(Altura.Text);
                var peso = double.Parse(Peso.Text);
                var imc = peso / (altura * altura);
                IMC.Text = imc.ToString();

                string resultado = "";

                if (imc < 18.5)
                {
                    resultado = "El peso que tienes es bajo";
                }
                else if (imc >= 18.5 && imc <= 24.9)
                {
                    resultado = "Tu peso es normal";
                }
                else if (imc >= 25 && imc <= 29.9)
                {
                    resultado = "Tienes sobrepeso";
                }
                else
                {
                    resultado = "Tienes sobrepeso";
                }

                DisplayAlert("Resultado", resultado, "OK");
            }
            else
            {
                DisplayAlert("Error", "Rellena los campos", "OK");
            }
        }
    }
}

