import { useState } from 'react'


interface Animal {
  name: string,
  speciesName: string,
  classificationName: string,
  enclosureName: string,
  sex: string,
  dateOfBirth: string,
  dateOfAqu : string
}


const ListAnimal : React.FC= () => {
  const [animal, setAnimal] = useState<Animal>()
  const [loading, setLoading] = useState<boolean>(false)
  const [error, setError] = useState<boolean>(false)

  const handleSubmit: React.FormEventHandler<HTMLFormElement> = (event) => {
    event.preventDefault()
    setAnimal(undefined)
    setError(false)
    const formData = new FormData(event.target as HTMLFormElement)
    const animalId = formData.get("animalId")
    console.log(animalId);
    if (animalId) {
      setLoading(true)
      fetch(`http://localhost:5031/animals/${animalId}`)
        .then((response) => response.json())
        .then((data) => setAnimal(data))
        .catch(() => setError(true))
        .finally(() => setLoading(false))
    }
  }

  return (
    <main>
      <form onSubmit={handleSubmit}>
        <label>
          Enter Animal ID:          
          <input type="text" name="animalId" />
        </label>
        <button type="submit">Get Animal!</button>
      </form>
      {animal &&
        <div>          
          <h1>{animal.name}</h1>
          <ul>
            <li>{animal.speciesName}</li>
            <li>{animal.classificationName}</li>
            <li>{animal.enclosureName}</li>
            <li>{animal.sex}</li>
            <li>{animal.dateOfBirth}</li>
            <li>{animal.dateOfAqu}</li>
          </ul>
        </div>
      }
      {loading &&
        <p>Loading...</p>
      }
      {error &&
        <p>Couldn't find your animal!</p>
      }
    </main>
  )
}

export default ListAnimal