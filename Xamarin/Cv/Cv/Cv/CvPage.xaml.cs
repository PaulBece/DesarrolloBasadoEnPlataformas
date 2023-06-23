using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cv
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CvPage : ContentPage
    {
        public CvPage(string nombre,string edad,string ocupa,string dire)
        {
            InitializeComponent();

            Label nombrelabel=this.FindByName<Label>("nombre");
            Label edadlabel = this.FindByName<Label>("edad");
            Label ocupalabel = this.FindByName<Label>("ocupa");
            Label direlabel = this.FindByName<Label>("dire");

            nombrelabel.Text = nombre;
            edadlabel.Text = edad;
            ocupalabel.Text = ocupa;
            direlabel.Text = dire;
        }
    }
}