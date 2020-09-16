using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarin_lab2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();

            switch (Device.RuntimePlatform)
            {
                case Device.Android:
                    ProfilePic.Source = ImageSource.FromFile("obito.png");
                    break;
                case Device.iOS:
                    ProfilePic.Source = ImageSource.FromFile("Image/obito.png");
                    break;
            }
            
        }

        private void OnClickRegister(object sender, EventArgs e)
        {
            string email, phone;
            email = EmailEntry.Text;
            phone = PhoneEntry.Text;

            DisplayAlert("Your Info", $"your email is: {email} , your phone: is {phone}",
                "OK", "Cancel");
        }
    }
}