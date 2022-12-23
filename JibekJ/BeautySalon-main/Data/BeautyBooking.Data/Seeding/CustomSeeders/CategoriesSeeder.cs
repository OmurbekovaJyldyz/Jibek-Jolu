namespace BeautyBooking.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using BeautyBooking.Common;
    using BeautyBooking.Data.Models;

    public class CategoriesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Categories.Any())
            {
                return;
            }

            var categories = new Category[]
                {
                    new Category // Id = 1
                    {
                        Name = "Товары для дома",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. ",
                        ImageUrl = GlobalConstants.Images.Hair,
                    },
                    new Category // Id = 2
                    {
                        Name = "Женская одежда",
                        Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. ",
                        ImageUrl = GlobalConstants.Images.HairRemoval,
                    },
                    new Category // Id = 3
                    {
                        Name = "Мужская одежда",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. ",
                        ImageUrl = GlobalConstants.Images.Massage,
                    },
                    new Category // Id = 4
                    {
                        Name = "Детская одежда",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. ",
                        ImageUrl = GlobalConstants.Images.Nails,
                    },
                    new Category // Id = 5
                    {
                        Name = "Натуральные продукты",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. ",
                        ImageUrl = GlobalConstants.Images.Face,
                    },
                    new Category // Id = 6
                    {
                        Name = "Аксессуары",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. ",
                        ImageUrl = GlobalConstants.Images.Body,
                    },
                    
                };

            // Need them in particular order
            foreach (var category in categories)
            {
                await dbContext.AddAsync(category);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
