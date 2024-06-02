using System.Runtime.InteropServices;
using SecondApiNet.Communication;

namespace SecondApiNet.Application;

public class GetAllPetsUseCase
{

    public ResponseAllPetJson Execute()
    {
        return new ResponseAllPetJson
        {
            /*Pets = new List<ResponseShortPetJson>() { 
                new ResponseShortPetJson { Id = 1, Name = "Dog", Type = PetType.Dog } }*/
        };
    }
}

