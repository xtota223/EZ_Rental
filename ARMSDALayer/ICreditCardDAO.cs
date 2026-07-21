using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace ARMSDALayer
{
    public interface ICreditCardDAO
    {
        //*************************************** ICreditCardDAO INTERFACE CODE *******************************************************************

        //######################################################## IMPORTANT WARNING! #######################################################
        //NOTE THAT IS PROVIDED HERE IN THIS DOCUMENT IS THE CODE INSIDE THE INTERFACE. 
        //THE INTERFACE HEADER AND STRUCTURE SHOULD HAVE ALREADY BEEN CREATED VIA VISUAL STUDIO VIA REQUIREMENTS AS INTRUCTED IN THE REQUIREMENT DOCUMENTATION.

        //###########################################################################################################################################



        //====================== START of ICreditCardDAO INTERFACE CODE LOCATED INSIDE THE INTERFACE HEADERS ========================



        /// <summary>
        /// Declaration of GetRecordByID(string key) method that 
        /// must be implemented by classes that implement this INTERFACE
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>

        CreditCardDTO GetRecordByID(string key);





        //====================== END of ICreditCardDAO INTERFACE Declarations =======================================================

       bool deleteRecordByID(string key);
    }
}
