using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ARMSDALayer
{
    public class CountryDAO : IUserInterfaceDAO<CountryDTO>
    {
        public CountryDTO GetRecordByID(int key)
        {
            //Step 1-GET the Connection from SQLServerDAOFactory Object & Create DAO SqlConnection Object
            SqlConnection objConn = new SqlConnection(SQLServerDAOFactory.ConnectionString());

            //Step A-Start Error Trapping
            try
            {
                //Step 2-Open connection
                objConn.Open();

                //Step 3-Create SQL string
                string strSQL = "SELECT * FROM Country WHERE CountryID = @CountryID;";

                //Step 4-Create Command object, pass query and connection object
                SqlCommand objCmd = new SqlCommand(strSQL, objConn);

                //Step 5-SET CommandType Property to text since we have a query string & NOT a Stored-Procedure
                //For stored procedures syntax is objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.CommandType = CommandType.Text;

                //Step 6-Add Parameter to. NOTE WE ARE ASSIGNING METHOD PARAMETER
                objCmd.Parameters.Add("@CountryID", SqlDbType.VarChar).Value = key;

                //Step 7-Create DATAREADER POINTER & Execute Query via
                //COMMAND OBJECT ExecuteReader Method which returns a populated
                //DATAREADER OBJECT with the results of the query
                SqlDataReader objDR = objCmd.ExecuteReader();

                //Step 8-Test to make sure there is data in the DataReader Object
                if (objDR.HasRows)
                {
                    //Create Data Transfer Object
                    CountryDTO objDTO = new CountryDTO();
                    //Step 8a-Call Read() Method to point and read the first record
                    objDR.Read();
                    //Step 8b-Extract data from a row s Object Populates itself.
                    //IMPORTANT! Note that data must be extracted in the ORDER
                    //in which the QUERY RETURNS THE DATA.
                    objDTO.CountryID = objDR.GetByte(0);
                    //objDTO.CountryCode2 = objDR.GetString(1);
                    //objDTO.CountryCode3 = objDR.GetString(2);
                    objDTO.CountryName = objDR.GetString(1);
                    objDTO.CountryCode = objDR.GetString(2);
                    //objDTO.NumericCode = objDR.GetString(4);

                    //Step 8b- Return Data Transfer Object
                    return objDTO;
                }
                //Step 9 - Terminate ADO Objects
                objDR.Close();
                objDR = null;
                objCmd.Dispose();
                objCmd = null;
                //Step10- return null since no data found
                return null;
            }//End of try

            //Step B-Trap for BO, App & General Exceptions
            catch (Exception objE)
            {
                //Step C- throw system exception since run time error has occurred.
                throw new Exception("Unexpected Error in CountryDAO GetRecordByID(key) Method:{0} " + objE.Message);
            }
            finally
            {
                //Step 11-Terminate connection
                objConn.Close();
                objConn.Dispose();
                objConn = null;
            }
        }//End of GetRecordByID

        public bool Insert(CountryDTO objDTO)
        {
            //Step 1-GET the Connection from SQLServerDAOFactory Object & Create DAO SqlConnection Object
            SqlConnection objConn = new SqlConnection(SQLServerDAOFactory.ConnectionString());

            //Step A-Start Error Trapping
            try
            {
                //Step 2-Open connection
                objConn.Open();

                //Step 3-Create SQL string
                string strSQL;
                strSQL = "INSERT INTO Country (CountryID,CountryCode2,CountryCode3,CountryName,NumericCode)";
                strSQL = strSQL + "VALUES(@CountryID,@CountryCode2,@CountryCode3,@CountryName,@NumericCode);";

                //Step 4-Create Command object, pass query and connection object
                SqlCommand objCmd = new SqlCommand(strSQL, objConn);

                //Step 5-SET CommandType Property to text since we have a query string & NOT a Stored-Procedure
                //For stored procedures syntax is objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.CommandType = CommandType.Text;

                //Step 6-Add Parameter to. NOTE WE ARE ASSIGNING METHOD PARAMETER
                //IMPORTANT! Parameter TOKENS @XXXXX name must match same name Used in the INSERT QUERY
                //AND IN LISTED IN THE ORDER LISTED IN INSERT QUERY! NOTE WE ARE ASSIGNING ALL OBJECT'S DATA
                /*
                objCmd.Parameters.Add("@CountryID", SqlDbType.TinyInt).Value = objDTO.CountryID;
                objCmd.Parameters.Add("@CountryCode2", SqlDbType.Char).Value = objDTO.CountryCode2.ToCharArray();
                objCmd.Parameters.Add("@CountryCode3", SqlDbType.Char).Value = objDTO.CountryCode3.ToCharArray();
                objCmd.Parameters.Add("@CountryName", SqlDbType.VarChar).Value = objDTO.CountryName;
                objCmd.Parameters.Add("@NumericCode", SqlDbType.Char).Value = objDTO.NumericCode.ToCharArray();
                */

                objCmd.Parameters.Add("@CountryID", SqlDbType.TinyInt).Value = objDTO.CountryID;;
                objCmd.Parameters.Add("@CountryName", SqlDbType.VarChar).Value = objDTO.CountryName;
                objCmd.Parameters.Add("@CountryCode", SqlDbType.Char).Value = objDTO.CountryCode.ToCharArray();

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
                throw new Exception("Unexpected Error in CountryDAO Insert(CountryDTO objDTO) Method:{0} " + objE.Message);
            }
            finally
            {
                //Step 11-Terminate connection
                objConn.Close();
                objConn.Dispose();
                objConn = null;
            }
        }//End of Insert

        public bool Update(CountryDTO objDTO)
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
                strSQL = "UPDATE Country";
                strSQL = strSQL + " SET CountryID=@CountryID,";
                strSQL = strSQL + "CountryCode2=@CountryCode2,";
                strSQL = strSQL + "CountryCode3=@CountryCode3,";
                strSQL = strSQL + "CountryName=@CountryName,";
                strSQL = strSQL + "NumericCode=@NumericCode";
                strSQL = strSQL + " WHERE CountryID=@CountryID;";

                //Step 4-Create Command object, pass query and connection object
                SqlCommand objCmd = new SqlCommand(strSQL, objConn);

                //Step 5-SET CommandType Property to text since we have a query string & NOT a Stored-Procedure
                //For stored procedures syntax is objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.CommandType = CommandType.Text;

                //Step 6-Add Parameter to. NOTE WE ARE ASSIGNING METHOD PARAMETER
                //IMPORTANT! Parameter TOKENS @XXXXX name must match same name Used in the UPDATE QUERY
                //AND IN LISTED IN THE ORDER LISTED IN INSERT QUERY! NOTE WE ARE ASSIGNING ALL OBJECT'S DATA
                objCmd.Parameters.Add("@CountryID", SqlDbType.TinyInt).Value = objDTO.CountryID;
                objCmd.Parameters.Add("@CountryName", SqlDbType.VarChar).Value = objDTO.CountryName;
                objCmd.Parameters.Add("@CountryCode", SqlDbType.Char).Value = objDTO.CountryCode.ToCharArray();

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
                throw new Exception("Unexpected Error in CountryDAO Update(CountryDTO objDTO) Method:{0}" + objE.Message);
            }
            finally
            {
                //Step 11-Terminate connection
                objConn.Close();
                objConn.Dispose();
                objConn = null;
            }
        }//End of Insert

        public bool Delete(int key)
        {
            //Step 1-GET the Connection from SQLServerDAOFactory Object & Create ADO SqlConnection Object
            SqlConnection objConn = new SqlConnection(SQLServerDAOFactory.ConnectionString());
            //Step A-Start Error Trapping
            try
            {
                //Step 2-Open connection
                objConn.Open();

                //Step 3-Create SQL string
                string strSQL = "DELETE FROM Country WHERE CountryID = @CountryID;";

                //Step 4-Create Command object, pass query and connection object
                SqlCommand objCmd = new SqlCommand(strSQL, objConn);

                //Step 5-SET CommandType Property to text since we have a query string & NOT a Stored-Procedure
                //For stored procedures syntax is objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.CommandType = CommandType.Text;

                //Step 6-Add Parameter to. NOTE WE ARE ASSIGNING METHOD PARAMETER
                //IMPORTANT! Parameter TOKENS @XXXXX name must match same name Used in the UPDATE QUERY
                //AND IN LISTED IN THE ORDER LISTED IN INSERT QUERY! NOTE WE ARE ASSIGNING ALL OBJECT'S DATA
                objCmd.Parameters.Add("@CountryID", SqlDbType.TinyInt).Value = key;

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
                throw new Exception("Unexpected Error in CountryDAO Delete(key) Method:{0} " + objE.Message);
            }
            finally
            {
                //Step 11-Terminate connection
                objConn.Close();
                objConn.Dispose();
                objConn = null;
            }
        }//End of Delete

        public List<CountryDTO> GetAllRecords()
        {
            //Step 1-GET the Connection from SQLServerDAOFactory Object & Create ADO SqlConnection Object
            SqlConnection objConn = new SqlConnection(SQLServerDAOFactory.ConnectionString());

            //Step A-Start Error Trapping
            try
            {
                //Step 2-Open connection
                objConn.Open();

                //Step 3-Create SQL string
                string strSQL = "SELECT * FROM Country;";

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
                    List<CountryDTO> colRecordList = new List<CountryDTO>();

                    //Step 10-Loop through the Collection to Add Data Transfer Object
                    while (objDR.Read())
                    {
                        //10a-Create Data Transfer Object
                        CountryDTO objDTO = new CountryDTO();

                        //10b-Populate Data Transfer Object with DataReader records. IMPORTANT! Note that data
                        // must be extracted in the ORDER in which the QUERY RETURNS THE DATA.
                        /*
                        objDTO.CountryID = objDR.GetByte(0);
                        objDTO.CountryCode2 = objDR.GetString(1);
                        objDTO.CountryCode3 = objDR.GetString(2);
                        objDTO.CountryName = objDR.GetString(3);
                        objDTO.NumericCode = objDR.GetString(4);
                        */

                        objDTO.CountryID = objDR.GetByte(0);
                        objDTO.CountryCode = objDR.GetString(1);
                        objDTO.CountryName = objDR.GetString(2);

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
                } //end of if/else
            } //end of try

            //Step B-Trap for BO, App & General Exceptions
            catch (Exception objE)
            {
                //Step C- throw system exception since run time error has occurred.
                throw new Exception("Unexpected Error in CountryDAO GetAllRecords() Method:{0} " + objE.Message);
            }

            finally
            {
                //Step 11-Terminate connection
                objConn.Close();
                objConn.Dispose();
                objConn = null;
            }
        }//End of GetAllRecords
    }
}
