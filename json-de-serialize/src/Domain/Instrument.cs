using System.Text.Json.Serialization;

namespace Domain;

[JsonDerivedType(typeof(Guitar), typeDiscriminator: "guitar")]
[JsonDerivedType(typeof(Synth), typeDiscriminator: "synth")]
public class Instrument : BaseInstrument
{
}
