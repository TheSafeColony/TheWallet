using System;
using System.Collections.Generic;
using TheWallet.Models;
using Xamarin.Forms;
using Base58Check;

namespace TheWallet
{
    public partial class TxsPage : ContentPage
    {
        public TxsPage(string Pubkey, string PrivKey)
        {
            
            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += (s, e) => {
                //PopupNavigation.Instance.PushAsync(new keyview());
                Application.Current.MainPage = new WalletPage(Pubkey,PrivKey);
                
            };
            InitializeComponent();
            var data = Credits.FetchHistory(Pubkey);
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
