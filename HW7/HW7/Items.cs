using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    public class Items
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int ExstingAmount { get; set; }
        public int? askedamount { get; set; }
        public int Id { get; set; }
        public CategoryEnum Category { get; set; }
    }
}
