string[] myStrings = new string[2]
    {
        "I like pizza. I like roast chicken. I like salad",
        "I like all three of the menu choices"
    };

int periodLocation;

for (int i = 0; i < myStrings.Length; i++)
{
    string myString = myStrings[i];
    periodLocation = myString.IndexOf('.');
    
    while (periodLocation != -1)
    {
        // Write out everything up until the first period
        Console.WriteLine(myString.Remove(periodLocation));
        
        // Grab everthing after the period and then trim any leading spaces
        myString = myString.Substring(periodLocation + 1).TrimStart();
        
        // Get the next period location if any
        periodLocation = myString.IndexOf('.');
    }
    Console.WriteLine(myString);
}