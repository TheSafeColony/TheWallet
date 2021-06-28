using System;
namespace TheWallet.Models
{
    public class HistoryModel
    {
        public string publicKey { get; set; }
        public string amount { get; set; }
        public string txsid { get; set; }
    }
}
