using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalcualrHipotenusa : ContentPage
    {
        public CalcualrHipotenusa()
        {
            InitializeComponent();
        }

        double ladoA;
        double ladoB;
        double hipotenusa;
        private void btnCalcularHip_Clicked(object sender, EventArgs e)
        {
            calcular();
            txtLadoB.Text = "";
            txtLadoC.Text = "";
        }
        private void calcular()
        {
            if(!string.IsNullOrEmpty(txtLadoB.Text) || !string.IsNullOrEmpty(txtLadoC.Text))
            {
                ladoA = Convert.ToDouble(txtLadoB.Text);
                ladoB = Convert.ToDouble(txtLadoC.Text);

                if (ladoA >= 1 && ladoB >= 1)
                {
                    ladoA *= ladoA;
                    ladoB *= ladoB;

                    hipotenusa = ladoA + ladoB;

                    hipotenusa = Math.Sqrt(hipotenusa);
                    DisplayAlert("La Hipotenusa Equivale a:", hipotenusa.ToString(), "Ok");
                }
                else
                {
                    DisplayAlert("Error", "Los datos Invalidos", "Aceptar");
                }
            }
            else
            {
                DisplayAlert("Error", "Campos Vacios", "Aceptar");
            }
        }
    }
}