// string[] pallets = { "B14", "A11", "B12", "A13" };
// Console.WriteLine("");
// string result = String.Join(',', pallets);
// Console.WriteLine(result);

// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 6);
// Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

// pallets[4] = "C01";
// pallets[5] = "C02";

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 3);
// Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// string value = "abc123";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);
// // string result = new string(valueArray);
// result = String.Join(",",valueArray);
// Console.WriteLine(result);

// string[] items = result.Split(",");
// foreach (string item in items)
// {
//     Console.WriteLine(item);
// }

// Split the pangram string on the space character to create the string array message.
// Create a new newMessagearray that will store a reversed copy of the "word" string from the message array.
// Loop through each element in the message array, reverse it and store this element in newMessage array.
// Join "word" strings from the array newMessage, using a space again, to create the desired single string to write to the console.

// string pangram = "The quick brown fox jumps over the lazy dog";
// string[] words = pangram.Split(" ");
// string[] newWords = new string[words.Length];
// for (int i = 0; i < words.Length; i++) 
// {
//     char[] letterArray = words[i].ToCharArray();
//     Array.Reverse(letterArray);
//     newWords[i] = new string(letterArray);
// }
// string result = String.Join(" ", newWords);
// Console.WriteLine(result);

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] orderIds = orderStream.Split(",");
Array.Sort(orderIds);
foreach (string orderId in orderIds)
{
    if (orderId.Length == 4)
        Console.WriteLine(orderId);
    else
        Console.WriteLine($"{orderId} \t - Error");
}

