using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp
{
    public class Workers
    {
        
        public string Name { get; set; }

        public string Surname { get; set; }
        public string PassWord { get; set; }
        public MarketStatus Status { get; set; }

        public string Mail { get; set; }
        public MarketS WorkPlace { get; set; }
        public int Wage { get; set; }
        public GrName gradetype { get; set; }
        public BonuceType bonucetype { get; set; }
        public int Id { get;  set; }
        public int Total { get; set; } = 0;
        public Workers()
        {
            this.Id = LocalStorage.Count;
            LocalStorage.Count++;
        }
    }
}
