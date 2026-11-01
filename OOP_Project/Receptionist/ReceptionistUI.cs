using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project.Receptionist
{
    internal class ReceptionistUI
    {
        public void Start()
        {
            ReceptionistMenu();
    }
        public string ReceptionistMenu()
        {
            Console.WriteLine("===================================");
            Console.WriteLine("         RECEPTIONIST MENU         ");
            Console.WriteLine("===================================");
            Console.WriteLine("1. Add Patients");
            Console.WriteLine("2. View All Patients");
            Console.WriteLine("3. Search Patients");
            Console.WriteLine("4. Update Patient");
            Console.WriteLine("5. Delete Patient");
            Console.WriteLine("6. Sort Patients");
            Console.WriteLine("7. Manage Room Numbers");
            Console.WriteLine("8. Generate Bill");
            Console.WriteLine("9. Book Appointment");
            Console.WriteLine("10. Logout");
            Console.Write("Enter Option:");
            string option = Console.ReadLine();
            return option;
        }
        }
}
