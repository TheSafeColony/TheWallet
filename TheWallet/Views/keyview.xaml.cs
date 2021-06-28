using System;
using System.Collections.Generic;
using Rg.Plugins.Popup.Services;
using Rg.Plugins.Popup.Pages;
using Xamarin.Forms;
using System.Windows.Input;

namespace TheWallet.Views
{
    public partial class keyview : PopupPage
    {
        public ICommand openwalletpressed { get; private set; }

        public keyview()
        {
            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += (s, e) => {
                //PopupNavigation.Instance.PushAsync(new keyview());
                Application.Current.MainPage = new WalletPage();
                PopupNavigation.Instance.PopAsync();
            };
            InitializeComponent();
            button1.GestureRecognizers.Add(tapGestureRecognizer);

        }
        private async void OnClose(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PopAsync();
        }
    }
}
