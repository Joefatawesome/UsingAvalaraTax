using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Author: Jacob M Cavish
 Date: 07/02/2015
 Purpose: To learn Avalara.AvaTax
     */

namespace UsingAvalaraTax
{
    class Program
    {
        
        static bool check = true;
        static void Main(string[] args)
        {//Let's check if address info is valid
            Avalara.AvaTax.RestClient.AddressInfo clientAddress = new Avalara.AvaTax.RestClient.AddressInfo();
            Console.WriteLine("Please provide a street address for your company's address.");
            while (check)
            {
                check = false;
                try
                {
                    clientAddress.line1 = Console.ReadLine();
                    MessageBox.Show(clientAddress.line1);
                }
                catch (Exception e)
                {
                    System.Windows.Forms.MessageBox.Show(e.Message);
                    Console.WriteLine("Please enter a valid Street Address");
                    check = true;
                }
            }
            check = true;
            Console.WriteLine("Please provide a valid country name for your company's address.");
            while(check)
            {
                check = false;
                try
                {
                    clientAddress.country = Console.ReadLine();
                    MessageBox.Show(clientAddress.country);
                }
                catch (Exception e)
                {
                    System.Windows.Forms.MessageBox.Show(e.Message);
                    Console.WriteLine("Please enter a valid, US English friendly country name");
                    check = true;
                }
            }
        }

        public static 
    }
}
