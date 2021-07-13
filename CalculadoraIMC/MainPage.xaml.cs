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

        private void Button_Clicked(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(altura.Text) && !string.IsNullOrEmpty(peso.Text))
            {
                var a = double.Parse(altura.Text);

                var p = double.Parse(peso.Text);

                var imc = p / (a * a);

                IMC.Text = imc.ToString();

                String resultado = "";

                if (imc < 18.5)
                {
                    resultado = "Tienes bajo peso";

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
                    resultado = "Tienes obesidad, debes ¡¡cuidarte!!";
                }

                DisplayAlert("Resultado", resultado, "OK");
            }
            else
            {
                DisplayAlert("Datos erroneos o faltantes","Por favor llenar todos los campos","OK");
            }

            
        }
    }
}
