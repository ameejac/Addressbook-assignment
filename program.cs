﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProgram
{
    class Program
    {
         static void Main(string[] args)
         {

            Console.WriteLine("Welcome to Address book program");

            //UC2-Add Contact Details
            ContactDetails contactDetails = new ContactDetails();
            contactDetails.AddContact();
            contactDetails.Display();

            //UC3-Editing Contact Details
             contactDetails.EditContact();
            contactDetails.Display();

            //uc4-Deleting Contact Details
            contactDetails.DeleteContact();
            contactDetails.Display();

         }
    }
    
}
