using System;
class ContactListClass
{
    public static System.Collections.ArrayList contactList = new() ;
    public class Contact
    {
        public string FirstName = String.Empty;
        public string LastName { get; set; }
        public string PhoneNumnber { get; set; }
    };

    static void Main()
    {
        
        while (true){
            switch ((int)Console.ReadKey(false).Key)
            {
                case 1:
                    AddContact();
                    break;

                /*case 2:
                    RemoveContact();
                    break;

                case 3:
                    ListContacts();
                    break;

                case 4:
                    Environment.Exit(0);
                    break; */

                default:
                    Console.WriteLine("please enter a number 1-4");
                    break;
            }
        }
        

    }

    public static void AddContact()
    {
        Contact thisContact = new();
        Console.WriteLine("Enter the contacts first name");
        thisContact.FirstName = Console.ReadLine();
        Console.WriteLine("Enter the contacts last name");
        thisContact.LastName = Console.ReadLine();
        Console.WriteLine("Enter the contacts phone number");
        thisContact.PhoneNumnber = (string)Console.ReadLine();
        contactList.Add(thisContact);
    }
}

