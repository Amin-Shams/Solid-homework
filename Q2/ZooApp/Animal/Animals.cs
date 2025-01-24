namespace ZooApp
{
    public class Lion : IAnimal
    {
        public string Name => "Lion";
        public string MakeSound() => "ROAR";
    }

    public class Elephant : IAnimal
    {
        public string Name => "Elephant";
        public string MakeSound() => "TRUMPET";
    }

    public class Giraffe : IAnimal
    {
        public string Name => "Giraffe";
        public string MakeSound() => "BLEAT";
    }

    public class Monkey : IAnimal
    {
        public string Name => "Monkey";
        public string MakeSound() => "SCREAM";
    }
}
