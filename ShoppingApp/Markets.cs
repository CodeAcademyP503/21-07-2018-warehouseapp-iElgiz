using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp
{
    public enum MarketS
    {
        mango,
        bershka,
        zara,
        celio
    }
    public class Markets
    {
        public MarketS MarketName { get; set; }
        public string MarketAddress { get; set; }
        public Workers[] workersss = new Workers[20];
        
        public Grade Grade { get; set; }
    }
}
