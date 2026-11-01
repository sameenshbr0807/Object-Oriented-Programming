using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Project.Receptionist;

namespace OOP_Project.Admin
{
    internal class AdminService
    {
        private AdminRepository _repo = new AdminRepository();
        public AdminService()
        {
        }
        //1.Add Doctors
        public void AddDoctor()
        {
            Console.Clear();
            Console.WriteLine("Enter Doctor ID:");
            int id = int.Parse(Console.ReadLine());
            List<AdminModel> doctors = _repo.GetAdminFromUser();
            foreach (AdminModel doctor in doctors)
            {
                if (doctor.GetDoctorID() == id)
                {
                    Console.WriteLine("Doctor ID Already exists!");
                    return;
                }
            }
            Console.WriteLine("Enter Doctor Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Age:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Specialization:");
            string specialization = Console.ReadLine();
            Console.WriteLine("Enter Consultation Fee:");
            float fee = int.Parse(Console.ReadLine());
            Console.WriteLine("Is Doctor Available? (true/false)");
            bool available = bool.Parse(Console.ReadLine());
            AdminModel newDoctor = new AdminModel(id,name,age,specialization,fee,available);
            _repo.SaveInFile(newDoctor);

            Console.WriteLine("Doctor Added Successfully!");
        }
        //2.View All Doctor
        public void ViewAllDoctors()
        {
            Console.Clear();
            List<AdminModel> doctors = _repo.GetAdminFromUser();
            if (doctors.Count == 0)
            {
                Console.WriteLine("No doctors Found.");
                return;
            }
            foreach(AdminModel doctor in doctors)
            {
                Console.WriteLine(doctor.ToString());
            }
        }
        //3.Search doctor by user
        public void Searchdoctor()
        {
            Console.Clear();
            Console.WriteLine("Enter Doctor ID:");
            int id = int.Parse(Console.ReadLine());
            List<AdminModel> doctors = _repo.GetAdminFromUser();
            foreach(AdminModel doctor in doctors)
            {
                if (doctor.GetDoctorID() == id)
                {
                    Console.WriteLine(doctor.ToString());
                    return;
                }
            }
            Console.WriteLine("Doctor Not Found.");
        }
        //Search Doctor By Name
        public void SearchDoctorByName()
        {
            Console.WriteLine("Enter Doctor Name:");
            string name = Console.ReadLine();
            List<AdminModel> doctors = _repo.GetAdminFromUser();
            bool found=false;
            foreach(AdminModel doctor in doctors)
            {
                if (doctor.GetDoctorName().Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(doctor.ToString());
                    found = false;
                }
            }
            if (!found)
            {
                Console.WriteLine("Doctor Not found.");
            }
        }
        //4.Update Doctor
        public void UpdateDoctor()
        {
            Console.Clear();
            Console.WriteLine("Enter Doctor ID To Update:");
            int id = int.Parse(Console.ReadLine());
            List<AdminModel> doctors = _repo.GetAdminFromUser();
            foreach(AdminModel doctor in doctors)
            {
                if (doctor.GetDoctorID() == id)
                {
                    Console.Write("Enter doctor Name:");
                    doctor.SetDoctorName(Console.ReadLine());
                    Console.Write("Enter Doctor Age:");
                    doctor.SetAge(int.Parse(Console.ReadLine()));
                    Console.Write("Enter Specialization:");
                    doctor.SetSpecialization(Console.ReadLine());
                    Console.Write("Enter Consulatation Fee:");
                    doctor.SetConsultationFee(int.Parse(Console.ReadLine()));
                    Console.Write("Is Available? (true\false):");
                    doctor.SetIsAvailable(bool.Parse(Console.ReadLine()));
                    _repo.SaveAllDataInFile(doctors);
                    Console.WriteLine("Doctor Updated SuccessFully!");
                    return;
                }
            }
            Console.WriteLine("Doctor Not found!");
        }
        //5.Delete Doctors
        public void DeleteDoctor()
        {
            Console.Clear();
            Console.WriteLine("Enter Doctor ID To Delete:");
            int id = int.Parse(Console.ReadLine());
            List<AdminModel> doctors = _repo.GetAdminFromUser();
            int count = 0;
            foreach(AdminModel doctor in doctors)
            {
                if (doctor.GetDoctorID() == id)
                {
                    doctors.RemoveAt(count);
                    _repo.SaveAllDataInFile(doctors);
                    Console.WriteLine("Doctor Deleted Successfully!");
                    return;
                }
                count++;
            }
            Console.WriteLine("Doctor Not Found.");
        }
        //6.Sort Doctors By name
        public void SortDoctors()
        {
            Console.Clear();
            List<AdminModel> doctors = _repo.GetAdminFromUser();
            for(int i = 0; i < doctors.Count - 1; i++)
            {
                for(int j = 0; j < doctors.Count - 1 - i; j++)
                {
                    if (string.Compare(doctors[j].GetDoctorName(), doctors[j + 1].GetDoctorName(), StringComparison.OrdinalIgnoreCase) > 0)
                    {
                        AdminModel temp = doctors[j];
                        doctors[j] = doctors[j + 1];
                        doctors[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Doctors Sorted by name:");
            foreach(AdminModel doctor in doctors)
            {
                Console.WriteLine(doctor.ToString());
            }
        }
        //7.View All patients
        public void ViewAllPatients()
        {
            Console.Clear();
            ReceptionistRepository repo = new ReceptionistRepository();

            List<ReceptionistModel> patients =
                repo.GetReceptionistFromFile();
            if (patients.Count == 0)
            {
                Console.WriteLine("No patients found.");
                return;
            }

            foreach (ReceptionistModel patient in patients)
            {
                Console.WriteLine(patient.ToString());
            }
        }
        //8.View Available Doctors
        public void ViewAvailableDoctors()
        {
            Console.Clear();
            List<AdminModel> doctors = _repo.GetAdminFromUser();
            bool found = false;
            foreach(AdminModel doctor in doctors)
            {
                if (doctor.GetIsAvailable())
                {
                    Console.WriteLine(doctor.ToString());
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("No Available doctors Found.");
            }
        }
        //9.View Hospital status
        public void ViewHospitalStatistics()
        {
            Console.Clear();
            List<AdminModel> doctors = _repo.GetAdminFromUser();
            int totalDoctors = doctors.Count;
            int availableDoctors = 0;
            foreach(AdminModel doctor in doctors)
            {
                if (doctor.GetIsAvailable())
                {
                    availableDoctors++;
                }
            }
            int unavailableDoctors = totalDoctors - availableDoctors;
            Console.WriteLine("==========HOSPITAL STATISTICS==========");
            Console.WriteLine("Total Doctors:" + totalDoctors);
            Console.WriteLine("Available Doctors:" + availableDoctors);
            Console.WriteLine("UnAvailable Doctors:" + unavailableDoctors);
        }
    }
}
