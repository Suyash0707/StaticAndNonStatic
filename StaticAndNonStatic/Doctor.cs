using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndNonStatic
{
    internal class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GrossIncome { get; set; }
        public int IncomeTax { get; set; }
        public int NetIncome { get; set; }



        // Non-Static

        public void GetData()
        {
            Console.WriteLine("Please Enter the value for ID:");
            Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter the Value for Name:");
            Name = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Please Enter the value for GrossIncome:");
            GrossIncome = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter the value for IncomeTax:");
            IncomeTax = Convert.ToInt32(Console.ReadLine());


            NetIncome = CalculateNetIncome();
        }

        public void PutData()
        {
            Console.WriteLine("Id =" + Id);
            Console.WriteLine("Name =" + Name);
            Console.WriteLine("GrossIncome =" + GrossIncome);
            Console.WriteLine("IncomeTax =" +  IncomeTax);
            Console.WriteLine("NetIncome =" + NetIncome);
        }

        public int CalculateNetIncome()
        {
            int NetIncome = GrossIncome - IncomeTax;
            return NetIncome;
        }

        ////////////////// OR ///////////////////
        
        //Static 
        public static void GetInput()
        {
            Doctor doctor2=new Doctor();  // we have to create object

            Console.WriteLine("Enter the value for Id:");
            doctor2.Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value for Name:");
            doctor2.Name = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter the value for GrossIncome:");
            doctor2.GrossIncome = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value for IncomeTax:");
            doctor2.IncomeTax = Convert.ToInt32(Console.ReadLine());

            doctor2.NetIncome = doctor2.CalculateNetIncome2();
        }

        public static void ShowOutput()
        {
            Console.WriteLine("Id = " +Id);
            Console.WriteLine("Name = " + Name);
            Console.WriteLine("GrossIncome = " + GrossIncome);
            Console.WriteLine("IncomeTax = " + IncomeTax);
            Console.WriteLine("NetIncome = " + NetIncome);
        }
        public int CalculateNetIncome2()
        {
            int NetIncome = GrossIncome - IncomeTax;
            return NetIncome;
        }
    }
}
