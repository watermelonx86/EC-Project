using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hachiko.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class updatesomedata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Description", "DisplayOrder", "Name" },
                values: new object[] { 4, "Science (from the Latin scientia, meaning “knowledge”) is the effort to discover, and increase human understanding of how the physical world works. Through controlled methods, science uses observable physical evidence of natural phenomena to collect data, and analyzes this information to explain what and how things work.", 4, "Science" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "CategoryId", "Description", "ISBN", "ImageUrl", "ListPrice", "Price1", "Price2", "Price3", "Title" },
                values: new object[,]
                {
                    { 7, "David Lipsky", 4, "In 1956, the New York Times prophesied that once global warming really kicked in, we could see parrots in the Antarctic. In 2010, when science deniers had control of the climate story, Senator James Inhofe and his family built an igloo on the Washington Mall and plunked a sign on top: AL GORE'S NEW HOME: HONK IF YOU LOVE CLIMATE CHANGE. In The Parrot and the Igloo, best-selling author David Lipsky tells the astonishing story of how we moved from one extreme (the correct one) to the other.\r\n\r\n\r\nWith narrative sweep and a superb eye for character, Lipsky unfolds the dramatic narrative of the long, strange march of climate science. The story begins with a tale of three inventors—Thomas Edison, George Westinghouse, and Nikola Tesla—who made our technological world, not knowing what they had set into motion. Then there are the scientists who sounded the alarm once they identified carbon dioxide as the culprit of our warming planet. And we meet the hucksters, zealots, and crackpots who lied about that science and misled the public in ever more outrageous ways. Lipsky masterfully traces the evolution of climate denial, exposing how it grew out of early efforts to build a network of untruth about products like aspirin and cigarettes.\r\n\r\n\r\nFeaturing an indelible cast of heroes and villains, mavericks and swindlers, The Parrot and the Igloo delivers a real-life tragicomedy—one that captures the extraordinary dance of science, money, and the American character.", "9780393866704", "", 25.0, 23.0, 22.0, 20.0, "The Parrot and the Igloo: Climate and the Science of Denial" },
                    { 8, "Susan Casey", 4, "From bestselling author Susan Casey, an awe-inspiring portrait of the mysterious world beneath the waves, and the men and women who seek to uncover its secrets\r\n\r\nFor all of human history, the deep ocean has been a source of wonder and terror, an unknown realm that evoked a singular, compelling question: What’s down there? Unable to answer this for centuries, people believed the deep was a sinister realm of fiendish creatures and deadly peril. But now, cutting-edge technologies allow scientists and explorers to dive miles beneath the surface, and we are beginning to understand this strange and exotic underworld: A place of soaring mountains, smoldering volcanoes, and valleys 7,000 feet deeper than Everest is high, where tectonic plates collide and separate, and extraordinary life forms operate under different rules. Far from a dark void, the deep is a vibrant realm that’s home to pink gelatinous predators and shimmering creatures a hundred feet long and ancient animals with glass skeletons and sharks that live for half a millennium—among countless other marvels.\r\n\r\nSusan Casey is our premiere chronicler of the aquatic world. For The Underworld she traversed the globe, joining scientists and explorers on dives to the deepest places on the planet, interviewing the marine geologists, marine biologists, and oceanographers who are searching for knowledge in this vast unseen realm. She takes us on a fascinating journey through the history of deep-sea exploration, from the myths and legends of the ancient world to storied shipwrecks we can now reach on the bottom, to the first intrepid bathysphere pilots, to the scientists who are just beginning to understand the mind-blowing complexity and ecological importance of the quadrillions of creatures who live in realms long thought to be devoid of life.\r\n\r\nThroughout this journey, she learned how vital the deep is to the future of the planet, and how urgent it is that we understand it in a time of increasing threats from climate change, industrial fishing, pollution, and the mining companies that are also exploring its depths. The Underworld is Susan Casey’s most beautiful and thrilling book yet, a gorgeous evocation of the natural world and a powerful call to arms.", "9780385545570", "", 225.0, 323.0, 422.0, 520.0, "The Underworld: Journeys to the Depths of the Ocean" },
                    { 9, "Roy A. Meals", 4, "An entertaining illustrated deep dive into muscle, from the discovery of human anatomy to the latest science of strength training. Muscle tissue powers every heartbeat, blink, jog, jump, and goosebump. It is the force behind the most critical bodily functions, including digestion and childbirth, as well as extreme feats of athleticism. We can mold our muscles with exercise and observe the results. In this lively, lucid book, orthopedic surgeon Roy A. Meals takes us on a wide-ranging journey through anatomy, biology, history, and health to unlock the mysteries of our muscles. He breaks down the three different types of muscle―smooth, skeletal, and cardiac―and explores major advancements in medicine and fitness, including cutting-edge gene-editing research and the science behind popular muscle conditioning strategies. Along the way, he offers insight into the changing aesthetic and cultural conception of muscle, from Michelangelo’s David to present-day bodybuilders, and shares fascinating examples of strange muscular maladies and their treatment. Brimming with fun facts and infectious enthusiasm, Muscle sheds light on the astonishing, essential tissue that moves us through life. 90 illustrations", "9781324021445", "", 725.0, 423.0, 322.0, 220.0, "Muscle: The Gripping Story of Strength and Movement\r\n\r\n" },
                    { 10, "Avi Loeb", 4, "“The world's leading alien hunter” — New York Times Magazine From acclaimed Harvard astrophysicist and bestselling author of Extraterrestrial comes a mind-expanding new book explaining why becoming an interstellar species is imperative for humanity’s survival and detailing a game plan for how we can settle among the stars. In the New York Times  bestseller  Extraterrestrial,  Avi Loeb, the longest serving Chair of Harvard’s Astronomy Department, presented a theory that   shook the scientific our solar system, Loeb claimed, had likely been visited by a piece of advanced alien technology from a distant star. This provocative and persuasive argument opened millions of minds internationally to the vast possibilities of our universe and the existence of intelligent life beyond Earth. But a crucial question now that we are aware of the existence of extraterrestrial life, what do we do next? How do we prepare ourselves for interaction with interstellar extraterrestrial civilization? How can our species become interstellar? Now Loeb tackles these questions in a revelatory, powerful call to arms that reimagines the idea of contact with extraterrestrial civilizations. Dismantling our science-fiction fueled visions of a human and alien life encounter,  Interstellar  provides a realistic and practical blueprint for how such an interaction might actually occur, resetting our cultural understanding and expectation of what it means to identify an extraterrestrial object. From awe-inspiring searches for extraterrestrial technology, to the heated debate of the existence of Unidentified Aerial Phenomena, Loeb provides a thrilling, front-row view of the monumental progress in science and technology currently preparing us for contact. He also lays out the profound implications of becoming—or not becoming—interstellar; in an urgent, eloquent appeal for more proactive engagement with the world beyond ours, he powerfully contends why we must seek out other life forms, and in the process, choose who and what we are within the universe. Combining cutting edge science, physics, and philosophy,  Interstellar  revolutionizes the approach to our search for extraterrestrial life and our preparation for its discovery. In this eye-opening, necessary look at our future, Avi Loeb artfully and expertly raises some of the most important questions facing us as humans, and proves, once again, that scientific curiosity is the key to our survival.", "FOT000000021", "", 425.0, 323.0, 522.0, 620.0, "Interstellar: The Search for Extraterrestrial Life and Our Future in the Stars" },
                    { 11, "Tom Ireland", 4, "At every moment, within your body and all around you, trillions of microscopic combatants are fighting an invisible war. Countless times per second, viruses known as bacteriophages invade and destroy bacteria from within, leaving all other cells, including our own, miraculously unharmed. These “phages” are the most abundant, diverse biological entity on Earth—but also the most underappreciated and misunderstood.\r\n\r\n\r\nThe Good Virus tells their strange, remarkable story for the first time, from their discovery by a renegade French Canadian scientist more than a century ago to their emergence in the present day as our unlikely allies in the struggle against antibiotic-resistant infections. We learn how this “phage therapy” was repeatedly shunned by Western medicine but flourished behind the Iron Curtain, and follow scientists now unlocking how phages shape evolution and life on our planet at large. Celebrating the paradoxical power of viruses to heal, not harm, The Good Virus will change how you see nature’s most maligned life forms.", "9781324050834", "", 1325.0, 4123.0, 322.0, 120.0, "The Good Virus: The Amazing Story and Forgotten Promise of the Phage" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
