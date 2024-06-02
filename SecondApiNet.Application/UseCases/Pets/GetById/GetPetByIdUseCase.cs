using SecondApiNet.Communication;

namespace SecondApiNet.Application;

public class GetPetByIdUseCase
{
public ResponsePetJson Execute(int id)
    {
        return new ResponsePetJson
        {
            Id = id,
            Name = "Dog",
            BirthDate = DateTime.Now,
            Type = PetType.Cat
        };
    }
}
