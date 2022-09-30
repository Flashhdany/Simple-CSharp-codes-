
string[] userNames = new string[10] { "", "", "", "", "", "", "", "", "", "" };
bool userType;
string searchString = "";
int countOfUsernames = Array.IndexOf(userNames, searchString);
Console.WriteLine("Welcome to the best restaurant in the world!");
while (countOfUsernames < 11)
{
    Console.WriteLine("Are you a registered user? Write true, or write false to register");
    userType = Convert.ToBoolean(Console.ReadLine());
    if (userType == true)
    {
        Console.WriteLine("Hello, you are registered user, please enter your user name");
        string userToSearch = Console.ReadLine();
        Console.WriteLine("The user you searched is {0}", userToSearch);
        int index = Array.IndexOf(userNames, userToSearch);
        if (index == -1)
        {
            Console.WriteLine("User not found, try again or register");
        }
        else if (index != -1)
        {
            Console.WriteLine("Welcome " + userNames.GetValue(index) + "es un placer brindarte servicio");
        }
    }
    else if (userType == false)
    {


        for (int i = -1; i < countOfUsernames && i < 11; i++)
        {
            Console.WriteLine("\nPlease write the user that you want to register\n");
            userNames[countOfUsernames] = Console.ReadLine();
            Console.WriteLine("\nWelcome {0}, your user has been saved successfully", userNames[countOfUsernames]);
            Console.WriteLine("\nThe list of users registered are:\n");
            countOfUsernames = Array.IndexOf(userNames, searchString);
            for (int j = 0; j < countOfUsernames; j++)
            {
                if (countOfUsernames < 11)
                {
                    Console.Write(userNames[j] + "  ");
                }
                else
                {
                    Console.WriteLine("The tables in the restaurant are full, try again next year");
                }
            }
        }
        int index = 0;
        foreach (string element in userNames)
        {
            Console.WriteLine("{0} {1}", index + 1, userNames[index]);
            index++;
        }
    }
}
