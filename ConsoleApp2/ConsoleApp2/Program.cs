using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ConsoleApp2


namespace AccountInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1
            AccountInformation info = new AccountInformation();
            bool status = true;
            info = info.CheckStatus(out status);
            Console.WriteLine("Status ===== " + status + "\n");
            Console.WriteLine("AccountInformation ===== " + JsonConvert.SerializeObject(info));
            Console.ReadLine();

            var accountInfo = new AccountInformation()
            {
                AccountName = "Hope",
                AccountNo = 0235939011,

            };
        }
    }

    public class AccountInformation
    {
        public string AccountName { get; set; }
        public int AccountNo { get; set; }
        public Address AccountAdd { get; set; }

        public AddressInformation CheckStatus(out bool status)
        {
            var accountAddress = new Address();

        {
                public string AddressOne { get; set; }
                public string AddressTwo { get; set; }
              public string AddressThree { get; set; }
        }




        var accountInfo = new AccountInformation({

                AccountName = "Hope",
                AccountNo = 0235939011
            });
            status = false;
            return accountInfo;

    }

    public class Address {
        public string AddressOne { get; set; }
        public string AddressTwo { get; set; }
        public string AddressThree { get; set; }
}
