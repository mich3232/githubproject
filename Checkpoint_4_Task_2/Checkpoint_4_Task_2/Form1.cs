using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkpoint_4_Task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnExecute_Click(object sender, EventArgs e)
        {
            IterativeBinarySearch ibs = new IterativeBinarySearch();
             
            int[] ADSMarks = new int[] { 72, 55, 1, 61, 38, 96, 45, 73, 57, 39, 6, 88 };
           
            Array.Sort(ADSMarks);

            txtOutput.Text += "\r\nSorted array: \r\n";
            foreach (int i in ADSMarks)
            {
                txtOutput.Text += i + "\t";
                
            }
            ibs.InterativeBinarySearch1(ADSMarks, 0, ADSMarks.Length, 61);
               txtOutput.Text += "\r\nValue 61 Found!!\r\n" + "Index of the value : " + ibs.mid;
            }
        
        public class IterativeBinarySearch
        {
            public int mid { get; set; }
            public int InterativeBinarySearch1(int[] ADSMarks, int first, int last, int element)
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
                            last = mid - 1;
                        }
                        else if (ADSMarks[mid] < element)
                        {
                            first = mid + 1;
                        } 
                        
                    }
                    return 0;
                }
            }
        

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    } 
}

 