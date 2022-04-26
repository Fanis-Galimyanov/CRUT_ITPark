using CRUT.Data;
using Microsoft.EntityFrameworkCore;

namespace CRUT.Models
{
    public class SetData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CRUTContext(
            serviceProvider.GetRequiredService<
            DbContextOptions<CRUTContext>>()))
            {
                if (context == null || context.Coin == null)
                {
                    throw new ArgumentNullException("Null CryptoDemoContext");
                }
                if (context.Coin.Any())
                {
                    return;
                }
                context.Coin.AddRange(
                new Coin
                {
                Name = "Bitcoin",
                Price = 42920
                },
                new Coin
                {
                 Name = "Litecoin",
                Price = 570
                },
                new Coin
                {
                 Name = "Dogecoin",
                 Price = 23
                },
                new Coin
                   {
                Name = "BNB",
                Price = 450
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
