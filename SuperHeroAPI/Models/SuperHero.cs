namespace SuperHeroApiDotNet7.Models
{
    public class SuperHero
    {
        // Lets add some properties to our models

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Place { get; set; } = string.Empty;
    }

    // Then let's go create the SuperHero Controller in controllers
}
