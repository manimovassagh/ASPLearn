

namespace ASPLearn.Entities
{
   
    public class Gaming
    {
        public List<Game> Games { get; set; }

        public Gaming()
        {
            Games = new List<Game>
            {
                new Game { Id = 1, Name = "GTA V", Price = 60 },
                new Game { Id = 2, Name = "Tomb Raider", Price = 23 },
                new Game { Id = 3, Name = "CS:GO", Price = 0 }
            };
        }
    }
}