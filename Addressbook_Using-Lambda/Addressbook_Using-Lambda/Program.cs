﻿using System;

namespace Addressbook_Using_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("**************************Welcome To Address Book Using Lambda Problem ****************************");

            AddressBookDetails abd = new AddressBookDetails();

            while (true)
            {


                Console.WriteLine("1.Add member to Contact list \n2.View Members in Contact List\n3.Edit members Contacts list\n4.Delete members Contacts list\n5.Search for details\n6.View details of city or state\n7.Count by city or state\n8.Sort the list\n9.Exit");
                Console.WriteLine("Enter an option:");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        abd.AddMember();
                        break;
                    case 2:
                        abd.ViewContacts();
                        break;
                    case 3:
                        abd.EditDetails();
                        break;
                    case 4:
                        abd.DeleteDetails();
                        break;
                    case 5:
                        abd.SearchDetails();
                        break;
                    case 6:
                        abd.ViewDetailsByStateOrCity();
                        break;
                    case 7:
                        abd.CountByStateOrCity();
                        break;
                    case 8:
                        abd.SortList();
                        break;
                    default:
                        // to exit from main method
                        Console.WriteLine("Exited");
                        return;


                }
            }
        }
    }
}



















