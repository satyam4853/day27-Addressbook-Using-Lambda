using System;

namespace Addressbook_Using_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("**************************Welcome To Address Book Using Lambda Problem ****************************");

            AddressBookDetails addressbookdetails = new AddressBookDetails();

            while (true)
            {

                Console.WriteLine("*********************************************************");
                Console.WriteLine("1.Add member to Contact list \n2.View Members in Contact List\n3.Edit members Contacts list\n4.Delete members Contacts list\n5.Search for details\n6.View details of city or state\n7.Count by city or state\n8.Sort the list\n9.Read list from file\n10.write list from file\n11.Read from Csv file\n12.Write from csv file\n13.Read from Json file\n14.Write to Json file\n15.Exit");
                Console.WriteLine("Enter an option:");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        addressbookdetails.AddMember();
                        break;
                    case 2:
                        addressbookdetails.ViewContacts();
                        break;
                    case 3:
                        addressbookdetails.EditDetails();
                        break;
                    case 4:
                        addressbookdetails.DeleteDetails();
                        break;
                    case 5:
                        addressbookdetails.SearchDetails();
                        break;
                    case 6:
                        addressbookdetails.ViewDetailsByStateOrCity();
                        break;
                    case 7:
                        addressbookdetails.CountByStateOrCity();
                        break;
                    case 8:
                        addressbookdetails.SortEntries();
                        break;
                    case 9:
                        addressbookdetails.ReadFromFile();
                        break;
                    case 10:
                        addressbookdetails.WriteToFile();
                        break;
                    case 11:
                        addressbookdetails.ReadFromCsvFile();
                        break;
                    case 12:
                        addressbookdetails.WriteToCsvFile();
                        break;
                    case 13:
                        addressbookdetails.ReadFromJsonFile();
                        break;
                    case 14:
                        addressbookdetails.WriteToJsonFile();
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
























