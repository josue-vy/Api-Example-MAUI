using ApiExample.Models;

namespace ApiExample.Services;

public interface IRickAndMortyService
{
    public Task<List<PersonajesResponse>> Get();
}