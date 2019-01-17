using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkpoint_4_Task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            RecursiveBinarySearch rbs = new RecursiveBinarySearch();
            int value = -1;
            int[] ADSMarks = new int[] { 72, 55, 1, 61, 38, 96, 45, 73, 57, 39, 6, 88 };
            
            Array.Sort(ADSMarks);

            txtOutput.Text += "\r\nSorted array: \r\n";
            foreach (int i in ADSMarks)
            {
                txtOutput.Text += i + "\t";
            }
            value = rbs.RecursiveBinarySearch1( ADSMarks, 0, ADSMarks.Length, 61);
            if (value != -1)
                {
                    txtOutput.Text += "\r\nValue 61 Found!!\r\n" + "Index of the value : " + value; 
                }
                else
                {
                    txtOutput.Text += "\r\nValue not found.";
                }
            }

        public class RecursiveBinarySearch
        {
            public int RecursiveBinarySearch1(int[] ADSMarks, int first, int last, int element)
            {
                first = 0;
                last = ADSMarks.Length - 1;
                element = 61;
                int mid = 0;
                {
                    while (first <= last)
                    {
                        mid = (first + last) / 2;
                        if (ADSMarks[mid] == element)
                        {
                            return mid;
                        }
                        else if (ADSMarks[mid] > element)
                        {
                             return RecursiveBinarySearch1(ADSMarks, element, first, mid - 1);
                        }
                        else if (ADSMarks[mid] < element)
                        {
                             return RecursiveBinarySearch1(ADSMarks, element,  mid + 1, last);
                        }
                        
                    }
                    return  -1;
                }
           }
        }
        

        private void btnEXit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
