using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARMSDALayer
{
    class SQLServerDAOFactory : DALObjectFactoryBase
    {
        //Public Static Method
        public static string ConnectionString()
        {
            //get database name for project
            return "Data Source=.\\SQLEXPRESS;Initial Catalog= ARMSDB;Integrated Security=True";
        }

        //Override the GetCreditCardDAO from parent class DALObjectFactoryBase
        public override CreditCardDAO GetCreditCardDAO()
        {
            return new CreditCardDAO();
        }

        //Override the GetUSStateDAO from parent class DALObjectFactoryBase
        public override USStateDAO GetUSStateDAO()
        {
            return new USStateDAO();
        }

        //Override the GetCountryDAO from parent class DALObjectFactoryBase
#pragma warning disable CS0115 // 'SQLServerDAOFactory.GetCountryDAO()': no suitable method found to override
#pragma warning disable CS0246 // The type or namespace name 'CountryDAO' could not be found (are you missing a using directive or an assembly reference?)
        public override CountryDAO GetCountryDAO()
#pragma warning restore CS0246 // The type or namespace name 'CountryDAO' could not be found (are you missing a using directive or an assembly reference?)
#pragma warning restore CS0115 // 'SQLServerDAOFactory.GetCountryDAO()': no suitable method found to override
        {
            return new CountryDAO();
        }
    }
}
