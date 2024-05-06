namespace BlazorECommerce.Server.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    id = 1,
                    title = "Never Go Back",
                    description = "Never Go Back is the eighteenth book in the Jack Reacher series written by Lee Child.[1] It was published on 3 September 2013 in the United States",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d4/Never_go_back_by_lee_child.png",
                    price = 9.99m
                },
                new Product
                {
                    id = 2,
                    title = "Killing Floor",
                    description = "Killing Floor is the debut novel by Lee Child, first published in 1997 by Putnam. The book won the Anthony Award and Barry Award for best first novel. It is also the first book to feature the character Jack Reacher. It is written in the first person",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/3/3c/Killing_floor_by_lee_child_1st_edition_uk.png",
                    price = 9.99m
                },
                new Product
                {
                    id = 3,
                    title = "Trip Wire",
                    description = "Tripwire is the third book in the Jack Reacher series written by Lee Child. It was published in 1999 by Putnam in America and Bantam in the United Kingdom. It is written in the third person. In the novel, retired military police officer Jack Reacher becomes embroiled in a mystery involving a Vietnam War veteran who was reported missing in action, but who has resurfaced as a vicious loanshark with a secret he will murder to protec",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/2/29/Tripwire_book.jpg",
                    price = 9.99m
                }
            );
        }
        public DbSet<Product> Products { get; set;}
    }
}
