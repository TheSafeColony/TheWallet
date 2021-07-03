using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheWallet
{
    public class Credits
    {
        public Credits()
        {
        }
        //Put Here the Ip Address of a node running Credits Blockchain software
        public static string ip = "161.97.121.0";
        //Put Here the port number of a node running Credits Blockchain software
        public static int port = 9091;
        //Retrieve the balance of the given wallet on the Credits Blockchain
        public static string balance(string PubKey)
        {
            try
            {
                var client_ = new Client(ip, port, PubKey, "", PubKey);
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
                var client_ = new Client(ip, port, PubKey, "", PubKey);
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
        public static bool SendTransaction(int Integeral, long fraction, string PublicKey, string PrivateKey, string Target )
        {
            try
            {
                var client_ = new Client(ip, port, PublicKey,PrivateKey,Target);
                if (fraction.ToString().Length < 18)
                {
                    var tempvar = fraction.ToString();
                    var extracount = 18 - tempvar.Length;
                    foreach (int value in Enumerable.Range(1, extracount)){ tempvar = tempvar + "0"; }
                    fraction = Convert.ToInt64(tempvar);
                    Console.WriteLine(fraction);
                }
                Console.WriteLine(client_.TransferCoins(Integeral, fraction, 1.0));
                return true;  
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;

            }
        }
    }
}
