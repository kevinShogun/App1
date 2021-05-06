using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.View {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConvertirGrados : ContentPage {
        public ConvertirGrados() {
            InitializeComponent();
        }

        double resp;
        double grados;
        private void btnGrados_Clicked(object sender, EventArgs e) {
            calcular();
            txtGrados.Text = "";
        }

        private void calcular() {
            if (!string.IsNullOrEmpty(txtGrados.Text)) {
                
                if(txtGrados.Text.Trim() == ".") {
                    DisplayAlert("Error", "Por favor colocque Números", "Ok");
                }

                if (txtGrados.Text.Trim() == "-") {
                    DisplayAlert("Error", "Por favor colocque Números", "Ok");
                }

                grados = Convert.ToDouble(txtGrados.Text);

                resp = (grados - 32) * 5 / 9;

                DisplayAlert("La Cantidad de Grados Centigrados son: ", resp.ToString(), "Ok");
            }
            else {
                DisplayAlert("Error", "Campos Vacios", "Ok");
            }
        }
    }
}