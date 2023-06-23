using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Cv
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            string labelnombre = this.FindByName<Entry>("nombre").Text;
            string labeledad = this.FindByName<Entry>("edad").Text;
            string labelocupa = this.FindByName<Entry>("ocupa").Text;
            string labeldire = this.FindByName<Entry>("dire").Text;

            await Navigation.PushAsync(new CvPage(labelnombre,labeledad,labelocupa,labeldire));
        }
    }
}
