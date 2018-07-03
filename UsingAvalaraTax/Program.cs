using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Author: Jacob M Cavish
 Date: 07/02/2015
 Purpose: To learn Avalara.AvaTax.AddressInfo
     */

namespace UsingAvalaraTax
{
    class Program
    {
        public static Avalara.AvaTax.RestClient.AddressInfo clientAddress = new Avalara.AvaTax.RestClient.AddressInfo();
        static bool check = true;
        static void Main(string[] args)
        {//Let's check if address info is valid while customer inputs it. TODO: Check input against Avalara Database for validity once the input doesn't break upon entering
            Console.Clear();
            checkStreet();
            checkCity();
            checkZip();
            checkLoLa();
            checkRegion();
            checkCountry();
            Console.WriteLine("Thank you for your time.");
            MessageBox.Show("User entered valid input that does crash the program");
        }

        public static void checkStreet()
        {//checks if input for street is valid
            Console.WriteLine("Please provide a Street Address for your company's address.");
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
        }

        public static void checkCity()
        {//checks if input for city is valid. Excludes numbers
            Console.WriteLine("Please provide a City for your company's address.");
            while (check)
            {
                check = false;
                try
                {
                    clientAddress.city = Console.ReadLine();
                    MessageBox.Show(clientAddress.city);
                    var isNumber = int.TryParse(clientAddress.city, out int n);
                    if (isNumber)
                    {
                        check = true;
                        Console.WriteLine("Please enter a valid City");
                    }
                }
                catch (Exception e)
                {
                    System.Windows.Forms.MessageBox.Show(e.Message);
                    check = true;
                    Console.WriteLine("Please enter a valid City");
                }
            }
            check = true;
        }

        public static void checkZip()
        {//checks if input for zip code is valid. Cannot exclude letters because many countries use letters in zip codes
            Console.WriteLine("Please provide a Postal Code for your company's address.");
            while (check)
            {
                check = false;
                try
                {
                    clientAddress.postalCode = Console.ReadLine();
                    MessageBox.Show(clientAddress.postalCode);
                }
                catch (Exception e)
                {
                    System.Windows.Forms.MessageBox.Show(e.Message);
                    Console.WriteLine("Please enter a valid Postal Code");
                    check = true;
                }
            }
            check = true;
        }

        public static void checkLoLa()
        {//checks if input for Latitude and Longitude is valid. Letters excluded
            Console.WriteLine("Please provide a Latitude, press enter, and then Longitude followed by another enter for your company's address.");
            while (check)
            {
                check = false;
                try
                {
                    clientAddress.latitude = Convert.ToDecimal(Console.ReadLine());
                    clientAddress.longitude = Convert.ToDecimal(Console.ReadLine());
                    MessageBox.Show(clientAddress.latitude.ToString() + " " + clientAddress.longitude.ToString());
                }
                catch (Exception e)
                {
                    System.Windows.Forms.MessageBox.Show(e.Message);
                    Console.WriteLine("Please enter a valid Latitude and Longitude");
                    check = true;
                }
            }
            check = true;
        }

        public static void checkRegion()
        {//checks if input for region is valid. Numbers excluded
            Console.WriteLine("Please provide a valid Region Name for your company's address.");
            while (check)
            {
                check = false;
                try
                {
                    clientAddress.region = Console.ReadLine();
                    MessageBox.Show(clientAddress.region);
                    var isNumber = int.TryParse(clientAddress.region, out int n);
                    if(isNumber)
                    {
                        check = true;
                        Console.WriteLine("Please enter a valid Region name");
                    }
                }
                catch (Exception e)
                {
                    System.Windows.Forms.MessageBox.Show(e.Message);
                    check = true;
                    Console.WriteLine("Please enter a valid Region name");
                }
            }
            check = true;
        }

        public static void checkCountry()
        {//checks if input for country name is valid. Numbers excluded
            Console.WriteLine("Please provide a valid Country Name for your company's address.");
            while (check)
            {
                check = false;
                try
                {
                    clientAddress.country = Console.ReadLine();
                    MessageBox.Show(clientAddress.country);
                    var isNumber = int.TryParse(clientAddress.country, out int n);
                    if (isNumber)
                    {
                        check = true;
                        Console.WriteLine("Please enter a valid, US English friendly country name");
                    }
                }
                catch (Exception e)
                {
                    System.Windows.Forms.MessageBox.Show(e.Message);
                    Console.WriteLine("Please enter a valid, US English friendly country name");
                    check = true;
                }
            }
        }
    }
}
