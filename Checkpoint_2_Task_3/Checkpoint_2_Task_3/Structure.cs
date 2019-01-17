using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Checkpoint_3_Task_3
{
    class Structure
    {
        public LinkedList<Transactions> loadData()
        {
            LinkedList<Transactions> transactions = new LinkedList<Transactions>();//create doublylinked list
            //add connection string
            SqlConnection con = new SqlConnection("Data Source=150.207.153.193, 14433;Initial Catalog=30011061;Persist Security Info=True;User ID=home30011061;Password=WU6c4Xfcqi");

            string accountNum = Microsoft.VisualBasic.Interaction.InputBox("Please enter the account number of the account you want to access.", "Enter Account Number");
            SqlCommand cmd = new SqlCommand("SELECT *FROM Transactions WHERE AccountNo = " + accountNum, con);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                double returned = reader.GetDouble(4); // new
                float f = (float)returned; // new
                Transactions theTransactions = new Transactions(reader.GetInt32(0), reader.GetDateTime(1), reader.GetString(2), reader.GetString(3), f);
                transactions.AddFirst(theTransactions);

            }

            reader.Close();
            con.Close();

            return transactions;
        }
    }
}


    


