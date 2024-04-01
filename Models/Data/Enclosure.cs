using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ZooManagement.Models.Data;

public class Enclosure
{
    [Key]
    public int EnclosureId {get;set;}
    public required string Name {get;set;}
    public required int NumberOfAnimals {get;set;}  
    public List<Animal> Animals {get;set;} = [];
    [NotMapped]
    public int CurrentAnimalNumber => Animals.Count();

}