using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARMSDALayer
{
    public abstract class DALObjectFactoryBase
    {
        //Public Constants to decide what Data source is being targeted
        public const int SQLSERVER = 1;
        public const int ORACLE = 2;
        public const int MYSQL = 3;

        //Static Processing Method
        public static DALObjectFactoryBase GetDataSourceDAOFactory(int targetDataSourceFactory)
        {
            switch (targetDataSourceFactory)
            {
                case 1: //MS SQLServer Data Source

                    //Return an object of the SQLServer Data Access
                    //Object Factory
                    //SQLServerDAOFactory Class
                    return new SQLServerDAOFactory();
                case 2: //Oracle Data Source

                    //Out of scope of this project and course.
                    //Throw NotImplementedException
                    throw new NotImplementedException();
                case 3: //MySQL Data Source
                        //Out of scope of this project and course.
                        //Throw NotImplementedException
                    throw new NotImplementedException();
                //case X: other data sources for this application here
                default: //Default valued returned when options not a case
                    return null;
            }//End of switch

        }//End of method

        //Enforced Method for Child Classes of Abstract DALObjectFactoryBase Class
        //Will only Implement CreditCardDAO for Backlog
        public abstract CreditCardDAO GetCreditCardDAO();
        public abstract USStateDAO GetUSStateDAO();
        public abstract CountryDAO GetCountryDAO();
        // public abstract CustomerUserAccountDAO GetCustomerUserAccountDAO();
        // public abstract RetailCustomerDAO GetRetailCustomerDAO();
        // public abstract CorporateCustomerDAO CorporateCustomerDAO();
    }
}
