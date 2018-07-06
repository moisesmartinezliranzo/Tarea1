using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tarea1
{
	public partial class MainPage : ContentPage
	{
        int counter = 0;

        public MainPage()
		{
			InitializeComponent();
            label.Text = "Hola, haz hecho " + counter + " click";
        }

        void OnButtonClicked(object sender, EventArgs args)
        {
            counter++;
            label.Text = "Hola, haz hecho " + counter + " click";
        } 
    }
}
