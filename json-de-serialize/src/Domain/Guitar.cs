namespace Domain;

public class Guitar : Instrument
{
	public int StringsNum { get; set; } = 0;

	public Guitar()
	{
		Category = BaseCategory.Wood;
	}

	override public string Play()
	{
		return $"this guitar of category {base.ResolveCategory(this.Category)} with {StringsNum} strings plays strings loud and soft";

	}
}
