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
        
        public WalletPage(string PubKey)
        {
            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += (s, e) => {
                Application.Current.MainPage = new TxsPage(PubKey);
            };
            InitializeComponent();
            Console.WriteLine(PubKey);
            txsbutton.GestureRecognizers.Add(tapGestureRecognizer);
            BalanceText.Text = "Current Balance: "+Credits.balance(PubKey);


        }
    }
}
