using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        double base_fig;
        double altura;
        double resp;
        private void BtnCalcularArea_Clicked(object sender, EventArgs e)
        {
            calcular();
        }

        private void btnCalcularArea_Clicked_1(object sender, EventArgs e)
        {
            calcular();
            txtAltura.Text = "";
            txtBase.Text = "";
        }
        private void calcular()
        {
            if (!string.IsNullOrEmpty(txtAltura.Text) || !string.IsNullOrEmpty(txtBase.Text))
            {

                if (txtBase.Text.Trim() == "." || txtBase.Text.Trim() == "-") {
                    DisplayAlert("Error", "Por favor colocque Números", "Ok");
                    txtBase.Text = "";
                }

                if (txtAltura.Text.Trim() == "-" || txtAltura.Text.Trim() == ".") {
                    DisplayAlert("Error", "Por favor colocque Números", "Ok");
                    txtAltura.Text = "";
                }

                base_fig = Convert.ToDouble(txtBase.Text);
                altura = Convert.ToDouble(txtAltura.Text);
               
                if(base_fig > 0 && altura > 0)
                {
                    resp = (base_fig * altura) / 2;
                    DisplayAlert("El área equivale a:", resp.ToString(), "Ok");
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

        private void btnHomePage_Clicked(object sender, EventArgs e)
        {
        }

        private void btnCalcularPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.CalcualrHipotenusa());
        }

        private void btnConvertPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.ConvertirGrados()); 
        }
    }
}
