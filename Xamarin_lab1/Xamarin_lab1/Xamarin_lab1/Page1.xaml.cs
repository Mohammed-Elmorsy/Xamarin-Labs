using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_lab1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private async void onBtnClick(object sender, EventArgs e)
        {
            string name, phoneNumber, mode;
            name = NameEntry.Text;
            phoneNumber = PhoneEntry.Text;
            mode = ModeEntry.Text;

            bool DisplayResult = await DisplayAlert("Your Information",
                "Do you want to read your information ?",
                "OK", "Cancel");

            if (DisplayResult)
            {
                await DisplayAlert("your information",
                            $"your name is: {name} , your phone number is: {phoneNumber} , your mode is:{mode}",
                            "OK");
            }
            else
            {
                await DisplayAlert("access denied", "It seems that you don't want to read your information",
                "OK");
            }

        }

        private async void onClick(object sender, EventArgs e)
        {
            string name, phoneNumber, mode;
            name = NameEntry.Text;
            phoneNumber = PhoneEntry.Text;
            mode = ModeEntry.Text;
            string result = await DisplayActionSheet("your info","Cancel",null
                                                        ,"read my name","read my phone", "read my mode");

            switch (result)
            {
                case "read my name":
                    await DisplayAlert("your information", $"your name is: {name}", "OK");
                    break;
                case "read my phone":
                    await DisplayAlert("your information", $"your phone is: {phoneNumber}", "OK");
                    break;
                case "read my mode":
                    await DisplayAlert("your information", $"your mode is: {mode}", "OK");
                    break;

                default:
                    break;

            }
        }
    }
}