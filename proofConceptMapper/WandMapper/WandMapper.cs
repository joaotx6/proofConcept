using Microsoft.Extensions.Configuration;
using proofConceptDB.DBEntities;
using HashidsNet;
using proofConceptViewModel.WandViewModel;
using System.Drawing;

namespace proofConceptMapper.WandMapper
{
    public static class WandMapper
    {
        public static Wand MapToWand(WandViewModel wandViewModel)
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var _salt = config["HashIdSalt"];

            var hashIdGenerator = new Hashids(_salt);
            hashIdGenerator.TryDecodeSingle(wandViewModel.wandId, out int wandId);


            var wand = new Wand()
            {
                wandId = wandId,
                core = wandViewModel.core,
                wood = wandViewModel.wood,
                flexibility = wandViewModel.flexibility,
                length = wandViewModel.length,
                size = wandViewModel.size,
                imgUrl = wandViewModel.imgUrl,
            };
            return wand;
        }

        public static WandViewModel MapToWandViewModel(Wand wand)
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var _salt = config["HashIdSalt"];
            var hashIdGenerator = new Hashids(_salt);

            var wandID = hashIdGenerator.Encode(wand.wandId);


            var wandViewModel = new WandViewModel()
            {

                wandId = wandID,
                core = wand.core,
                wood = wand.wood,
                flexibility = wand.flexibility,
                length = (int)wand.length,
                size = (float)wand.size,
                imgUrl = wand.imgUrl,
            };
            return wandViewModel;
        }

        public static List<WandViewModel> MapToAirplaneViewModels(List<Wand> wands)
        {
            var list = new List<WandViewModel>();
            if (wands != null && wands.Any())
            {
                foreach (var wand in wands)
                {
                    list.Add(MapToWandViewModel(wand));
                }
            }
            return list;
        }
    }
}
