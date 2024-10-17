using System.Text.Json;
using Domain;

var guitar = new Guitar
{
	Name = "Fender Telecaster",
	StringsNum = 6
};


var bass = new Guitar
{
	Name = "Fender Precision",
	StringsNum = 4,
};


var modeld = new Synth
{
	Name = "Moog Model D",
	KnobNum = 13
};



var instruments = new List<Instrument>();
instruments.Add(guitar);
instruments.Add(bass);
instruments.Add(modeld);

try
{
	using (var streamW = new StreamWriter("data.json"))
	{
		var store = JsonSerializer.Serialize(instruments);
		streamW.Write(store);
	}
}
catch (Exception err)
{
	Console.WriteLine(err);
}

try
{
	using (var streamR = new StreamReader("data.json"))
	{

		var rStore = streamR.ReadToEnd();
		var insRead = JsonSerializer.Deserialize<List<Instrument>>(rStore);
		Console.WriteLine(insRead?.ElementAt(0).Play());
		Console.WriteLine(insRead?.ElementAt(1).Play());
		Console.WriteLine(insRead?.ElementAt(2).Play());
	}
}
catch (Exception err)
{
	Console.WriteLine(err);
}



