using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ARMSDALayer;

namespace ARMSBOLayer
{
    public class USState
    {
        public int StateID { get; set; }
        public string StateCode { get; set; }
        public string StateName { get; set; }

        public USState()
        {
            this.StateID = 0;
            this.StateCode = "";
            this.StateName = "";
        }

        public USState(int stateID, string stateCode, string stateName)
        {
            this.StateID = stateID;
            this.StateCode = stateCode;
            this.StateName = stateName;
        }

        ~USState()
        {
            //Example - Code to clean up memory to make sure all resources
            //being used by an object are destroyed when object is destroyed
        }

        public void Print()
        {
            try
            {
                //Step 1-Create object to open/create file for appending
                StreamWriter objPrinterFile = new StreamWriter("Network_Printer.txt", true);

                objPrinterFile.WriteLine("US State information: ");
                objPrinterFile.WriteLine("US State ID = {0}", StateID);
                objPrinterFile.WriteLine("US State Code = {0}", StateCode);
                objPrinterFile.WriteLine("US State Name = {0}", StateName);

                objPrinterFile.WriteLine();
                objPrinterFile.WriteLine();

                //Step 3-Close file
                objPrinterFile.Close();
            }//end try
            catch (Exception objE)
            {
                //Step C-Re-Throw an general exceptions
                throw new Exception("Unexpected Error in Print() Method: {0} " + objE.Message);
            }
        }//End method 

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

        public static List<USState> GetAllUSStates()
        {
            return DALayer_GetAllUSStates();
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
                USStateDAO objUSStateDAO = objSQLDAOFactory.GetUSStateDAO();

                //Step 3-call the USStateDAO Data Access Object to do the work
                USStateDTO objUSStateDTO = objUSStateDAO.GetRecordByID(key);

                //Step 4- test if DTO object exists & populate this object with DTO object's properties
                //and return a true or return a False if no DTO object exists.
                if (objUSStateDTO != null)
                {
                    //Step 4a-get the data from the Data Transfer Object
                    this.StateID = objUSStateDTO.StateID;
                    this.StateCode = objUSStateDTO.StateCode;
                    this.StateName = objUSStateDTO.StateName;

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
                USStateDAO objUSStateDAO = objSQLDAOFactory.GetUSStateDAO();

                //Step 3-Create new Data Transfer Object to send to DA Later for DATA ACCESS LAYER
                USStateDTO objUSStateDTO = new USStateDTO();

                //Step 4- POPULATE the Data Transfer Object with data from THIS OBJECT to send to database
                objUSStateDTO.StateID = this.StateID;
                objUSStateDTO.StateCode = this.StateCode;
                objUSStateDTO.StateName = this.StateName;

                //Step 5-call the USStateDAO Data Access Object to do the work
                bool inserted = objUSStateDAO.Insert(objUSStateDTO);

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
                USStateDAO objUSStateDAO = objSQLDAOFactory.GetUSStateDAO();

                //Step 3-Create new Data Transfer Object to send to DA Later for DATA ACCESS LAYER
                USStateDTO objUSStateDTO = new USStateDTO();

                //Step 4- POPULATE the Data Transfer Object with data from THIS OBJECT to send to database
                objUSStateDTO.StateID = this.StateID;
                objUSStateDTO.StateCode = this.StateCode;
                objUSStateDTO.StateName = this.StateName;

                //Step 5-call the USStateDAO Data Access Object to do the work
                bool updated = objUSStateDAO.Update(objUSStateDTO);

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
                USStateDAO objUSStateDAO = objSQLDAOFactory.GetUSStateDAO();

                //Step 3-call the USStateDAO Data Access Object to do the work
                bool deleted = objUSStateDAO.Delete(key);

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

        protected static List<USState> DALayer_GetAllUSStates()
        {
            //Step A-Start Error Trapping
            try
            {
                DALObjectFactoryBase objSQLDAOFactory = DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);

                //Step 2-now that you have the SQL FACTORY object GET DAO object to do the work
                USStateDAO objUSStateDAO = objSQLDAOFactory.GetUSStateDAO();

                //Step 3-call USStateDAO DAO to do the work & return COLLECTION of Data Transfer Objects
                List<USStateDTO> objUSStateDTOList = objUSStateDAO.GetAllRecords();

                //Step 4- test if List<USStateDTO> DTO collection exists
                if (objUSStateDTOList != null)
                {
                    //Step 5-Create a LIST Collection of USState object to get copy of DTO collection
                    List<USState> objUSStateList = new List<USState>();

                    //Step 6-Loop through List<USStateDTO> objUSStateDTOList collection
                    foreach (USStateDTO objDTO in objUSStateDTOList)
                    {
                        //Step 6a-Create new USState object
                        USState objUSState = new USState();

                        //Step 6b-get the data from DTO object and SET USState ob
                        objUSState.StateID = objDTO.StateID;
                        objUSState.StateCode = objDTO.StateCode;
                        objUSState.StateName = objDTO.StateName;

                        //Step 6c-Add USState Object to the objUSStateList List<USState> COLLECTION
                        objUSStateList.Add(objUSState);
                    }//End of foreach

                    //Step 6d-once copy process ends, Return objUSStateList List<USState> COLLECTION
                    return objUSStateList;
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
                throw new Exception("Unexpected Error in DALayer_GetAllState(key) Method: {0} " +
                objE.Message);
            }
        }//End of method
    }
}
