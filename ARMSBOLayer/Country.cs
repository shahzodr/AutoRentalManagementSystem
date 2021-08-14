using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ARMSDALayer;

namespace ARMSBOLayer
{
    public class Country
    {
        public int CountryID { get; set; }
        //public string CountryCode2 { get; set; }
        //public string CountryCode3 { get; set; }
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
        //public string NumericCode { get; set; }

        public Country()
        {
            this.CountryID = 0;
            this.CountryName = "";
            this.CountryCode = "";
        }

        public Country(int CountryID, string CountryName, string CountryCode)
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;
            this.CountryCode = CountryCode;
        }

        ~Country()
        {
            //Example - Code to clean up memory to make sure all resources
            //being used by an object are destroyed when object is destroyed
        }

        public void Print()
        {
            //Step A-Start Error Trapping
            try
            {
                //Step 1-Create object to open/create file for appending
                StreamWriter objPrinterFile = new StreamWriter("Network_Printer.txt", true);

                objPrinterFile.WriteLine("Country information: ");
                objPrinterFile.WriteLine("Country ID = {0}", CountryID);
                objPrinterFile.WriteLine("Country Name = {0}", CountryName);
                objPrinterFile.WriteLine("Country Code = {0}", CountryCode);

                objPrinterFile.WriteLine();
                objPrinterFile.WriteLine();

                //Step 3-Close file
                objPrinterFile.Close();
            }
            //Step B-Traps for general exception.
            catch (Exception objE)
            {
                //Step C-Re-Throw an general exceptions
                throw new Exception("Unexpected Error in Print() Method: {0} " + objE.Message);
            }
        }

        public bool Load(int key)
        {
            //Step 1 - Calls DALayer_Load(key) method to do the work
            return DALayer_Load(key);
        }

        public bool Insert()
        {
            //Step 1 - Calls DALayer_Inser() method to do the work
            return DALayer_Insert();
        }

        public bool Update()
        {
            //Step 1 - Calls DALayer_Update(key) method to do the work
            return DALayer_Update();
        }

        public bool Delete(int key)
        {
            //Step 1 - Calls DALayer_Delete(key) method to do the work
            return DALayer_Delete(key);
        }

        public static List<Country> GetAllCountry()
        {
            return DALayer_GetAllCountry();
        }

        protected bool DALayer_Load(int key)
        {
            //Step A-Start Error Trapping
            try
            {
                //Step 1-Use DAL object Factory to get the SQL Server FACTORY Data Access Object
                DALObjectFactoryBase objSQLDAOFactory =
                    DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);

                //Step 2-now that you have the sql FACTORY data access object
                //call the correct Data Access Object to perform the Data Access
                CountryDAO objCountryDAO = objSQLDAOFactory.GetCountryDAO();

                //Step 3-call the CountryDAO Data Access Object to do the work
                CountryDTO objCountryDTO = objCountryDAO.GetRecordByID(key);

                //Step 4- test if DTO object exists & populate this object with DTO object's properties
                //and return a true or return a False if no DTO object exists.
                if (objCountryDTO != null)
                {
                    //Step 4a-get the data from the Data Transfer Object
                    this.CountryID = objCountryDTO.CountryID;
                    this.CountryName = objCountryDTO.CountryName;
                    this.CountryCode = objCountryDTO.CountryCode;

                    //Step 4c-Returns a true since this class object has been populated.
                    return true;
                }
                else
                {
                    return false;
                }
            }//End of try
             //Step B-Traps for general exception.
            catch (Exception objE)
            {
                //Step C-Re-Throw an general exceptions
                throw new Exception("Unexpected Error in DALayer_Load(key) Method: {0} " + objE.Message);
            }
        }//End of method

        protected bool DALayer_Insert()
        {
            //Step A-Start Error Trapping
            try
            {
                //Step 1-Use DAL object Factory to get the SQL Server FACTORY Data Access Object
                DALObjectFactoryBase objSQLDAOFactory =
                DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);

                //Step 2-now that you have the sql FACTORY data access object
                //call the correct Data Access Object to perform the Data Access
                CountryDAO objCountryDAO = objSQLDAOFactory.GetCountryDAO();

                //Step 3-Create new Data Transfer Object to send to DA Later for DATA ACCESS LAYER
                CountryDTO objCountryDTO = new CountryDTO();

                //Step 4- POPULATE the Data Transfer Object with data from THIS OBJECT to send to database
                objCountryDTO.CountryID = this.CountryID;
                objCountryDTO.CountryName = this.CountryName;
                objCountryDTO.CountryCode = this.CountryCode;

                //Step 5-call the CountryDAO Data Access Object to do the work
                bool inserted = objCountryDAO.Insert(objCountryDTO);

                //Step 6- test if insert to database was successful return true,
                //otherwise return false
                if (inserted == true)
                {
                    //Step 6b-Returns a true since this class object has been inserted & marked as old.
                    return true;
                }
                else
                {
                    return false;
                }
            }//End of try

            //Step B-Traps for general exception.
            catch (Exception objE)
            {
                //Step C-Re-Throw an general exceptions
                throw new Exception("Unexpected Error in DALayer_Insert() Method: {0} " + objE.Message);
            }
        }//End of method

        protected bool DALayer_Update()
        {
            //Step A-Start Error Trapping
            try
            {
                //Step 1-Use DAL object Factory to get the SQL Server FACTORY Data Access Object
                DALObjectFactoryBase objSQLDAOFactory =
                DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);

                //Step 2-now that you have the sql FACTORY data access object
                //call the correct Data Access Object to perform the Data Access
                CountryDAO objCountryDAO = objSQLDAOFactory.GetCountryDAO();

                //Step 3-Create new Data Transfer Object to send to DA Later for DATA ACCESS LAYER
                CountryDTO objCountryDTO = new CountryDTO();

                //Step 4- POPULATE the Data Transfer Object with data from THIS OBJECT to send to database
                objCountryDTO.CountryID = this.CountryID;
                objCountryDTO.CountryName = this.CountryName;
                objCountryDTO.CountryCode = this.CountryCode;


                //Step 5-call the CountryDAO Data Access Object to do the work
                bool updated = objCountryDAO.Update(objCountryDTO);

                //Step 6- test if update to database was successful & MARK the object as old return true,
                //otherwise return false
                if (updated == true)
                {
                    //Step 6b-Returns a true since this class object has been updated.
                    return true;
                }
                else
                {
                    return false;
                }
            }//End of try

            //Step B-Traps for general exception.
            catch (Exception objE)
            {
                //Step C-Re-Throw an general exceptions
                throw new Exception("Unexpected Error in DALayer_Update() Method: {0} " + objE.Message);
            }
        }//End of method

        protected bool DALayer_Delete(int key)
        {
            //Step A-Start Error Trapping
            try
            {
                //Step 1-Use DAL object Factory to get the SQL Server FACTORY Data Access Object
                DALObjectFactoryBase objSQLDAOFactory =
                DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);

                //Step 2-now that you have the sql FACTORY data access object
                //call the correct Data Access Object to perform the Data Access
                CountryDAO objCountryDAO = objSQLDAOFactory.GetCountryDAO();

                //Step 3-call the CountryDAO Data Access Object to do the work
                bool deleted = objCountryDAO.Delete(key);

                //Step 4- Test if delete to database was successful & MARK the object as NEW since
                //deleted from database and NEW in memory and return a true, otherwise return false
                if (deleted == true)
                {
                    //Step 4b-Returns a true since this class object has been deleted & marked as NEW.
                    return true;
                }
                else
                {
                    return false;
                }
            }//End of try

            //Step B-Traps for general exception.
            catch (Exception objE)
            {
                //Step C-Re-Throw an general exceptions
                throw new Exception("Unexpected Error in DALayer_Update() Method: {0} " + objE.Message);
            }
        }//End of method

        protected static List<Country> DALayer_GetAllCountry()
        {
            //Step A-Start Error Trapping
            try
            {
                DALObjectFactoryBase objSQLDAOFactory = DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);

                //Step 2-now that you have the SQL FACTORY object GET DAO object to do the work
                CountryDAO objCountryDAO = objSQLDAOFactory.GetCountryDAO();

                //Step 3-call CountryDAO DAO to do the work & return COLLECTION of Data Transfer Objects
                List<CountryDTO> objCountryDTOList = objCountryDAO.GetAllRecords();

                //Step 4- test if List<CountryDTO> DTO collection exists
                if (objCountryDTOList != null)
                {
                    //Step 5-Create a LIST Collection of Country object to get copy of DTO collection
                    List<Country> objCountryList = new List<Country>();

                    //Step 6-Loop through List<CountryDTO> objCountryDTOList collection
                    foreach (CountryDTO objDTO in objCountryDTOList)
                    {
                        //Step 6a-Create new Country object
                        Country objCountry = new Country();

                        //Step 6b-get the data from DTO object and SET Country ob
                        objCountry.CountryID = objDTO.CountryID;
                        objCountry.CountryName = objDTO.CountryName;
                        objCountry.CountryCode = objDTO.NumericCode;

                        //Step 6c-Add Country Object to the objCountryList List<Country> COLLECTION
                        objCountryList.Add(objCountry);
                    }//End of foreach

                    //Step 6d-once copy process ends, Return objCountryList List<Country> COLLECTION
                    return objCountryList;
                }//End of if
                else
                {
                    return null;
                }
            }//End of try

            //Step B-Traps for general exception.
            catch (Exception objE)
            {
                //Step C-Re-Throw a general exceptions
                throw new Exception("Unexpected Error in DALayer_GetAllCountry(key) Method: {0} " +
                objE.Message);
            }
        }//End of method
        
    }
}
