internal static class ContactListClassHelpers
{

    public static string GetUserText(string infoType)
    {
        //gets text from the user and validates
        //valid types are: phone and name
        var input = Console.ReadLine();
        if (input != null)
        {
            switch (infoType)
            {
                case "phone":
                    //verify it is 7 or 10 digits
                    if (input.Length != (7 ^ 10))
                    {
                        return input;
                    }
                    else { return "invalid number"; }
                case "name":
                    //capitolize the first letter of each word
                    char capLetter = input.ToUpper()[0];
                    string restOfName = input.Substring(1);
                    return capLetter + restOfName;
                default: return "N/A";


            }
        }
        else
        {
            return "";
        }
    }
}