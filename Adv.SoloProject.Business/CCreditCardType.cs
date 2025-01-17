﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Adv.SoloProject.Data;

namespace Adv.SoloProject.Business
{
    public class CCreditCardType
    {
        // Private Fields
        private int _iCreditCardTypeId;
        private string _sDescription;

        // Public Properties
        public int CreditCardTypeId
        {
            get { return _iCreditCardTypeId; }
            set { _iCreditCardTypeId = value; }
        }

        public string Description
        {
            get { return _sDescription; }
            set { _sDescription = value; }
        }

        // Constructors
        public CCreditCardType()
        {

        }

        public CCreditCardType(tblCreditCardType otblCreditCardType)
        {
            _iCreditCardTypeId = otblCreditCardType.CreditCardType_Id;
            _sDescription = otblCreditCardType.Description;
        }

        // Public Methods
        public void Insert()
        {
            try
            {
                MediaVaultDataContext oDc = new MediaVaultDataContext();

                tblCreditCardType otblCreditCardType = new tblCreditCardType();

                otblCreditCardType.CreditCardType_Id = CreditCardTypeId;
                otblCreditCardType.Description = Description;

                oDc.tblCreditCardTypes.InsertOnSubmit(otblCreditCardType);
                oDc.SubmitChanges();
                oDc = null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update()
        {
            try
            {
                MediaVaultDataContext oDc = new MediaVaultDataContext();

                tblCreditCardType otblCreditCardType = (from c in oDc.tblCreditCardTypes
                                            where c.CreditCardType_Id == CreditCardTypeId
                                            select c).FirstOrDefault();

                otblCreditCardType.Description = Description;

                oDc.SubmitChanges();
                oDc = null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete()
        {
            try
            {
                MediaVaultDataContext oDc = new MediaVaultDataContext();

                tblCreditCardType otblCreditCardType = (from c in oDc.tblCreditCardTypes where c.CreditCardType_Id == CreditCardTypeId select c).FirstOrDefault();

                oDc.tblCreditCardTypes.DeleteOnSubmit(otblCreditCardType);
                oDc.SubmitChanges();

                otblCreditCardType = null;
                oDc = null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
