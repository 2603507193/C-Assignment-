using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_2
{
    class supplier
    {
        private string supplier_name;
        private int supplier_account_number;
        private double supplier_beginning_owing;
        private double supplier_total_purchases;
        private double supplier_total_payments;
        private double supplier_total_owing;
 
        public supplier()
        {

        }

        public supplier(string name, int account_number, double beginnign_owing, double total_purchases, double total_payments, double total_owing)
        {
            supplier_name = name;
            supplier_account_number = account_number;
            supplier_beginning_owing = beginnign_owing;
            supplier_total_purchases = total_purchases;
            supplier_total_payments = total_payments;
            supplier_total_owing = total_owing;
        } 

        public string Name
        {
            get
            {
                return supplier_name;
            }
            set
            {
                supplier_name = value;
            }
        }

        public int Account
        {
            get
            {
                return supplier_account_number;
            }
            set
            {
                supplier_account_number = value;
            }
        }

        public double Begin
        {
            get
            {
                return supplier_beginning_owing;
            }
            set
            {
                supplier_beginning_owing = value;
            }
        }

        public double Purchases
        {
            get
            {
                return supplier_total_purchases;
            }
            set
            {
                supplier_total_purchases = value;
            }
        }

        public double Payment
        {
            get
            {
                return supplier_total_payments;
            }
            set
            {
                supplier_total_payments = value;
            }
        }

        public double Supplier_total_owing 
        {
            get
            {
                return supplier_total_owing; 
            }
            set
            {
                supplier_total_owing = value;
            }
        }

        public override string ToString()
        {
            return "supplier name: "+ supplier_name + "\tsupplier account number: " + supplier_account_number + "\taccount balance at the beginning month: " + supplier_beginning_owing + "\tDavid total purchases: " + supplier_total_purchases + "\tDavid total payments: " + supplier_total_payments + "\tDavid amount owing: " + supplier_total_owing.ToString("C") ;
        }
    }
}
