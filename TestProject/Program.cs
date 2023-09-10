string[] fraudulentOrderIDs = {"B123","C234","A345","C15","B177","G3033","C234","B179"};

foreach (string id in fraudulentOrderIDs) 
{
    if (id.StartsWith('B'))
    {
        Console.WriteLine(id);
    }
}