using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_2
{
    class customer
    {
        private string customer_name;
        private int custormer_account_number;
        private double custormer_beginning_owing ;
        private double custormer_total_purchases;
        private double custormer_total_payment;
        private double custormer_total_owing;
      

        public customer()
        {

        }

        public customer(string name, int account_number, double money, double purchases, double total_payment, double total_owing)
        {
            customer_name = name;
            custormer_account_number = account_number;
            custormer_beginning_owing = money;
            custormer_total_purchases = purchases;
            custormer_total_payment = total_payment;
            custormer_total_owing = total_owing;
          
        }
        
        public string Customer_name
        {
            get
            {
                return customer_name;
            }
            set
            {
                customer_name = value;
            }
        }

        public int Account_number
        {
            get
            {
                return custormer_account_number;
            }
            set
            {
                custormer_account_number = value;
            }
        }

        public double Custormer_beginning_owing
        {
            get
            {
                return custormer_beginning_owing;
            }
            set
            {
                custormer_beginning_owing = value;
            }
        } 

        public double Custormer_total_purchases
        {
            get
            {
                return custormer_total_purchases;
            }
            set
            {
                custormer_total_purchases = value;
            }
        }

        public double Custormer_total_payment
        {
            get
            {
                return custormer_total_payment;
            }
            set
            {
                custormer_total_payment = value;
            }
        }


       public double Custormer_total_owing
        {
            get
            {
                return custormer_total_owing;
            }
            set
            {
                custormer_total_owing = value;
            }
        }


         public override string ToString()
        {       
            return "custormer name: " + customer_name + "\tcustormer account number: " + custormer_account_number + "\t the owing money at the beginning of month: " + custormer_beginning_owing + "\tcustormer this month total purchases: " + custormer_total_purchases + "\tcustormer total payment: " + custormer_total_payment + "\tamount of owing money for this month:" + custormer_total_owing.ToString("c");
        }
    }
}
