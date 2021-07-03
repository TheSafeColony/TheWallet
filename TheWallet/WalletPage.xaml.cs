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
    public partial class WalletPage : ContentPage
    {
        
        public WalletPage(string PubKey, string PrivKey)
        {
            var tapGestureRecognizer = new TapGestureRecognizer();
            var SendTxsGesture = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += (s, e) => {
                Application.Current.MainPage = new TxsPage(PubKey,PrivKey);
            };
            SendTxsGesture.Tapped += (s, e) => {
                Credits.SendTransaction(0, 0, PubKey, PrivKey, "2KKw6TRcwfsAw1DG3D9hCrrnAqZmaUrFfTiamZMPVGdE");
            };
            InitializeComponent();
            txsbutton.GestureRecognizers.Add(tapGestureRecognizer);
            Send_Button.GestureRecognizers.Add(SendTxsGesture);
            BalanceText.Text = "Current Balance: "+Credits.balance(PubKey);


        }
    }
}
