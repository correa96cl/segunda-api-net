namespace SecondApiNet.Communication;

public class ResponsePetJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public DateTime BirthDate { get; set; }

    public PetType Type { get; set; }
}
