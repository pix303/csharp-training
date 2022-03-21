using System.Globalization;


Console.WriteLine("Creation date -----------------------------------------");
var date1 = new DateTime();
Console.WriteLine($"First date possible {date1.ToString()}");

var date2 = DateTime.Now;
Console.WriteLine($"Date now {date2.ToString()}");
Console.WriteLine("-------------------------------------------------------");


// ----------------------------------------------
//Parse string date
// ----------------------------------------------
Console.WriteLine("Parsing date ------------------------------------------");

// Parse different string with defaul system culture
Console.WriteLine();
Console.WriteLine($"The current culture is: {CultureInfo.CurrentCulture}");

List<string> dateStringToParse = new List<string>();
dateStringToParse.Add("2006-08-12T00:00:03");
dateStringToParse.Add("2006 08 12 12:14:43");
dateStringToParse.Add("7/25/2019 13:45:00");
dateStringToParse.Add("July 25, 2019 13:45:00");
dateStringToParse.Add("Thursday, July 25, 2019 13:45:00:00");
dateStringToParse.Add("July 25, 2019 13:45:00:00");
dateStringToParse.Add("15/08/2006");

foreach (string dateToParse in dateStringToParse) {
    try
    {
        var parsedData = DateTime.Parse(dateToParse);
        Console.WriteLine($"OK this {dateToParse} is recongnizable: {parsedData.ToString()}");
    }
    catch (Exception ex) 
    {
        Console.WriteLine($"ERROR: Can't parse this data {dateToParse}");
    }
}


CultureInfo.CurrentCulture = new CultureInfo("en-US");
Console.WriteLine();
Console.WriteLine($"The current culture is: {CultureInfo.CurrentCulture}");

foreach (string dateToParse in dateStringToParse)
{
    try
    {
        var parsedData = DateTime.Parse(dateToParse);
        Console.WriteLine($"OK this {dateToParse} is recongnizable: {parsedData.ToString()}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"ERROR: Can't parse this data {dateToParse}");
    }
}


CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
Console.WriteLine();
Console.WriteLine($"The current culture is: {CultureInfo.CurrentCulture}");

foreach (string dateToParse in dateStringToParse)
{
    try
    {
        var parsedData = DateTime.Parse(dateToParse);
        Console.WriteLine($"OK this {dateToParse} is recongnizable: {parsedData.ToString()}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"ERROR: Can't parse this data {dateToParse}");
    }
}



Console.WriteLine();

string dateFormat = "dddd, MMMM dd, yyyy HH:mm:ss:ff";
Console.WriteLine($"Parsing date with format - {dateFormat} -----------------------------------------");
foreach (string dateToParse in dateStringToParse)
{
    try
    {
        var parsedData = DateTime.ParseExact(dateToParse,dateFormat,CultureInfo.InvariantCulture);
        Console.WriteLine($"OK this {dateToParse} is recongnizable: {parsedData.ToString()}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"ERROR: Can't parse this data {dateToParse}");
    }
}
