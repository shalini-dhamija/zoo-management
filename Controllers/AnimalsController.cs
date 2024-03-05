using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Writers;
using ZooManagement.Models.Data;
using ZooManagement.Models.Requests;
using ZooManagement.Models.Response;

namespace ZooManagement.Controllers;

[ApiController]
[Route("/animals")]
public class AnimalsController: ControllerBase
{
    private readonly Zoo _zoo;
    public AnimalsController(Zoo zoo)
    {
        _zoo = zoo;
    }

    [HttpGet("{id}")]
    public IActionResult GetById([FromRoute] int id)
    {
        var matchingAnimal = _zoo.Animals
        .Include(animal => animal.Species)
        .SingleOrDefault(animal => animal.Id == id);
        if (matchingAnimal == null)
        {
            return NotFound();
        }
        return Ok(new AnimalResponse()
        {
            Name = matchingAnimal.Name,
            SpeciesName = matchingAnimal.Species.Name,
            Classification = matchingAnimal.Species.Classification.ToString(),
            Sex = matchingAnimal.Sex.ToString(),
            DateOfBirth = matchingAnimal.DateOfBirth,
            DateOfAcquisition = matchingAnimal.DateOfAcquisition, 
        });
    }

    [HttpPost]
    public IActionResult Add([FromBody] CreateAnimalRequest createAnimalRequest)
    {
        if(_zoo.Species.Any(species => species.Id == createAnimalRequest.SpeciesId))
        {
            Console.WriteLine("creating new animal");
            var newAnimal = _zoo.Animals.Add(new Animal
            {
                Name = createAnimalRequest.Name,
                SpeciesId = createAnimalRequest.SpeciesId,
                Sex = createAnimalRequest.Sex,
                DateOfBirth = createAnimalRequest.DateOfBirth,
                DateOfAcquisition = createAnimalRequest.DateOfAcquisition,
            }).Entity;
            _zoo.SaveChanges();
            return Ok(newAnimal);  
        } else
        {
            return BadRequest();
        }
    }
}