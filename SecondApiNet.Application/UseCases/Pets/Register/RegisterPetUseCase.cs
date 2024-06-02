using SecondApiNet.Communication;

namespace SecondApiNet.Application.UseCases.Pets.Register;

public class RegisterPetUseCase
{
    public ResponseRegisteredPetJson Execute(RequestPetJson request)
    {
        return new ResponseRegisteredPetJson
        {
            Id = 1,
            Name = request.Name
        };
    }
}
