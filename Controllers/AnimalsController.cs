using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZooManagement.Models.Data;
using ZooManagement.Models.Requests;
using ZooManagement.Models.Response;
using ZooManagement.Enums;
using Microsoft.VisualBasic;
using System.Net;

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
        .Include(animal => animal.Enclosure)
        .SingleOrDefault(animal => animal.AnimalId == id);
        if (matchingAnimal == null)
        {
            return NotFound();
        }
        return Ok(new AnimalResponse()
        {
            Name = matchingAnimal.Name,
            SpeciesName = matchingAnimal.Species.Name,
            Classification = matchingAnimal.Species.Classification.ToString(),
            EnclosureName = matchingAnimal.Enclosure.Name,
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

    [HttpGet("list/enclosures")]
    public IActionResult ListEnclosures()
    {
        var allEnclosures =_zoo.Enclosures.Include(e => e.Animals).ThenInclude(a=>a.Species).ToList();
        return Ok(allEnclosures);
    }

    [HttpGet("listall")]
    public IActionResult ListAll([FromQuery] string species ="", [FromQuery] string classification ="", [FromQuery] int pagesize = 10, [FromQuery] int pagenum = 1)
    {     
        
        var filteredData = _zoo.Animals.Include(animal => animal.Species).Include(animal => animal.Enclosure).AsQueryable();
        
        if (!string.IsNullOrEmpty(species))
        {
            filteredData = filteredData.Where(animal => animal.Species.Name == species).AsQueryable();
        }

        if (!string.IsNullOrEmpty(classification))
        {
            if(!Enum.TryParse<Classification>(classification,ignoreCase:true,out var intClassification))
            {
                return Ok(new List<AnimalResponse>());
            }
            filteredData = filteredData.Where(animal => animal.Species.Classification == intClassification).AsQueryable();
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
                EnclosureName = animal.Enclosure.Name,
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
        if(_zoo.Species.Any(species => species.SpeciesId == createAnimalRequest.SpeciesId) && _zoo.Enclosures.Any(enclosure => enclosure.EnclosureId == createAnimalRequest.EnclosureId))
        {
            Console.WriteLine("<----------Test--------->");
            var enclosure = _zoo.Enclosures.First(enclosure => enclosure.EnclosureId == createAnimalRequest.EnclosureId);
            Console.WriteLine("<----------Found Enclosure--------->");
            if(_zoo.Animals.Count(animal => animal.EnclosureId == enclosure.EnclosureId)+1 < enclosure.NumberOfAnimals)
            {
                Console.WriteLine("creating new animal");
                var newAnimal = _zoo.Animals.Add(new Animal
                {
                    Name = createAnimalRequest.Name,
                    SpeciesId = createAnimalRequest.SpeciesId,
                    EnclosureId = createAnimalRequest.EnclosureId,
                    Sex = createAnimalRequest.Sex,
                    DateOfBirth = createAnimalRequest.DateOfBirth,
                    DateOfAcquisition = createAnimalRequest.DateOfAcquisition,
                }).Entity;
                _zoo.SaveChanges();
                return Ok(newAnimal);  
            }
            else
            {
                var msg = $"Enclosure {enclosure.Name} cannot have more than {enclosure.NumberOfAnimals} animals.";
                return Conflict(new {Message=msg});
                //throw new HttpRequestException(msg,null,HttpStatusCode.Conflict);                
            }
        } 
        else
        {
            return BadRequest();
        }
    }
}