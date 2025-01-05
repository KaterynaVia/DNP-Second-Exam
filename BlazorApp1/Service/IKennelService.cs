using BlazorApp1.Entity;

namespace BlazorApp1.Service;

public interface IKennelService
{
    List<Dog> GetAllDogs();
    Dog GetDogById(int id);
    void AddDog(Dog dog);
    
}