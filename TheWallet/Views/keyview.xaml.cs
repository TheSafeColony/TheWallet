using System;
using Chaos.NaCl;
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
            string PublicKey;
            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += (s, e) => {
                if (String.IsNullOrEmpty(TextInput2.Text) == false)
                {
                    try
                    {
                        PublicKey = Base58Check.Base58CheckEncoding.EncodePlain(Ed25519.PublicKeyFromSeed(Base58Check.Base58CheckEncoding.DecodePlain(TextInput2.Text)));
                        Application.Current.MainPage = new WalletPage(PublicKey, TextInput2.Text);
                        PopupNavigation.Instance.PopAsync();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                        Application.Current.MainPage.DisplayAlert("ERROR", "Invalid Key entered", "OK");

                    }
                }
                else
                {
                    Application.Current.MainPage.DisplayAlert("ERROR", "Value Cannot be nothing", "OK");

                }

                
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
