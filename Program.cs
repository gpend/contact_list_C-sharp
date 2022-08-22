using System;
class ContactListClass
{
    public static System.Collections.ArrayList contactList = new() ;
    public class Contact
    {
        public string firstName = String.Empty;
        public string lastName = String.Empty;
        public string phoneNumnber  = String.Empty;

        public Contact (string first, string last, string phone)
        {
            firstName = first ;
            lastName = last ;
            phoneNumnber = phone ;
        }
    };

    static void Main()
    {
        
        while (true){
            Console.WriteLine(@"Select an option
1) Add a contact
2) Remove a contact
3) List the contacts
4) Exit");
            var key = Console.ReadLine(); //quit printing the number
            switch (key)
            {
                case "1":
                    AddContact();
                    break;

                /*case "2":
                    RemoveContact();
                    break;*/

                case "3":
                    ListContacts();
                    break; 

                case "4":
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
        
        Console.WriteLine("Enter the contact's first name");
        string firstName = Console.ReadLine();
        Console.WriteLine("Enter the contact's last name");
        string lastName = Console.ReadLine();
        Console.WriteLine("Enter the contact's phone number");
        string phone = (string)Console.ReadLine();

        Contact thisContact = new Contact(firstName, lastName, phone);
        contactList.Add(thisContact);
        Console.WriteLine(thisContact.firstName + thisContact.lastName + thisContact.phoneNumnber);
    }

    public static void ListContacts()
    {
        Console.WriteLine();
        Console.WriteLine(contactList.Count);
        foreach(var person in contactList)
        {
            Console.WriteLine(person);  //how do I access the contact?
        }
    }
}

