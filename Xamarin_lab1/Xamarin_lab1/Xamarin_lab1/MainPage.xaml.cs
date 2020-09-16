using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xamarin_lab1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            myBox.Opacity = 0;
            colorList.IsEnabled = false;
            op.IsEnabled = false;

        }

        private void changeBoxViewColor(object sender, SelectedItemChangedEventArgs e)
        {
            string color = (sender as ListView).SelectedItem.ToString();

            switch(color)
            {
                case "Aqua":
                    myBox.Color = Color.Aqua;
                    break;
                case "Blue":
                    myBox.Color = Color.Blue;
                    break;
                case "Green":
                    myBox.Color = Color.Green;
                    break;

            } 
        }

        private void OnToggled(object sender, ToggledEventArgs e)
        {
            bool Toggled = (sender as Switch).IsToggled;

            if (Toggled) 
            {
                myBox.Opacity = op.Value;
                colorList.IsEnabled = true;
                op.IsEnabled = true;
            } 
            else
            {
                myBox.Opacity = 0;
                colorList.IsEnabled = false;
                op.IsEnabled = false;
            }
        }

        private void OnValueChanged(object sender, ValueChangedEventArgs e)
        {
            double value = e.NewValue;
            sliderValue.Text = String.Format("Your value is : {0}", value);
        }


        private void OnValueChangedChangeOpacity(object sender, ValueChangedEventArgs e)
        {
            myBox.Opacity = e.NewValue;
            myBoxOpacity.Text = String.Format("Opacity : {0}", myBox.Opacity);
        }
    }
}
