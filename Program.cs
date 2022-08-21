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
            Console.WriteLine(@"Select an option
1) Add a contact
2) Remove a contact
3) List the contacts
4) Exit");
            int key = Console.ReadKey(false).KeyChar; //quit printing the number
            Console.WriteLine(key);
            switch (key)
            {
                case 49:
                    AddContact();
                    break;

                /*case 50:
                    RemoveContact();
                    break;*/

                case 51:
                    ListContacts();
                    break; 

                case 52:
                    Environment.Exit(0);
                    break;

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

    public static void ListContacts()
    {
        foreach(var contact in contactList)
        {
            Console.WriteLine(contact);  //how do I access the contact?
        }
    }
}

