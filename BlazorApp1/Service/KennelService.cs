using BlazorApp1.Entity;

namespace BlazorApp1.Service;

public class KennelService : IKennelService
{
    private readonly List<Dog> _dogs;

    public KennelService()
    {
        _dogs = new List<Dog>
        {
            new Dog(1, "Nika", "female", "labrador", new DateOnly(2021,1,21), "a friendly dog",
                "https://plus.unsplash.com/premium_photo-1668114375111-e90b5e975df6?q=80&w=2069&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D"),
            new Dog(2, "Nika", "female", "labrador", new DateOnly(2021, 1, 21), "a friendly dog",
                "https://plus.unsplash.com/premium_photo-1668114375111-e90b5e975df6?q=80&w=2069&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D"),
            new Dog(3, "Nika", "female", "labrador", new DateOnly(2001, 1, 21), "a friendly dog",
                "https://plus.unsplash.com/premium_photo-1668114375111-e90b5e975df6?q=80&w=2069&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D"),
            new Dog(4, "Nika", "female", "labrador", new DateOnly(2001, 1, 21), "a friendly dog",
                "https://plus.unsplash.com/premium_photo-1668114375111-e90b5e975df6?q=80&w=2069&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D"),
            new Dog(5, "Nika", "female", "labrador", new DateOnly(2000, 1, 21), "a friendly dog",
                "https://plus.unsplash.com/premium_photo-1668114375111-e90b5e975df6?q=80&w=2069&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D"),

        };

    }

    public List<Dog> GetAllDogs()
    {
        return _dogs;
    }

    public Dog GetDogById(int id)
    {
        return _dogs.FirstOrDefault(d => d.Id == id);
    }

    public void AddDog(Dog dog)
    {
        _dogs.Add(dog);
    }


}