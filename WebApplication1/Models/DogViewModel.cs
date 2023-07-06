namespace WebApplication1.Models
{
    public class DogViewModel
    {
        public string Name { get; set; }
        public int age { get; set; }
    }
    public class Dog
    {
        public string Sound;
        public Dog(string sound) { 
            Sound = sound;
        }
    }
}
