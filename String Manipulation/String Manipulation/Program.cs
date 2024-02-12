using System;

class Program
{
    static void Main(string[] args)
    {
        // Test the method with different input strings
        TestSplitString(@"Whitebridge High School\\DHCP\\10.112.421.23");
        TestSplitString(@"Whitebridge High School\\Web Server\\10.112.421.24");
        TestSplitString(@"Smithtown Public\\DHCP\\10.432.123.21");
        TestSplitString(@"Kotara High School\\Web Server\\10.764.234.43");
    }

    static void TestSplitString(string input)
    {
        Console.WriteLine("Testing with input: " + input);



        ///// MISSING CODE HERE, YOU SHOULD BE SPLITTING THE STRING INTO A STRING ARRAY HERE ON THE \\


        // Split the input string into three segments
        string[] segments = input.Split(new string[] { @"\\" }, StringSplitOptions.None);



        
        if ()//// MISSING CONDITION HERE, YOU SHOULD BE CHECKING THE SIZE OF THE ARRAY
        {

            //// MISSING CODE HERE YOU SHOULD BE ASSIGNING THE INDEXES IN THE ARRAY TO SEPERATE STRINGS
            

            Console.WriteLine("School: " + School);
            Console.WriteLine("Server: " + Server);
            Console.WriteLine("IP Address: " + IPAddress);
        }
        else
        {
            Console.WriteLine("Invalid input format. Please make sure the input contains three segments separated by '\\\\'.");
        }

        Console.WriteLine();
    }
}