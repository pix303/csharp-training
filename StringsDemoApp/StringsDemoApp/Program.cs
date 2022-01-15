using System.Text;

// substring using index
string data = "This is a test about strings";
Console.WriteLine(data[5..]);
Console.WriteLine(data[5..7]);
Console.WriteLine(data[..8]);
Console.WriteLine(data[data.IndexOf("test")..]);

// string concatenation
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