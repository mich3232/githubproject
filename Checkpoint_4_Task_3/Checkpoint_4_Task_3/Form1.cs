using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkpoint_4_Task_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            BinarySearchTree btree = new BinarySearchTree();

            btree.AddNode("D");
            btree.AddNode("B");
            btree.AddNode("F");
            btree.AddNode("E");
            btree.AddNode("A");
            btree.AddNode("G");
            btree.AddNode("C");
           
            
            txtOutput.Text += "\r\nPrinting binary tree\r\n" + btree.PrintNodes(btree.root);

                Node item = btree.FindNode("A");
                if (item == null)
                {
                    txtOutput.Text += "\r\nNode not found\r\n";//if node is not present
                }
                else
                {
                    txtOutput.Text += "\r\nNode found.\r\n";//prints if node is found
                }
                

            }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        }
    }

