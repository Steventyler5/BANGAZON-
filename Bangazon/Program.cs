using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bangazon
{
    class Program
    {
        static void Main(string[] args)
        {
            Bangazon Bangazon = new Bangazon();
            Bangazon.MainMenu();
            bool TerminateBangazon = false;

            do
            {
                Bangazon.line = Console.ReadLine();
                switch (Bangazon.line)
                {
                    case "1":
                        Bangazon.CreateAccount();
                        break;
                    case "2":
                        Bangazon.SelectCustomer();
                        break;
                    case "3":
                        Bangazon.LoadProducts();
                        break;
                    case "4":
                        Bangazon.CheckOrderStatus();
                        break;
                    case "5":
                        Bangazon.SortItemsByPopularity();
                        break;
                    case "6":
                        TerminateBangazon = true;
                        break;
                }
            } while (!TerminateBangazon);
        }
    }
}