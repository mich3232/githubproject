using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Checkpoint_3_Task_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void loadData()
        {
            string accountNum = Microsoft.VisualBasic.Interaction.InputBox("Please enter the account number of the account you want to access.", "Enter Account Number");
            //create doublylinked list
            LinkedList<Transactions> transactions = new LinkedList<Transactions>();
            //add connection string
            SqlConnection con = new SqlConnection("Data Source=150.207.153.193, 14433;Initial Catalog=30011061;Persist Security Info=True;User ID=home30011061;Password=WU6c4Xfcqi");

            SqlCommand cmd = new SqlCommand("SELECT *FROM Transactions WHERE AccountNo" + accountNum, con);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Transactions theTransactions = new Transactions(reader.GetInt32(0), reader.GetDateTime(1), reader.GetString(2), reader.GetString(3), reader.GetFloat(4));
                    transactions.AddFirst(theTransactions);

                }

                reader.Close();
                con.Close();
            }
        }


        private void btnExucute_Click(object sender, EventArgs e)
        {
            LinkedList<Transactions> transactions = new LinkedList<Transactions>();

            Structure structure = new Structure();
            transactions = structure.loadData();

            foreach (Transactions transaction in transactions)
            {
                txtOutput.Text += "Transactions for Account No ";
                
                int AccNo = transaction.getAccNo();
                txtOutput.Text += AccNo.ToString();
                
                DateTime Dat = transaction.getDat();
                string Descript = transaction.getDescript();
                string DebCredit = transaction.getDebCredit();
                float Amoun = transaction.getAmoun();
                txtOutput.Text += "\r\n" + "\r\nDate" + "\t"+"\t"+"\t" + "Desciption" + "\t" + "Debitcredit" + "\t" + "Amount" +"\r\n";
                txtOutput.Text += Dat.ToString() + "\t" + Descript.ToString() + "\t" + "\t" + DebCredit.ToString() + "\t" + "\t" + Amoun.ToString();
                

            }
        }

        
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
       
    }
}

