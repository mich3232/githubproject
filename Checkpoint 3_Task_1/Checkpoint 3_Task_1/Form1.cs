using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkpoint_3_Task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            int numberOfChildren;
            string[] names;
            int num = 0;

            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter number of children", "Number of Children");//prompts for day

            try
            {
                while (!(int.TryParse(input, out num)))//converts the string to an int and returns a message to tell whether valid input has been entered
                {
                    MessageBox.Show("Not a valid number. Please enter a number.");
                    input = Microsoft.VisualBasic.Interaction.InputBox("Enter number of children", "Number of Children");
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Value entered is not a valid format");//message to be returned if invalid input.
            }
            numberOfChildren = int.Parse(input);
            names = new string[numberOfChildren];

            txtOutput.Text += "Unsorted array\r\n";
            for (int i = 0; i < names.Length; i++ )
            {
                
             string  name =  Microsoft.VisualBasic.Interaction.InputBox("Please enter children's names", "Enter Childrens Names");
             
                names[i] = name;
           txtOutput.Text += name + "\t";
            }
            txtOutput.Text += "\r\nSorted array: \r\n";
            mergeSort(names, 0, names.Length - 1);
       foreach (string s in names)
       {
           txtOutput.Text += s + "\t";
       }
      }

    
         public void mergeSort(IComparable[] sortArray, int lower, int upper)
        {
            int middle;
            if (upper == lower)
                return;
            else
            {
                middle = (lower + upper) / 2;
                mergeSort(sortArray, lower, middle);
                mergeSort(sortArray, middle + 1, upper);
                Merge(sortArray, lower, middle + 1, upper);
            }
        }

        public void Merge(IComparable[] sortArray, int lower, int middle, int upper)
        {
            IComparable[] temp = new IComparable[sortArray.Length];
            int lowEnd = middle - 1;
            int low = lower;
            int n = upper - lower + 1;
            while ((lower <= lowEnd) && (middle <= upper))
            {
                if (sortArray[lower].CompareTo(sortArray[middle])< 0)
                {
                    temp[low] = sortArray[lower];
                    low++;
                    lower++;
                }
                else
                {
                    temp[low] = sortArray[middle];
                    low++;
                    middle++;
                }
            }
            while (lower <= lowEnd)
            {
                temp[low] = sortArray[lower];
                low++;
                lower++;
            }
            while (middle <= upper)
            {
                temp[low] = sortArray[middle] ;
                low++;
                middle++;
            }
            for (int i = 0; i < n; i++)
            {
                sortArray[upper] = temp[upper];
                upper--;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}