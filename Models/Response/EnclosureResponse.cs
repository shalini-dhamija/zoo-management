namespace ZooManagement.Models.Response;

public class EnclosureResponse
{
    public required string Name {get;set;}
    public required int NumberOfAnimals {get;set;}      
    public int CurrentAnimalNumber {get;set;}
}