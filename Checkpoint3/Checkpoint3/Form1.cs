using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkpoint3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Declaring objects
        StockItem StockItem1;
        StockItem StockItem2;
        StockItem StockItem3;
        StockItem StockItem4;
        StockItem StockItem5;

        private void Form1_Load(object sender, EventArgs e)
        {
            //Generating objects 
            StockItem1 = new StockItem("Screwdriver", 42);
            StockItem2 = new CarEngine(8025, "Mazda B6T", 1252, 800, "Z4537298D");
            StockItem3 = new CarEngine("Holden 308", 958, 1104, "P746238545");
            StockItem4 = new StockItem(8002, "Trolley Jack", 127);
            StockItem5 = new HeavyStockItem("JD Caterpilar Track", 3820, 2830);
            
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            //calling a click event to use stockitem print to display output
            txtOutput.Text += StockItem1.Print();
            txtOutput.Text += StockItem2.Print();
            txtOutput.Text += StockItem3.Print();
            txtOutput.Text += StockItem4.Print();
            txtOutput.Text += StockItem5.Print();
        }

        

        }
    }

