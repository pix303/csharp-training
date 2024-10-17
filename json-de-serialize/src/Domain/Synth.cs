namespace Domain;

public class Synth : Instrument
{
	public int KnobNum { get; set; } = 0;

	public Synth()
	{
		Category = BaseCategory.Electronic;
	}

	override public string Play()
	{
		return $"this synth of category {ResolveCategory(this.Category)} plays every sound tweaking well his {KnobNum} knobs";
	}
}
