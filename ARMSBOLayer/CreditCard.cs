using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ARMSDALayer;
namespace ARMSBOLayer
{
    public class CreditCard
    {
        //**** Private Date ******
        private string m_CreditCardNumber;
        private string m_CreditCardOwnerName;
        private string m_MerchantName;
        private DateTime m_ExpDate;
        private string m_AddressLine1;
        private string m_AddressLine2;
        private string m_City;
        private string m_StateCode;
        private string m_ZipCode;
        private string m_Country;
        private decimal m_CreditCardLimit;
        private decimal m_CreditCardBalance;
        private bool m_ActivationStatus;

        //*** Public Instance Properties ***
        public string CreditCardNumber
        {
            get { return m_CreditCardNumber; }
            set { m_CreditCardNumber = value; }
        }
        public string CreditCardOwnerName
        {
            get { return m_CreditCardOwnerName; }
            set { m_CreditCardOwnerName = value; }
        }
        public string MerchantName
        {
            get { return m_MerchantName; }
            set { m_MerchantName = value; }
        }
        public DateTime ExpDate
        {
            get { return m_ExpDate; }
            set { m_ExpDate = value; }
        }
        public string AddressLine1
        {
            get { return m_AddressLine1; }
            set { m_AddressLine1 = value; }
        }
        public string AddressLine2
        {
            get { return m_AddressLine2; }
            set { m_AddressLine2 = value; }
        }
        public string City
        {
            get { return m_City; }
            set { m_City = value; }
        }
        public string StateCode
        {
            get { return m_StateCode; }
            set { m_StateCode = value; }
        }
        public string ZipCode
        {
            get { return m_ZipCode; }
            set { m_ZipCode = value; }
        }
        public string Country
        {
            get { return m_Country; }
            set { m_Country = value; }
        }
        public decimal CreditCardLimit
        {
            get { return m_CreditCardLimit; }
            set { m_CreditCardLimit = value; }
        }
        public decimal CreditCardBalance
        {
            get { return m_CreditCardBalance; }
            set { m_CreditCardBalance = value; }
        }

        public bool ActivationStatus
        {
            get { return m_ActivationStatus; } //read only 
        }

        //*** Public Default & Parameterized Constructor Methods ***

        //Public Default Constructor Method
        public CreditCard()
        {
            m_CreditCardNumber = "";
            m_CreditCardOwnerName = "";
            m_MerchantName = "";
            m_ExpDate = new DateTime().Date;
            m_AddressLine1 = "";
            m_AddressLine2 = "";
            m_City = "";
            m_StateCode = "";
            m_ZipCode = "";
            m_Country = "";
            m_CreditCardBalance = 3000.0M;
            m_CreditCardLimit = 3000.0M;
            m_ActivationStatus = true;
        }

        //Public Parameterized Constructor
        public CreditCard(string ccNum, string ccOwnerName, string mName, string eDate,
                           string aLine1, string aLine2, string cty, string sCode, string zCode,
                           string cntry, decimal ccBalance = 3000.0M, decimal ccLimit = 3000.0M)
        {
            this.CreditCardNumber = ccNum;
            this.CreditCardOwnerName = ccOwnerName;
            this.MerchantName = mName;
            this.ExpDate = Convert.ToDateTime(eDate);
            this.AddressLine1 = aLine1;
            this.AddressLine2 = aLine2;
            this.City = cty;
            this.StateCode = sCode;
            this.ZipCode = zCode;
            this.Country = cntry;
            this.CreditCardLimit = ccLimit;
            this.CreditCardBalance = ccBalance;

            m_ActivationStatus = true;

        }

        //Destructor Method
        ~CreditCard()
        {
            Console.WriteLine("This is the destructor, destructing");
        }

        //*** Public Instance Methods ***

        //Prints the Credit Card Information to screen
        public void Print()
        {
            //Step A-Start Error Trapping
            try
            {
                // Create object to open/create file for appending
                StreamWriter objPrinterFile = new StreamWriter("Network_Printer.txt", true);
                objPrinterFile.WriteLine("Credit Card information: ");
                objPrinterFile.WriteLine("Credit Card Number = {0}", m_CreditCardNumber);
                objPrinterFile.WriteLine("Credit Card Owner Name = {0}", m_CreditCardOwnerName);
                objPrinterFile.WriteLine("Merchant Name = {0}", m_MerchantName);
                objPrinterFile.WriteLine("Expiration Date = {0}", m_ExpDate);
                objPrinterFile.WriteLine("AddressLine1 = {0}", m_AddressLine1);
                objPrinterFile.WriteLine("AddressLine2 = {0}", m_AddressLine2);
                objPrinterFile.WriteLine("City = {0}", m_City);
                objPrinterFile.WriteLine("State = {0}", m_StateCode);
                objPrinterFile.WriteLine("Zip code = {0}", m_ZipCode);
                objPrinterFile.WriteLine("Country = {0}", m_Country);
                objPrinterFile.WriteLine("Credit Card Limit = {0}", m_CreditCardLimit);
                objPrinterFile.WriteLine("Credit Card Balance = {0}", m_CreditCardBalance);

                objPrinterFile.WriteLine("Activation Status = {0}", m_ActivationStatus);

                objPrinterFile.WriteLine();
                objPrinterFile.WriteLine();

                //Close file
                objPrinterFile.Close();

            }//End of try

            //Step B-Traps for general exception.
            catch (Exception objE)
            {
                //Step C-Re-Throw an general exceptions
                throw new Exception("Unexpected Error in Print() Method: {0} " + objE.Message);
            }

        }//End of method

        //Sets Activations Status to True
        public bool Activate()
        {
            m_ActivationStatus = true;
            return m_ActivationStatus;
        }

        //Sets Activation Status to False
        public bool Deactivate()
        {
            m_ActivationStatus = false;
            return m_ActivationStatus;
        }

        //***Public Instance & Static Data Access Methods: ***
        public bool Load(string key)
        {
            //Starts the laoding of this object's data from database
            return DALayer_Load(key);
        }
        public bool Insert()
        {
            //Starts the inserting of this object's data to Credit Card database table
            return DALayer_Insert();
        }
        public bool InsertCreditCardOfACustomer(string customerkey)
        {
            return DALayer_InsertCreditCardOfACustomer(customerkey);
        }
        public bool Update()
        {
            return DALayer_Update();
        }
        public bool Delete(string key)
        {
            return DALayer_Delete(key);
        }

        public static List<CreditCard> GetAllCreditCards()
        {
            return DALayer_GetAllCreditCards();

        }

        //*** Protected Instance & Static Data Access Methods: ***

        protected bool DALayer_Load(string key)
        {
            try
            {
                //Use DAL object Factory to get the SQL Server Factory Data Access Object
                DALObjectFactoryBase objSQLDAOFactory =
                DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);

                //Call the correct Data Access Object to perform the Data Access
                CreditCardDAO objCreditCardDAO = objSQLDAOFactory.GetCreditCardDAO();

                //Call the CreditCardDAO Data Access Object to do the work 
                CreditCardDTO objCreditCardDTO = objCreditCardDAO.GetRecordByID(key);

                //Check if DTO object exists & populate this objct with DTO object's properties
                if (objCreditCardDTO != null)
                {
                    //Get the data from the Data Transfer Object
                    this.CreditCardNumber = objCreditCardDTO.CreditCardNumber;
                    this.CreditCardOwnerName = objCreditCardDTO.CreditCardOwnerName;
                    this.MerchantName = objCreditCardDTO.MerchantName;
                    this.ExpDate = objCreditCardDTO.ExpDate;
                    this.AddressLine1 = objCreditCardDTO.AddressLine1;
                    this.AddressLine2 = objCreditCardDTO.AddressLine2;
                    this.City = objCreditCardDTO.City;
                    this.StateCode = objCreditCardDTO.StateCode;
                    this.ZipCode = objCreditCardDTO.ZipCode;
                    this.Country = objCreditCardDTO.Country;
                    this.CreditCardLimit = objCreditCardDTO.CreditCardLimit;
                    this.CreditCardBalance = objCreditCardDTO.CreditCardBalance;


                    //Handle activation status
                    if (objCreditCardDTO.ActivationStatus == true)
                        this.Activate();
                    else
                        this.Deactivate();
                    //since it has been populated, return true
                    return true;
                }
                else
                {
                    //if null or no object returned from DALayer, return false
                    return false;
                }
            }//End of try 
            catch (Exception objE)
            {
                //Rethrow general exceptions
                throw new Exception("Unexpected Error is DALayer_Load(key) Method: {0} " + objE.Message);
            }
        }//End of method

        protected bool DALayer_Insert()
        {
            try
            {
                //Use DAL object Factory to get the SQL Server Factory Data Access Object
                DALObjectFactoryBase objSQLDAOFactory =
                DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);

                //Call the correct Data Access Object to perform the Data Access
                CreditCardDAO objCreditCardDAO = objSQLDAOFactory.GetCreditCardDAO();

                //Call the CreditCardDAO Data Access Object to do the work 
                CreditCardDTO objCreditCardDTO = new CreditCardDTO();

                //Populate the data transfer object with data from THIS object to send to database
                objCreditCardDTO.CreditCardNumber = this.CreditCardNumber;
                objCreditCardDTO.CreditCardOwnerName = this.CreditCardOwnerName;
                objCreditCardDTO.MerchantName = this.MerchantName;
                objCreditCardDTO.ExpDate = this.ExpDate;
                objCreditCardDTO.AddressLine1 = this.AddressLine1;
                objCreditCardDTO.AddressLine2 = this.AddressLine2;
                objCreditCardDTO.City = this.City;
                objCreditCardDTO.StateCode = this.StateCode;
                objCreditCardDTO.ZipCode = this.ZipCode;
                objCreditCardDTO.Country = this.Country;
                objCreditCardDTO.CreditCardLimit = this.CreditCardLimit;
                objCreditCardDTO.CreditCardBalance = this.CreditCardBalance;

                objCreditCardDTO.ActivationStatus = this.ActivationStatus;

                //Call the CreditCardDAO Data Access Object to do the work
                bool inserted = objCreditCardDAO.Insert(objCreditCardDTO);

                //Test if insert to database was successful return true
                if (inserted == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }//End of try
            catch (Exception objE)
            {
                //Rethrow general exceptions
                throw new Exception("Unexpected Error is DALayer_Insert() Method: {0} " + objE.Message);
            }
        }

        protected bool DALayer_InsertCreditCardOfACustomer(string parentKey)
        {
            try
            {
                //Use DAL object Factory to get the SQL Server Factory Data Access Object
                DALObjectFactoryBase objSQLDAOFactory =
                DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);

                //Call the correct Data Access Object to perform the Data Access
                CreditCardDAO objCreditCardDAO = objSQLDAOFactory.GetCreditCardDAO();

                //Call the CreditCardDAO Data Access Object to do the work 
                CreditCardDTO objCreditCardDTO = new CreditCardDTO();

                //Populate the data transfer object with data from THIS object to send to database
                objCreditCardDTO.CreditCardNumber = this.CreditCardNumber;
                objCreditCardDTO.CreditCardOwnerName = this.CreditCardOwnerName;
                objCreditCardDTO.MerchantName = this.MerchantName;
                objCreditCardDTO.ExpDate = this.ExpDate;
                objCreditCardDTO.AddressLine1 = this.AddressLine1;
                objCreditCardDTO.AddressLine2 = this.AddressLine2;
                objCreditCardDTO.City = this.City;
                objCreditCardDTO.StateCode = this.StateCode;
                objCreditCardDTO.ZipCode = this.ZipCode;
                objCreditCardDTO.Country = this.Country;
                objCreditCardDTO.CreditCardLimit = this.CreditCardLimit;
                objCreditCardDTO.CreditCardBalance = this.CreditCardBalance;

                objCreditCardDTO.ActivationStatus = this.ActivationStatus;

                //call the CreditCardDAO Data Access Object to do the work
                bool inserted = objCreditCardDAO.InsertChildObjectOfAParent(parentKey, objCreditCardDTO);

                //test if insert to the database was successful & MARK object as old return true
                if (inserted == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }//End of try

            catch (Exception objE)
            {
                //Rethrow general exceptions
                throw new Exception("Unexpected Error is DALayer_InsertCreditCardOfACustomer() Method: {0} " + objE.Message);
            }
        }
        protected bool DALayer_Update()
        {
            try
            {
                //Use DAL object Factory to get the SQL Server Factory Data Access Object
                DALObjectFactoryBase objSQLDAOFactory =
                DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);

                //Call the correct Data Access Object to perform the Data Access
                CreditCardDAO objCreditCardDAO = objSQLDAOFactory.GetCreditCardDAO();

                //Call the CreditCardDAO Data Access Object to do the work 
                CreditCardDTO objCreditCardDTO = new CreditCardDTO();

                //Populate the data transfer object with data from THIS object to send to database
                objCreditCardDTO.CreditCardNumber = this.CreditCardNumber;
                objCreditCardDTO.CreditCardOwnerName = this.CreditCardOwnerName;
                objCreditCardDTO.MerchantName = this.MerchantName;
                objCreditCardDTO.ExpDate = this.ExpDate;
                objCreditCardDTO.AddressLine1 = this.AddressLine1;
                objCreditCardDTO.AddressLine2 = this.AddressLine2;
                objCreditCardDTO.City = this.City;
                objCreditCardDTO.StateCode = this.StateCode;
                objCreditCardDTO.ZipCode = this.ZipCode;
                objCreditCardDTO.Country = this.Country;
                objCreditCardDTO.CreditCardLimit = this.CreditCardLimit;
                objCreditCardDTO.CreditCardBalance = this.CreditCardBalance;

                objCreditCardDTO.ActivationStatus = this.ActivationStatus;

                //Call the CreditCardDAO data access object to do the work
                bool updated = objCreditCardDAO.Update(objCreditCardDTO);

                //test if insert to the database was successful & MARK object as old return true
                if (updated == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }//End of try
            catch (Exception objE)
            {
                //Rethrow general exceptions
                throw new Exception("Unexpected Error is DALayer_Update() Method: {0} " + objE.Message);
            }
        }

        protected bool DALayer_Delete(string key)
        {
            try
            {
                //Use DAL object Factory to get the SQL Server Factory Data Access Object
                DALObjectFactoryBase objSQLDAOFactory =
                DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);

                //Call the correct Data Access Object to perform the Data Access
                CreditCardDAO objCreditCardDAO = objSQLDAOFactory.GetCreditCardDAO();

                //call the CreditCArdDAO data access object to do the work
                bool deleted = objCreditCardDAO.Delete(key);

                //test if delete to the database was successful & MARK object as old return true
                if (deleted == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }//End of try
            catch (Exception objE)
            {
                //Rethrow general exceptions
                throw new Exception("Unexpected Error is DALayer_Delete() Method: {0} " + objE.Message);
            }
        }

        protected static List<CreditCard> DALayer_GetAllCreditCards()
        {
            //Step A-Start Error Trapping
            try
            {
                //Step 1-Use DAL object Factory to get the SQL Server FACTORY Data Access Object
                DALObjectFactoryBase objSQLDAOFactory =
               DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);
                //Step 2-now that you have the SQL FACTORY object GET DAO object to do the work
                CreditCardDAO objCreditCardDAO = objSQLDAOFactory.GetCreditCardDAO();
                //Step 3-call CreditCardDAO DAO to do the work & return COLLECTION of Data Transfer Objects
                List<CreditCardDTO> objCreditCardDTOList = objCreditCardDAO.GetAllRecords();
                //Step 4- test if List<CreditCardDTO> DTO collection exists 
                if (objCreditCardDTOList != null)
                {
                    //Step 5-Create a LIST Collection of CreditCard object to get copy of DTO collection
                    List<CreditCard> objCreditCardList = new List<CreditCard>();
                    //Step 6-Loop through List<CreditCardDTO> objCreditCardDTOList collection
                    foreach (CreditCardDTO objDTO in objCreditCardDTOList)
                    {
                        //Step 6a-Create new CreditCard object
                        CreditCard objCreditCard = new CreditCard();
                        //Step 6b-get the data from DTO object and SET CreditCard object
                        objCreditCard.CreditCardNumber = objDTO.CreditCardNumber;
                        objCreditCard.CreditCardOwnerName = objDTO.CreditCardOwnerName;
                        objCreditCard.MerchantName = objDTO.MerchantName;
                        objCreditCard.ExpDate = objDTO.ExpDate;
                        objCreditCard.AddressLine1 = objDTO.AddressLine1;
                        objCreditCard.AddressLine2 = objDTO.AddressLine2;
                        objCreditCard.City = objDTO.City;
                        objCreditCard.StateCode = objDTO.StateCode;
                        objCreditCard.ZipCode = objDTO.ZipCode;
                        objCreditCard.Country = objDTO.Country;
                        objCreditCard.CreditCardLimit = objDTO.CreditCardLimit;
                        objCreditCard.CreditCardBalance = objDTO.CreditCardBalance;


                        //Handle activation status accordingly since ActivationStutus property is read only
                        if (objDTO.ActivationStatus == true)
                            objCreditCard.Activate();
                        else
                            objCreditCard.Deactivate();

                        //Step 6c-Add CreditCard Object to the objCreditCardList List<CreditCard> COLLECTION 
                        objCreditCardList.Add(objCreditCard);
                    }//End of foreach
                     //Step 6d-once copy process ends, Return objCreditCardList List<CreditCard> COLLECTION
                    return objCreditCardList;
                }//End of if
                else
                {
                    //Step 6e- No DTO collection object returned from DALayer, return a null
                    return null;
                }
            }//End of try
             //Step B-Traps for general exception. 
            catch (Exception objE)
            {
                //Step C-Re-Throw a general exceptions
                throw new Exception("Unexpected Error in DALayer_GetAllCreditCards(key) Method: {0} " +
                objE.Message);
            }
        }//End of method
    }
}
