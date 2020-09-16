using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarin_lab3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterAndDetails : MasterDetailPage
    {
        public MasterAndDetails()
        {
            InitializeComponent();
            Master = masterPage;
            Detail = new NavigationPage(new ContactsPageCS());
        }
    }
}