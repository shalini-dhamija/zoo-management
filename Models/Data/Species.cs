using System.ComponentModel.DataAnnotations;
using ZooManagement.Enums;

namespace ZooManagement.Models.Data;

public class Species
{
    [Key]
    public int SpeciesId {get; set;}
    public required string Name {get; set;}
    public required Classification Classification {get; set;}
}