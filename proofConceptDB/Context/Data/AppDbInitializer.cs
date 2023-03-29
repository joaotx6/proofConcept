using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using proofConceptDB.DBEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace proofConceptDB.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            try
            {
                using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
                {
                    var context = serviceScope.ServiceProvider.GetService<Context.proofConceptContext>();

                    context.Database.EnsureCreated();

                    //Wands
                    if (!context.wands.Any())
                    {
                        context.wands.AddRange(new List<Wand>()
                    {
                        new Wand()
                        {
                            core = "Dragon Heart",
                            flexibility = "High Flexibility",
                            length = 25,
                            size = 20,
                            imgUrl = "https://m.media-amazon.com/images/W/IMAGERENDERING_521856-T1/images/I/71MVKy4Pv8L._AC_UF894,1000_QL80_.jpg",
                        },
                        new Wand()
                        {
                            core = "Shark Heart",
                            flexibility = "Medium flexibility",
                            length = 25,
                            size = 20,
                            imgUrl = "https://m.media-amazon.com/images/W/IMAGERENDERING_521856-T1/images/I/611rFJfiXTL.jpg",
                        },
                        new Wand()
                        {
                            core = "Lion Heart",
                            flexibility = "Hard Flexibility",
                            length = 25,
                            size = 20,
                            imgUrl = "https://www.worten.pt/i/4dd08137b18b8076af8b9cba80422838a931c462.jpg",
                        },
                    });
                        context.AddRange(context.wands);
                        context.SaveChanges();

                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}