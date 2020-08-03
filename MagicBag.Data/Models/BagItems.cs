using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicBag.Data.Models
{
    public class BagItems
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ItemType Type { get; set; }
    }
}
