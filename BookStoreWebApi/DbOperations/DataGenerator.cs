using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BookStoreWebApi.DbOperations
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {

            using (var context = new BookStoreDbContext(serviceProvider.GetRequiredService<DbContextOptions<BookStoreDbContext>>()))
            {
                if (context.Books.Any())
                {
                    return;
                }
                context.Books.AddRange(
                     new Book
                     {
                         Id = 1,
                         Title = "Lean Starup",
                         GenereId = 1,//personal Grwtn
                       PageCount = 200,
                         PublishDate = new DateTime(2001, 6, 12)
                     },
                     new Book
                     {
                         Id = 2,
                         Title = "İnce Mehmet",
                         GenereId = 2,//personal Grwtn
                       PageCount = 710,
                         PublishDate = new DateTime(1990, 7, 20)
                     },
                     new Book
                     {
                         Id = 3,
                         Title = "Dune",
                         GenereId = 3,//personal Grwtn
                       PageCount = 540,
                         PublishDate = new DateTime(2018, 5, 10)
                     }
                );

                context.SaveChanges();
            }
        }
    }
}