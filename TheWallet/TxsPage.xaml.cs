using System;
using System.Collections.Generic;
using TheWallet.Models;
using Xamarin.Forms;
using Base58Check;

namespace TheWallet
{
    public partial class TxsPage : ContentPage
    {
        public TxsPage()
        {
            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += (s, e) => {
                //PopupNavigation.Instance.PushAsync(new keyview());
                Application.Current.MainPage = new WalletPage();
                
            };
            InitializeComponent();
            var Testsource = new List<HistoryModel>()
            {
                new HistoryModel(){ publicKey= "Hello", amount="1.0", txsid="5000.2"},
                new HistoryModel(){ publicKey= "Hello", amount="12.0", txsid="5000.2"},
                new HistoryModel(){ publicKey= "Hello", amount="13.0", txsid="5000.2"},
                new HistoryModel(){ publicKey= "Hello", amount="14.0", txsid="5000.2"},
                new HistoryModel(){ publicKey= "Hello", amount="15.0", txsid="5000.2"},
                new HistoryModel(){ publicKey= "Hello", amount="16.0", txsid="5000.2"},
            };
            var data = Credits.FetchHistory("4SFfA1S2xfA3BdgkTn2tK14yDhLuD11RVz78kqx35jct");
            var converted_list = new List<HistoryModel>();
            
            foreach(var x in data)
            {
                int index = x.Id.Index + 1;
                converted_list.Add(new HistoryModel { amount = x.Trxn.Amount.Integral.ToString()+"."+x.Trxn.Amount.Fraction.ToString(), txsid = x.Id.PoolSeq.ToString() +"."+ index.ToString(), publicKey = Base58CheckEncoding.EncodePlain(x.Trxn.Source) });
            }
            TransactionHistoryCollection.ItemsSource = converted_list;
            BackButton.GestureRecognizers.Add(tapGestureRecognizer);
        }
    }
}
