using PokemonReviewApp.Data;
using PokemonReviewApp.Models;

namespace PokemonReviewApp
{
    public class Seed
    {
        private readonly DataContext dataContext;
        public Seed(DataContext context)
        {
            this.dataContext = context;
        }
        public void SeedDataContext()
        {
            if (!dataContext.PokemonOwners.Any())
            {
                var pokemonOwners = new List<PokemonOwner>()
                {
                    new PokemonOwner()
                    {
                        Pokemon = new Pokemon()
                        {
                            Name = "Pikachu",
                            JapaneseName = "Pikachuピカチュウ",
                            Pokedex = 25,
                            Attack = 55,
                            Defense = 40,
                            
                            PokemonCategories = new List<PokemonCategory>()
                            {
                                new PokemonCategory { Category = new Category() { Name = "Electric"}}
                            },
                            Reviews = new List<Review>()
                            {
                                new Review { Title="Pikachu",Text = "Pickahu is the best pokemon, because it is electric", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Teddy", LastName = "Smith" } },
                                new Review { Title="Pikachu", Text = "Pickachu is the best a killing rocks", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Taylor", LastName = "Jones" } },
                                new Review { Title="Pikachu",Text = "Pickchu, pickachu, pikachu", Rating = 1,
                                Reviewer = new Reviewer(){ FirstName = "Jessica", LastName = "McGregor" } },
                            }
                        },
                        Owner = new Owner()
                        {
                            Name = "Jack London",
                            Gym = "Brocks Gym",
                            Country = new Country()
                            {
                                Name = "Kanto"
                            }
                        }
                    },
                    new PokemonOwner()
                    {
                        Pokemon = new Pokemon()
                        {
                            Name = "Bulbasaur",
                            JapaneseName = "Fushigidaneフシギダネ",
                            Pokedex = 1,
                            Attack = 49,
                            Defense = 49,

                            PokemonCategories = new List<PokemonCategory>()
                            {
                                new PokemonCategory { Category = new Category() { Name = "Grass" } },
                                new PokemonCategory { Category = new Category() { Name = "Poison" } }
                            },
                            Reviews = new List<Review>()
                            {
                                new Review { Title = "Bulbasaur", Text = "Bulbasaur is a great starter with a dual type advantage!", Rating = 4,
                                Reviewer = new Reviewer(){ FirstName = "Ash", LastName = "Ketchum" } },
                                new Review { Title = "Bulbasaur", Text = "Bulbasaur's Leech Seed move is a game-changer!", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Misty", LastName = "Waterflower" } },
                                new Review { Title = "Bulbasaur", Text = "Bulbasaur's cute appearance makes battles more enjoyable!", Rating = 4,
                                Reviewer = new Reviewer(){ FirstName = "Brock", LastName = "Rockwell" } },
                            }
                        },
                        Owner = new Owner()
                        {
                            Name = "Professor Oak",
                            Gym = "Oak's Gym",
                            Country = new Country()
                            {
                                Name = "Kanto"
                            }
                        }
                    },
                    new PokemonOwner()
                    {
                        Pokemon = new Pokemon()
                        {
                            Name = "Pikachu",
                            JapaneseName = "Pikachuピカチュウ",
                            Pokedex = 25,
                            Attack = 55,
                            Defense = 40,

                            PokemonCategories = new List<PokemonCategory>()
                            {
                                new PokemonCategory { Category = new Category() { Name = "Electric"}}
                            },
                            Reviews = new List<Review>()
                            {
                                new Review { Title="Pikachu",Text = "Pickahu is the best pokemon, because it is electric", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Teddy", LastName = "Smith" } },
                                new Review { Title="Pikachu", Text = "Pickachu is the best a killing rocks", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Taylor", LastName = "Jones" } },
                                new Review { Title="Pikachu",Text = "Pickchu, pickachu, pikachu", Rating = 1,
                                Reviewer = new Reviewer(){ FirstName = "Jessica", LastName = "McGregor" } },
                            }
                        },
                        Owner = new Owner()
                        {
                            Name = "Jack London",
                            Gym = "Brocks Gym",
                            Country = new Country()
                            {
                                Name = "Kanto"
                            }
                        }
                    },
                    new PokemonOwner()
                    {
                        Pokemon = new Pokemon()
                        {
                            Name = "Squirtle",
                            JapaneseName = "Zenigameゼニガメ",
                            Pokedex = 7,
                            Attack = 48,
                            Defense = 65,

                            PokemonCategories = new List<PokemonCategory>()
                            {
                                new PokemonCategory { Category = new Category() { Name = "Water" } }
                            },
                            Reviews = new List<Review>()
                            {
                                new Review { Title = "Squirtle", Text = "Squirtle's Water Gun move is a splash of power!", Rating = 4,
                                Reviewer = new Reviewer(){ FirstName = "Dawn", LastName = "Breeze" } },
                                new Review { Title = "Squirtle", Text = "Squirtle's defensive stats make it a solid choice in battles!", Rating = 4,
                                Reviewer = new Reviewer(){ FirstName = "Calem", LastName = "Kalos" } },
                                new Review { Title = "Squirtle", Text = "Squirtle's shell is both protective and stylish!", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "May", LastName = "Maple" } },
                            }
                        },
                        Owner = new Owner()
                        {
                            Name = "Marina Waves",
                            Gym = "Aqua Gym",
                            Country = new Country()
                            {
                                Name = "Kanto"
                            }
                        }
                    }
                };
                dataContext.PokemonOwners.AddRange(pokemonOwners);
                dataContext.SaveChanges();
            }
        }
    }
}