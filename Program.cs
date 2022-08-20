using System;
class ContactListClass
{
    class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumnber { get; set; }
    };

    static void Main()
    {
        Console.WriteLine("Enter the contacts first name");
        string key = Console.ReadLine();
        Console.WriteLine(key);
        Contact thisContact = new Contact();
        thisContact.FirstName = key;
        thisContact.LastName = "lname";
        thisContact.PhoneNumnber = "1234";

    }
}

