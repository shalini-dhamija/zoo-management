using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZooManagement.Models.Data;
using ZooManagement.Models.Requests;
using ZooManagement.Models.Response;
using ZooManagement.Enums;

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
    [HttpGet("list/species")]
    public IActionResult ListSpecies()
    {
        var allSpecies =_zoo.Species.Select(species => species.Name).ToArray();
        return Ok(allSpecies);
    }

    [HttpGet("listall")]
    public IActionResult ListAll([FromQuery] string species ="", [FromQuery] string classification ="", [FromQuery] int pagesize = 10, [FromQuery] int pagenum = 1)
    {     

        var filteredData = _zoo.Animals.Include(animal => animal.Species).AsQueryable();
        
        if (!string.IsNullOrEmpty(species))
        {
            filteredData = filteredData.Where(animal => animal.Species.Name == species).AsQueryable();
        }

        if (!string.IsNullOrEmpty(classification))
        {
            filteredData = filteredData.ToList().Where(animal => animal.Species.Classification.ToString() == classification).AsQueryable();
        }
        
        if(filteredData == null)
        {
            return NotFound();
        }

        filteredData = filteredData
                        .OrderBy(animal => animal.Name);

        var totalPages = (int)Math.Ceiling((double)filteredData.Count() / pagesize);  

        if (pagenum >totalPages)
        {
            pagenum = totalPages;
        }

        var pagedData = filteredData
                        .Skip((pagenum -1) * pagesize)
                        .Take(pagesize)
                        .ToList();            

        var animalsResponse = new List<AnimalResponse>();
        foreach(var animal in pagedData)
        {
            var animalResponse = new AnimalResponse()
            {
                Name = animal.Name,
                SpeciesName = animal.Species.Name,
                Classification = animal.Species.Classification.ToString(),
                Sex = animal.Sex.ToString(),
                DateOfBirth = animal.DateOfBirth,
                DateOfAcquisition = animal.DateOfAcquisition, 
            };
            animalsResponse.Add(animalResponse);
        }
        return Ok(animalsResponse);
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