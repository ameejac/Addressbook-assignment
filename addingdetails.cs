﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProgram
    {
        class ContactDetails
        {
            List<Contact> contactlist = new List<Contact>();
            public void AddContact()
            {

                //uc2 adding contacts  details in addressbook
                Console.WriteLine("Enter your first Name");
                var FirstName = Console.ReadLine();
                Console.WriteLine("Enter your last Name");
                var LastName = Console.ReadLine();
                Console.WriteLine("Enter Phone Number");
                var Phone = long.Parse(Console.ReadLine());
                Console.WriteLine("Enter Address");
                var Address = Console.ReadLine();
                Console.WriteLine("Enter City");
                var City = Console.ReadLine();
                Console.WriteLine("Enter State");
                var State = Console.ReadLine();
                Console.WriteLine("Enter Zip Code");
                var Zip = int.Parse(Console.ReadLine());
                Contact _contact = new Contact(FirstName, LastName, Phone, Address, City, State, Zip);
                contactlist.Add(_contact);
            }

            //Created method to display contact details
            public void Display()
            {
                foreach (Contact con in contactlist)
                {
                    Console.WriteLine(con.FirstName + "  " + con.Phone + "  " + con.Address + "  " + con.City + "  " + con.State + "  " + con.Zip);
                }
            }
        // uc-3 edit existing contact person using their name
        public void EditContact()
        {
            //I am using console to edit the person details
            Console.WriteLine(" enter firstName to modify contact details of a person ");
            string UserFirstname = Console.ReadLine();
            foreach (Contact con in contactlist)
            {
                // Console.WriteLine(con.FirstName + "  " + con.Phone + "  " + con.Address + "  " + con.City + "  " + con.State + "  " + con.Zip);
                if (con.FirstName.Equals(UserFirstname))
                {
                    Console.WriteLine("what data u want to edit,press first character only  of that field");
                    char userinput = char.Parse(Console.ReadLine());
                    switch (userinput)
                    {
                        case 'a':
                            Console.WriteLine(" enter address");
                            con.Address = Console.ReadLine();
                            Console.WriteLine(" edited Adress" + con.Address);
                            break;
                        case 'p':
                            Console.WriteLine(" enter Phone");
                            con.Phone = int.Parse(Console.ReadLine());
                            Console.WriteLine(" edited Adress" + con.Phone);
                            break;
                        case 'f':
                            Console.WriteLine(" enter firstname");
                            con.FirstName = Console.ReadLine();
                            Console.WriteLine(" edited Adress" + con.FirstName);
                            break;
                        case 'c':
                            Console.WriteLine(" enter city");
                            con.City = Console.ReadLine();
                            Console.WriteLine(" edited Adress" + con.City);
                            break;
                        case 's':
                            Console.WriteLine(" enter state");
                            con.State = Console.ReadLine();
                            Console.WriteLine(" edited Adress" + con.State);
                            break;
                        case 'z':
                            Console.WriteLine(" enter address");
                            con.Zip = int.Parse(Console.ReadLine());
                            Console.WriteLine(" edited Adress" + con.Zip);
                            break;

                        default:
                            Console.WriteLine("wrong input ");
                            break;
                    }
                }
            }
        }
    }

}


