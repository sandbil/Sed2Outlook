using System;
using System.Collections.Generic;
using System.Text;

namespace OutlookIntegrationEx
{
  class MyContact
    {
        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        private string _emailAddress;

        public string EmailAddress
        {
            get { return _emailAddress; }
            set { _emailAddress = value; }
        }
        private string _phone;

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        private string _address;

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        private string _customProperty;

        public string CustomProperty
        {
            get { return _customProperty; }
            set { _customProperty = value; }
        }
    }
}
