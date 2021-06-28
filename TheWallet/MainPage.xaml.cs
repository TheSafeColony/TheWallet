using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Rg.Plugins.Popup.Services;
using TheWallet.Views;
using Xamarin.Forms;

namespace TheWallet
{
    public partial class MainPage : ContentPage
    {
        public ICommand openwalletpressed { get; private set; }

        public MainPage()
        {
            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += (s, e) => {
                PopupNavigation.Instance.PushAsync(new keyview());


            };
            InitializeComponent();
            button1.GestureRecognizers.Add(tapGestureRecognizer);
            //openwalletpressed = new Command(async _ => await PopupNavigation.Instance.PushAsync(new keyview()));
        }
    }
}
