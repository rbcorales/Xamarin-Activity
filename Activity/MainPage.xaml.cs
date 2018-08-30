using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Activity
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void Button_Clicked_0(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Exercise1());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Exercise2());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Exercise3());
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Exercise4());
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Exercise5());
        }

    }
}
