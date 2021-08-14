using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ARMSDALayer
{
    public class CreditCardDAO : ICreditCardDAO
    {
        //Data Access Object class which will perfomr all data access on 
        //behalf of the CreditCard class in the Business Layer

        public CreditCardDTO GetRecordByID(string key)
        {
            //Get connection from SQLServerDAOfacotry Object & create ADO SqlConnection Object
            SqlConnection objConn = new SqlConnection(SQLServerDAOFactory.ConnectionString());

            try
            {
                //Open connection
                objConn.Open();

                //create Sql String
                string strSQL = "SELECT * FROM CreditCard WHERE CreditCardNumber = @CreditCardNumber;";

                //create Command object, pass query and connection object
                SqlCommand objCmd = new SqlCommand(strSQL, objConn);

                //Set CommandType Preperty to text due to the query being a string and not a stored procedure
                //for stroed procedure use CommandType.StoredProcedure;
                objCmd.CommandType = CommandType.Text;

                //Add the methods Parameter to the query
                objCmd.Parameters.Add("@CreditCardNumber", SqlDbType.VarChar).Value = key;

                //Create datareader pointer & execute Query using Command Object
                // ExecuteReader which returns a populated datareader object with results 
                SqlDataReader objDR = objCmd.ExecuteReader();

                // test to make sure there is data in the DataReader Object
                if (objDR.HasRows)
                {
                    //create data transfer object
                    CreditCardDTO objDTO = new CreditCardDTO();

                    //call read method to point and read first record
                    objDR.Read();

                    //extrect data from a row Object Populates itself
                    //Order must be kept in which the Query returns data
                    //in this case * returns all the columns and the table columns dictate the order
                    objDTO.CreditCardNumber = objDR.GetString(0);
                    objDTO.CreditCardOwnerName = objDR.GetString(1);
                    objDTO.MerchantName = objDR.GetString(2);
                    objDTO.ExpDate = objDR.GetDateTime(3);
                    objDTO.AddressLine1 = objDR.GetString(4);
                    objDTO.AddressLine2 = objDR.GetString(5);
                    objDTO.City = objDR.GetString(6);
                    objDTO.StateCode = objDR.GetString(7);
                    objDTO.ZipCode = objDR.GetString(8);
                    objDTO.Country = objDR.GetString(9);
                    objDTO.CreditCardLimit = objDR.GetDecimal(10);
                    objDTO.CreditCardBalance = objDR.GetDecimal(11);
                    objDTO.ActivationStatus = objDR.GetBoolean(12);

                    //return data transfer object
                    return objDTO;

                }

                // terminate ADO objects
                objDR.Close();
                objDR = null;
                objCmd.Dispose();
                objCmd = null;

                //return null since no data found
                return null;
            }//End of try

            //Step B-Trap for BO, App & General Exceptions
            catch (Exception objE)
            {
                //Step C- throw system exception since run time error has occurred.
                throw new Exception("Unexpected Error in CreditCardADO GetRecordByID(key) Method: " +
                "{0} " + objE.Message);
            }
            finally
            {
                //Will always execute, terminate connection
                objConn.Close();
                objConn.Dispose();
                objConn = null;
            }
        }//End of GetRecordByID

        public bool Insert(CreditCardDTO objDTO)
        {
            //Step 1-GET the Connection from SQLServerDAOFactory Object & Create ADO SqlConnection Object
            SqlConnection objConn = new SqlConnection(SQLServerDAOFactory.ConnectionString());
            //Step A-Start Error Trapping
            try
            {
                //Step 2-Open connection
                objConn.Open();
                //Step 3-Create SQL string
                string strSQL;
                strSQL = "INSERT INTO CreditCard (CreditCardNumber,OwnerName,MerchantName,ExpDate,";
                strSQL = strSQL + "AddressLine1,AddressLine2,City,StateCode,ZipCode,Country,";
                strSQL = strSQL + "CreditCardLimit,CreditCardBalance,ActivationStatus)";
                strSQL = strSQL + "VALUES(@CreditCardNumber,@OwnerName,@MerchantName,@ExpDate,";
                strSQL = strSQL + "@AddressLine1,@AddressLine2,@City,@StateCode,@ZipCode,@Country,";
                strSQL = strSQL + "@CreditCardLimit,@CreditCardBalance,@ActivationStatus);";

                //Step 4-Create Command object, pass query and connection object
                SqlCommand objCmd = new SqlCommand(strSQL, objConn);
                //Step 5-SET CommandType Property to text since we have a query string & NOT a Stored-Procedure
                //For stored procedures syntax is objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.CommandType = CommandType.Text;
                //Step 6-Add Parameter to. NOTE WE ARE ASSIGNING METHOD PARAMETER
                //IMPORTANT! Parameter TOKENS @XXXXX name must match same name Used in the INSERT QUERY 
                //AND LISTED IN THE ORDER LISTED IN INSERT QUERY! NOTE WE ARE ASSIGNING ALL OBJECT'S DATA
                objCmd.Parameters.Add("@CreditCardNumber", SqlDbType.VarChar).Value = objDTO.CreditCardNumber;
                objCmd.Parameters.Add("@OwnerName", SqlDbType.VarChar).Value = objDTO.CreditCardOwnerName;
                objCmd.Parameters.Add("@MerchantName", SqlDbType.VarChar).Value = objDTO.MerchantName;
                objCmd.Parameters.Add("@ExpDate", SqlDbType.VarChar).Value = objDTO.ExpDate;
                objCmd.Parameters.Add("@AddressLine1", SqlDbType.VarChar).Value = objDTO.AddressLine1;
                objCmd.Parameters.Add("@AddressLine2", SqlDbType.VarChar).Value = objDTO.AddressLine2;
                objCmd.Parameters.Add("@City", SqlDbType.VarChar).Value = objDTO.City;
                objCmd.Parameters.Add("@StateCode", SqlDbType.Char).Value = objDTO.StateCode.ToCharArray();
                objCmd.Parameters.Add("@ZipCode", SqlDbType.VarChar).Value = objDTO.ZipCode;
                objCmd.Parameters.Add("@Country", SqlDbType.VarChar).Value = objDTO.Country;
                objCmd.Parameters.Add("@CreditCardLimit", SqlDbType.Decimal).Value = objDTO.CreditCardLimit;
                objCmd.Parameters.Add("@CreditCardBalance", SqlDbType.Decimal).Value = objDTO.CreditCardBalance;
                objCmd.Parameters.Add("@ActivationStatus", SqlDbType.Bit).Value = objDTO.ActivationStatus;

                //Step 7-Execute ACTION-Query, Test result and throw exception if failed
                int intRecordsAffected = objCmd.ExecuteNonQuery();
                //Step 8-validate if INSERT QUERY was successful
                if (intRecordsAffected == 1)
                {
                    //Step 8a-Return true
                    return true;
                }
                //Step 9 - Terminate ADO Objects
                objCmd.Dispose();
                objCmd = null;
                //Step10-return false
                return false;
            }//End of try
             //Step B-Trap for BO, App & General Exceptions
            catch (Exception objE)
            {
                //Step C- throw system exception since run time error has occurred.
                throw new Exception("Unexpected Error in CreditCardADO Insert(CreditCardDTO objDTO) Method: " +
                " {0} " + objE.Message);
            }
            finally
            {
                //Step 11-Terminate connection
                objConn.Close();
                objConn.Dispose();
                objConn = null;
            }
        }//End of Insert

        public bool InsertChildObjectOfAParent(string parentKey, CreditCardDTO objDTO)
        {
            //Step 1-GET the Connection from SQLServerDAOFactory Object & Create ADO SqlConnection Object
            SqlConnection objConn = new SqlConnection(SQLServerDAOFactory.ConnectionString());
            //Step A-Start Error Trapping
            try
            {
                //Step 2-Open connection
                objConn.Open();
                //Step 3-Create SQL string
                string strSQL;
                //Step 4-This is a multi-query where two INSERT statements are executed one after the other
                //The first inserts into the CreditCard table, the second adds a row to the
                //Person_CreditCard Table to complete the association betweeen the Person and the
                //Credit Card they own. Note spaces within the string for formatting the query
                strSQL = "INSERT INTO CreditCard (CreditCardNumber,OwnerName,MerchantName,ExpDate,";
                strSQL = strSQL + "AddressLine1,AddressLine2,City,StateCode,ZipCode,Country,";
                strSQL = strSQL + "CreditCardLimit,CreditCardBalance,ActivationStatus)";
                strSQL = strSQL + "VALUES(@CreditCardNumber,@OwnerName,@MerchantName,@ExpDate,";
                strSQL = strSQL + "@AddressLine1,@AddressLine2,@City,@StateCode,@ZipCode,@Country,";
                strSQL = strSQL + "@CreditCardLimit,@CreditCardBalance,@ActivationStatus);";
                strSQL = strSQL + " INSERT INTO Customer_CreditCard (CustomerID,CreditCardNumber)";
                strSQL = strSQL + "VALUES (@CustomerID,@CreditCardNumber);";

                //Step 5-Create Command object, pass query and connection object
                SqlCommand objCmd = new SqlCommand(strSQL, objConn);
                //Step 6-SET CommandType Property to text since we have a query string & NOT a Stored-Procedure
                //For stored procedures syntax is objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.CommandType = CommandType.Text;
                //Step 7-Add Parameter to. NOTE WE ARE ASSIGNING METHOD PARAMETER
                //IMPORTANT! Parameter TOKENS @XXXXX name must match same name Used in the INSERT QUERY 
                //AND IN LISTED IN THE ORDER LISTED IN INSERT QUERY! NOTE WE ARE ASSIGNING ALL OBJECT'S DATA
                objCmd.Parameters.Add("@CreditCardNumber", SqlDbType.VarChar).Value = objDTO.CreditCardNumber;
                objCmd.Parameters.Add("@OwnerName", SqlDbType.VarChar).Value = objDTO.CreditCardOwnerName;
                objCmd.Parameters.Add("@MerchantName", SqlDbType.VarChar).Value = objDTO.MerchantName;
                objCmd.Parameters.Add("@ExpDate", SqlDbType.VarChar).Value = objDTO.ExpDate;
                objCmd.Parameters.Add("@AddressLine1", SqlDbType.VarChar).Value = objDTO.AddressLine1;
                objCmd.Parameters.Add("@AddressLine2", SqlDbType.VarChar).Value = objDTO.AddressLine2;
                objCmd.Parameters.Add("@City", SqlDbType.VarChar).Value = objDTO.City;
                objCmd.Parameters.Add("@StateCode", SqlDbType.Char).Value = objDTO.StateCode.ToCharArray();
                objCmd.Parameters.Add("@ZipCode", SqlDbType.VarChar).Value = objDTO.ZipCode;
                objCmd.Parameters.Add("@Country", SqlDbType.VarChar).Value = objDTO.Country;
                objCmd.Parameters.Add("@CreditCardLimit", SqlDbType.Decimal).Value = objDTO.CreditCardLimit;
                objCmd.Parameters.Add("@CreditCardBalance", SqlDbType.Decimal).Value = objDTO.CreditCardBalance;
                objCmd.Parameters.Add("@ActivationStatus", SqlDbType.Bit).Value = objDTO.ActivationStatus;
                objCmd.Parameters.Add("@CustomerID", SqlDbType.VarChar).Value = parentKey;

                //Step 8-Execute ACTION-Query, Test result and throw exception if failed
                int intRecordsAffected = objCmd.ExecuteNonQuery();
                //Step 9-validate if INSERT QUERY was successful
                if (intRecordsAffected == 2)
                {
                    //Step 9a-Return true
                    return true;
                }
                //Step 10 - Terminate ADO Objects
                objCmd.Dispose();
                objCmd = null;
                //Step10-return false
                return false;
            }//End of try
             //Step B-Trap for BO, App & General Exceptions
            catch (Exception objE)
            {
                //Step C- throw system exception since run time error has occurred.
                throw new Exception("Unexpected Error in CreditCardADO InsertChildObjectOfAParent (Key, CreditCardDTO objDTO) Method: { 0} " +
                 objE.Message);
            }
            finally
            {
                //Step 11-Terminate connection
                objConn.Close();
                objConn.Dispose();
                objConn = null;
            }
        }//End of InsertChildObjectOfParent

        public bool Update(CreditCardDTO objDTO)
        {
            //Step 1-GET the Connection from SQLServerDAOFactory Object & Create ADO SqlConnection Object
            SqlConnection objConn = new SqlConnection(SQLServerDAOFactory.ConnectionString());
            //Step A-Start Error Trapping
            try
            {
                //Step 2-Open connection
                objConn.Open();
                //Step 3-Create SQL string
                string strSQL;
                strSQL = "UPDATE CreditCard";
                strSQL = strSQL + " SET OwnerName=@OwnerName,";
                strSQL = strSQL + "MerchantName=@MerchantName,";
                strSQL = strSQL + "ExpDate=@ExpDate,";
                strSQL = strSQL + "AddressLine1=@AddressLine1,";
                strSQL = strSQL + "AddressLine2=@AddressLine2,";
                strSQL = strSQL + "City=@City,";
                strSQL = strSQL + "StateCode=@StateCode,";
                strSQL = strSQL + "ZipCode=@ZipCode,";
                strSQL = strSQL + "Country=@Country,";
                strSQL = strSQL + "CreditCardLimit=@CreditCardLimit,";
                strSQL = strSQL + "CreditCardBalance=@CreditCardBalance,";
                strSQL = strSQL + "ActivationStatus=@ActivationStatus";
                strSQL = strSQL + " WHERE CreditCardNumber=@CreditCardNumber;";

                //Step 4-Create Command object, pass query and connection object
                SqlCommand objCmd = new SqlCommand(strSQL, objConn);
                //Step 5-SET CommandType Property to text since we have a query string & NOT a Stored-Procedure
                //For stored procedures syntax is objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.CommandType = CommandType.Text;
                //Step 6-Add Parameter to. NOTE WE ARE ASSIGNING METHOD PARAMETER
                //IMPORTANT! Parameter TOKENS @XXXXX name must match same name Used in the UPDATE QUERY 
                //AND IN LISTED IN THE ORDER LISTED IN INSERT QUERY! NOTE WE ARE ASSIGNING ALL OBJECT'S DATA
                objCmd.Parameters.Add("@OwnerName", SqlDbType.VarChar).Value = objDTO.CreditCardOwnerName;
                objCmd.Parameters.Add("@MerchantName", SqlDbType.VarChar).Value = objDTO.MerchantName;
                objCmd.Parameters.Add("@ExpDate", SqlDbType.VarChar).Value = objDTO.ExpDate;
                objCmd.Parameters.Add("@AddressLine1", SqlDbType.VarChar).Value = objDTO.AddressLine1;
                objCmd.Parameters.Add("@AddressLine2", SqlDbType.VarChar).Value = objDTO.AddressLine2;
                objCmd.Parameters.Add("@City", SqlDbType.VarChar).Value = objDTO.City;
                objCmd.Parameters.Add("@StateCode", SqlDbType.Char).Value = objDTO.StateCode.ToCharArray();
                objCmd.Parameters.Add("@ZipCode", SqlDbType.VarChar).Value = objDTO.ZipCode;
                objCmd.Parameters.Add("@Country", SqlDbType.VarChar).Value = objDTO.Country;
                objCmd.Parameters.Add("@CreditCardLimit", SqlDbType.Decimal).Value = objDTO.CreditCardLimit;
                objCmd.Parameters.Add("@CreditCardBalance", SqlDbType.Decimal).Value = objDTO.CreditCardBalance;
                objCmd.Parameters.Add("@ActivationStatus", SqlDbType.Bit).Value = objDTO.ActivationStatus;
                objCmd.Parameters.Add("@CreditCardNumber", SqlDbType.VarChar).Value = objDTO.CreditCardNumber;

                //Step 7-Execute ACTION-Query, Test result and throw exception if failed
                int intRecordsAffected = objCmd.ExecuteNonQuery();
                //Step 8-validate if INSERT QUERY was successful
                if (intRecordsAffected == 1)
                {
                    //Step 8a-Return true
                    return true;
                }
                //Step 9 - Terminate ADO Objects
                objCmd.Dispose();
                objCmd = null;
                //Step10-return false
                return false;
            }//End of try
             //Step B-Trap for BO, App & General Exceptions
            catch (Exception objE)
            {
                //Step C- throw system exception since run time error has occurred.
                throw new Exception("Unexpected Error in CreditCardADO Update(CreditCardDTO objDTO) Method: " +
               " {0} " + objE.Message);
            }
            finally
            {
                //Step 11-Terminate connection
                objConn.Close();
                objConn.Dispose();
                objConn = null;
            }
        }//End of Update

        public bool Delete(string key)
        {
            //Step 1-GET the Connection from SQLServerDAOFactory Object & Create ADO SqlConnection Object
            SqlConnection objConn = new SqlConnection(SQLServerDAOFactory.ConnectionString());
            //Step A-Start Error Trapping
            try
            {
                //Step 2-Open connection
                objConn.Open();
                //Step 3-Create SQL string
                string strSQL = "DELETE FROM CreditCard WHERE CreditCardNumber = @CreditCardNumber;";

                //Step 4-Create Command object, pass query and connection object
                SqlCommand objCmd = new SqlCommand(strSQL, objConn);
                //Step 5-SET CommandType Property to text since we have a query string & NOT a Stored-Procedure
                //For stored procedures syntax is objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.CommandType = CommandType.Text;
                //Step 6-Add Parameter to. NOTE WE ARE ASSIGNING METHOD PARAMETER
                //IMPORTANT! Parameter TOKENS @XXXXX name must match same name Used in the UPDATE QUERY 
                //AND IN LISTED IN THE ORDER LISTED IN INSERT QUERY! NOTE WE ARE ASSIGNING ALL OBJECT'S DATA
                objCmd.Parameters.Add("@CreditCardNumber", SqlDbType.VarChar).Value = key;

                //Step 7-Execute ACTION-Query, Test result and throw exception if failed
                int intRecordsAffected = objCmd.ExecuteNonQuery();
                //Step 8-validate if INSERT QUERY was successful
                if (intRecordsAffected == 1)
                {
                    //Step 8a-Return true
                    return true;
                }
                //Step 9 - Terminate ADO Objects
                objCmd.Dispose();
                objCmd = null;
                //Step10-return false
                return false;
            }//End of try
             //Step B-Trap for BO, App & General Exceptions
            catch (Exception objE)
            {
                //Step C- throw system exception since run time error has occurred.
                throw new Exception("Unexpected Error in CreditCardADO Delete(key) Method: " +
                " {0} " + objE.Message);
            }
            finally
            {
                //Step 11-Terminate connection
                objConn.Close();
                objConn.Dispose();
                objConn = null;
            }
        }//End of Delete

        public List<CreditCardDTO> GetAllRecords()
        {
            //Step 1-GET the Connection from SQLServerDAOFactory Object & Create ADO SqlConnection Object 
            SqlConnection objConn = new SqlConnection(SQLServerDAOFactory.ConnectionString());
            //Step A-Start Error Trapping
            try
            {
                //Step 2-Open connection
                objConn.Open();
                //Step 3-Create SQL string
                string strSQL = "SELECT * FROM CreditCard;";

                //Step 4-Create Command object, pass query and connection object
                SqlCommand objCmd = new SqlCommand(strSQL, objConn);
                //Step 5-SET CommandType Property to text since we have a query string & NOT a Stored-Procedure
                //For stored procedures syntax is objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.CommandType = CommandType.Text;
                //Step 7-Create DATAREADER POINTER & Execute Query via
                //COMMAND OBJECT ExecuteReader Method which returns a populated
                //DATAREADER OBJECT with the results of the query
                SqlDataReader objDR = objCmd.ExecuteReader();

                //Step 8-Test to make sure there is data in the DataReader Object
                if (objDR.HasRows)
                {
                    //Step 9-Test Create a Generic List Collection Object of Data Transfer Objects
                    List<CreditCardDTO> colRecordList = new List<CreditCardDTO>();
                    //Step 10-Loop through the Collection to Add Data Transfer Object
                    while (objDR.Read())
                    {
                        //10a-Create Data Transfer Object
                        CreditCardDTO objDTO = new CreditCardDTO();
                        //10b-Populate Data Transfer Object with DataReader records. IMPORTANT! Note that data
                        // must be extracted in the ORDER in which the QUERY RETURNS THE DATA.
                        objDTO.CreditCardNumber = objDR.GetString(0);
                        objDTO.CreditCardOwnerName = objDR.GetString(1);
                        objDTO.MerchantName = objDR.GetString(2);
                        objDTO.ExpDate = objDR.GetDateTime(3);
                        objDTO.AddressLine1 = objDR.GetString(4);
                        objDTO.AddressLine2 = objDR.GetString(5);
                        objDTO.City = objDR.GetString(6);
                        objDTO.StateCode = objDR.GetString(7);
                        objDTO.ZipCode = objDR.GetString(8);
                        objDTO.Country = objDR.GetString(9);
                        objDTO.CreditCardLimit = objDR.GetDecimal(10);
                        objDTO.CreditCardBalance = objDR.GetDecimal(11);
                        objDTO.ActivationStatus = objDR.GetBoolean(12);
                        //Step 10c-Add Data Transfer Object to the collection
                        colRecordList.Add(objDTO);
                    }//End of loop
                     //Step 11-Return the collection
                    return colRecordList;
                }
                else
                {
                    //Step 12 - Terminate ADO Objects
                    objDR.Close();
                    objDR = null;
                    objCmd.Dispose();
                    objCmd = null;
                    //Step13-return null since no records found
                    return null;

                }//End of if/else
            }//End of try
             //Step B-Trap for BO, App & General Exceptions
            catch (Exception objE)
            {
                //Step C- throw system exception since run time error has occurred.
                throw new Exception("Unexpected Error in CreditCardADO GetAllRecords() Method: " +
                 " {0} " + objE.Message);
            }
            finally
            {
                //Step 11-Terminate connection
                objConn.Close();
                objConn.Dispose();
                objConn = null;
            }
        }//End of GetAllRecords

        public List<string> GetAllKeys()
        {
            //Step 1-GET the Connection from SQLServerDAOFactory Object & Create ADO SqlConnection Object
            SqlConnection objConn = new SqlConnection(SQLServerDAOFactory.ConnectionString());
            //Step A-Start Error Trapping
            try
            {
                //Step 2-Open connection
                objConn.Open();
                //Step 3-Create SQL string
                string strSQL = "SELECT CreditCardNumber FROM CreditCard;";

                //Step 4-Create Command object, pass query and connection object
                SqlCommand objCmd = new SqlCommand(strSQL, objConn);
                //Step 5-SET CommandType Property to text since we have a query string & NOT a Stored-Procedure
                //For stored procedures syntax is objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.CommandType = CommandType.Text;
                //Step 7-Create DATAREADER POINTER & Execute Query via
                //COMMAND OBJECT ExecuteReader Method which returns a populated
                //DATAREADER OBJECT with the results of the query
                SqlDataReader objDR = objCmd.ExecuteReader();

                //Step 8-Test to make sure there is data in the DataReader Object
                if (objDR.HasRows)
                {
                    //Step 9-Test Create a Generic List Collection Object of Data Transfer Objects
                    List<string> colKeyList = new List<string>();
                    //Step 10-Loop through the Collection & Add results from the first column of DataReader
                    while (objDR.Read())
                    {
                        //Step 10a-Add Data Transfer Object to the collection
                        colKeyList.Add(objDR.GetString(0));
                    }//End of loop
                     //Step 11-Return the collection
                    return colKeyList;
                }
                else
                {
                    //Step 12 - Terminate ADO Objects
                    objDR.Close();
                    objDR = null;
                    objCmd.Dispose();
                    objCmd = null;
                    //Step13-return null since no records found
                    return null;

                }//End of if/else
            }//End of try
             //Step B-Trap for BO, App & General Exceptions
            catch (Exception objE)
            {
                //Step C- throw system exception since run time error has occurred.
                throw new Exception("Unexpected Error in CreditCardADO GetAllKeys() Method: " +
                 " {0} " + objE.Message);
            }
            finally
            {
                //Step 11-Terminate connection
                objConn.Close();
                objConn.Dispose();
                objConn = null;
            }
        }//End of GetAllKeys

        public List<CreditCardDTO> GetAllChildRecordsOwnedByParent(int parentKey)
        {
            //Step 1-GET the Connection from SQLServerDAOFactory Object & Create ADO SqlConnection Object
            SqlConnection objConn = new SqlConnection(SQLServerDAOFactory.ConnectionString());
            //Step A-Start Error Trapping
            try
            {
                //Step 2-Open connection
                objConn.Open();
                //Step 3-Create SQL string. Note spaces between SELECT, FROM, WHERE & AND clauses
                string strSQL;
                strSQL = "SELECT CreditCard.CreditCardNumber,CreditCard.OwnerName,";
                strSQL = strSQL + "CreditCard.MerchantName,CreditCard.ExpDate,";
                strSQL = strSQL + "CreditCard.AddressLine1,CreditCard.AddressLine2, CreditCard.City,CreditCard.StateCode,";
                strSQL = strSQL + "CreditCard.ZipCode,CreditCard.Country,";
                strSQL = strSQL + "CreditCard.CreditCardLimit,CreditCard.CreditCardBalance,)";
                strSQL = strSQL + "CreditCard.ActivationStatus)";
                strSQL = strSQL + " FROM CreditCard, Customer_CreditCard";
                strSQL = strSQL + " WHERE CreditCard.CreditCardNumber = Customer_CreditCard.CreditCardNumber";
                strSQL = strSQL + " AND Customer_CreditCard.CustomerID = @CustomerID;";

                //Step 4-Create Command object, pass query and connection object
                SqlCommand objCmd = new SqlCommand(strSQL, objConn);
                //Step 5-SET CommandType Property to text since we have a query string & NOT a Stored-Procedure
                //For stored procedures syntax is objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.CommandType = CommandType.Text;
                //Step 6-Add Parameter to. NOTE WE ARE ASSIGNING METHOD PARAMETER
                objCmd.Parameters.Add("@CustomerID", SqlDbType.Int).Value = parentKey;
                //Step 7-Create DATAREADER POINTER & Execute Query via
                //COMMAND OBJECT ExecuteReader Method which returns a populated
                //DATAREADER OBJECT with the results of the query
                SqlDataReader objDR = objCmd.ExecuteReader();

                //Step 8-Test to make sure there is data in the DataReader Object
                if (objDR.HasRows)
                {
                    //Step 9-Test Create a Generic List Collection Object of Data Transfer Objects
                    List<CreditCardDTO> colRecordList = new List<CreditCardDTO>();
                    //Step 10-Loop through the Collection & Add Data Transfer Object (DTO)
                    while (objDR.Read())
                    {
                        //10a-Create Data Transfer Object
                        CreditCardDTO objDTO = new CreditCardDTO();
                        //10b-Populate Data Transfer Object with DataReader records
                        //IMPORTANT! Note that data must be extracted in the ORDER 
                        //in which the QUERY RETURNS THE DATA.
                        objDTO.CreditCardNumber = objDR.GetString(0);
                        objDTO.CreditCardOwnerName = objDR.GetString(1);
                        objDTO.MerchantName = objDR.GetString(2);
                        objDTO.ExpDate = objDR.GetDateTime(3);
                        objDTO.AddressLine1 = objDR.GetString(4);
                        objDTO.AddressLine2 = objDR.GetString(5);
                        objDTO.City = objDR.GetString(6);
                        objDTO.StateCode = objDR.GetString(7);
                        objDTO.ZipCode = objDR.GetString(8);
                        objDTO.Country = objDR.GetString(9);
                        objDTO.CreditCardLimit = objDR.GetDecimal(10);
                        objDTO.CreditCardBalance = objDR.GetDecimal(11);
                        objDTO.ActivationStatus = objDR.GetBoolean(12);
                        //Step 10c-Add Data Transfer Object to the collection
                        colRecordList.Add(objDTO);
                    }//End of loop
                     //Step 11-Return the collection
                    return colRecordList;
                }
                else
                {
                    //Step 12 - Terminate ADO Objects
                    objDR.Close();
                    objDR = null;
                    objCmd.Dispose();
                    objCmd = null;
                    //Step13-return null since no records found
                    return null;

                }//End of if/else
            }//End of try
             //Step B-Trap for BO, App & General Exceptions
            catch (Exception objE)
            {
                //Step C- throw system exception since run time error has occurred.
                throw new Exception("Unexpected Error in CreditCardADO GetAllChildKeysOwnedByParent() Method: " +
                " {0} " + objE.Message);
            }
            finally
            {
                //Step 11-Terminate connection
                objConn.Close();
                objConn.Dispose();
                objConn = null;
            }
        }//End of GetAllChildRecordsOwnedByParent

        public List<string> GetAllChildKeysOwnedByParent(int parentKey)
        {
            //Step 1-GET the Connection from SQLServerDAOFactory Object & Create ADO SqlConnection Object
            SqlConnection objConn = new SqlConnection(SQLServerDAOFactory.ConnectionString());
            //Step A-Start Error Trapping
            try
            {
                //Step 2-Open connection
                objConn.Open();
                //Step 3-Create SQL string. Note spaces between SELECT, FROM, WHERE & AND clauses
                string strSQL;
                strSQL = "SELECT CreditCard.CreditCardCardNumber";
                strSQL = strSQL + " FROM CreditCard, Customer_CreditCard";
                strSQL = strSQL + " WHERE CreditCard.CreditCardNumber = Customer_CreditCard.CreditCardNumber";
                strSQL = strSQL + " AND Customer_CreditCard.CustomerID = @CustomerID;";

                //Step 4-Create Command object, pass query and connection object
                SqlCommand objCmd = new SqlCommand(strSQL, objConn);
                //Step 5-SET CommandType Property to text since we have a query string & NOT a Stored-Procedure
                //For stored procedures syntax is objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.CommandType = CommandType.Text;
                //Step 6-Add Parameter to. NOTE WE ARE ASSIGNING METHOD PARAMETER
                objCmd.Parameters.Add("@CustomerID", SqlDbType.Int).Value = parentKey;
                //Step 7-Create DATAREADER POINTER & Execute Query via
                //COMMAND OBJECT ExecuteReader Method which returns a populated
                //DATAREADER OBJECT with the results of the query
                SqlDataReader objDR = objCmd.ExecuteReader();

                //Step 8-Test to make sure there is data in the DataReader Object
                if (objDR.HasRows)
                {
                    //Step 9-Test Create a Generic List Collection Object of Data Transfer Objects
                    List<string> colKeyList = new List<string>();
                    //Step 10-Loop through the Collection & Add results from the first column of DataReader
                    while (objDR.Read())
                    {
                        //Step 10a-Add Data Transfer Object to the collection
                        colKeyList.Add(objDR.GetString(0));
                    }//End of loop
                     //Step 11-Return the collection
                    return colKeyList;
                }
                else
                {
                    //Step 12 - Terminate ADO Objects
                    objDR.Close();
                    objDR = null;
                    objCmd.Dispose();
                    objCmd = null;
                    //Step13-return null since no records found
                    return null;

                }//End of if/else
            }//End of try
             //Step B-Trap for BO, App & General Exceptions
            catch (Exception objE)
            {
                //Step C- throw system exception since run time error has occurred.
                throw new Exception("Unexpected Error in CreditCardADO GetAllChildKeysOwnedByParent() Method: " +
                 "{0} " + objE.Message);
            }
            finally
            {
                //Step 11-Terminate connection
                objConn.Close();
                objConn.Dispose();
                objConn = null;
            }
        }//End of GetAllChildKeysOwnedByParent
    }
}
