using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string customer_name, supplier_name, choose;
            int customer_account, supplier_account, i, answer, customer_number, supplier_number;
            double customer_purchases, customer_payment, customer_begining_owing, customer_total_owing;
            double suppliler_purchases, suppliler_payment, supplier_begining_owing, supplier_total_owing;

            Console.WriteLine("this apllication can track the customers and suppliers status");
            Console.WriteLine("you need input the name , account number, the orginal owing, total purchase, \nand total payments. Then, the amount owing for custormers and David Jones will be caculated.");
            Console.WriteLine("please enter anykey to continue");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.ReadKey();
            Console.Clear();

            

           

            choose = check("customer status");
            if (int.TryParse(choose, out answer) == true)
            {
                if (answer == 1)
                {
                    customer_number = get_number("custormers");
                    customer[] number_of_customers = new customer[customer_number];
                    for (i = 0; i < customer_number; i++)
                    {
                        customer_name = get_name("custormer"+ (i+1));
                        customer_account = get_custormer_account_number();
                        customer_begining_owing = get_beginning_owing("amount owing by the customer at the beginning of a month");
                        customer_purchases = get_total_purchases("total purchases of customer");
                        customer_payment = get_total_payments("total payment of customer", customer_purchases,customer_begining_owing);
                        customer_total_owing = get_total_owing(customer_begining_owing, customer_purchases, customer_payment);
                        number_of_customers[i] = new customer(customer_name, customer_account, customer_begining_owing, customer_payment, customer_purchases, customer_total_owing);
                        Console.Clear();
                    }
                    display_customer_results(number_of_customers);
                    Console.ReadKey();
                }
            }

                choose = check("supplier status");
                if (int.TryParse(choose, out answer) == true)
                {
                    if (answer == 1)
                    {
                      supplier_number = get_number("suppliers");
                      supplier[] number_of_suppliers = new supplier[supplier_number];
                      for (i = 0; i < supplier_number; i++)
                          {
                            supplier_name = get_name("supplier"+(i+1));
                            supplier_account = get_supplier_account_number();
                            supplier_begining_owing = get_beginning_owing("the beginning owing to supplier");
                            suppliler_purchases = get_total_purchases("total purchases of David");
                            suppliler_payment = get_total_payments("total payment of David", suppliler_purchases,supplier_begining_owing);
                            supplier_total_owing = get_total_owing(supplier_begining_owing, suppliler_purchases, suppliler_payment);
                            number_of_suppliers[i] = new supplier(supplier_name, supplier_account, supplier_begining_owing, suppliler_purchases, suppliler_payment, supplier_total_owing);
                          }
                    diplay_supplier_results(number_of_suppliers);
                        Console.ReadKey();
                    }
                }
                 
      }


        public static string check(string whichone)
        {
            Console.WriteLine("do you want to check {0} ?", whichone);
            Console.WriteLine("if you do want to check, please enter 1.");
            Console.WriteLine("if you do not want to check please enter any key");
            return Console.ReadLine();
        }

        public static int get_number(string whichone)
        {
            string invalue;
            int number = 0;
            bool moredate = true;
            while (moredate)
            {
                Console.WriteLine("how many {0} ?", whichone);
                invalue = Console.ReadLine();
                if (int.TryParse(invalue, out number) == false)
                    Console.WriteLine("please enter valid number");
                else if (number < 1)
                    Console.WriteLine("please enter valid number");
                else moredate = false;
            }
            return number;
        }


        public static string get_name(string whichone)
        {
            string name;
            do
            {
                Console.WriteLine("please enter the {0} name \n(the name must be between 6 and 15 characters)", whichone);
                name = Console.ReadLine();
                if (name.Length < 6 || name.Length > 15)
                    Console.WriteLine("please enter the name which is between 6 and 15 characters");
            }
            while (name.Length < 6 || name.Length > 15);
            return name;
        }

        public static int get_custormer_account_number()
        {
            string invalue;
            int accountnumber;
            do
            {
                Console.WriteLine("please enter the custormer account number \n(must be 6 dights and start with dight 1)");
                invalue = Console.ReadLine();
                if (int.TryParse(invalue, out accountnumber) == false)
                    Console.WriteLine("please enter the right form of account number");
                else if (accountnumber < 100000 || accountnumber > 199999)
                    Console.WriteLine("the custormer account number must be 6 digits and start with dight 1");
            }
            while (accountnumber < 100000 || accountnumber > 199999);
            return accountnumber;
        }

        public static int get_supplier_account_number()
        {
            string invalue;
            int accounter_number = 0;
            bool moredate = true;
            while (moredate)
            {
                Console.WriteLine("please enter the supplier number \n(must be 6 dights and start with 2)");
                invalue = Console.ReadLine();
                if (int.TryParse(invalue, out accounter_number) == false)
                    Console.WriteLine("please enter the valid account number ");
                else if (accounter_number < 200000 || accounter_number > 299999)
                    Console.WriteLine("please enter the account number which must be 6 digits and start with digit ");
                else moredate = false;
            }
            return accounter_number;
        }

        public static double get_beginning_owing(string whichone)
        {
            string invalue;
            bool moredate = true;
            double beginning_owing = 0;
            while (moredate)
            {
                Console.WriteLine("please enter the {0}", whichone);
                invalue = Console.ReadLine();
                if (double.TryParse(invalue, out beginning_owing) == false)
                    Console.WriteLine("please enter the valid payment");
                else if (beginning_owing < 0)
                    Console.WriteLine("please enter the valid payment");
                else moredate = false;

            }
            return beginning_owing;
        }

        public static double get_total_purchases(string whichone)
        {
            string invalue;
            bool moredata = true;
            double total_purchases = 0;
            while (moredata)
            {
                Console.WriteLine("please enter {0}", whichone);
                invalue = Console.ReadLine();
                if (double.TryParse(invalue, out total_purchases) == false)
                    Console.WriteLine("please enter the valid purchases");
                else if (total_purchases < 0)
                    Console.WriteLine("please enter the valid total purchases");
                else moredata = false;
            }
            return total_purchases;
        }

        public static double get_total_payments(string whichnone, double total_purchases, double beginning_owing)
        {
            string invalue;
            bool moredate = true;
            double total_payments = 0;
            while (moredate)
            {
                Console.WriteLine("please enter the {0}", whichnone);
                invalue = Console.ReadLine();
                if (double.TryParse(invalue, out total_payments) == false)
                    Console.WriteLine("please enter the valid total pay");
                else if (total_payments < 0)
                    Console.WriteLine("please enter the valid total pay");
                else if (total_payments > total_purchases + beginning_owing)
                    Console.WriteLine("overpayment, you need to enter the right payment");
                else moredate = false;
            }
            return total_payments;
        }

        public static double get_total_owing(double beginning, double purchases, double payments)
        {
            double total;
            total = beginning + purchases - payments;
            return total;
        }

        public static void display_customer_results(customer[] number_of_customers )
        {
            Console.WriteLine("---------------------------------------------------------");
            foreach (customer pl in number_of_customers)
            {              
                Console.WriteLine("customer account number: {0}", pl.Account_number);
                Console.WriteLine("customer total owing： {0:c}", pl.Custormer_total_owing);
                if (pl.Custormer_total_owing > 400)
                    Console.WriteLine("Credit limit exceeded");
                Console.WriteLine("------------------------------------------------------");
            }  
        }

        public static void diplay_supplier_results(supplier[] number_of_suppliers)
        {
            Console.WriteLine("----------------------------------------------------");
            foreach (supplier p2 in number_of_suppliers)
            {
                Console.WriteLine("supplier account number: {0}", p2.Account);
                Console.WriteLine("David total owing: {0:c}", p2.Supplier_total_owing);
                if (p2.Supplier_total_owing > 500)
                    Console.WriteLine("Payment of this account is due now");
                Console.WriteLine("-------------------------------------------------");
            }
        }
    }
}
