using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project.Admin
{
    internal class AdminUI
    {
        public string AdminMenu()
        {

            Console.WriteLine("==============================================");
            Console.WriteLine("                ADMIN MANAGEMENT              ");
            Console.WriteLine("==============================================");
            Console.WriteLine("1. Add Doctor");
            Console.WriteLine("2. View All Doctors");
            Console.WriteLine("3. Search Doctor");
            Console.WriteLine("4. Update Doctor");
            Console.WriteLine("5. Delete Doctor");
            Console.WriteLine("6. Sort Doctors");
            Console.WriteLine("7. View All Patients");
            Console.WriteLine("8. View Available Doctors");
            Console.WriteLine("9. View Hospital Statistics");
            Console.WriteLine("10. Logout");
            Console.WriteLine("11.Display Matching Records");
            Console.Write("Enter Option:");
            string option = Console.ReadLine();
            return option;
        }
        AdminService service = new AdminService();
        public void displayMatchingRecords()
        {
            Console.WriteLine("Enter Doctor ID:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Consultation Fee:");
            int fee = int.Parse(Console.ReadLine());
            service.displayMatchingRecords();
        }
    }
    
}