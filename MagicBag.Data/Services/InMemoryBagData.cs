using System.Collections.Generic;
using System.Linq;
using MagicBag.Data.Models;

namespace MagicBag.Data.Services
{
    public class InMemoryBagData : IBagData
    {
        List<BagItems> bagItems;

        public InMemoryBagData()
        {
            bagItems = new List<BagItems>()
            {
                new BagItems { Id = 1, Name = "Big magic sword", Type = ItemType.Weapon },
                new BagItems { Id = 2, Name = "Magic armour", Type = ItemType.Armour },
                new BagItems { Id = 3, Name = "Magic wand", Type = ItemType.Item },
                new BagItems { Id = 4, Name = "Spell book", Type = ItemType.None},
            };
        }
        public IEnumerable<BagItems> GetAll()
        {
            return bagItems.OrderBy(i => i.Name);
        }
    }
}