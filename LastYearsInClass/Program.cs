using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastYearsInClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product =  Product.GetProduct();
            product.GenerateSampleData();

           string departMentId = SelectDepartment();


            Console.WriteLine("To run current query? Yes/No");
            string runQuery = Console.ReadLine();

            if(runQuery.ToLower() == "yes")
            {
                product.DisplayProducts(departMentId);

                string dealId = SelectDealType();

                product.DisplayProducts(departMentId, dealId);


            }
            else
            {
                Console.WriteLine("Query canceled.");
            }



        }

        public static string SelectDepartment ()
        {
            Console.WriteLine("Please select Department:");
            Console.WriteLine("1. Baby");
            Console.WriteLine("2. Electronics");
            Console.WriteLine("3. Devices");
            Console.WriteLine("4. Books");

            string departmentId = Console.ReadLine();
            return departmentId;
        }

        public static string SelectDealType()
        {
            Console.WriteLine("Please select Deal:");
            Console.WriteLine("1. All Deals");
            Console.WriteLine("2. Top Deals");
            Console.WriteLine("3. Best Deals");

            string dealId = Console.ReadLine();
            return dealId;
        }
    }
}
