using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ventana2 : ContentPage
    {
        public Ventana2(string user, string pass)
        {
            InitializeComponent();

            string usuario = lblUser.Text;
            lblUser.Text = usuario + user;
        }
    }
}