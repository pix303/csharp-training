using System.Text;
using System.Text.RegularExpressions;

// substring using index
string data = "This is a test about strings";
Console.WriteLine("--Substring by range--------------------------------------");
Console.WriteLine(data[5..]);
Console.WriteLine(data[5..7]);
Console.WriteLine(data[..8]);
Console.WriteLine(data[data.IndexOf("test")..]);

// string concatenation
Console.WriteLine("--Concatening strings-------------------------------------");
string[] datas = { "zero", "one", "two", "three", "four", "five" };

// concat by + operator
string buildByOperator = "";
// string builders
StringBuilder sb = new StringBuilder();
StringBuilder sbp = new StringBuilder();

for (int i = 0; i < datas.Length; i++) {
    // operator += and +
    buildByOperator += datas[i] + " ";
    // append in line
    sb.Append($"{datas[i]} - ");
    // append new line
    sbp.AppendLine(datas[i]);
}

Console.WriteLine(buildByOperator);
Console.WriteLine(sb.ToString());
Console.WriteLine(sbp.ToString());

// concat static method of string
Console.WriteLine( "Concat: " + String.Concat(datas));
// join with separator static method string
Console.WriteLine( "Join  : {0}", String.Join(" - ", datas));

// match a string with regular expression
Console.WriteLine("--Regular expression--------------------------------------");
string dataRegEx = "This is a test about strings, only a test";

Regex regex = new Regex(@"test");
MatchCollection matches = regex.Matches(dataRegEx);
foreach (Match match in matches) {
    int position = match.Groups[0].Index;
    string name = match.Groups[0].Value;
    Console.WriteLine($"Match result is \"{name}\" at position {position}");
}