using eTickets.Models;

namespace eTickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
               var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Cinema
                if(!context.cinemas.Any())
                {
                    context.cinemas.AddRange(new List<Cinema>()
                    {
                     new Cinema()
                     {
                         Name = "voxcinemas",
                         logo = "https://ksa.voxcinemas.com/assets/images/logo-dark-288x92.png",
                         Description = "VOX Cinemas, the MENA region’s largest cinema operator, is honoured to be awarded one of the first licenses to operate cinemas in Saudi Arabia. Its brand-new cinema, which will be the first multiplex in Saudi Arabia will open at Riyadh Park Mall. VOX Cinemas will start delivering on an ambitious plan to bring its world-class cinema entertainment portfolio to Saudi Arabia and support the growth of audio-visual and creative talent across the Kingdom."
                     },

                     new Cinema()
                     {
                         Name = "Muvi",
                         logo = "https://www.muvicinemas.com/assets/images/welcome-muvi-logo.png",
                         Description = "muvi Cinemas is the first home-grown cinema brand and the market leader in terms of screen count in the Kingdom of Saudi Arabia. Established in 2019 with headquarters in Riyadh, it is owned and operated by muvi Cinemas Co. muvi continues its expansion plan in the upcoming years across the kingdom offering state-of-the-art technology, diverse and immersive experiences combined with unlimited options from our delicious menu to give moviegoers complete and exceptional cinema experience."
                     },

                     new Cinema()
                     {
                         Name = "AMC",
                         logo = "https://prodcdnuaenorthamcscc.azureedge.net/prod-amcsccl-images/Content/images/Home/amc-logo.svg",
                         Description = "AMC Cinemas is dedicated to innovating the way you see movies. Don’t just visit a cinema; experience the AMC difference of premium formats that bring you superior acoustics, richer imagery, and a choice between Real D® 3D, Dolby Cinema®, and IMAX® technologies. Taste our special menu of elevated cinema favorites and enjoy bolder flavors, wider variety, and superior quality movie snacks. Reserve your seats when you purchase tickets online and on our app and relax into the spacious comforts of our luxe recliners. Come and enjoy the very best of cutting-edge entertainment when you choose AMC Cinemas."
                     }
                    });

                    context.SaveChanges();
                }
                //Actors
                if(!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Tom Holland",
                            ProfilePictureURL = "https://www.themoviedb.org/t/p/w300_and_h450_bestv2/bBRlrpJm9XkNSg0YT5LCaxqoFMX.jpg",
                            Bio = "Thomas \"Tom\" Stanley Holland is an English actor and dancer. He is best known for playing Peter Parker / Spider-Man in the Marvel Cinematic Universe and has appeared as the character in six films: Captain America: Civil War (2016), Spider-Man: Homecoming (2017), Avengers: Infinity War (2018), Avengers: Endgame (2019), Spider-Man: Far From Home (2019), and Spider-Man: No Way Home (2021). He is also known for playing the title role in Billy Elliot the Musical at the Victoria Palace Theatre, London, as well as for starring in the 2012 film The Impossible."
                        }, 
                        new Actor()
                        {
                            FullName = "Zendaya",
                            ProfilePictureURL = "https://www.themoviedb.org/t/p/w300_and_h450_bestv2/6TE2AlOUqcrs7CyJiWYgodmee1r.jpg",
                            Bio = "Zendaya Maree Stoermer Coleman (born September 1, 1996) is an American actress and singer. She began her career as a child model and backup dancer. She rose to mainstream prominence for her role as Rocky Blue on the Disney Channel sitcom Shake It Up (2010–2013). In 2013, Zendaya was a contestant on the 16th season of the dance competition series Dancing with the Stars. She produced and starred as the titular spy, K.C. Cooper, in the sitcom K.C. Undercover (2015–2018). Her film roles include the musical drama The Greatest Showman (2017), the superhero film Spider-Man: Homecoming (2017) and its sequels, the computer-animated musical comedy Smallfoot (2018), the romantic drama Malcolm & Marie (2021), the live-action/animation hybrid sports comedy Space Jam: A New Legacy (2021), and the science fiction epic Dune (2021)."
                        },
                        new Actor()
                        {
                            FullName = "Ingrid Oliver",
                            ProfilePictureURL = "https://www.themoviedb.org/t/p/w300_and_h450_bestv2/mHlw4Zn1OFqShcVe3bBnCgIF7cI.jpg",
                            Bio = "We don't have a biography for Ingrid Oliver."
                        }
                    });

                    context.SaveChanges();
                }
                //Producers
                if(!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Alfred Molina",
                            ProfilePictureURL = "https://www.themoviedb.org/t/p/w300_and_h450_bestv2/nJo91Czesn6z0d0pkfbDoVZY3sg.jpg",
                            Bio = "Alfred Molina (born 24 May 1953) is an English-American actor. He rose to fame on stage in the West End of London and has also appeared in many roles on Broadway. He is known for films such as Raiders of the Lost Ark, Spider-Man 2 and An Education."
                        },

                        new Producer()
                        {
                            FullName = "Harvey Keitel",
                            ProfilePictureURL = "https://www.themoviedb.org/t/p/w300_and_h450_bestv2/c1KlwOAlnFhBWfcPIvA6hmrElb6.jpg",
                            Bio = "An American actor. Some of his more notable starring roles were in Martin Scorsese's Mean Streets and Taxi Driver, Ridley Scott's The Duellists and Thelma and Louise, Quentin Tarantino's Reservoir Dogs and Pulp Fiction, Jane Campion's The Piano, Abel Ferrara's Bad Lieutenant, James Mangold's Cop Land, Nicolas Roeg's Bad Timing, and Theo Angelopoulos's Ulysses' Gaze. His latest work was as Detective Lieutenant Gene Hunt on the American adaptation of Life on Mars."
                        }
                    });

                    context.SaveChanges();
                }  
                //Movies
                if(!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "House of the Dragon ",
                            Description = "The prequel series finds the Targaryen dynasty at the absolute apex of its power, with more than 15 dragons under their yoke. Most empires—real and imagined—crumble from such heights. In the case of the Targaryens, their slow fall begins almost 193 years before the events of Game of Thrones, when King Viserys Targaryen breaks with a century of tradition by naming his daughter Rhaenyra heir to the Iron Throne. But when Viserys later fathers a son, the court is shocked when Rhaenyra retains her status as his heir, and seeds of division sow friction across the realm.",
                            ImageURL = "https://www.themoviedb.org/t/p/w300_and_h450_bestv2/z2yahl2uefxDCl0nogcRBstwruJ.jpg",
                            StartDate = DateTime.Now.AddDays(-30),
                            EndDate = DateTime.Now.AddDays(30),
                            Price = 60.75,
                            CinemaId = 1,
                            ProducerId = 1,
                            MovieCategory =Enums.MovieCategory.Drama
                        }
                    });

                    context.SaveChanges();
                }
                //Actors & Movies
                if(!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 1
                        },

                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 1
                        },

                         new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 1
                        }
                    });

                    context.SaveChanges();
                }


            }
        }
    }
}
