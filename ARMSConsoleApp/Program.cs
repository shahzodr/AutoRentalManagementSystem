using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARMSBOLayer;

namespace ARMSTestingConsole
{
    class Program
    {
        static void Main(string[] args)
        {   
            //**Test the default constructor, parameterized constructor and Print() Method****

            //Create object using Default Constructor and test Print()
            CreditCard objCard1 = new CreditCard();
            objCard1.Print();
            Console.WriteLine();

            //Create object using Parameterized Constructor with optional and test Print()
            CreditCard objCard2 = new CreditCard("123", "Jack Sparrow", "Bank of City Tech", "02/04/2020", "567 Court st", "Apt 3C", "Brooklyn", "NY", "11987", "USA", 200.12M, 1000);
            objCard2.Print();
            Console.WriteLine();

            //Create object using Parameterized Constructor with preset and test Print()
            CreditCard objCard6 = new CreditCard("123567", "Hen Sparrow", "Bank of TT Tech", "01/03/2020", "587 Court st", "Apt 3C", "Bronx", "NY", "11897", "USA");
            objCard6.Print();
            Console.WriteLine();

            //*** Test Instance Properties, Get and Set

            //Set Instance Properties using objCard1 
            objCard1.CreditCardNumber = "4004000000000001";
            objCard1.CreditCardOwnerName = "Luka Modric";
            objCard1.MerchantName = "Castilla Bank";
            objCard1.ExpDate = new DateTime(2015, 12, 31, 5, 10, 20);
            objCard1.AddressLine1 = "44 Pine Street";
            objCard1.AddressLine2 = "Apt 2B";
            objCard1.City = "Bronx";
            objCard1.StateCode = "NY";
            objCard1.ZipCode = "45867";
            objCard1.Country = "Usa";
            objCard1.CreditCardLimit = 15000M;
            objCard1.CreditCardBalance = 475.86M;


            //Get Instance Properties
            Console.WriteLine("Credit Card Information: ");
            Console.WriteLine("Credit Card Number = {0}", objCard1.CreditCardNumber);
            Console.WriteLine("Credit Card Owner Name = {0}", objCard1.CreditCardOwnerName);
            Console.WriteLine("Merchant Name = {0}", objCard1.MerchantName);
            Console.WriteLine("Expiration Date = {0}", objCard1.ExpDate);
            Console.WriteLine("AddressLine1 = {0}", objCard1.AddressLine1);
            Console.WriteLine("AddressLine2 = {0}", objCard1.AddressLine2);
            Console.WriteLine("City = {0}", objCard1.City);
            Console.WriteLine("State = {0}", objCard1.StateCode);
            Console.WriteLine("Zip code = {0}", objCard1.ZipCode);
            Console.WriteLine("Country = {0}", objCard1.Country);
            Console.WriteLine("Credit Card Limit = {0}", objCard1.CreditCardLimit);
            Console.WriteLine("Credit Card Balance = {0}", objCard1.CreditCardBalance);
            Console.WriteLine("Activation Status = {0}", objCard1.ActivationStatus);
            Console.WriteLine();

            //***Test Instance Methods Acitvate and Deactivate***

            //Test Deactivate Method to change default value from true to false
            Console.WriteLine(objCard1.Deactivate());

            //Test Activate Method to change the recently deactivated card back to true
            Console.WriteLine(objCard1.Activate());

            //Use Load to get info for CreditCard 4004000000000001 and use Print() to print to file 
            CreditCard objCard3 = new CreditCard();
            objCard3.Load("4004000000000001");
            objCard3.Print();

            //Use Insert() to insert previously created objCard2 object into database
            //objCard2.Insert();

            //Set objCard2 properties with different values and use the UPDATE() to update them in the database
            /*objCard2.MerchantName = "Castilla Bank";
            objCard2.ExpDate = new DateTime(2015, 12, 31, 5, 10, 20);
            objCard2.AddressLine1 = "44 Pine Street";
            objCard2.AddressLine2 = "Apt 2B";
            objCard2.City = "Bronx";
            objCard2.StateCode = "NY";
            objCard2.ZipCode = "45867";
            objCard2.Country = "Usa";
            objCard2.CreditCardBalance = 475.86M;
            objCard2.CreditCardLimit = 15000M;

            objCard2.Update();*/

            //Use Delete() to delete previously inserted CreditCard 123, from database
            objCard2.Delete("123");



            /*Console.WriteLine();
            objCard1.Insert();
            Console.WriteLine();
            objCard1.InsertCreditCardOfACustomer("574849330");
            Console.WriteLine();
            objCard1.Update();
            Console.WriteLine();
            objCard1.Delete("758493034");
            Console.WriteLine();*/


            /****** USState Class Test ******

            //Create object using Default Constructor and test Print()
            USState objState1 = new USState();
            objState1.Print();
            Console.WriteLine();

            //Create object using Parameterized Constructor with optional and test Print()
            USState objState2 = new USState(1, "NY", "New York");
            objState2.Print();
            Console.WriteLine();

            //*** Test Instance Properties, Get and Set

            //Set Instance Properties using objState1
            objState1.StateID = 2;
            objState1.StateCode = "NJ";
            objState1.StateName = "New Jersery";

            //Get Instance Properties
            Console.WriteLine("State information:");
            Console.WriteLine("State ID = {0}", objState1.StateID);
            Console.WriteLine("State Code = {0}", objState1.StateCode);
            Console.WriteLine("State Name = {0}", objState1.StateName);
            
            //Insert created objects into database
            //objState1.Insert();
            //objState2.Insert();

            //Update objState1 in database

            //objState1.StateCode = "PA";
            //objState1.StateName = "Pennyslvania";

            //objState1.Update();

            //Load state with StateId of 1 from database into objState3
            //USState objState3 = new USState();
            //objState3.Load(2);
            //objState3.Print();
            
            //Delete row with StateID of 2
            //objState1.Delete(2);
            
            //var list = USState.GetAllUSStates();
            //foreach (USState state in list)
            //{
              //  Console.WriteLine(state);
            //}

            /*********Country Class Test *******

            //Create object using Default Constructor and test Print()
            Country objCountry1 = new Country();
            objCountry1.Print();
            Console.WriteLine();

            //Create object using Parameterized Constructor with optional and test Print()
            Country objCountry2 = new Country(1, "Mx", "Mex", "Mexico","050");
            objCountry2.Print();
            Console.WriteLine();

            //*** Test Instance Properties, Get and Set

            //Set Instance Properties using objState1
            objCountry1.CountryID = 2;
            objCountry1.CountryCode2 = "US";
            objCountry1.CountryCode3 = "USA";
            objCountry1.CountryName = "United States";
            objCountry1.NumericCode = "001";

            //Get Instance Properties
            Console.WriteLine("Country information:");
            Console.WriteLine("Country ID = {0}", objCountry1.CountryID);
            Console.WriteLine("Country Code 2 = {0}", objCountry1.CountryCode2);
            Console.WriteLine("Country Code 3 = {0}", objCountry1.CountryCode3);
            Console.WriteLine("Country Name = {0}", objCountry1.CountryName);
            Console.WriteLine("Numeric Code = {0}", objCountry1.NumericCode);

            //Insert objs into database
            //objCountry1.Insert();
            //objCountry2.Insert();

            //Update objcountry1 in database
            //objCountry1.CountryCode2 = "AU";
            //objCountry1.CountryCode3 = "AUD";
            //objCountry1.CountryName = "Australia";
            //objCountry1.NumericCode = "003";

            //objCountry1.Update();

            //Load Country with ID number of 1 and use print method to verify loading success
            //Country objCountry3 = new Country();
            //objCountry3.Load(1);
            //objCountry3.Print();

            //Delete row with CountryID of 2
            objCountry1.Delete(2); */


        }
    }
}
