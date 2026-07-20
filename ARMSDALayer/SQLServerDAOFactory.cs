namespace ARMSDALayer
{
    //*************************************** SQLServerDAOFactory CLASS *******************************************************************

    //######################################################## IMPORTANT WARNING! #######################################################
    //NOTE THAT IS PROVIDED HERE IN THIS DOCUMENT IS THE CODE INSIDE THE CLASS. 
    //THE CLASS HEADER AND STRUCTURE SHOULD HAVE ALREADY BEEN CREATED VIA VISUAL STUDIO VIA REQUIREMENTS AS INTRUCTED IN THE REQUIREMENT DOCUMENTATION.

    //###########################################################################################################################################


    //====================== REMEMBER THAT THE SQLServerDAOFactory CLASS IS INHERITED FROM DALObjectFactoryBase THEREFORE APPEND DECLARATION TO CLASS HEADER ====


    public class SQLServerDAOFactory : DALObjectFactoryBase
    {





        //====================== START of SQLServerDAOFactory CLASS CODE Declaration =======================================================


        //=================================================================
        //Name:         ConnectionString() Method
        //Purpose:      Centralized method that returns the Connection  
        //              String for MS SQLServer data access.
        //Parameter:    None.
        //Return Value: string that contains the connection string.
        public static string ConnectionString()
        {
            return "Data Source=localhost\\SQLEXPRESS;Initial Catalog=EzRentalAppDB;Integrated Security=True;TrustServerCertificate=True;";

        }

        //=================================================================
        //Name:         GetCreditCardDAO() Method
        //Purpose:      Method that returns the CreditCardDAO Data Access Object 
        //              that handles the data access for the CreditCard 
        //              class in the business object Layer.
        //Parameter:    None.
        //Return Value: a new CreditCardDAO object.
        public override CreditCardDAO GetCreditCardDAO()
        {
            //return CreditCardDAO Data Access Object to perform CreditCard class Data Access
            return new CreditCardDAO();

        }



        //====================== END of SQLServerDAOFactory CLASS CODE Declaration =======================================================

    }
}