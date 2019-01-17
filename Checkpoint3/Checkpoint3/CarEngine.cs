using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint3
{
    class CarEngine : HeavyStockItem
    {
        internal String EngineNumber;

        //constructor that invokes the stockitem and Heavystockitem classes super constructors passing 4 arguments
        public CarEngine(string Description, int CostPrice, int Weight, string EngineNumber)
            : base(Description, CostPrice, Weight)
        {
            LastStockNumber++;
            this.Description = Description;
            this.CostPrice = CostPrice;
            this.Weight = Weight;
            this.EngineNumber = EngineNumber;
        }
        //constructor that invokes the stockitem and Heavystockitem classes super constructors and overloads the previous one passing 5 arguments

        public CarEngine(int StockNumber, string Description, int CostPrice, int Weight, string EngineNumber)
            : base(StockNumber, Description, CostPrice, Weight)
        { 
            this.EngineNumber = EngineNumber;
        }

        
       //print method to over ride the base print method
        public override string Print()
        {
            return "Engine Number: " + EngineNumber + "\n\r\n\r" + "Weight:" + Weight + "\n\r\n\r" + base.Print();
        }
    }
}
