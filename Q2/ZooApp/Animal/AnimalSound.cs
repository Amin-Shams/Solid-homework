namespace ZooApp.Animal
{
    public class Zoo
    {
        private readonly List<IAnimal> _animals;
        public Zoo(List<IAnimal> animals)
        {
            _animals = animals;
        }

        public void DisplayAnimalSounds()
        {
            foreach (var animal in _animals)
            {
                Console.WriteLine($"Animal: {animal.Name}");
                Console.WriteLine($"Sound: {animal.MakeSound()}\n");
            }
        }
    }
}
