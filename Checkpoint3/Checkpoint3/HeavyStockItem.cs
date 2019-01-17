using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint3
{
    class HeavyStockItem : StockItem
    {
        // declaring variable
        internal int Weight;

        //constructor that invokes the stockitem classes super constructors passing 3 arguments 
        public HeavyStockItem(string Description, int CostPrice, int Weight)
            : base(Description, CostPrice)
        {
            LastStockNumber++;
            this.Description = Description;
            this.CostPrice = CostPrice;
        }

        //constructor that invokes the stockitem classes super constructors and over loads the previous one passing 4 arguments 
        public HeavyStockItem(int StockNumber, string Description, int CostPrice, int Weight)
            : base(StockNumber, Description, CostPrice)
        {
            this.Weight = Weight;
        }
        // basic getter method
        public int GetWeight()
        {
            return Weight;
        }
        
    }
}

