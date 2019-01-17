using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Checkpoint_3_Task_3
{
    class Transactions
    {
        //variables of transaction table created

        int AccountNo;
        DateTime Date;
        string Description;
        string DebitCredit;
        float Amount;

        public Transactions(int ANo, DateTime date, string description, string debcred, float amount)
        {
            this.AccountNo = ANo;
            this.Date = date;
            this.Description = description;
            this.DebitCredit = debcred;
            this.Amount = amount;


        }
        public int getAccNo()
        {
            return AccountNo;
        }

        public DateTime getDat()
        {
            return Date;
        }

        public string getDescript()
        {
            return Description;
        }

        public string getDebCredit()
        {
            return DebitCredit;
        }

        public float getAmoun()
        {
            return Amount;
        }
    }
}

