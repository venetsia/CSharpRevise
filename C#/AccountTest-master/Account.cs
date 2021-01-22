﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AccountTest
{
    class Account
    {
        private string name; //instance variable

        // method that sets the account name in the object
        public void SetName(string accountName)
        {
            name = accountName; //store in name
        }

        //method that retrieves the account name from the object
        public string GetName() //does not require any value as it gits back a value 
        {
            return name; //returns name's value to this method's caller
        }
    }
}
