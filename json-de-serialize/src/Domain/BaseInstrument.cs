using System.Text.Json.Serialization;

namespace Domain;

[JsonDerivedType(typeof(Guitar), typeDiscriminator: "guitar")]
[JsonDerivedType(typeof(Synth), typeDiscriminator: "synth")]
public class BaseInstrument
{
	public enum BaseCategory
	{
		Unknown,
		Wood,
		Brass,
		Electronic
	}


	public string Name { get; set; } = "no-name";
	public BaseCategory Category { get; set; } = BaseCategory.Unknown;

	public virtual string Play()
	{
		return $"no sound for {ResolveCategory(this.Category)}";
	}

	public string ResolveCategory(BaseCategory category)
	{
		return category switch
		{
			BaseCategory.Wood => "wood",
			BaseCategory.Brass => "brass",
			BaseCategory.Electronic => "electronic",
			BaseCategory.Unknown => "unknown",
			_ => "no-value"
		};
	}
}
