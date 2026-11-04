using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project.Receptionist
{
    internal class ReceptionistService
    {
        private ReceptionistRepository _repo = new ReceptionistRepository();
        public ReceptionistService()
        {

        }
        //1.Add Patient
        public void AddPatient()
        {
            Console.Clear();
            Console.WriteLine("Enter patient ID:");
            int id = int.Parse(Console.ReadLine());
            List<ReceptionistModel> patients = _repo.GetReceptionistFromFile();
            foreach(ReceptionistModel patient in patients)
            {
                if (patient.GetPatientID() == id)
                {
                    Console.WriteLine("Patient ID already Exists!");
                    return;
                }
            }
            Console.Write("Enter Pateint Name:");
            string name = Console.ReadLine();
            Console.Write("Enter Age:");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter Gender:");
            string gender=(Console.ReadLine());
            Console.Write("Enter Disease:");
            string disease = Console.ReadLine();
            Console.Write("Enter Room Number:");
            int roomNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter Appointment Date:");
            string appointment = Console.ReadLine();
            Console.Write("Enter BillAmount:");
            float bill = float.Parse(Console.ReadLine());
            ReceptionistModel newPatient = new ReceptionistModel(id, name, age, gender, disease, roomNumber, appointment, bill);
            _repo.SaveInFile(newPatient);
            Console.WriteLine("Patient Added SuccessFully!");
        }
        //2.View all patients
        public void ViewAllPatient()
        {
            Console.Clear();
            List<ReceptionistModel> patients = _repo.GetReceptionistFromFile();
            if (patients.Count == 0)
            {
                Console.WriteLine("No Patients Found.");
                return;
            }
            foreach(ReceptionistModel patient in patients)
            {
                Console.WriteLine(patient.ToString());
            }
        }
        //3.Search Patient by Id
        public void SearchPatient()
        {
            Console.Clear();
            Console.WriteLine("1.Search by Id:");
            Console.WriteLine("2.Search by Name:");
            Console.Write("Enter your option:");
            string option = Console.ReadLine();
            List<ReceptionistModel> patients = _repo.GetReceptionistFromFile();
            bool found = false;
            if (option == "1")
            {
                Console.Write("Enter Patient ID:");
                int id = int.Parse(Console.ReadLine());

                foreach (ReceptionistModel patient in patients)
                {
                    if (patient.GetPatientID() == id)
                    {
                        Console.WriteLine(patient.ToString());
                        found = true;
                        break;
                    }
                }
            }
            else if (option == "2")
            {
                Console.Write("Enter Patient Name: ");
                string name = Console.ReadLine();

                foreach (ReceptionistModel patient in patients)
                {
                    if (patient.GetPatientName().Equals(
                        name, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine(patient.ToString());
                        found = true;
                    }
                }
            }
            else
            {
                if (!found)
                {
                    Console.WriteLine("Patient not Found!");
                }
            }
        }
            //4.Update patient
            public void UpdatePatient()
            {
            Console.Clear();
            List<ReceptionistModel> patients =_repo.GetReceptionistFromFile();
                Console.Write("Enter Patient ID to update: ");
                int id = int.Parse(Console.ReadLine());
                foreach (ReceptionistModel patient in patients)
                {
                  if (patient.GetPatientID() == id)
                  {
                    Console.Write("Enter New Name: ");
                    patient.SetPatientName(Console.ReadLine());

                    Console.Write("Enter New Age: ");
                    patient.SetAge(int.Parse(Console.ReadLine()));

                    Console.Write("Enter New Gender: ");
                    patient.SetGender(Console.ReadLine());

                    Console.Write("Enter New Disease: ");
                    patient.SetDisease(Console.ReadLine());

                    Console.Write("Enter New Room Number: ");
                    patient.SetRoomNumber(int.Parse(Console.ReadLine()));

                    Console.Write("Enter New Appointment Date: ");
                    patient.SetAppointmentDate(Console.ReadLine());

                    Console.Write("Enter New Bill Amount: ");
                    patient.SetBillAmount(float.Parse(Console.ReadLine()));

                    _repo.SaveAllDataInFile(patients);

                    Console.WriteLine("Patient updated successfully!");
                    return;
                }
            }

            Console.WriteLine("Patient not found.");
        }

        // 5.Delete Patient
        public void DeletePatient()
        {
            Console.Clear();
            List<ReceptionistModel> patients =_repo.GetReceptionistFromFile();
            Console.Write("Enter Patient ID to delete: ");
            int id = int.Parse(Console.ReadLine());
            for (int i = 0; i < patients.Count; i++)
            {
                if (patients[i].GetPatientID() == id)
                {
                    patients.RemoveAt(i);

                    _repo.SaveAllDataInFile(patients);

                    Console.WriteLine("Patient deleted successfully!");
                    return;
                }
            }
            Console.WriteLine("Patient not found.");
        }
        //6.Sort patient by Id
        public void SortPatientsByID()
        {
            Console.Clear();
            List<ReceptionistModel> patients = _repo.GetReceptionistFromFile();
            for(int i = 0; i < patients.Count - 1; i++)
            {
                for(int j = 0; j < patients.Count - i - 1; j++)
                {
                    if (patients[j].GetPatientID() > patients[j + 1].GetPatientID())
                    {
                        ReceptionistModel temp = patients[j];
                        patients[j] = patients[j + 1];
                        patients[j + 1] = temp;
                    }
                }
            }
            _repo.SaveAllDataInFile(patients);
            Console.WriteLine("Patients sorted by ID:");
            foreach(ReceptionistModel patient in patients)
            {
                Console.WriteLine(patient.ToString());
            }
        }
        //7.Manage Room Number
        public void ManageRoomNumber()
        {
            Console.Clear();
            List<ReceptionistModel> patients = _repo.GetReceptionistFromFile();
            Console.Write("Enter Patient ID:");
            int id = int.Parse(Console.ReadLine());
            foreach (ReceptionistModel patient in patients)
            {
                if (patient.GetPatientID() == id)
                {
                    Console.Write("Enter Room Number:");
                    int room = int.Parse(Console.ReadLine());
                    patient.SetRoomNumber(room);
                    _repo.SaveAllDataInFile(patients);
                    Console.WriteLine("Room number Updated successfully!");
                    return;
                }
            }
        }
            //8.Book appointment
            public void BookAppointment()
        {
            Console.Clear();
            List<ReceptionistModel> patients =
                _repo.GetReceptionistFromFile();

            Console.Write("Enter Patient ID: ");
            int id = int.Parse(Console.ReadLine());

            foreach (ReceptionistModel patient in patients)
            {
                if (patient.GetPatientID() == id)
                {
                    Console.Write("Enter Appointment Date: ");
                    string date = Console.ReadLine();

                    patient.SetAppointmentDate(date);

                    _repo.SaveAllDataInFile(patients);

                    Console.WriteLine("Appointment booked successfully!");
                    return;
                }
            }

            Console.WriteLine("Patient not found. Add the patient first.");
        }
        //9.Generate bill
        public void GenerateBill()
        {
            Console.Clear();
            List<ReceptionistModel> patients = _repo.GetReceptionistFromFile();
            Console.Write("Enter Patient ID: ");
            int id = int.Parse(Console.ReadLine());
            foreach (ReceptionistModel patient in patients)
            {
                if (patient.GetPatientID() == id)
                {
                    Console.Write("Enter Bill Amount: ");
                    float amount = float.Parse(Console.ReadLine());
                    patient.SetBillAmount(amount);
                    _repo.SaveAllDataInFile(patients);
                    Console.WriteLine("Patient ID: " +
                        patient.GetPatientID());
                    Console.WriteLine("Patient Name: " +
                        patient.GetPatientName());
                    Console.WriteLine("Room Number: " +
                        patient.GetRoomNumber());
                    Console.WriteLine("Appointment Date: " +
                        patient.GetAppointmentDate());
                    Console.WriteLine("Total Bill: " + amount);
                    return;
                }
            }

            Console.WriteLine("Patient not found.");
        }
        public void PaginatedView()
        {
            List<ReceptionistModel> patients = _repo.GetReceptionistFromFile();
        }
    }
  
}
