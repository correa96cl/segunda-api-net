namespace SecondApiNet.Communication;

public class RequestPetJson
{
    public string Name { get; set; } = string.Empty;
    public DateTime BirthDate { get; set; }

    public PetType Type { get; set; }
}
