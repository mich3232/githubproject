using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint3
{
    class StockItem
    {
        //declaring variables
        internal string Description;
        internal int CostPrice;
        internal static int LastStockNumber = 10000;
        internal int StockNumber;

        
        // method that tells program what to output 
        public virtual string Print()
        {
            string Output = "";
            Output += "Stock Item: ";
            Output += "\r\n";
            Output += "StockNumber: " + StockNumber;
            Output += "\r\n";
            Output += "Desc: " + Description;
            Output += "\r\n";
            Output += "Cost: " + CostPrice;
            Output += "\r\n\r\n";
            return Output;
        }
        //getter method
        public int GetCostPrice()
        {
            return CostPrice;
        }
        //constructor passing 2 arguments 
        public StockItem(string Description, int CostPrice)
        {
            LastStockNumber++;
            this.StockNumber = LastStockNumber;
            this.Description = Description;
            this.CostPrice = CostPrice;
        }
        // constructo overloads the previous one adding an extra argument 
        public StockItem(int StockNumber, string Description, int CostPrice)
        {
            this.StockNumber = StockNumber;
            this.Description = Description;
            this.CostPrice = CostPrice;
        }
         
    }
}
