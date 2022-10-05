using static ContactListClassHelpers;

class ContactListClass
{
    public static List<Contact> contactList = new();  //works here

    public class Contact
    {
        private string? firstName;
        public string? FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Contact(string first, string last, string phone, string email = "")
        {
            FirstName = first;
            LastName = last;
            PhoneNumber = phone;
            Email = email;
        }

        public string OutputListItem()
        {
            return ($"{this.FirstName} {this.LastName}\t - \t{this.PhoneNumber}"
            );
        }
    };

    //public static List<Contact> contactList = new(); //not here

    static void Main()
    {
        contactList.Add(new Contact("james", "smith", "123-9874"));
        contactList.Add(new Contact("judy", "smith", "125-5574"));
        contactList.Add(new Contact("dave", "smith", "555-5534"));

        while (true)
        {
            Console.WriteLine("****************\n" +
                "Select an option\n" +
                "****************\n\n" +
                "1) Add a contact\n" +
                "2) Remove a contact\n" +
                "3) List the contacts\n" +
                "4) Exit\n");
            var key = Console.ReadLine();
            switch (key)
            {
                case "1":
                    AddContact();
                    break;

                case "2":
                    RemoveContact();
                    break;

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

    /*********
     * Main Methods
     * *******/


    public static void AddContact()
    {

        Console.WriteLine("Enter the contact's first name");
        string firstName = GetUserText("name");
        Console.WriteLine("Enter the contact's last name");
        string lastName = GetUserText("name");
        Console.WriteLine("Enter the contact's phone number");
        string phone = GetUserText("phone");

        Contact thisContact = new(firstName, lastName, phone);
        contactList.Add(thisContact);
    }


    public static void RemoveContact()
    {
        Console.WriteLine("enter the phone number of the person to remove");
        string? enteredNumber = Console.ReadLine();
        if (enteredNumber != null)
        {

            var contactToRemove = contactList?.Find(x => x.PhoneNumber == enteredNumber);
            if (contactToRemove != null)
            {
                if (contactList!.Remove(contactToRemove))
                {
                    Console.WriteLine("Contact Removed");
                }
                else
                {
                    Console.WriteLine("Contact not found, please verify your number");
                }
            }

        }
    }


    public static void ListContacts()
    {
        Console.WriteLine();
        Console.WriteLine();

        foreach (var person in contactList)
        {
            Console.WriteLine(person.OutputListItem());
        }

        Console.WriteLine();
    }
}

