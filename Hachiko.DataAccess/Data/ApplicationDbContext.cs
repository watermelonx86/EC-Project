using System.Data;
using Hachiko.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Hachiko.DataAcess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        //Constructor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //Add Models as DbSet Into the Database(DbContext)
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category() {Id =1, Name = "Action", DisplayOrder = 1},
                new Category() {Id = 2, Name = "SciFi", DisplayOrder = 2},
                new Category() {Id = 3, Name = "History", DisplayOrder = 3},
                new Category() { Id = 4, Name ="Science", DisplayOrder = 4, Description= "Science (from the Latin scientia, meaning “knowledge”) is the effort to discover, and increase human understanding of how the physical world works. Through controlled methods, science uses observable physical evidence of natural phenomena to collect data, and analyzes this information to explain what and how things work." }
            );
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Fortune of Time",
                    Author = "Billy Spark",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ISBN = "SWD9999001",
                    ListPrice = 99,
                    Price1 = 90,
                    Price2 = 85,
                    Price3 = 80,
                    CategoryId = 1,
                    ImageUrl =""
                },
                new Product
                {
                    Id = 2,
                    Title = "Dark Skies",
                    Author = "Nancy Hoover",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ISBN = "CAW777777701",
                    ListPrice = 40,
                    Price1 = 30,
                    Price2 = 25,
                    Price3 = 20,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 3,
                    Title = "Vanish in the Sunset",
                    Author = "Julian Button",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ISBN = "RITO5555501",
                    ListPrice = 55,
                    Price1 = 50,
                    Price2 = 40,
                    Price3 = 35,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 4,
                    Title = "Cotton Candy",
                    Author = "Abby Muscles",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ISBN = "WS3333333301",
                    ListPrice = 70,
                    Price1 = 65,
                    Price2 = 60,
                    Price3 = 55,
                    CategoryId = 3,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 5,
                    Title = "Rock in the Ocean",
                    Author = "Ron Parker",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ISBN = "SOTJ1111111101",
                    ListPrice = 30,
                    Price1 = 27,
                    Price2 = 25,
                    Price3 = 20,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 6,
                    Title = "Leaves and Wonders",
                    Author = "Laura Phantom",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ISBN = "FOT000000001",
                    ListPrice = 25,
                    Price1 = 23,
                    Price2 = 22,
                    Price3 = 20,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                 new Product
                 {
                     Id = 7,
                     Title = "The Parrot and the Igloo: Climate and the Science of Denial",
                     Author = "David Lipsky",
                     Description = "In 1956, the New York Times prophesied that once global warming really kicked in, we could see parrots in the Antarctic. In 2010, when science deniers had control of the climate story, Senator James Inhofe and his family built an igloo on the Washington Mall and plunked a sign on top: AL GORE'S NEW HOME: HONK IF YOU LOVE CLIMATE CHANGE. In The Parrot and the Igloo, best-selling author David Lipsky tells the astonishing story of how we moved from one extreme (the correct one) to the other.\r\n\r\n\r\nWith narrative sweep and a superb eye for character, Lipsky unfolds the dramatic narrative of the long, strange march of climate science. The story begins with a tale of three inventors—Thomas Edison, George Westinghouse, and Nikola Tesla—who made our technological world, not knowing what they had set into motion. Then there are the scientists who sounded the alarm once they identified carbon dioxide as the culprit of our warming planet. And we meet the hucksters, zealots, and crackpots who lied about that science and misled the public in ever more outrageous ways. Lipsky masterfully traces the evolution of climate denial, exposing how it grew out of early efforts to build a network of untruth about products like aspirin and cigarettes.\r\n\r\n\r\nFeaturing an indelible cast of heroes and villains, mavericks and swindlers, The Parrot and the Igloo delivers a real-life tragicomedy—one that captures the extraordinary dance of science, money, and the American character.",
                     ISBN = "9780393866704",
                     ListPrice = 25,
                     Price1 = 23,
                     Price2 = 22,
                     Price3 = 20,
                     CategoryId = 4,
                     ImageUrl = ""
                 },
                  new Product
                  {
                      Id = 8,
                      Title = "The Underworld: Journeys to the Depths of the Ocean",
                      Author = "Susan Casey",
                      Description = "From bestselling author Susan Casey, an awe-inspiring portrait of the mysterious world beneath the waves, and the men and women who seek to uncover its secrets\r\n\r\nFor all of human history, the deep ocean has been a source of wonder and terror, an unknown realm that evoked a singular, compelling question: What’s down there? Unable to answer this for centuries, people believed the deep was a sinister realm of fiendish creatures and deadly peril. But now, cutting-edge technologies allow scientists and explorers to dive miles beneath the surface, and we are beginning to understand this strange and exotic underworld: A place of soaring mountains, smoldering volcanoes, and valleys 7,000 feet deeper than Everest is high, where tectonic plates collide and separate, and extraordinary life forms operate under different rules. Far from a dark void, the deep is a vibrant realm that’s home to pink gelatinous predators and shimmering creatures a hundred feet long and ancient animals with glass skeletons and sharks that live for half a millennium—among countless other marvels.\r\n\r\nSusan Casey is our premiere chronicler of the aquatic world. For The Underworld she traversed the globe, joining scientists and explorers on dives to the deepest places on the planet, interviewing the marine geologists, marine biologists, and oceanographers who are searching for knowledge in this vast unseen realm. She takes us on a fascinating journey through the history of deep-sea exploration, from the myths and legends of the ancient world to storied shipwrecks we can now reach on the bottom, to the first intrepid bathysphere pilots, to the scientists who are just beginning to understand the mind-blowing complexity and ecological importance of the quadrillions of creatures who live in realms long thought to be devoid of life.\r\n\r\nThroughout this journey, she learned how vital the deep is to the future of the planet, and how urgent it is that we understand it in a time of increasing threats from climate change, industrial fishing, pollution, and the mining companies that are also exploring its depths. The Underworld is Susan Casey’s most beautiful and thrilling book yet, a gorgeous evocation of the natural world and a powerful call to arms.",
                      ISBN = "9780385545570",
                      ListPrice = 225,
                      Price1 = 323,
                      Price2 = 422,
                      Price3 = 520,
                      CategoryId = 4,
                      ImageUrl = ""
                  },
                   new Product
                   {
                       Id = 9,
                       Title = "Muscle: The Gripping Story of Strength and Movement\r\n\r\n",
                       Author = "Roy A. Meals",
                       Description = "An entertaining illustrated deep dive into muscle, from the discovery of human anatomy to the latest science of strength training. Muscle tissue powers every heartbeat, blink, jog, jump, and goosebump. It is the force behind the most critical bodily functions, including digestion and childbirth, as well as extreme feats of athleticism. We can mold our muscles with exercise and observe the results. In this lively, lucid book, orthopedic surgeon Roy A. Meals takes us on a wide-ranging journey through anatomy, biology, history, and health to unlock the mysteries of our muscles. He breaks down the three different types of muscle―smooth, skeletal, and cardiac―and explores major advancements in medicine and fitness, including cutting-edge gene-editing research and the science behind popular muscle conditioning strategies. Along the way, he offers insight into the changing aesthetic and cultural conception of muscle, from Michelangelo’s David to present-day bodybuilders, and shares fascinating examples of strange muscular maladies and their treatment. Brimming with fun facts and infectious enthusiasm, Muscle sheds light on the astonishing, essential tissue that moves us through life. 90 illustrations",
                       ISBN = "9781324021445",
                       ListPrice = 725,
                       Price1 = 423,
                       Price2 = 322,
                       Price3 = 220,
                       CategoryId = 4,
                       ImageUrl = ""
                   },
                    new Product
                    {
                        Id = 10,
                        Title = "Interstellar: The Search for Extraterrestrial Life and Our Future in the Stars",
                        Author = "Avi Loeb",
                        Description = "“The world's leading alien hunter” — New York Times Magazine From acclaimed Harvard astrophysicist and bestselling author of Extraterrestrial comes a mind-expanding new book explaining why becoming an interstellar species is imperative for humanity’s survival and detailing a game plan for how we can settle among the stars. In the New York Times  bestseller  Extraterrestrial,  Avi Loeb, the longest serving Chair of Harvard’s Astronomy Department, presented a theory that   shook the scientific our solar system, Loeb claimed, had likely been visited by a piece of advanced alien technology from a distant star. This provocative and persuasive argument opened millions of minds internationally to the vast possibilities of our universe and the existence of intelligent life beyond Earth. But a crucial question now that we are aware of the existence of extraterrestrial life, what do we do next? How do we prepare ourselves for interaction with interstellar extraterrestrial civilization? How can our species become interstellar? Now Loeb tackles these questions in a revelatory, powerful call to arms that reimagines the idea of contact with extraterrestrial civilizations. Dismantling our science-fiction fueled visions of a human and alien life encounter,  Interstellar  provides a realistic and practical blueprint for how such an interaction might actually occur, resetting our cultural understanding and expectation of what it means to identify an extraterrestrial object. From awe-inspiring searches for extraterrestrial technology, to the heated debate of the existence of Unidentified Aerial Phenomena, Loeb provides a thrilling, front-row view of the monumental progress in science and technology currently preparing us for contact. He also lays out the profound implications of becoming—or not becoming—interstellar; in an urgent, eloquent appeal for more proactive engagement with the world beyond ours, he powerfully contends why we must seek out other life forms, and in the process, choose who and what we are within the universe. Combining cutting edge science, physics, and philosophy,  Interstellar  revolutionizes the approach to our search for extraterrestrial life and our preparation for its discovery. In this eye-opening, necessary look at our future, Avi Loeb artfully and expertly raises some of the most important questions facing us as humans, and proves, once again, that scientific curiosity is the key to our survival.",
                        ISBN = "FOT000000021",
                        ListPrice = 425,
                        Price1 = 323,
                        Price2 = 522,
                        Price3 = 620,
                        CategoryId = 4,
                        ImageUrl = ""
                    },
                     new Product
                     {
                         Id = 11,
                         Title = "The Good Virus: The Amazing Story and Forgotten Promise of the Phage",
                         Author = "Tom Ireland",
                         Description = "At every moment, within your body and all around you, trillions of microscopic combatants are fighting an invisible war. Countless times per second, viruses known as bacteriophages invade and destroy bacteria from within, leaving all other cells, including our own, miraculously unharmed. These “phages” are the most abundant, diverse biological entity on Earth—but also the most underappreciated and misunderstood.\r\n\r\n\r\nThe Good Virus tells their strange, remarkable story for the first time, from their discovery by a renegade French Canadian scientist more than a century ago to their emergence in the present day as our unlikely allies in the struggle against antibiotic-resistant infections. We learn how this “phage therapy” was repeatedly shunned by Western medicine but flourished behind the Iron Curtain, and follow scientists now unlocking how phages shape evolution and life on our planet at large. Celebrating the paradoxical power of viruses to heal, not harm, The Good Virus will change how you see nature’s most maligned life forms.",
                         ISBN = "9781324050834",
                         ListPrice = 1325,
                         Price1 = 4123,
                         Price2 = 322,
                         Price3 = 120,
                         CategoryId = 4,
                         ImageUrl = ""
                     }
                );
        }
    }
}
