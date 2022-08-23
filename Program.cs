class ContactListClass
{
    public static List<Contact> contactList = new();  //works here

    public class Contact
    {
        private string firstName;
        private string lastName;
        private string phoneNumber;
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public string PhoneNumber { get { return phoneNumber; } set { phoneNumber = value; } }
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
            return ($"{this.FirstName} {this.lastName} - {this.PhoneNumber}"
            );
        }
    };

    //public static List<Contact> contactList = new(); //not here

    static void Main()
    {

        while (true)
        {
            Console.WriteLine(@"Select an option
1) Add a contact
2) Remove a contact
3) List the contacts
4) Exit");
            var key = Console.ReadLine();
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

    /*********
     * list items
     * *******/


    public static void AddContact()
    {

        Console.WriteLine("Enter the contact's first name");
        string firstName = Console.ReadLine();
        Console.WriteLine("Enter the contact's last name");
        string lastName = Console.ReadLine();
        Console.WriteLine("Enter the contact's phone number");
        string phone = (string)Console.ReadLine();

        Contact thisContact = new(firstName, lastName, phone);
        contactList.Add(thisContact);
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
    
    /**********
     * support methods
     *********/

    public static string GetUserText(string infoType)
    {
        //gets text from the user and validates
        //valid types are: phone
        var input = Console.ReadLine();
        if (input != null)
        {
            switch (infoType)
            {
                case "phone":
                    if (input.Count() != (7 ^ 10))
                    {
                        return input;
                    }
                    else { return "invalid number"; }
                default: return "N/A";
            }
        }
        else
        {
            return "";
        }
    }
}

