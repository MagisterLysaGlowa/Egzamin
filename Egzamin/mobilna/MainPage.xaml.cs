using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace mobilna
{
    public partial class MainPage : ContentPage
    {
        string[] quotes = { "Dzień dobry", "Good moring", "Buenos dias" };
        int currentQuote = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void Slider_Changed(object sender, ValueChangedEventArgs e)
        {
            int size = ((int)slider.Value);
            size_lbl.Text = $"Rozmiar: {size}";
            quote.FontSize = size;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            currentQuote = currentQuote > 1 ? 0 : currentQuote + 1;
            quote.Text = quotes[currentQuote];
        }
    }
}
