using System;
using System.Collections.Generic;

namespace TheWallet
{
    public class Credits
    {
        public Credits()
        {
        }
        //Put Here the Ip Address of a node running Credits Blockchain software
        public static string ip = "161.97.121.0";
        //Retrieve the balance of the given wallet on the Credits Blockchain
        public static string balance(string PubKey)
        {
            try
            {
                var client_ = new Client(ip, 9090, PubKey, "", PubKey);
                var data = client_.WalletGetBalance();
                if (data.Status.Code == 0)
                {
                    return data.Balance.Integral.ToString() + "." + data.Balance.Integral.ToString();
                }
                else
                {
                    return "ERROR";
                }



                }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return "ERROR";

            }
        }

        public static List<NodeApi.SealedTransaction> FetchHistory(string PubKey)
        {
            try
            {
                var client_ = new Client(ip, 9090, PubKey, "", PubKey);
                //var data = client_.WalletGetBalance();
                var data = client_.TransactionsGet(0, 10);
                
                if (data.Status.Code == 0)
                {
                    return data.Transactions;
                }
                else
                {
                    return new List<NodeApi.SealedTransaction>();
                }



            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return new List<NodeApi.SealedTransaction>();

            }
        }
    }
}
