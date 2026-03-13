SELECT a.Name 
FROM Animal a
	INNER JOIN ZooAnimal za ON za.AnimalId = a.Id
WHERE za.ZooId = 1