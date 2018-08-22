using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
namespace MarcStore.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            var scopeFactory = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>();
            using (var scope = scopeFactory.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                if (!context.Products.Any())
                {
                    context.Products.AddRange(
                        new Product
                        {
                            Name = "MVGL's Favorite Games of 2017",
                            Description = "Hello everyone! As 2017 is coming to",
                            Category = "Shooter",
                            Price = 20.12m,
                            Text = "Hello everyone! As 2017 is coming to" +
                            " a close we wanted to share our favorite games of " +
                            "the year. We've all been working on and playing tons " +
                            "of great games this year, but the following stood out" +
                            " as the ones we enjoyed the most. If you haven't played" +
                            " them yourself, we definitely recommend them!",
                            ImageData = null,
                            ImageMimeType = null

                        },

                        new Product
                        {
                            Name = "PLAYERUNKNOWN'S BATTLEGROUNDS",
                            Description = "I had a tough time trying to figure out which game",
                            Category = "Shooter",
                            Price = 20.95m,
                            Text = "I had a tough time trying to figure out " +
                            "which game I really enjoyed the most this year, " +
                            "so I went with PLAYERUNKNOWN'S BATTLEGROUND. " +
                            "While it's definitely the most anxiety-inducing " +
                            "game I've ever played, I can definitely say each time I" +
                            " played I had a lot of fun. Having never played this genre " +
                            "of game before, PLAYERUNKNOW'S does a good job of making " +
                            "things dead on simple. Gear up, get weapons and attempt to stay" +
                            " alive until the end! While 99% of the matches I played ended" +
                            " within 5-10 minutes, I thoroughly enjoyed the wide variety of " +
                            "outfits, and weapons one is capable of collecting throughout the" +
                            " map. The current map itself is huge and with 100 gamers in the" +
                            " match, it certainly leads to some tense and action-packed moments." +
                            " I'm eagerly awaiting the 2 new maps which I hope come out this" +
                            " coming year, as well as the Xbox One release in a little under " +
                            "a month!",
                            ImageData = null,
                            ImageMimeType = null

                        },
                        new Product
                        {
                            Name = "Resident Evil 7: biohazard",
                            Description = "As a huge fan of the Resident Evil series",
                            Category = "Shooter",
                            Price = 12,
                            Text = "As a huge fan of the Resident Evil series," +
                            " I was very happy to see the game return to more of its roots. " +
                            "While definitely much better then the 5th and 6th game in the series, " +
                            "it wasn't exactly like the 1st and 2nd games. Nonetheless, I still enjoyed" +
                            " working my way through the old Baker family house. The attention to details, " +
                            "puzzles, and story kept me entertained throughout the game. I have yet to work" +
                            " on the DLC but I'm sure it'll be fun!",
                            ImageData = null,
                            ImageMimeType = null
                        },
                        new Product
                        {
                            Name = "Super Mario Odyssey",
                            Description = "As a fan of the first Yo-kai Watch game",
                            Category = "Arcady",
                            Price = 12.95m,
                            Text = "I have never been a big fan of the Super Mario franchise; " +
                            "I always found the games to be a little uninspired, dull and not engaging" +
                            " at all when it comes to gameplay. However, Super Mario Odyssey was the most " +
                            "joyful gaming experience I had in a while. Gameplay-wise, it shines with tight" +
                            " and fun controls and well-designed challenges and puzzles; every level shows" +
                            " lovely sceneries with a beautiful soundtrack to accompany them. Even though the " +
                            "game is brandnew, I got some serious nostalgic vibes while playing it. A truly fantastic " +
                            "game, I highly recommend it to anyone owning a Nintendo Switch.",
                            ImageData = null,
                            ImageMimeType = null
                        },
                        new Product
                        {
                            Name = "Nier: Automata",
                            Description = "2B or not 2B game of the year, " +
                            "that is the question. In this sequel to ",
                            Category = "Arcady",
                            Price = 5,
                            Text = "2B or not 2B game of the year, that is the question. In this sequel to the 2010 action RPG Nier, the eccentric Yoko Taro brings us more of his " +
                            "unique design choices, tragic stories, and philosophical musings and I've been having a blast with it. The masters of spectacle combat PlatinumGames (Bayonetta, Vanquish) " +
                            "are the developers this time around which brings welcome improvement to the gameplay of the first one. In terms of gameplay, I'm particularly fond of the bullet hell" +
                            " mechanics which spices up the regular hack n' slash combat significantly. In terms of story, themes and characters I'm fond of how it plays to the medium's strengths, " +
                            "Nier: Automata would hardly work as anything but a game. And lastly, in terms of the audiovisual, I absolutely adore the divine soundtrack.",
                            ImageData = null,
                            ImageMimeType = null

                        },
                        new Product
                        {
                            Name = "Exodus: Proxima Centauri",
                            Description = "Adapted from the original board game" +
                            "Exodus: Proxima Centauri pits you against up to 5 opponents",
                            Category = "Stragedy",
                            Price = 8,
                            Text = "And so the Exodus began… after a war that lasted only 83 days, Earth has been reduced to a nuclear wasteland. Nine factions fled the planet in search of a new home among the stars. Only six survived the journey before encountering the Centaurians, an advanced alien race, who guided the remains of humanity to safety in the Proxima Centauri star system." +
                           " Now each faction vies for control, exploiting resources and Centaurian technologies, and battling each other to become the leader of the next chapter for the human race." +
                           " In Exodus: Proxima Centauri, you will take command of one of these 6 - factions, making tactical decisions for the advancement of your fledgling empire.The game progresses through a series of turns, where players fight for control of vital planets and resources.Players fulfill the role of explorer, colonizer, politician, and military commander, before ultimately a victor is declared - the next leader of human kind." +
                             "Exodus: Proxima Centauri is a 4X game, including elements of eXploration, eXpansion, eXploitation, and eXtermination.It is adapted from the original board game created by NSKN games",
                            ImageData = null,
                            ImageMimeType = null
                        },
                        new Product
                        {
                            Name = "Flotilla 2",
                            Description = "About big battleships in outer space.",
                            Category = "Stragedy",
                            Price = 13,
                            Text = "Combat is turn-based and strategic: outmaneuver and flank your opponents from all angles. " +
                            "There is no up in space!Find firing solutions for your cannons, particle rays, tractor beams, and more.Find " +
                            "the perfect angle to ambush the enemy.Journey through a campaign of 100 hand - crafted levels filled with deadly mines, " +
                            "gravity wells, cosmic horrors, and more.Use the built -in level editor to create your own scenarios, and upload and share " +
                            "them on the Steam Workshop.Mod - friendly design is open to your creativity: make new ships, weapons, art, and more!Welcome to Flotilla 2.Good luck, captain!",
                            ImageData = null,
                            ImageMimeType = null
                        },
                        new Product
                        {
                            Name = "Cat Inside",
                            Description = "Play as a orange cat to help the little girl...",
                            Text = "1. This is a puzzle game." +
                            "2. 4 stages with different style," +
                             " puzzles and hidden items." +
                            "3.There is an orange cat in the game." +
                            "4.There's a girl in the game" +
                            "5.There's an orange cat in the game - it's you.",
                            Price = 7,
                            Category = "RPG",
                            ImageData = null,
                            ImageMimeType = null
                        },
                        new Product
                        {
                            Name = "The night of fire stealing",
                            Description = "classic puzzle game but with a slight Japanese touch ...",
                            Category = "RPG",
                            Price = 12,
                            Text = "The night of fire stealing is a retro wind JRPG game made by RPGmaker MV. You're going to play Zhou Shuren in the game. Adventures in Shanghai with two girls who call themselves Nietzsche and Marx.Explore the unknown world full of mythological and philosophical elements.Solving the crisis of the universe.Operation method:-Direction key，shift- Out the menu: z / x- In the menu:left and right mouse button The night of fire stealing is the first game I made.I try to fuse my interest in myth and philosophy.Building a world of paradoxes Because it is the first time to make, all the work of the game is completed by me.There are some shortcomings, such as the unknown bug.",
                            ImageData = null,
                            ImageMimeType = null
                        }
                    );
                    context.SaveChanges();
                }
            }
            //using (var serviceScope = app.ApplicationServices.CreateScope())
            //{
            //    var context = app.ApplicationServices
            //   .GetRequiredService<ApplicationDbContext>();
                
            //}
        }
    }
}
