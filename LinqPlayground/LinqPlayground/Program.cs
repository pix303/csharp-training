using System.Linq;


string[] names = new string[] { "Paolo", "Pietro", "Aurora", "Andrea", "Giacomo", "Gianni", "Francesco", "Ferdinando" };

string[] values = names
    .Where(x => x.StartsWith("P")) // filter
    .Select(x => x.ToLower()) // map
    .ToArray();

var enr = values.GetEnumerator(); // iterator
while (enr.MoveNext())
{
    Console.Write($"{enr.Current} - ");
}
