using OOP_Project.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Project.Receptionist;

namespace OOP_Project
{
    internal class Hospital
    {
        public void Start()
        {
            while (true)
            {
                string option = MainMenu();
                if (option == "1")
                {
                    RunAdmin();
                }
                else if (option == "2")
                {
                    RunReceptionist();
                }
                else if (option == "3")
                {
                    Console.WriteLine("Hospital Management System closed.");
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid option!");
                    Console.ReadLine();
                }
            }
        }
        public string MainMenu()
        {
            Console.Clear();
            Console.WriteLine("==========================================");
            Console.WriteLine("        HOSPITAL MANAGEMENT SYSTEM        ");
            Console.WriteLine("==========================================");
            Console.WriteLine("1. Admin");
            Console.WriteLine("2. Receptionist");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("3.Exit");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter Option:");
            string option = Console.ReadLine();
            return option;
        }
        public void RunAdmin()
        {
            AdminUI ui = new AdminUI();
            AdminService service = new AdminService();
            while (true)
            {
                Console.Clear();
                string option = ui.AdminMenu();
                if (option == "1")
                    service.AddDoctor();
                else if (option == "2")
                    service.ViewAllDoctors();
                else if (option == "3")
                    service.Searchdoctor();
                else if (option == "4")
                    service.UpdateDoctor();
                else if (option == "5")
                    service.DeleteDoctor();
                else if (option == "6")
                    service.SortDoctors();
                else if (option == "7")
                    service.ViewAllPatients();
                else if (option == "8")
                    service.ViewAvailableDoctors();
                else if (option == "9")
                    service.ViewHospitalStatistics();
                else if (option == "10")
                    break;
                else
                {
                    Console.WriteLine("Invalid option!");
                }
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
        }
        //ReceptionistMenu
        public void RunReceptionist()
        {
            ReceptionistUI ui = new ReceptionistUI();
            ReceptionistService service = new ReceptionistService();
            while (true)
            {
                Console.Clear();
                string option = ui.ReceptionistMenu();
                if (option == "1")
                {
                    service.AddPatient();
                }
                else if (option == "2")
                {
                    service.ViewAllPatient();
                }
                else if (option == "3")
                {
                    service.SearchPatient();
                }
                else if (option == "4")
                {
                    service.UpdatePatient();
                }
                else if (option == "5")
                {
                    service.DeletePatient();
                }
                else if (option == "6")
                {
                    service.SortPatientsByID();
                }
                else if (option == "7")
                {
                    service.ManageRoomNumber();
                }
                else if (option == "8")
                {
                    service.BookAppointment();
                }
                else if (option == "9")
                {
                    service.GenerateBill();
                }
                else if (option == "10")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option!");
                }

                Console.WriteLine();
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
        }
    }
}
