namespace CDentonReviews.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using CDentonReviews.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<CDentonReviews.Models.CDentonReviewsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "CDentonReviews.Models.CDentonReviewsContext";
        }

        protected override void Seed(CDentonReviews.Models.CDentonReviewsContext context)
        {
            context.Categories.AddOrUpdate(x => x.CatID,
                new Category() { CatID = 1, CatName = "Game Reviews", ReviewID = 1 },
                new Category() { CatID = 2, CatName = "Tech Reviews", ReviewID = 2 },
                new Category() { CatID = 1, CatName = "Studio Interviews", ReviewID = 3 }
                );

            context.Authors.AddOrUpdate(x => x.AuthorID,
                new Author() { AuthorID = 1, AuthorName = "Cameron" }
        );

            context.Reviews.AddOrUpdate(x => x.ReviewID,
                new Review()
                {
                    ReviewID = 1,
                    AuthorID = 1,
                    Rating = 8,
                    ReviewTitle = "Overwatch: Keep Watching, It's Good",
                    PublishedDate = DateTime.Now,
                    ReviewContent = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc id quam ut ante pulvinar mollis. Vestibulum sollicitudin libero at viverra sagittis. Duis purus velit, consequat convallis dui eget, semper faucibus nibh. Nullam vehicula, magna quis condimentum suscipit, nisi ligula bibendum massa, sed finibus justo nibh sed orci. Cras condimentum consequat aliquet. Etiam sapien augue, vehicula porta placerat sit amet, gravida ac tortor. Donec sagittis nisl ut quam porttitor gravida. Duis accumsan congue purus vel pellentesque. Vivamus sit amet sodales nunc. Sed non nisi vel mauris posuere bibendum. Ut libero ligula, ullamcorper sit amet aliquet sed, elementum sit amet felis. Praesent justo arcu, semper a est eu, lobortis scelerisque mauris. Integer at fermentum lorem, sed varius ipsum. Nunc ipsum enim, tristique sit amet lacinia sit amet, lacinia vitae turpis. Vivamus hendrerit egestas tellus in aliquam. Aenean eget fringilla massa."
                },
                new Review()
                {
                    ReviewID = 2,
                    AuthorID = 1,
                    Rating = 4,
                    ReviewTitle = "Playstation Pro: I Should Have Saved My Money",
                    PublishedDate = DateTime.Now,
                    ReviewContent = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc id quam ut ante pulvinar mollis. Vestibulum sollicitudin libero at viverra sagittis. Duis purus velit, consequat convallis dui eget, semper faucibus nibh. Nullam vehicula, magna quis condimentum suscipit, nisi ligula bibendum massa, sed finibus justo nibh sed orci. Cras condimentum consequat aliquet. Etiam sapien augue, vehicula porta placerat sit amet, gravida ac tortor. Donec sagittis nisl ut quam porttitor gravida. Duis accumsan congue purus vel pellentesque. Vivamus sit amet sodales nunc. Sed non nisi vel mauris posuere bibendum. Ut libero ligula, ullamcorper sit amet aliquet sed, elementum sit amet felis. Praesent justo arcu, semper a est eu, lobortis scelerisque mauris. Integer at fermentum lorem, sed varius ipsum. Nunc ipsum enim, tristique sit amet lacinia sit amet, lacinia vitae turpis. Vivamus hendrerit egestas tellus in aliquam. Aenean eget fringilla massa."
                },
                new Review()
                {
                    ReviewID = 3,
                    AuthorID = 1,
                    Rating = 7,
                    ReviewTitle = "Team Ninja: Is There Enough Breast?",
                    PublishedDate = DateTime.Now,
                    ReviewContent = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc id quam ut ante pulvinar mollis. Vestibulum sollicitudin libero at viverra sagittis. Duis purus velit, consequat convallis dui eget, semper faucibus nibh. Nullam vehicula, magna quis condimentum suscipit, nisi ligula bibendum massa, sed finibus justo nibh sed orci. Cras condimentum consequat aliquet. Etiam sapien augue, vehicula porta placerat sit amet, gravida ac tortor. Donec sagittis nisl ut quam porttitor gravida. Duis accumsan congue purus vel pellentesque. Vivamus sit amet sodales nunc. Sed non nisi vel mauris posuere bibendum. Ut libero ligula, ullamcorper sit amet aliquet sed, elementum sit amet felis. Praesent justo arcu, semper a est eu, lobortis scelerisque mauris. Integer at fermentum lorem, sed varius ipsum. Nunc ipsum enim, tristique sit amet lacinia sit amet, lacinia vitae turpis. Vivamus hendrerit egestas tellus in aliquam. Aenean eget fringilla massa."
                },
                new Review()
                {
                    ReviewID = 4,
                    AuthorID = 1,
                    Rating = 9,
                    ReviewTitle = "Fallout 4: I'm Staying Out of Boston",
                    PublishedDate = DateTime.Now,
                    ReviewContent = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc id quam ut ante pulvinar mollis. Vestibulum sollicitudin libero at viverra sagittis. Duis purus velit, consequat convallis dui eget, semper faucibus nibh. Nullam vehicula, magna quis condimentum suscipit, nisi ligula bibendum massa, sed finibus justo nibh sed orci. Cras condimentum consequat aliquet. Etiam sapien augue, vehicula porta placerat sit amet, gravida ac tortor. Donec sagittis nisl ut quam porttitor gravida. Duis accumsan congue purus vel pellentesque. Vivamus sit amet sodales nunc. Sed non nisi vel mauris posuere bibendum. Ut libero ligula, ullamcorper sit amet aliquet sed, elementum sit amet felis. Praesent justo arcu, semper a est eu, lobortis scelerisque mauris. Integer at fermentum lorem, sed varius ipsum. Nunc ipsum enim, tristique sit amet lacinia sit amet, lacinia vitae turpis. Vivamus hendrerit egestas tellus in aliquam. Aenean eget fringilla massa."
                },
                new Review()
                {
                    ReviewID = 5,
                    AuthorID = 1,
                    Rating = 3,
                    ReviewTitle = "Duke Nukem Forever: We Already Know",
                    PublishedDate = DateTime.Now,
                    ReviewContent = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc id quam ut ante pulvinar mollis. Vestibulum sollicitudin libero at viverra sagittis. Duis purus velit, consequat convallis dui eget, semper faucibus nibh. Nullam vehicula, magna quis condimentum suscipit, nisi ligula bibendum massa, sed finibus justo nibh sed orci. Cras condimentum consequat aliquet. Etiam sapien augue, vehicula porta placerat sit amet, gravida ac tortor. Donec sagittis nisl ut quam porttitor gravida. Duis accumsan congue purus vel pellentesque. Vivamus sit amet sodales nunc. Sed non nisi vel mauris posuere bibendum. Ut libero ligula, ullamcorper sit amet aliquet sed, elementum sit amet felis. Praesent justo arcu, semper a est eu, lobortis scelerisque mauris. Integer at fermentum lorem, sed varius ipsum. Nunc ipsum enim, tristique sit amet lacinia sit amet, lacinia vitae turpis. Vivamus hendrerit egestas tellus in aliquam. Aenean eget fringilla massa."
                }



                );
        }
    }
}
