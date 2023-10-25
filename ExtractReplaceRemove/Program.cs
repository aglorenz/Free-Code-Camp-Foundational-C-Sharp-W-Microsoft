// string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// // The IndexOfAny() helper method requires a char array of characters. 
// // You want to look for:

// char[] openSymbols = { '[', '{', '(' };

// int closingPosition = 0;

// while (true)
// {
//     int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

//     if (openingPosition == -1) break;

//     string currentSymbol = message.Substring(openingPosition, 1);

//     // Now find the closing symbol
//     char matchingSymbol = ' ';

//     switch (currentSymbol) 
//     {
//         case "[":
//             matchingSymbol = ']';
//             break;
//         case  "{":
//             matchingSymbol = '}';
//             break;
//         case "(":
//             matchingSymbol = ')';
//             break;
//     }
//     openingPosition += 1;
//     closingPosition = message.IndexOf(matchingSymbol, openingPosition);

//     int length = closingPosition - openingPosition;
//     Console.WriteLine(message.Substring(openingPosition,length));
// }

// string message = "This--is--ex-amp-le--da-ta";
// message = message.Replace("--", " ");
// message = message.Replace("-", "");
// Console.WriteLine(message);

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";
//                    0123456789012345678901234567890123456789012345678901
string quantity = "";
string output = "";

// Your work here
const string startDiv = "<div>";
const string endDiv = "</div>";
const string startSpan = "<span>";
const string endSpan = "</span>";
const string tradeSymbol = "&trade";
const string regSymbol = "&reg";

int startPos = input.IndexOf(startDiv) + startDiv.Length;
int endPos = input.IndexOf(endDiv);
int length = endPos - startPos;

if (startPos >= 0 && endPos >= 0)
{
    // Extract the output string from between the <div> tags  and then replace the trademark symbol
    // Note: could use the .Remove() method to remove the <div> tags. 
    output = input.Substring(startPos, length);
    output = $"Output: {output.Replace(tradeSymbol, regSymbol)}";
}

startPos = input.IndexOf(startSpan) + startSpan.Length;
endPos = input.IndexOf(endSpan);
length = endPos - startPos;

if (startPos >= 0 && endPos >= 0)
{
    // grab the quantity from the input string.
     quantity = $"Quantity: {input.Substring(startPos, length)}";
}

Console.WriteLine(quantity);
Console.WriteLine(output);