using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Examen_Parcial_1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Numero.Text))
            {
                var numero = double.Parse(Numero.Text);

                var original = (numero / 10) - 4;
                Original.Text = original.ToString();
            }
            else
            {
                DisplayAlert("Datos erróneos",
                    "Por favor, llena toda la información", 
                    "Ok");
            }
            
        }
    }
}
