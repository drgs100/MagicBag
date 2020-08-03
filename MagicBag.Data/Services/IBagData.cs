using System.Collections.Generic;
using MagicBag.Data.Models;

namespace MagicBag.Data.Services
{
    public interface IBagData
    {
        IEnumerable<BagItems> GetAll();
    }
}
