using Microsoft.EntityFrameworkCore;
using ZooManagement.Enums;
using ZooManagement.Models.Data;
using ZooManagement.Models.Requests;

namespace ZooManagement;

public class Zoo : DbContext
{
    public DbSet<Animal> Animals {get; set;} = null!;
    public DbSet<Species> Species {get; set;} = null!;

protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost; Port=5432; Database=zoo; Username=zoo; Password=zoo;");
    }
protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var lion = new Species 
        {
            Id = -1,
            Name = "lion",
            Classification = Classification.Mammal
        };

        modelBuilder.Entity<Species>().HasData(lion);

        var simba = new Animal
        {
            Id = -1,
            Name = "simba",
            SpeciesId = -1,
            Sex = Sex.Male,
            DateOfBirth = new DateTime(2000, 1, 1).ToUniversalTime(),
            DateOfAcquisition = new DateTime(2000, 1, 1).ToUniversalTime(),
        };

        var nala = new Animal{
            Id = -2,
            Name = "nala",
            SpeciesId = -1,
            Sex = Sex.Female,
            DateOfBirth = new DateTime(1997, 9, 10).ToUniversalTime(),
            DateOfAcquisition = new DateTime(2001, 2, 3).ToUniversalTime(),
        };
        modelBuilder.Entity<Animal>().HasData(simba, nala);

        var species = new Dictionary<string, Classification>(){
            {"elephant", Classification.Mammal},
            {"zebra", Classification.Mammal},
            {"snake", Classification.Reptile},
            {"giraffe", Classification.Mammal},
            {"spider", Classification.Insect},
            {"hippo", Classification.Mammal},
            {"parrot", Classification.Bird},
            {"goldfish", Classification.Fish}
        };
        var speciesId = 1;
        foreach (var s in species){
            var newSpecies = new Species
            {
                Id = speciesId,
                Name = s.Key,
                Classification = s.Value,
            };
            modelBuilder.Entity<Species>().HasData(newSpecies);
            speciesId++;
        }
        
        var names = new[]
        {
            "Spot", "Pooh", "Piglet", "Kanga", "Peter", "Tabatha", "Winston", "Daffy", "Garfield", "Mickey", "Snoopy"
        };

        var arrSpeciesId = new[]
            {
                -1, 1, 2, 3, 4, 5, 6, 7
            };
        
        var values = Enum.GetValues(typeof(Sex));
        var random = new Random();

        var newAnimals = Enumerable.Range(1, 100).Select(index =>
            new Animal{
                Id = index,
                Name = names[Random.Shared.Next(names.Length)],                
                Sex = (Sex)values.GetValue(random.Next(values.Length)),
                DateOfAcquisition = DateTime.Now.ToUniversalTime(),
                DateOfBirth = DateTime.Now.ToUniversalTime(),
                SpeciesId = arrSpeciesId[Random.Shared.Next(arrSpeciesId.Length)],
            }).ToArray();

        foreach (var animal in newAnimals)
        {
            modelBuilder.Entity<Animal>().HasData(animal);
        }    
    }
}