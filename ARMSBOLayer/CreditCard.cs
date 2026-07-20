using System;
using System.Collections.Generic;
using System.Text;

using ARMSDALayer;
using System.IO;

namespace ARMSBOLayer
{
    public class CreditCard
    {
        private string m_CreditCardNumber;
        private string m_CreditCardOwnerName;
        private byte m_CreditCardProcessingMerchantServiceCompanyCode;
        private string m_CreditCardProcessingMerchantServiceCompanyName;
        private byte m_CreditCardNetworkCompanyCode;
        private string m_CreditCardNetworkCompanyName;
        private byte m_CreditCardIssuingBankCode;
        private string m_CreditCardIssuingBankName;
        private byte m_CreditCardCorporateMerchantBankCode;
        private string m_CreditCardCorporateMerchantBankName;
        private DateTime m_ExpDate;
        private string m_AddressLine1;
        private string m_AddressLine2;
        private string m_City;
        private string m_StateCode;
        private string m_ZipCode;
        private string m_Country;
        private decimal m_CreditCardLimit;
        private decimal m_CreditCardAvailableCredit;
        private bool m_CreditCardActivationStatus;


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

        public byte CreditCardProcessingMerchantServiceCompanyCode
        {
            get { return m_CreditCardProcessingMerchantServiceCompanyCode; }
            set { m_CreditCardProcessingMerchantServiceCompanyCode = value; }
        }

        public string CreditCardProcessingMerchantServiceCompanyName
        {
            get { return m_CreditCardProcessingMerchantServiceCompanyName; }
            set { m_CreditCardProcessingMerchantServiceCompanyName = value; }
        }

        public byte CreditCardNetworkCompanyCode
        {
            get { return m_CreditCardNetworkCompanyCode; }
            set { m_CreditCardNetworkCompanyCode = value; }
        }

        public string CreditCardNetworkCompanyName
        {
            get { return m_CreditCardNetworkCompanyName; }
            set { m_CreditCardNetworkCompanyName = value; }
        }

        public byte CreditCardIssuingBankCode
        {
            get { return m_CreditCardIssuingBankCode; }
            set { m_CreditCardIssuingBankCode = value; }
        }

        public string CreditCardIssuingBankName
        {
            get { return m_CreditCardIssuingBankName; }
            set { m_CreditCardIssuingBankName = value; }
        }

        public byte CreditCardCorporateMerchantBankCode
        {
            get { return m_CreditCardCorporateMerchantBankCode; }
            set { m_CreditCardCorporateMerchantBankCode = value; }
        }

        public string CreditCardCorporateMerchantBankName
        {
            get { return m_CreditCardCorporateMerchantBankName; }
            set { m_CreditCardCorporateMerchantBankName = value; }
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

        public decimal CreditCardAvailableCredit
        {
            get { return m_CreditCardAvailableCredit; }
            set { m_CreditCardAvailableCredit = value; }
        }


        public bool CreditCardActivationStatus
        {
            get { return m_CreditCardActivationStatus; }
        }

        public CreditCard()
        {
            m_CreditCardNumber = "";
            m_CreditCardOwnerName = "";
            m_CreditCardProcessingMerchantServiceCompanyCode = 0;
            m_CreditCardProcessingMerchantServiceCompanyName = "";
            m_CreditCardNetworkCompanyCode = 0;
            m_CreditCardNetworkCompanyName = "";
            m_CreditCardIssuingBankCode = 0;
            m_CreditCardIssuingBankName = "";
            m_CreditCardCorporateMerchantBankCode = 0;
            m_CreditCardCorporateMerchantBankName = "";
            m_ExpDate = new DateTime().Date;
            m_AddressLine1 = "";
            m_AddressLine2 = "";
            m_City = "";
            m_StateCode = "";
            m_ZipCode = "";
            m_Country = "";
            m_CreditCardLimit = 3000.0M;
            m_CreditCardAvailableCredit = 3000.0M;
            m_CreditCardActivationStatus = true;
        }

        public CreditCard(
            string ccNumber,
            string ccOwnerName,
            byte ccProcMerchCode,
            byte ccNetworkCode,
            byte ccIssuingBankCode,
            byte ccCorpMerchBankCode,
            string expDateStr,
            string addr1,
            string addr2,
            string city,
            string stateCode,
            string zipCode,
            string country,
            decimal ccLimit = 3000.0M,
            decimal ccAvailableCredit = 3000.0M)
        {

            this.CreditCardNumber = ccNumber;
            this.CreditCardOwnerName = ccOwnerName;
            this.CreditCardProcessingMerchantServiceCompanyCode = ccProcMerchCode;
            this.CreditCardNetworkCompanyCode = ccNetworkCode;
            this.CreditCardIssuingBankCode = ccIssuingBankCode;
            this.CreditCardCorporateMerchantBankCode = ccCorpMerchBankCode;
            this.ExpDate = DateTime.Parse(expDateStr);
            this.AddressLine1 = addr1;
            this.AddressLine2 = addr2;
            this.City = city;
            this.StateCode = stateCode;
            this.ZipCode = zipCode;
            this.Country = country;
            this.CreditCardLimit = ccLimit;
            this.CreditCardAvailableCredit = ccAvailableCredit;

            m_CreditCardProcessingMerchantServiceCompanyName = "";
            m_CreditCardNetworkCompanyName = "";
            m_CreditCardIssuingBankName = "";
            m_CreditCardCorporateMerchantBankName = "";
            m_CreditCardActivationStatus = true;
        }


        
        ~CreditCard()//destructor 
        {
        }


        public void Print()
        {
            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter("Network_Printer.txt", true);

                writer.WriteLine("Credit Card information:");
                writer.WriteLine("Credit Card Number = " + m_CreditCardNumber);
                writer.WriteLine("Credit Card Owner Name = " + m_CreditCardOwnerName);
                writer.WriteLine("Credit Card Processing Merchant Service Company Code = "
                                 + m_CreditCardProcessingMerchantServiceCompanyCode);
                writer.WriteLine("Credit Card Processing Merchant Service Company Name = "
                                 + m_CreditCardProcessingMerchantServiceCompanyName);
                writer.WriteLine("Credit Card Network Company Code = "
                                 + m_CreditCardNetworkCompanyCode);
                writer.WriteLine("Credit Card Network Company Name = "
                                 + m_CreditCardNetworkCompanyName);
                writer.WriteLine("Credit Card Issuing Bank Code = "
                                 + m_CreditCardIssuingBankCode);
                writer.WriteLine("Credit Card Issuing Bank Name = "
                                 + m_CreditCardIssuingBankName);
                writer.WriteLine("Credit Card Corporate Merchant Bank Code = "
                                 + m_CreditCardCorporateMerchantBankCode);
                writer.WriteLine("Credit Card Corporate Merchant Bank Name = "
                                 + m_CreditCardCorporateMerchantBankName);
                writer.WriteLine("Expiration Date = " + m_ExpDate.ToShortDateString());
                writer.WriteLine("AddressLine1 = " + m_AddressLine1);
                writer.WriteLine("AddressLine2 = " + m_AddressLine2);
                writer.WriteLine("City = " + m_City);
                writer.WriteLine("State Code = " + m_StateCode);
                writer.WriteLine("Zip code = " + m_ZipCode);
                writer.WriteLine("Country = " + m_Country);
                writer.WriteLine("Credit Card Limit = " + m_CreditCardLimit);
                writer.WriteLine("Credit Card Available Credit = " + m_CreditCardAvailableCredit);
                writer.WriteLine("Credit Card Activation Status = " + m_CreditCardActivationStatus);
                writer.WriteLine();
            }
            catch (Exception objE)
            {
                throw new Exception("Unexpected Error in Print() Method: " + objE.Message);
            }
            finally
            {
                if (writer != null) writer.Close();
            }
        }

        public bool Activate()
        {
            m_CreditCardActivationStatus = true;
            return m_CreditCardActivationStatus;
        }

        public bool Deactivate()
        {
            m_CreditCardActivationStatus = false;
            return m_CreditCardActivationStatus;
        }

        public bool Load(string key)
        {
            return this.DALayer_Load(key);
        }

        protected bool DALayer_Load(string key)
        {
            try
            {
                DALObjectFactoryBase objDAOFactory =
                    DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);

                CreditCardDAO objCreditCardDAO = objDAOFactory.GetCreditCardDAO();
                CreditCardDTO objDTO = objCreditCardDAO.GetRecordByID(key);

                if (objDTO != null)
                {
                    this.CreditCardOwnerName = objDTO.CreditCardOwnerName;
                    this.CreditCardProcessingMerchantServiceCompanyCode =
                        objDTO.CreditCardProcessingMerchantServiceCompanyCode;
                    this.CreditCardProcessingMerchantServiceCompanyName =
                        objDTO.CreditCardProcessingMerchantServiceCompanyName;
                    this.CreditCardNetworkCompanyCode = objDTO.CreditCardNetworkCompanyCode;
                    this.CreditCardNetworkCompanyName = objDTO.CreditCardNetworkCompanyName;
                    this.CreditCardIssuingBankCode = objDTO.CreditCardIssuingBankCode;
                    this.CreditCardIssuingBankName = objDTO.CreditCardIssuingBankName;
                    this.CreditCardCorporateMerchantBankCode = objDTO.CreditCardCorporateMerchantBankCode;
                    this.CreditCardCorporateMerchantBankName = objDTO.CreditCardCorporateMerchantBankName;
                    this.ExpDate = objDTO.ExpDate;
                    this.AddressLine1 = objDTO.AddressLine1;
                    this.AddressLine2 = objDTO.AddressLine2;
                    this.City = objDTO.City;
                    this.StateCode = objDTO.StateCode;
                    this.ZipCode = objDTO.ZipCode;
                    this.Country = objDTO.Country;
                    this.CreditCardLimit = objDTO.CreditCardLimit;
                    this.CreditCardAvailableCredit = objDTO.CreditCardAvailableCredit;

                    if (objDTO.CreditCardActivationStatus == true)
                        this.Activate();
                    else
                        this.Deactivate();

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception objE)
            {
                throw new Exception("Unexpected Error in DALayer_Load(key) Method: {0} " + objE.Message);
            }
        }
    }
}
